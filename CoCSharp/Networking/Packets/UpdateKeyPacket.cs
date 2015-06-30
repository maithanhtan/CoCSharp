﻿namespace CoCSharp.Networking.Packets
{
    public class UpdateKeyPacket : IPacket
    {
        public ushort ID { get { return 0x4E20;} }

        public byte[] Key;
        private int Unknown1; // = 1

        public void ReadPacket(PacketReader reader)
        {
            Key = reader.ReadByteArray();
            Unknown1 = reader.ReadInt();
        }

        public void WritePacket(PacketWriter writer)
        {

        }
    }
}