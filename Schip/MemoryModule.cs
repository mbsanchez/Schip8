using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schip
{
    class MemoryModule
    {
        #region atributos
        private uint memorySize;
        private byte[] data;
        #endregion

        #region metodos getter y setter
        public uint MemorySize { get { return memorySize; } }
        //public byte[] Data { get { return data; } }
        #endregion

        #region constructor
        public MemoryModule(uint size)
        {
            memorySize = size;
            data = new byte[memorySize];
        }
        #endregion

        #region otros metodos
        public void Clear()
        {
            for (int i = 0; i < memorySize; i++)
                data[i] = 0;
        }

        public void WriteByte(uint address, byte value)
        {
            if (address < 0 || address >= memorySize)
                throw new Exception("Invalid address for store");

            data[address] = value;
        }

        public void WriteByte(uint address, uint offset, byte value)
        {
            WriteByte(address + offset, value);
        }

        public byte ReadByte(uint address)
        {
            if (address < 0 || address >= memorySize)
                throw new Exception("Invalid address for read");

            return data[address];
        }

        public byte ReadByte(uint address, uint offset)
        {
            return ReadByte(address + offset);
        }
        #endregion
    }
}
