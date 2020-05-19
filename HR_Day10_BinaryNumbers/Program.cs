using System;
using System.Linq;

namespace HR_Day10_BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //string output = Convert.ToString(n, 2);
            int count =0;
            int max = 0;
            while ( n > 0)
            {
                if(n%2 ==1)
                {
                    count += 1;
                    if(max < count)
                    {
                        max = count;
                    }
                }
                else
                {
                    count = 0;
                }
                n = n / 2;

            }
            Console.WriteLine(max);
            //int count = 1;
            //int max = 0;
            //if (!output.Contains('1'))
            //{
            //    count = 0;

            //}
            //else
            //{
            //    for (int i = 0; i < output.Length - 1; i++)
            //    {
            //        if (output[i] == '1' && output[i + 1] == '1')
            //        {
            //            count += 1;
            //        }
            //        else if (output[i] == '0')
            //        {
            //            if (max < count)
            //            {
            //                max = count;
            //            }
            //            count = 1;
            //        }
            //    }
            //}
            //Console.WriteLine(max < count ? count :max);
        }
    }
}
