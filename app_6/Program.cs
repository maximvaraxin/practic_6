/*   
 *   Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 *   0, 7, 8, -2, -2 -> 2
 *   1, -7, 567, 89, 223-> 3 
 */

namespace App_6
{
    class Program
    {
            static void Main(string[] args)
            {   
                Console.Write($"Введите длину массива: ");
                int length = Convert.ToInt32(Console.ReadLine());

                int[] array = AddArray( length );

                PrintArray( array );
                
                Console.WriteLine();
                Console.WriteLine($"Количество элементов > 0: {ComparisonElementArray(array)}");
            }
            
            // заполняет массив введенными пользователем числами
            static int[] AddArray(int length)
            {
                int[] resultArray = new int[length];

                for (int i = 0; i < resultArray.Length; i++)
			    {
                    Console.Write($"Введите длину { i } элемент массива: ");
                    resultArray[i] = Convert.ToInt32(Console.ReadLine());
			    }

                return resultArray;
            }

            // выводит массив в консоль
            static void PrintArray(int[] array)
            {   
                Console.Write($"Массив: ");

                for (int i = 0; i < array.Length; i++)
			    {
                    Console.Write($"{array[i]}({i}) ");
			    }
            }

            // определяет количество элементов > 0
            static int ComparisonElementArray(params int[] array)
            {   
                int count = 0;
                
                for (int i = 0; i < array.Length; i++)
			    {
                    if (array[i] > 0)
	                {
                       count++;     
	                }
			    }

                return count;
            }
    }
}