using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// ref - обязательно проинициализированы

namespace classes_sharp
{

    class Student
    {
        // модификатор доступа пишется для каждого элемента, private по умолчанию
        // в классах прототипы не делаем - сразу тело конструктора пишем
        string fname;
        string lname;
        int age;
        double avg;
        static string group;

        static Student() // заменяет базовый коструктор, ко всем остальным полям пишет 0 + нет модификатора
        {
            group = "PV221";
            WriteLine($"constructor with static");
        }

        /*public Student()
        {
            fname = " ";
            lname = " ";
            age = 0;
            avg = 0;
            WriteLine($"constructor default");
        }*/

        public Student() : this("not fname", "not lname", 0, 0) { } // в той последовательночти в которой объявили поля

        public Student(string fn, string ln, int a, double av)
        {
            fname = fn;
            lname = ln;
            age = a;
            avg = av;
            WriteLine($"constructor with param");
        }

        public void show()
        {
            WriteLine($"{lname} {fname} {age} {avg} {group}");
        }

        public void setFname()
        {
            WriteLine($"enter the name: ");
            fname = ReadLine();
        }

        public string getFname()
        {
            return fname;
        }

        public override string ToString()
        {
            return $"{lname} {fname} {age} {avg} {group}";
        }

    }

   /* class A
    {
        public void fA(B obj)
        {
            obj.fB(this);
        }
    }

    class B
    {
        public void fB(A obj)
        {
            WriteLine($"работает класс {obj.GetType().Name}");


        }
    }*/

   /* class Calc
    {
        public static int Mult (int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Mult(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;
        }

        public static double Mult(double n1, double n2)
        {
            return n1 + n2;
        }
    }*/

    // ref & out


    internal class Program
    {
        // без изменений
        /* static void func ( int n1, int[] arr)
         {
             WriteLine($"внутри функции, но до использования {n1} ");
             foreach (int item in arr)
             {
                 Write($"{item} ");
             }
             WriteLine();

             n1 = 200;
             arr = new int[] { 5, 5, 6 };

             WriteLine($"внутри функции, но после использования {n1} ");
             foreach (int item in arr)
             {
                 Write($"{ item} ");
             }
             WriteLine();
         }*/

        // ref
        /* static void func (ref int n1, ref int[] arr)
        {
            WriteLine($"внутри функции, но до использования {n1} ");
            foreach (int item in arr)
            {
                Write($"{item} ");
            }
            WriteLine();

            n1 = 200;
            arr = new int[] { 5, 5, 6 };

            WriteLine($"внутри функции, но после использования {n1} ");
            foreach (int item in arr)
            {
                Write($"{ item} ");
            }
            WriteLine();
        }*/

        // out
       /* static void func(out int n1, out int[] arr)
        {

            n1 = 200;
            arr = new int[] { 5, 5, 6 };

            WriteLine($"внутри функции, но после использования {n1} ");
            foreach (int item in arr)
            {
                Write($"{ item} ");
            }
            WriteLine();
        }*/
        static void Main(string[] args)
        {
            /* Student s1 = new Student("LN1", "FN1", 23, 7.8);
             s1.show();
             Student s2 = new Student();
             s2.show();
             s2.setFname();
             WriteLine($"********************");
             s2.show();*/
            /*
            A a = new A();
            B b = new B();
            a.fA(b);*/

            /* int num1 = 2, num2 = 3, num3 = 8;
             double num4 = 45.2, num5 = 10.5;
             WriteLine($"{num1} * {num2} = {Calc.Mult(num1, num4)}");
             WriteLine($"{num1} * {num2} * {num3} = {Calc.Mult(num1, num2, num3)}");
             WriteLine($"{num4} + {num5} = {Calc.Mult(num4, num1)}");*/

            // ref & out

            // без изменений
            /* int numb = 50;
             int[] arrr = new int[] { 2, 3, 4 };
             WriteLine($"в мейне до использования {numb} ");
             foreach (int item in arrr)
             {
                 Write($"{ item}");
             }
             WriteLine();
             WriteLine("***************************");
             func(numb, arrr);
             WriteLine("***************************");
             WriteLine($"в мейне после использования {numb} ");
             foreach (int item in arrr)
             {
                 Write($"{ item}");
             }
             WriteLine();*/

            /*// после ref
            int numb = 50;
            int[] arrr = new int[] { 2, 3, 4 };
            WriteLine($"в мейне до использования {numb} ");
            foreach (int item in arrr)
            {
                Write($"{ item} ");
            }
            WriteLine();
            WriteLine("***************************");
            func(ref numb, ref arrr);
            WriteLine("***************************");
            WriteLine($"в мейне после использования {numb} ");
            foreach (int item in arrr)
            {
                Write($"{ item} ");
            }
            WriteLine();*/

            // после out
            /* int numb;
             int[] arrr = new int[] {};

             WriteLine("***************************");
             func(out numb, out arrr);
             WriteLine("***************************");
             WriteLine($"в мейне после использования {numb} ");
             foreach (int item in arrr)
             {
                 Write($"{ item} ");
             }
             WriteLine();*/

            Student s = new Student("sbchs", "ndcbsc", 22, 45.6);
            WriteLine(s);
        }
    }
}

// Parse - string в любой тип
// Convert - любой тип в любой тип
