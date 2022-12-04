using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculation
    {
        private int number1;
        private int number2;

        public int Number1
        {
            get{
                return number1;
            }
            set
            {
                number1 = value;
            }
           
    }
        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                number2 = value;
            }
        }

        public void solution()
        {
            Console.Write("What you want? [0-Add,1-Sub,2-Multi,3-Divided] :");
            int method = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number1 :");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number2 :");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer is "+math(Number1,Number2,method));
        }
        private double math(int a,int b,int method)
        {
            switch (method)
            {
                case 0:
                    return (float) a + b;
                case 1:
                    return (float) a - b;
                case 2:
                    return (float) a * b;
                case 3:
                    try
                    {
                        double v = a / b;
                        return (float) v;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Err is "+e);
                        return -1;
                        
                    }
                    
                default:
                    return -1;
                   
            }
        }
    }
}
