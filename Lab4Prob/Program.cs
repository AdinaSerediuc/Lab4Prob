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
            dulap.lungime = 2.5;
            dulap.latime = 1.0;
            dulap.inaltime = 2.0;

            dulap.volum = dulap.CalculeazaVolum();

            PrintDulap(dulap);
            PrintVolum(dulap);

        }
        static void PrintDulap(Dulap dulap)
        {
            Console.WriteLine($"Dimensiunile unui dulap sunt {dulap.lungime} , {dulap.latime} , {dulap.inaltime} ");
        }

        static void PrintVolum(Dulap dulap)
        {
            Console.WriteLine($"Volumul Dulapului este {dulap.volum} ");
        }
        class Dulap
        {
            public double lungime;
            public double latime;
            public double inaltime;
            public double volum;

            public double CalculeazaVolum()
            {
                volum = lungime * latime * inaltime;
                return volum;
            }
        }

    }
}

        

