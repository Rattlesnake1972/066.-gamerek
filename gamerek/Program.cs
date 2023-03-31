using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gamerek
{
    class gamer
    {
        public string nev;
        public string jelszo;
        public string email;
        public int pontszam;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<gamer> jatekosok = new List<gamer>();
            StreamReader sr = new StreamReader("gamer.txt");
            while(!sr.EndOfStream)
            {
                gamer gr = new gamer();
                string sor = sr.ReadLine();
                string[] darabok = sor.Split(';');
                gr.nev = darabok[0];
                gr.jelszo = darabok[1];
                gr.email = darabok[2];
                gr.pontszam = Convert.ToInt32(darabok[3]);
                jatekosok.Add(gr);
            }

            sr.Close();
            foreach(var item in jatekosok)
            {
                Console.WriteLine(item.email);
            }

            Console.ReadLine();
                
        }
    }
}
