using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AulaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite a Quantidade ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a Quantidade ");
                vet [i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            double sum = 0.00;

            for (int i = 0; i < n; i++)
            {
                sum = sum + vet [i];

            }

            double avg = sum / n;

            Console.WriteLine(avg);

            string[] vet = new string[] { "Maria", "Alex", "Joao" };

            foreach (string obg in vet)

            {
                Console.WriteLine(obg);
            }

            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Ana");

            foreach (string s in list)
            {

                Console.WriteLine(s);
            }

            Console.WriteLine(list.Count);*/

            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];
            
            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine( mat[j, j]);
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                

                for (int j = 0; j < n; j++)
                {
                  if ( mat[i, j] < 0 )
                        count++;

                }


            }

            Console.WriteLine(count);
            Console.WriteLine(mat);




        }
    }
}
