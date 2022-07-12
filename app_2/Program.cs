/*   
 *   Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
 *   Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.   
 *   
 */

namespace App_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] length = new int[3];
           
            for (int i = 0; i < 3; i++)
			{
                Console.Write($"Введите длину { i + 1 } стороны: ");
                length[i] = Convert.ToInt32(Console.ReadLine());
			}
            Console.WriteLine($"------------");
            Console.WriteLine( IsExistЕriangle(length) ? "Треугольник существует" : "Треугольник НЕ существует" );
        }
        
        // проверяет может ли существовать треугольник с сторонами такой длины
        static bool IsExistЕriangle( params int[] length)
        {
            bool existЕriangle = false;

            if ( length[0] + length[1] > length[2] && length[0] > 0 && length[1] > 0 && length[2] > 0 )
	        {
                existЕriangle = true;
	        }
            else if ( length[0] + length[2] > length[1] && length[0] > 0 && length[1] > 0 && length[2] > 0  )
            {
                existЕriangle = true;
            }
            else if ( length[1] + length[2] > length[0] && length[0] > 0 && length[1] > 0 && length[2] > 0  )
            {
                existЕriangle = true;
            }
            else
            {
                existЕriangle = false;
            }
            
            return existЕriangle;
        }
    }
}