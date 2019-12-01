using System;
namespace Домашна_6
{
    class Program
    {
        static void Print(string name, int age)
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
        }
        static void Fill(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element {0}:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
        static bool Contain(int[] arr, int n)
        {
            bool result = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        static int GetIndex(int[] arr, int n)
        {
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == n)
                {
                    index = i;
                    break;
                }
            }
            Console.Write("Index of element {0} is: ", n);
            return index;
        }
        public static bool IsEqual(int a, int b)
        {
            bool result = false;
            if (a == b)
            {
                result = true;
            }
            return result;
        }
        public static bool IsEqual(double a, double b)
        {
            bool result = false;
            if (a == b)
            {
                result = true;
            }
            return result;
        }
        public static void Initialise(ref int a, ref int b)
        {
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
        }
        public static void Initialise(out double a, out double b)
        {
            Console.WriteLine("Enter floating a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter floating b:");
            b = double.Parse(Console.ReadLine());
        }
        static void Display(int a, int b)
        {
            if (IsEqual(a, b) == true)
            {
                Console.WriteLine("{0} is equal to {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} is not equal to {1}", a, b);
            }
        }
        static void Display(double a, double b)
        {
            if (IsEqual(a, b) == true)
            {
                Console.WriteLine("{0} is equal to  {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} a is not equal to {1}", a, b);
            }
        }
        static int Sum(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else
            {
                return a + Sum(a + 1, b);
            }
        }
        static void Main()
        {
            string name; //Zadacha1
            int age, n, counter = 0;
            Console.WriteLine("Enter number of people:");
            n = int.Parse(Console.ReadLine());
            while (counter < n)
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age = int.Parse(Console.ReadLine());
                Print(name, age);
                counter++;
            }
            /*Zadacha 2
              int[] arr;
            int n;
            Console.WriteLine("Enter number of elements in the array:");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            Fill(arr, n);
            PrintArray(arr);
            Console.WriteLine();
            Print(arr, n);
            Console.WriteLine(GetIndex(arr, n));*/
            /*Zadacha3
            int a = 0, b = 0;
            double c, d;
            Initialise(ref a, ref b);
            Initialise(out c, out d);
            Display(a, b);
            Console.WriteLine();
            Display(c, d);*/
            /*Zadacha4
             int n;
            Console.WriteLine("Enter n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of the first {0} numbers is:{1}",n, Sum(1, n));*/
        }
    }
}
