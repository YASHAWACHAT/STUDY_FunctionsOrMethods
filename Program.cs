using System;
using System.ComponentModel;

namespace FunctionsOrMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///How to make object
            ///Class name Objectname=new classname();
            Program prg = new Program();
            prg.EvenNumber();
            Program.OddNumber();
            prg.EvenNumber(20);
            Program.AddNumber(12, 34);

            double sum=prg.AddNumber(12, 34, 67);
            Console.WriteLine("Addition of 3 Numbers="+sum);
            Console.WriteLine("Enter First and Last name");
            string FN = Console.ReadLine();
            string LN = Console.ReadLine();
            string FULLNAME= Program.FullName(FN, LN);
            Console.WriteLine(FULLNAME);
            string result=prg.AddDifferentDatataType(100, 45.67, "Result");
            Console.WriteLine(result);
        }
        //Methods are seperate peice of code written in certain block
        //Which is repeated block of code, used to call/invoke any time when ever required
        ///Their are two types of methods
        ///1.Instance Method: It used called using object
        ///2.Static Method: It is called using class name
        ///Static method contans static keyword
        ///Syntax:
        ///[Attribute]
        ///AccessModifier ReturnType MethodName(Optional Parameters)
        ///{
        ///  Statement 1
        ///  Statement 2
        /// }
        /// Access Modifiers:
        /// 1.Public
        /// 2.Private
        /// 3.Protected
        /// 4. Internal
        /// 5. Protected Internal
        /// Return Types:
        /// Some kewords are used as return type ex. int, void, float, char, string, double.
        /// -------------------------------
        /// 1. WAP to print even number from 1 to 10
        /// Method
        public void EvenNumber()//Instance Method
        {
            Console.WriteLine("This is EvenNumber Instance Method");
            for(int i=1;i<=10;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void EvenNumber(int num)//Instance Method
        {
            Console.WriteLine("This is EvenNumber Instance Method with Parameter");
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void OddNumber()
        {
            Console.WriteLine("This is OddNumber Static Method");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void AddNumber(double num1, double num2)
        {
            Console.WriteLine("This is AddMethod with 2 parameters");
            Console.WriteLine("Addition="+(num1+num2));
        }
        public double AddNumber(double num1, double num2,double num3)
        {
            Console.WriteLine("This is AddMethod with 3 parameters and retuntype");
            return num1 + num2+num3;
        }
        public static string FullName(string FN,string LN)
        {
            return "FullName=" + FN+ " " + LN;
        }

        public string AddDifferentDatataType(int n1, double n2, string name)
        {
            return "Sum="+(n1+n2)+" "+name; 
        }

    }
}
