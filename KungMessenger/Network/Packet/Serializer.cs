using System;
using System.Text;
using System.Text.Encodings;
namespace KungMessenger.Network.Packet
{
    public class Serializer 
    {
        #region Write
        public bool Write(Buffer buffer, string data, int index) 
        {
            var stringToBytes = Encoding.UTF8.GetBytes(data);
            if (Write(buffer, (UInt16)data.Length,index))
            {
                index += sizeof(UInt16);
                return buffer.Write(stringToBytes,index);
            }

            return false;
        }
        public bool Write(Buffer buffer, Int16 data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index); 
        }
        public bool Write(Buffer buffer, Int32 data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index);
        }
        public bool Write(Buffer buffer, Int64 data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index);
        }
        public bool Write(Buffer buffer, UInt16 data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index);
        }
        public bool Write(Buffer buffer, UInt32 data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index);
        }
        public bool Write(Buffer buffer, UInt64 data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index);
        }
        public bool Write(Buffer buffer, bool data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index);
        }
        public bool Write(Buffer buffer, Single data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index);
        }
        public bool Write(Buffer buffer, Double data, int index)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes, index);
        }
        //no index
        public bool Write(Buffer buffer, string data)
        {
            var stringToBytes = Encoding.UTF8.GetBytes(data);

            if (Write(buffer,(UInt16)data.Length))
            {
                return buffer.Write(stringToBytes);
            }

            return false;
        }
        public bool Write(Buffer buffer, Int16 data)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes);
        }
        public bool Write(Buffer buffer, Int32 data)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes);
        }
        public bool Write(Buffer buffer, Int64 data) 
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes);
        }
        public bool Write(Buffer buffer, UInt16 data)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes);
        }
        public bool Write(Buffer buffer, UInt32 data)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes);
        }
        public bool Write(Buffer buffer, UInt64 data)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes);
        }
        public bool Write(Buffer buffer, bool data)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes);
        }
        public bool Write(Buffer buffer, Single data)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes); 
        }
        public bool Write(Buffer buffer, Double data)
        {
            var bytes = BitConverter.GetBytes(data);
            return buffer.Write(bytes);
        }

        #endregion
    }

    public interface ISerializer
    {
        bool Serialize(Packet packet);
        bool Deserialize(Packet packet);
    }
}
