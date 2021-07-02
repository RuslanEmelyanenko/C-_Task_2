using System;

/*
   Таск_2
   Дано двузначное число.Найти:
     а) число десятков в нем;
     б) число единиц в нем;
     в) сумму его цифр;
     г) произведение его цифр.
     д *) выполните “неправильное сложение”, пример:

          22 + 1 => 221
          10 + 10 => 1010           
*/

namespace TwoDidgitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any two-digit number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 10 || number > 99)
            {
                Console.WriteLine("Error!!! Number is not two-didgit");
            }
            else
            {
                int numberDozens = number / 10;
                int numberUnit = number % 10;

                Console.WriteLine($"\nIn number {number} is - {numberDozens} dozen(s)");
                Console.WriteLine($"\nIn number {number} is - {numberUnit} unit(s)");
                Console.WriteLine($"\nSum of numbers {numberDozens}  and {numberUnit} is: {numberDozens + numberUnit}");
                Console.WriteLine($"\nMultiplication of numbers {numberDozens}  and {numberUnit} is: {numberDozens * numberUnit}");
                
                string str1 = Convert.ToString(numberDozens);
                string str2 = Convert.ToString(numberUnit);
                Console.WriteLine("");
                Console.WriteLine(number + str1 + str2);
            }

        }
    }
}
