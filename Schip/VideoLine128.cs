using System;

namespace Schip
{
    class VideoLine128
    {
        private ulong rightSide, leftSide;

        public VideoLine128()
        {
            rightSide = leftSide = 0;
        }

        public void Shr(int n)
        {
            if (n < 64)
            {
                ulong mask = (1UL << n) - 1;
                rightSide >>= n;
                rightSide |= (leftSide & mask) << (64 - n);
                leftSide >>= n;
            }
            else
            {
                n = n - 64;
                rightSide = leftSide >> n;
                leftSide = 0;
            }
        }

        public void Shl(int n)
        {
            if (n < 64)
            {
                ulong mask = ((1UL << n) - 1) << (64 - n);
                leftSide <<= n;
                leftSide |= (rightSide & mask) >> (64 - n);
                rightSide <<= n;
            }
            else
            {
                n = n - 64;
                leftSide = rightSide << n;
                rightSide = 0;
            }
        }

        public void ActivePixel(int p)
        {
            if (p < 64)
                leftSide |= (1UL << ConvertLeft(p));
            else
                rightSide |= (1UL << ConvertRight(p));
        }

        public void DeactivePixel(int p)
        {
            if (p < 64)
                leftSide &= ~(1UL << ConvertLeft(p));
            else
                rightSide &= ~(1UL << ConvertRight(p));
        }

        public void XorPixel(int p, byte value)
        {
            ulong val = (ulong)(value & 1);

            if (p < 64)
                leftSide ^= (val << ConvertLeft(p));
            else
                rightSide ^= (val << ConvertRight(p));
        }

        public bool IsPixelActive(int p)
        {
            if (p < 64)
                return !((leftSide & (1UL << ConvertLeft(p)))==0);
            return !((rightSide & (1UL << ConvertRight(p)))==0);
        }

        public int GetPixelValue(int p)
        {
            if (p < 64)
                return (leftSide & (1UL << ConvertLeft(p))) == 0?0:1;
            return (rightSide & (1UL << ConvertRight(p))) == 0?0:1;
        }

        public void Erase() {
            rightSide = leftSide = 0;
        }

        public override string ToString()
        {
            return Convert.ToString((long)leftSide, 2).PadLeft(64, '0') + Convert.ToString((long)rightSide, 2).PadLeft(64, '0');
        }
        
        private int ConvertLeft(int p)
        {
            return 63 - p;
        }

        private int ConvertRight(int p)
        {
            return 127 - p;
        }
    }
}
