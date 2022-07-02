using System;

namespace KungMessenger.Network.Packet
{
    public struct LoginData
    {
        public string ID { get; set; }
        public string Password { get; set; }
    }

    public class LoginPacketSerializer : Serializer , ISerializer
    {
        public bool Deserialize(Packet packet)
        {
            return false;
        }

        public bool Serialize(Packet packet)
        {
            var loginPakcet = packet as LoginPacket;
            var buffer = loginPakcet.Buffer;
            var data = loginPakcet.LogingData;
            var size = data.ID.Length+ data.Password.Length+ sizeof(UInt16)+sizeof(UInt16);

            //마지막에 사이즈
            bool result = false;
            result= Write(buffer, (UInt16)loginPakcet.ID);
            result= Write(buffer, size);
            result= Write(buffer, data.ID);
            result= Write(buffer, data.Password);
            return result;
        }
    }

    public class LoginPacket : Packet 
    {
        //데이터
        public LoginData LogingData { get;  set; }
        //buffer
        public Buffer Buffer { get; set; }
        //serializer
        private LoginPacketSerializer serializer;

        public LoginPacket()
        {
            ID = PacketID.Login;
            Size = 0;
            serializer=new LoginPacketSerializer();
            Buffer = new Buffer();
        }

        public void Serialize()
        {
            serializer.Serialize(this);
        }
        public void DeSerialize()
        {
            serializer.Deserialize(this);
        }
    }
}
