namespace KungMessenger.Network;
using System.Net;
using System.Net.Sockets;



public class Client
{
    private Socket socket;
    private EndPoint endPoint;

    private bool isConnect;
    private bool isConnecting;

    private Buffer receive_buffer;
    private Buffer send_buffer;
    private Buffer send_temp_buffer;

    private object send_lock = new object();
    private object receive_lock = new object();

    private SocketAsyncEventArgs connect_event;
    private SocketAsyncEventArgs receive_event;
    private SocketAsyncEventArgs send_event;

    public Client()
    {
        isConnect = false;
        isConnecting = false;
    }

    public void Start(string IpAddress, int port)
    {
        if (isConnect || isConnecting)
            return;
        //socket crete
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //endpoint
        endPoint = new IPEndPoint(IPAddress.Parse(IpAddress), port);
        //nagle algoritm off
        socket.NoDelay = true;

        //buffer create
        receive_buffer = new Buffer();
        send_buffer = new Buffer();
        send_temp_buffer = new Buffer();

        //socket async event
        connect_event = new SocketAsyncEventArgs();
        receive_event = new SocketAsyncEventArgs();
        send_event = new SocketAsyncEventArgs();

        //event register
        connect_event.Completed += OnScoketCompleted;
        receive_event.Completed += OnScoketCompleted;
        send_event.Completed += OnScoketCompleted;

        connect_event.RemoteEndPoint = endPoint;
        //Connecting start
        isConnecting = true;

        try
        {
            //I/O 작업이 보류 중인 경우 true 를 반환
            if (!socket.ConnectAsync(connect_event))
            {
                OnProcessConnect(connect_event);
            }
        }
        catch (SocketException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public void Disconnect()
    {
        if (!isConnect)
            return;

        connect_event.Completed -= OnScoketCompleted;
        receive_event.Completed -= OnScoketCompleted;
        send_event.Completed -= OnScoketCompleted;

        try
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }

            socket.Close();
            socket.Dispose();

            connect_event.Dispose();
            receive_event.Dispose();
            send_event.Dispose();
        }
        catch (ObjectDisposedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void OnScoketCompleted(object sender, SocketAsyncEventArgs e)
    {
        switch (e.LastOperation)
        {
            case SocketAsyncOperation.Connect:
                OnProcessConnect(e);
                break;
            case SocketAsyncOperation.Receive:
                OnProcessReceive(e);
                break;
            case SocketAsyncOperation.Send:
                OnProcessSend(e);
                break;
        }
    }


    public void OnProcessConnect(SocketAsyncEventArgs e)
    {
        if (e.SocketError == SocketError.Success)
        {
            Console.WriteLine("Connect");

            isConnect = true;
            isConnecting = false;

            ReceiveAsync();

            return;
        }
        else
        {
            Console.WriteLine("Connect fail");
        }
    }

    public void ReceiveAsync()
    {
        lock (receive_lock)
        {
            receive_event.SetBuffer(receive_buffer.Data, 0, receive_buffer.Capctiy);
        }

        if (!socket.ReceiveAsync(receive_event))
        {
            OnProcessReceive(receive_event);
        }
    }


    public void OnProcessReceive(SocketAsyncEventArgs e)
    {
        if (e.BytesTransferred > 0 && e.SocketError == SocketError.Success)
        {
            bool result = socket.ReceiveAsync(receive_event);
            if (!result)
            {
                OnProcessReceive(receive_event);
            }
   
            Console.WriteLine("Receive");
        }
        else
        {
            //Disconnect here
            Disconnect();
        }
    }

    public void Send(Buffer buffer)
    {
        if (!isConnect)
        {
            Console.WriteLine("Not Connect");
        }

        send_buffer.Write(buffer);

        TrySend();
    }

    private void TrySend()
    {
        try
        {
            lock (send_lock)
            {
                if (send_temp_buffer.Offset<=0)
                {
                    send_temp_buffer = Interlocked.Exchange(ref send_buffer, send_temp_buffer);
                }
                else
                {
                    Console.WriteLine("Dd");
                    return;
                }
            }

            send_event.SetBuffer(send_temp_buffer.Data, 0, send_temp_buffer.Offset);

        }
        catch (ObjectDisposedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        //
        if (!socket.SendAsync(send_event))
        {
            OnProcessSend(send_event);
        }
    }

        public void OnProcessSend(SocketAsyncEventArgs e)
        {
        if (!isConnect)
            return;

        long size = e.BytesTransferred;
        if (size > 0)
        {
            //Console.WriteLine(size);
            send_buffer.Clear();
            send_temp_buffer.Clear();
        }

        if (e.SocketError == SocketError.Success)
        {
            return;
        }
        else
        {
            Disconnect();
        }
    }
}