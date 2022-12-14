using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Tìm phần tử thứ 15 trong dãy fibonacci
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số thứ = ");
            decimal n = decimal.Parse(Console.ReadLine());
            //decimal n = Input(); // nhập số bằng hàm gọi
            decimal f1 = 1; decimal f2 = 1;// dãy fibonacci bắt đầu từ 1 và 1
            if(n < 2)
            {
                Console.WriteLine("Nhập giá trị n lớn hơn 2...");
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    decimal f = f1 + f2; // phần từ tiếp theo bằng tổng 2 phần tử trước phần từ thứ n = n - 1 + n - 2
                    //Console.Write(f + " ");
                    f1 = f2;
                    f2 = f;
                    if (i == n)
                    {
                        Console.WriteLine($"Số Fibonacci thứ {n} là : {f}");
                    }
                }
            }
            Console.ReadKey();
        }
        static decimal Input()
        {
            Console.Write("Nhập số thứ = ");
            string std = Console.ReadLine();
            decimal value = decimal.Parse(std);
            return value;
        }
    }
}
