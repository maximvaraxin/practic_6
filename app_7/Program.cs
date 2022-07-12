/*   
 *   Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 *   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 *   значения b1, k1, b2 и k2 задаются пользователем.
 *   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

namespace App_7
{
    class Program
    {
            static void Main(string[] args)
            {   
                Console.Write($"Введите длину b1: ");
                float b1 = Convert.ToInt32(Console.ReadLine());
           
                Console.Write($"Введите длину k1: ");
                float k1 = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Введите длину b2: ");
                float b2 = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Введите длину k2: ");
                float k2 = Convert.ToInt32(Console.ReadLine());
                
                ComparisonElementArray( b1, k1, b2, k2);
            }
            
            // определяет точку пересечения двух прямых
            static void ComparisonElementArray( float b1, float k1, float b2, float k2)
            {   
                float[] result = new float[2];
                float x = 0;
                float y = 0;

                x = (b2-b1) / (k1-k2);
                y = k1 * (b2-b1) / ( k1 - k2 ) + b1;
                
               Console.WriteLine($"Точка пересечения двух прямых ({x}; {y})");
            }
    }
}