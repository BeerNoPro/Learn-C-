using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        // In ra họ tên và điểm số từ input
        static void firstExercise()
        {
            /*
             * ==> Request
            Viết chương trình khai báo các biến:
            1, fullName,
            2, mathScores,
            3, literaturesScores
            input: Cho người dùng nhập vào full name, math scores, literature scores
            output: Học sinh tên ... điểm toán ... điểm văn.
            Conver utf8: Console.OutputEncoding = Encoding.UTF8;
             */
            string fullName;
            float mathScores;
            float literatureScores;

            Console.WriteLine("Please enter your full name: ");
            fullName = Console.ReadLine();

            Console.WriteLine("Please enter your math scores: ");
            mathScores = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your literature scores: ");
            literatureScores = float.Parse(Console.ReadLine());

            Console.WriteLine("Full name is {0} math scores is {1} literature scores is {2}", fullName, mathScores, literatureScores);
            Console.ReadKey();
        }

        // Tính tổng hai số từ input
        static void sumTwoNumber()
        {
            float x, y;
            Console.WriteLine("Pleaser enter first number: ");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Pleaser enter second number: ");
            y = float.Parse(Console.ReadLine());

            float z1 = x + y;
            float z2 = x - y;
            float z3 = x * y;
            float z4 = x / y;
            float z5 = x % y;

            Console.WriteLine("{0} + {1} = {2}", x, y, z1);
            Console.WriteLine("{0} - {1} = {2}", x, y, z2);
            Console.WriteLine("{0} * {1} = {2}", x, y, z3);
            Console.WriteLine("{0} / {1} = {2}", x, y, z4);
            Console.WriteLine("{0} % {1} = {2}", x, y, z5);
            Console.ReadKey();
        }

        // Kiểm tra số nhập vào từ input là số chẵn hay số lẻ
        static void checkParity()
        {
            int a;
            Console.WriteLine("Pleaser enter your number int: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Your enter number {0}", a);
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is number even", a);
            }
            else
            {
                Console.WriteLine("{0} is number odd", a);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            // firstExercise();
            // sumTwoNumber();
            checkParity();
        }
    }
}
