using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            int originNum = 0;
            bool isSpecialNum = false;

            for (int num = 1; num <= inputNum; num++)
            {
                originNum = num;

                while (num > 0)
                {
                    sumDigits += num % 10;
                    num = num / 10;
                }

                isSpecialNum = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine("{0} -> {1}", originNum, isSpecialNum);
                sumDigits = 0;
              //  num = originNum;
            }

        }
    }
}
