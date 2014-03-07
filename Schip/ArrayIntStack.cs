using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schip
{
    class ArrayIntStack
    {
        #region atributos
        private int[] data;
        private int size;
        private int maxSize;
        #endregion

        #region metodos getter y setter
        public int Size { get { return size; } }
        public int MaxSize { get { return maxSize; } }
        #endregion

        #region constructores
        public ArrayIntStack(int maxSize)
        {
            this.maxSize = maxSize;
            size = 0;
            data = new int[maxSize];
        }
        #endregion

        #region otros metodos 
        public void Push(int value)
        {
            if(size == maxSize)
                throw new Exception("Stack overflow");

            data[size++] = value;
        }
        
        public void Pop()
        {
            size--;
        }

        public int Top()
        {
            if (size == 0)
                throw new Exception("Empty Stack");

            return data[size - 1];
        }

        public int lookAt(int i)
        {
            if (i > size || i<0)
                throw new Exception("Index out of bounds");

            return data[i];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Clear()
        {
            size = 0;
        }
        #endregion
    }
}
