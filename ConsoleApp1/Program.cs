using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a = 5;
            int b = a;
            a = 15;
         //   Console.WriteLine($"a = {a}");
         //   Console.WriteLine($"b = {b}");

            Insan i1 = new Insan();
            i1.age = 5;

          CalculateYear(i1);
          


        }

        private static Insan CalculateYear(Insan insan)
        {
            DateTime date = DateTime.Today;

            date = date.AddYears(-1*insan.age);
            insan.BirthYear = date.Year;
            return insan;
        }
    }
    
   


    public class Insan
    {
        public int age = 20;

        public int BirthYear;
    }

}
