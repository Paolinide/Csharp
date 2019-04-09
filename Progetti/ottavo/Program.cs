using System;

namespace ottavo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Paroloni("Hello World!").Replace('•', ''));
            //Console.WriteLine(Caratterone('B').Replace('·', ' '));
            //Console.WriteLine(Caratterone('d').Replace('·', ' '));
        }

        static public string Frasone(string stringa){
            string risultato = "";
            foreach(var s in stringa.Split(" "))
                risultato += Paroloni(s)+"\n";
            return risultato;
        }
        static public string Paroloni(string stringa)
        {
            string[] r = new string[Caratterone('c').Split("\n").Length];//{ "", "", "", "", "", "", "" };
            foreach (var c in stringa)
            {
                string[] s = Caratterone(c).Split("\n");
                for (int i = 0; i < r.Length; i++)
                    r[i] += s[i] + " ";
            }
            return r[0] + "\n" + r[1] + "\n" + r[2] + "\n" + r[3] + "\n" + r[4] + "\n" + r[5] + "\n" + r[6];
        }
        static public string Caratterone(char c)
        {
            string risultato = "";
            switch (c)
            {
                case 'A':
                case 'a':
                    risultato = "··•··\n·•·•·\n•···•\n•••••\n•···•\n·····\n·····";
                    break;
                case 'B':
                case 'b':
                    risultato = "••••·\n•···•\n••••·\n•···•\n••••·\n·····\n·····";
                    break;
                case 'C':
                case 'c':
                    risultato = "·•••·\n•···•\n•····\n•···•\n·•••·\n·····\n·····";
                    break;
                case 'D':
                case 'd':
                    risultato = "••••·\n•···•\n•···•\n•···•\n••••·\n·····\n·····";
                    break;
                case 'E':
                case 'e':
                    risultato = "•••••\n•····\n••••·\n•····\n•••••\n·····\n·····";
                    break;
                case 'F':
                case 'f':
                    risultato = "•••••\n•····\n••••·\n•····\n•····\n·····\n·····";
                    break;
                case 'G':
                case 'g':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'H':
                case 'h':
                    risultato = "•···•\n•···•\n•••••\n•···•\n•···•\n·····\n·····";
                    break;
                case 'I':
                case 'i':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'J':
                case 'j':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'K':
                case 'k':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'L':
                case 'l':
                    risultato = "•····\n•····\n•····\n•····\n•••••\n·····\n·····";
                    break;
                case 'M':
                case 'm':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'N':
                case 'n':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'O':
                case 'o':
                    risultato = "·•••·\n•···•\n•···•\n•···•\n·•••·\n·····\n·····";
                    break;
                case 'P':
                case 'p':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'Q':
                case 'q':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'R':
                case 'r':
                    risultato = "••••·\n•···•\n••••·\n•··•·\n•···•\n·····\n·····";
                    break;
                case 'S':
                case 's':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'T':
                case 't':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'U':
                case 'u':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'V':
                case 'v':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'W':
                case 'w':
                    risultato = "•···•\n•···•\n•·•·•\n•·•·•\n·•·•·\n·····\n·····";
                    break;
                case 'X':
                case 'x':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'Y':
                case 'y':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                case 'Z':
                case 'z':
                    risultato = "·····\n·····\n·····\n·····\n·····\n·····\n·····";
                    break;
                    // PUNTEGGIATURA
                case ' ':
                    risultato = "···\n···\n···\n···\n···\n···\n···";
                    break;
                case '.':
                    risultato = "···\n···\n···\n···\n·•·\n···\n···";
                    break;
                case ',':
                    risultato = "···\n···\n···\n···\n···\n·•·\n•··";
                    break;
                case '!':
                    risultato = "·•·\n·•·\n·•·\n···\n·•·\n···\n···";
                    break;
                default:
                    risultato = "Oops!\n·····\n·NOT·\nPRSNT\n·····\n·····\nOops!";
                    break;
            }
            return risultato;
        }
        static public string Moltiplica(char c, int volte)
        {
            string risultato = "";
            for (int i = 0; i < volte; i++)
                risultato += c;
            return risultato;
        }
    }
}
