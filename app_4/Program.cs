/*   
 *   Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
 *   Если N = 5 -> 0 1 1 2 3
 *   Если N = 3 -> 0 1 1
 *   Если N = 7 -> 0 1 1 2 3 5 8 
 *   
 */

namespace App_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите число: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            PrintArray(FibonacciNumbers( length ),length);
        }

        // вычисляет первых N чисел Фибоначчи
        static double[] FibonacciNumbers( int numbers )
        {   
            double[] result = new double[numbers];

            for (int i = 0; i < result.Length; i++)
			{    
                 if ( i == 0 )
	             {
                    result[i] = 0;
	             }
                 else if ( i == 1 || i == 2)
                 {
                    result[i] = 1;
                 }
                 else
                 {
                    result[i] =  result[ i - 2 ] + result[ i - 1 ];
                 }
			}
            
            return result;
        }

        // выводит результат в консоль
        static void PrintArray( double[] array, int len )
        {   
            Console.Write($"Первые { len } чисел Фибоначчи: ");

            for (int i = 0; i < array.Length; i++)
			{
                Console.Write($"{array[i]} ");
			}
        }
    }
}