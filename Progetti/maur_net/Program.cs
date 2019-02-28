using System;

namespace myIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPv4 ip1 = new IPv4("1.1.1.50");
            IPv4 ip2 = new IPv4("2.2.2.50"
            );
            IPv4 ip3 = new IPv4();
            ip3 = ip1 + ip2;
            ip3.print();
            ip3++;
            ip3.print();

            for (int i = 0; i < 10; i++)
            {
                ip3 = ip3 + ip2;
                ip3.print();

            }

            try
            {

            }
            catch (System.Exception e)
            {

                throw;
            }



        }
    }

    class IPv4

    {
        private int[] ip = { 0, 0, 0, 0 };
        public int[] Ip
        {
            get
            {
                return this.ip;
            }
            set
            {
                this.ip = value;
            }
        }

        public IPv4()
        {
            //int[] this.ip ={ 0,0,0,0};
        }
        public IPv4(int[] quartina)
        {

            for (int i = 0; i < quartina.Length; i++)
            {
                this.ip[i] = quartina[i];
            }
        }
        public IPv4(string quartina)
        {
            string[] ips = quartina.Split('.');

            //int[] IPs = new int[4];
            for (int i = 0; i < ips.Length; i++)
            {
                this.ip[i] = Convert.ToInt32(ips[i]);
            }

        }
        public void print()
        {
            printQuad(this.ip);
        }
        public static void printQuad(int[] quad)
        {
            foreach (var item in quad)
            {
                Console.Write("{0}.", item);
            }
            Console.WriteLine("\b ");
        }

        public static IPv4 operator +(IPv4 IP1, IPv4 IP2)
        {
            IPv4 IPSUM = new IPv4();
            int riporto, temp, somma;

            for (int i = 3; i > 0; i--)
            {

                temp = IPSUM.ip[i] + IP1.ip[i] + IP2.ip[i];
                riporto = temp / 255;
                somma = temp % 255;
                IPSUM.ip[i] = somma;
                IPSUM.print();
                IPSUM.ip[i - 1] += riporto;
                IPSUM.print();
            }
            IPSUM.ip[0] += IP1.ip[0] + IP2.ip[0];
            return IPSUM;
        }
        public static IPv4 operator ++(IPv4 IP1)
        {
            //        Complex temp = new Complex();  
            IPv4 IPSUM = new IPv4("0.0.0.1");
            IPSUM = IP1 + IPSUM;

            return IPSUM;
        }
        public static IPv4 operator -(IPv4 IP1, IPv4 IP2)
        {

            //////////////////////////////////////////////////////////////////////////////
            //   FIXME   puro segnaposto per l'operazione

            IPv4 IPDIFF = new IPv4();
            Console.WriteLine("dentro");
            IP1.print();
            IP2.print();
            IPDIFF.print();
            int riporto, temp, diff;

            for (int i = 0; i < 4; i++)
            {

                IPDIFF.ip[i] = IP1.ip[i] - IP2.ip[i];

            }

            return IPDIFF;
        }
        public static IPv4 operator --(IPv4 IP1)
        {
            //        Complex temp = new Complex();  
            IPv4 IPSUM = new IPv4("0.0.0.-1");
            IPSUM = IP1 + IPSUM;

            return IPSUM;
        }

        /*

                public override bool Equals(Object o)
                {
                    if ((IPv4)o).ip == this.ip)
                        return true;
                    else
                        return false;
                }

                public static explicit operator IPv4(object v)
                {
                    throw new NotImplementedException();
                }

                // obbligatorio per far funzionare quello sopra
                public override int GetHashCode()
                {
                    return this.ToString().GetHashCode();
                }
                public static bool operator ==(IPv4 IP1, IPv4 IP2)
                {
                    return IP1.Equals(IP2);
                }

                public static bool operator !=(IPv4 IP1, IPv4 IP2)
                {
                    return !IP1.Equals(IP2);


                }
        */

    }
}
    
    
    
    
    
    /*

    class IPnet
    {
        public string nomeRete;
        public void Set(string nome) => nomeRete = nome;

        private IPv4 ipnet;
        private IPv4 broadcast;
        private IPv4 firstHost;
        private IPv4 lastHost;
        private IPv4 subnetMask;
        private int numHost;

        public IPnet()
        { }
        public IPnet(IPv4 ipnet, IPv4 subnet)
        {
            this.ipnet = ipnet;
            this.subnetMask = subnet;
            this.firstHost = ipnet++;
            this.broadcast = calcBroadcast(IPv4 ipnett, IPv4 subnett);
            this.lastHost = this.broadcast--;
            this.numHost = howMuch(this.lastHost - this.firstHost);

        }
        public IPnet(IPv4 ipnet, int numhost)
        { }
        public IPnet(IPv4 ipHost, IPv4 subnetmask, int j)
        { }
        public static IPv4 calcBroadcast(IPv4 ipnet, IPv4 subnet)
        {
            ////////////////////////////////////////////////////////////////////////////////
            IPv4 temp = new IPv4;
            temp = subnet - ipnet;
            return temp--
        }




    }




}
 */