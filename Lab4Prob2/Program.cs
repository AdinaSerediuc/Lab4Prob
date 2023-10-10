using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex 2
Scrieti un program care va modela un autoturism. Un autoturism va avea o
marca (string), un numar de inmatriculare (string), precum si o
capacitate cilindrica(int).
Autoturismul va avea:
 Campurile corespunzatoare caracteristicilor autoturismului.
 Un constructor care va initializa campurile acestuia
 O metoda “GetDescription” care va returna descrierea acestuia sub forma : “marca,
numarDeInmatriculare, capacitateCilindrica”.
Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
xml pentru metodele publice.
Creeati doua obiecte de tipul autoturism in functia “Main” apelati-le metodele
si afisati rezultatul.
            */
            Autoturism autoturism = new Autoturism("BMW", "CJ24YUK", 1995);
            //autoturism.marca = "BMW";
            //autoturism.nrDeInmatriculare = "CJ24YUK";
           // autoturism.capacitateCilindrica = 1995;


            Autoturism autoturism2 = new Autoturism("VW", "CJ97VLK", 1598);
            //autoturism2.marca = "VW";
            //autoturism2.nrDeInmatriculare = "CJ97VLK";
            //autoturism2.capacitateCilindrica = 1598;




            //PrintAutoturism(autoturism);
            autoturism.PrintAutoturism();
            autoturism2.PrintAutoturism();

        }
           /* static void PrintAutoturism(Autoturism autoturism)
             {
                 Console.WriteLine($"Caracteristicile automobilului sunt: Marca {autoturism.marca} , Nr de Inmatriculare {autoturism.nrDeInmatriculare} , Capacitate Cilindrica {autoturism.capacitateCilindrica} centimetrii cubi ");
             }*/
        
        class Autoturism
        {
            public readonly string marca;
            private string nrDeInmatriculare;
            public int capacitateCilindrica;

            public Autoturism(string marca, string nrDeInmatriculare, int capacitateCilindrica)
            {
                this.marca = marca;
                this.nrDeInmatriculare = nrDeInmatriculare;
                this.capacitateCilindrica = capacitateCilindrica;


            }
             public void PrintAutoturism()
            {
                Console.WriteLine($"Caracteristicile automobilului sunt: Marca {marca} , Nr de Inmatriculare {nrDeInmatriculare} , Capacitate Cilindrica {capacitateCilindrica} centimetrii cubi ");
            }
        }
    }
}
