using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Prob
{
    class Program
    {
        static void Main(string[] args)
            /*
             * Ex 1
Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
metoda care va calcula volumul acestuia.
Folositi o clasa care va modela un dulap.
 Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
 Cele trei campuri vor fi initializate cu ajutorul constructorului
 Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
afisati rezultatul.
            */
        {
             Dulap dulap = new Dulap();
            dulap.lungime = 200;
            dulap.latime = 250;
            dulap.inaltime = 230;

        //Console.WriteLine($"Volumul Dulapului este {dulap.volum} ");

        }
        static void PrintDulap (Dulap dulap)
        {
            Console.WriteLine($"Dimensiunile unui dulap sunt {dulap.lungime} , {dulap.latime} , {dulap.inaltime} ");
        }
    }
    class Dulap
    {
        public double lungime;
        public double latime;
        public double inaltime;
    }
        
}
