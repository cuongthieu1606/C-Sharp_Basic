// CS03 - Các toán tử tính toán số học trong C# toán tử gán và tăng giảm, lập trình C# .NET Core

using System;

namespace CS03
{

    class Program
    {
        static void Main(string[] args)
        {
            // + - ^ / %
            int a = 5;
            int b = 4;
            int kq = a + b;

            Console.WriteLine("a + b =" + kq);
            // Tương tự


            // Gán: =, +=, -=, *=, %=, %=
            int x = 10;
            x += 2; // x = x + 2 <=> x = 10 + 2 = 12
            Console.WriteLine(x);
            // Tương tự -=, *=, %=, %= 

            // ++, --
            int y = 10;

            int z = 2 * y++;
            // 2 * x
            // x = x + 1
            Console.WriteLine(z);

            int k = 10;

            int i = 2 * ++k;
            // k = k + 1;
            // 2 * k
            Console.WriteLine(i);


        }
    }
}