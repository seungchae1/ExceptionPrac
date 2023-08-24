using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력해주세요.");
            int input = int.Parse(Console.ReadLine());
            if (input < array.Length && input >= 0)
            {
                Console.WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");
            }
        }
    }
}
