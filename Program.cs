/*Даны целые положительные числа A, B, C. Значение
  этих чисел программа должна запрашивать у пользо-
  вателя. На прямоугольнике размера A*B размещено
  максимально возможное количество квадратов со
  стороной C. Квадраты не накладываются друг на
  друга. Найти количество квадратов, размещенных на
  прямоугольнике, а также площадь незанятой части
  прямоугольника.
  Необходимо предусмотреть служебные сообщения
  в случае, если в прямоугольнике нельзя разместить ни
  одного квадрата со стороной С (например, если зна-
  чение С превышает размер сторон прямоугольника).*/
using System;

namespace HomeCaseCS_Lesson1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A (width): ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B (height): ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number C (square): ");
            int C = Convert.ToInt32(Console.ReadLine());
            if (A < C || B < C)
            {
                Console.WriteLine("Error! In a rectangle, " +
                    $"you can not place any square with the side {C}");
            }
            else
            {
                int quantity = (A / C) * (B / C);
                int area = A * B - quantity * C * C;
                Console.WriteLine("The number of squares on " +
                    $"the rectangle is: {quantity}");
                Console.WriteLine("The area of the unoccupied " +
                     $"part of the rectangle is: {area}");
            }

            Console.ReadKey();
        }
    }
}