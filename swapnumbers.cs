using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class SwapNumbers
    {
        public static void ReadingInputFromUser()
        {
            Console.WriteLine(" Please Enter First Number ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number ");
            int second = Convert.ToInt32(Console.ReadLine());
            SwapNumbers swap = new SwapNumbers();
            swap.SwapTwoNumbers(first , second);
        }
        public void SwapTwoNumbers( int first,int second)
        {
            int temp=0;
            Console.WriteLine("Before Swaping first{0} second{1}", first, second);
            temp=first;
            first=second;
            second=temp;
            Console.WriteLine("After Swaping first{0} second{1}", first, second);
        }
    }
}
