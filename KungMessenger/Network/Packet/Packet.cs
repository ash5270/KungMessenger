using System;

namespace KungMessenger.Network.Packet
{
    public enum PacketID :UInt16
    {
        Login=2000,
        Signup=2001,

    }

    public abstract class Packet
    {
        public PacketID ID { get; set; }  
        public UInt16 Size { get; set; }
    }
}
