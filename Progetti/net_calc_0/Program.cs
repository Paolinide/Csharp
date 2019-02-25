using System;

namespace net_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip1 = new IPv4Address();
        }
    }
    class IPv4Address
    {
        byte[] quarto = new byte[4];
        public bool setQuarto(byte n, byte valore)
        {
            //n = min(1, max(4, n));
            if (n<1 || n>4) return false;
            quarto[n] = valore;
            return true;
        }
        public void setValore(byte b1, short b2=-1, short b3=-1, short b4=-1)
        {
            quarto[0] = b1;
            if (b2>=0 && b2<=255) quarto[1] = (byte)b2;
            if (b2>=0 && b2<=255) quarto[2] = (byte)b3;
            if (b2>=0 && b2<=255) quarto[3] = (byte)b4;
        }
        public static byte max(byte v1, byte v2) { return (v1 > v2) ? v1 : v2; }
        public static byte min(byte v1, byte v2) { return (v1 < v2) ? v1 : v2; }
    }
}
