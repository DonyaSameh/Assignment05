using System;
using System.Data.Common;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {

        #region Demo
            #region Casting
            //object obj = new object();
            //obj = "mostafa";
            //obj = 3;
            //int x = 10;
            //object obj01 = new object();
            //obj01 = x;
            //Console.WriteLine(x);
            //object obj02 = new object();
            //obj02 = 10;
            //int x = (int)obj02;
            #endregion
            #region Nullable DataType
            //int x = null;
            //int? x = null;
            //Nullable<int> number;
            //int?  x =10;
            //int y =(int) x;
            //int y;
            //if (x != null)
            //{
            //    y = (int)x;
            //}
            //else {
            //    y = 0;
            //}
            //int y;
            //if (x.HasValue)
            //{
            //    y =x.Value;
            //}
            //else {
            //    y = 0;
            //}
            //y = HasValue ? x.Value : 0;
            //Console.WriteLine("y");
            #endregion
            #region Refrence
            //string? name = null;
            //Console.WriteLine(name);
            #endregion
            #region Null Propagation Operator
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //if (numbers != null)
            //{
            //    for (int i = 0; numbers != null && i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //int length = numbers?.length ? 0 ;
            //Console.WriteLine(length);
            //Employee EMP = new Employee();

            //if (Employee!=null)
            //{
            //    if (EMP.DEpartment != null)
            //    {
            //        Console.WriteLine(EMP.Department.Name);
            //    }
            //}
            //Console.WriteLine(EMP?.Department?.Name??"Not Found");
            #endregion
            #region Functions
            //PrintShape(10, "_");
            //Console.WriteLine("Hello \n Mostafa Welcome To\t Route ");
            //PrintShape(10, "/*\\");
            #endregion
            #region Value type Parameters
            #region by value
            //int a = 5;
            //int b = 9;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b); 
            #endregion
            #region by ref
            //int a = 5;
            //int b = 9;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(ref a,ref  b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #region Reference Type
            #region By Value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);

            #endregion
            #endregion
            #region Ex02
            #region By Value 
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);

            #endregion

            #region By Reference

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(ref Numbers);
            //Console.WriteLine(Numbers[0]);

            #endregion

            #endregion
            #region Functions - Passing By Out
            //int A = 10;
            //int B = 20;
            ////int Sum, Mul;
            //int Sum = 0 , Mul = 0 ; 
            ////SumMul(A, B, out Sum,out Mul);
            //SumMul(A, B, ref Sum,ref Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);
            #endregion
            #region Functions - Parms

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            //int A = 10, B = 20, C = 30;
            //Console.WriteLine("A : {0} , B : {1} , C : {2}", A, B, C);

            #endregion
            #endregion
        }
        #endregion

        #region Assignment05

        #region Q1

        //Passing by Value
        //When you pass a value type parameter by value, a copy of the variable is passed to the method.This means any changes made to the parameter inside the method do not affect the original variable.



        //    static void Main()
        //    {
        //        int number = 10;
        //        Console.WriteLine("Before: " + number); 
        //        IncrementByValue(number);
        //        Console.WriteLine("After: " + number);  
        //    }

        //    static void IncrementByValue(int num)
        //    {
        //        num += 5;
        //    }
        //}


        //Passing by Reference
        //When you pass a value type parameter by reference, the method receives a reference to the original variable.This means any changes made to the parameter inside the method will affect the original variable.


        //static void Main()
        //{
        //    int number = 10;
        //    Console.WriteLine( number); 
        //    IncrementByReference(ref number);
        //    Console.WriteLine( number);  
        //}

        //static void IncrementByReference(ref int num)
        //{
        //    num += 5;
        //}


        #endregion


        #region Q2

        //Passing Reference Type Parameters by Value
        //When you pass a reference type parameter by value, the method receives a copy of the reference to the object. This means the method can modify the object's data, but it cannot change the reference to point to a new object.

        //    static void Main()
        //    {
        //        Person person = new Person { Name = "Donya" };
        //        Console.WriteLine(Name);
        //        ChangeNameByValue(person);
        //        Console.WriteLine(person.Name);  
        //    }

        //    static void ChangeNameByValue(Person p)
        //    {
        //        p.Name = "Donya"; 
        //        p = new Person { Name = "Sameh" }; 
        //    }
        //}

        //Passing Reference Type Parameters by Reference
        //When you pass a reference type parameter by reference, the method receives a reference to the reference.This means the method can modify the object's data and also change the reference to point to a new object.

        //    static void Main()
        //    {
        //        Person person = new Person { Name = "Donya" };
        //        Console.WriteLine(person.Name); 
        //        ChangeNameByReference(ref person);
        //        Console.WriteLine(person.Name);  
        //    }

        //    static void ChangeNameByReference(ref Person p)
        //    {
        //        p.Name = "Donya";
        //        p = new Person { Name = "Sameh" }; 
        //    }
        //}

        #endregion


        #region Q3
        //static void Main()
        //{
        //    Console.WriteLine("Enter the first number:");
        //    int num1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the second number:");
        //    int num2 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the third number:");
        //    int num3 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the fourth number:");
        //    int num4 = int.Parse(Console.ReadLine());
        //    (int sum, int difference) = Calculate(num1, num2, num3, num4);
        //    Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
        //    Console.WriteLine($"Difference between {num3} and {num4} is: {difference}");
        //}

        //static (int, int) Calculate(int a, int b, int c, int d)
        //{
        //    int sum = a + b;
        //    int difference = c - d;
        //    return (sum, difference);
        //}

        #endregion


        #region Q4



        #endregion


        #region Q5

        //static void Main()
        //{
        //    Console.WriteLine("Enter a number to check if it is prime:");
        //    int number = int.Parse(Console.ReadLine());

        //    bool result = IsPrime(number);
        //    if (result)
        //    {
        //        Console.WriteLine($"{number} is a prime number.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not a prime number.");
        //    }
        //}

        //static bool IsPrime(int num)
        //{
        //    if (num <= 1) return false;
        //    if (num == 2) return true;
        //    if (num % 2 == 0) return false;

        //    for (int i = 3; i <= Math.Sqrt(num); i += 2)
        //    {
        //        if (num % i == 0) return false;
        //    }
        //    return true;
        //}

        #endregion


        #region Q6

        //static void Main()
        //{
        //    int[] numbers = { 3, 5, 7, 2, 8, -1, 4, 10, 12 };
        //    int min = int.MaxValue;
        //    int max = int.MinValue;

        //    MinMaxArray(numbers, ref min, ref max);

        //    Console.WriteLine($"Minimum value: {min}");
        //    Console.WriteLine($"Maximum value: {max}");
        //}

        //static void MinMaxArray(int[] array, ref int min, ref int max)
        //{
        //    foreach (int num in array)
        //    {
        //        if (num < min)
        //        {
        //            min = num;
        //        }
        //        if (num > max)
        //        {
        //            max = num;
        //        }
        //    }
        //}

        #endregion


        #region Q7

        //static void Main()
        //{
        //    Console.WriteLine("Enter a number to calculate its factorial:");
        //    int number = int.Parse(Console.ReadLine());

        //    long factorial = CalculateFactorial(number);
        //    Console.WriteLine($"Factorial of {number} is: {factorial}");
        //}

        //static long CalculateFactorial(int num)
        //{
        //    long result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        #endregion


        #region Q8

        #endregion


        #endregion
    }
}


