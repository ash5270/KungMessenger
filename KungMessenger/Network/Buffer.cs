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
        Array.Clear(buffer.Data, 0, buffer.Data.Length); 
        Capctiy = buffer.Capctiy;
        Offset = buffer.Offset;
    }

    public bool Write(byte[] bytes,int index)
    {
        Array.Copy(bytes, 0, Data, index, bytes.Length);
        Offset += bytes.Length;
        return true;
    }

    public bool Write(byte[] bytes)
    {
        Array.Copy(bytes, 0, Data, Offset, bytes.Length);
        Offset += bytes.Length;
        return true;
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

