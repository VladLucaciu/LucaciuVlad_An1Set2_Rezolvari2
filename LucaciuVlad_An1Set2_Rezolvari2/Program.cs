using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaciuVlad_An1Set2_Rezolvari2
{
    class Program
    {
        //Se da o secventa de n numere.Sa se determine cate din ele sunt pare
        static void s2p1()
        {
            int n;
            int pare = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int nr;
                nr = int.Parse(Console.ReadLine());
                if (nr % 2 == 0)
                    pare++;

            }
            Console.WriteLine("{0} sunt numere pare", pare);
            Console.ReadLine();

           
        }
        //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        static void s2p2() 
        {
            {
                int n;
                int pozitive = 0;
                int zero = 0;
                int negative = 0;
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    int nr;
                    nr = int.Parse(Console.ReadLine());
                    if (nr == 0)
                        zero++;
                    else if (nr > 0)
                        pozitive++;
                    else if (n < 0)
                        negative++;
                    
                    


                }
                Console.WriteLine("Numarul este {0},{1},{2} ", pozitive, zero, negative);
                Console.ReadLine();


            }
        }
        static void s2p3()
        //Calculati suma si produsul numerelor de la 1 la n. 
        {
            int n;
            int suma=0, produs=1;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int nr;
                nr = int.Parse(Console.ReadLine());
                suma = suma+nr;
                produs = produs*nr;

            }
            Console.WriteLine("Suma si produsul sunt {0} respectiv {1}",suma,produs);
            Console.ReadLine();
        }
        
        // setul 3 problema 1 
        //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        static void s3p1() 
        {
            int sum = 0;
            Console.Write("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];


            Console.WriteLine("Introduceti elementele:");
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma elementelor din vectorul dat este: ");
            for (int i = 0; i < n ; i++)
                sum += v[i];

            Console.WriteLine(sum);

            Console.ReadLine();


        }
         
        
        static void Main(string[] args)
        {
            //s2p1(); //Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
            //s2p2(); // Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
            //s2p3(); // Calculati suma si produsul numerelor de la 1 la n. 
            //s3p1(); // Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

        }
    }
}
