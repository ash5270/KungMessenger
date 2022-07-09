using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungMessenger.Network.Packet
{
    public struct SignupData
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
    }

    public class SignupPacketSerializer : Serializer, ISerializer
    {
        public bool Deserialize(Packet packet)
        {

            return false;
        }

        public bool Serialize(Packet packet)
        {
            var signupPacket = packet as SignupPacket;
            var buffer = signupPacket.Buffer;
            var data = signupPacket.SignupData;
            signupPacket.Size = (UInt16)(data.ID.Length + data.Nickname.Length + data.Password.Length + sizeof(UInt16) * 3);

            bool result = false;
            result = Write(buffer, (UInt16)signupPacket.ID);
            result = Write(buffer, (UInt16)signupPacket.Size);

            result = Write(buffer, data.ID);
            result = Write(buffer, data.Password);
            result = Write(buffer, data.Nickname);

            return false;
        }
    }

    public class SignupPacket : Packet
    {
        public SignupData SignupData { get; set; }
        public Buffer Buffer { get; set; }
        private SignupPacketSerializer serializer;

        public SignupPacket()
        {
            ID = PacketID.Signup;
            Size = 0;
            serializer = new SignupPacketSerializer();
            Buffer = new Buffer();
        }

        public void Serialize()
        {
            serializer.Serialize(this);
        }

        public void Deserialize()
        {
            serializer.Deserialize(this);
        }
    }
}
