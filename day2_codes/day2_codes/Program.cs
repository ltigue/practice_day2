using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_codes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int result = AddNumbers(10, 5);
            Console.WriteLine(result);
            
           
        }
        public static int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            if (result > 10)
            {
                return result;
            }
            return 0;
        }


        
    }

}
