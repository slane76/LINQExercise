using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var L1 = Enumerable.Range(0, 10);
            var L2 = Enumerable.Range(10, 10);
            int i = 1;
            foreach (var list in L1)
            {
                Console.WriteLine($" Value {i} : {list}");
                i++;
            }
            Console.WriteLine("-----------------------------");
            var L1Sum = L1.Sum();
            Console.WriteLine($" The sum of L1 is : {L1Sum}");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("L2 list :");
            int n = 1;
            foreach (var list2 in L2)
            {
                Console.WriteLine($" Value {n} is : Multiplication :{n * 2}");
                n++;
            }
            Console.WriteLine("-----------------------------");



            Console.WriteLine("Sum L1 + L2: ");

            var SumValue = L1.Zip(L2, (n1, n2) => n1 + n2);

            foreach (var number in SumValue)
            {
                Console.WriteLine($" L1 + L2 = {number}");
            }







        }
    }
}
