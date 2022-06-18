using System;
using System.Text;
using System.Collections.Generic;

namespace KungMessenger.Network;

public class Buffer
{
    public readonly int DefaultSize = 2048;

    public byte [] Data { get; private set; }
    public int Offset { get; private set; }
    public int Capctiy { get; private set; }

    public Buffer()
    {
        Data=new byte[DefaultSize];
        Offset = 0;
        Capctiy = DefaultSize;
    }

    public Buffer(int size)
    {
        Data = new byte[size];
        Offset = 0;
        Capctiy = size;
    }
    
    public Buffer(Buffer buffer)
    {
        Data = new byte[buffer.Capctiy];
        Array.Copy(buffer.Data,0, Data, Offset, buffer.Capctiy);
        Capctiy = buffer.Capctiy;
        Offset = buffer.Offset;
    }

    public void Write(Int16 data)
    {
        byte[] bytes = BitConverter.GetBytes(data);
        Array.Copy(bytes, 0, Data, Offset, bytes.Length);
        Offset += bytes.Length; 
    }

    public void Write(Int32 data)
    {
        byte[] bytes = BitConverter.GetBytes(data);
        Array.Copy(bytes, 0, Data, Offset, bytes.Length);
        Offset += bytes.Length; 
    }

    public void Write(Int64 data)
    {
        byte[] bytes = BitConverter.GetBytes(data);
        Array.Copy(bytes, 0, Data, Offset, bytes.Length);
        Offset += bytes.Length;
    } 

    public void Write(float data)
    {
        byte[] bytes = BitConverter.GetBytes(data);
        Array.Copy(bytes, 0, Data, Offset, bytes.Length);
        Offset += bytes.Length;
    }

    public void Write(double data)
    {
        byte[] bytes = BitConverter.GetBytes(data);
        Array.Copy(bytes,0, Data,Offset, bytes.Length);
        Offset += bytes.Length;
    }

    public void Write(string data)
    {
        byte[] temp_buffer = Encoding.UTF8.GetBytes(data);
        Int16 length = (Int16)temp_buffer.Length;
        Write(length);

        Array.Copy(temp_buffer, Data, temp_buffer.Length);
        Offset += temp_buffer.Length;
    }

    public void Write(Buffer buffer)
    {
        Array.Copy(buffer.Data, 0, Data, Offset,buffer.Offset);
        Offset += buffer.Offset;
    }

    public void Clear()
    {
        Array.Clear(Data, 0, Data.Length);
        Offset = 0;
    }
}

