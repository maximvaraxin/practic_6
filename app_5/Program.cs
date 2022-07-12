/*   
 *   Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 
 */

namespace App_5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите длину массива: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = AddArray(length);

            PrintArray(array);
            int[] copyArray = CopyArray( array, true );
            PrintArray(copyArray);
        }
             // заполняет массив случайными числами
            static int[] AddArray(int length)
            {
                int[] resultArray = new int[length];

                for (int i = 0; i < resultArray.Length; i++)
			    {
                    resultArray[i] = new Random().Next(10,100);
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

            // копирует массив в новый массив
            static int[] CopyArray(int[] array, bool enableLogging = false)
            {   
                int[] copyArray = new int[array.Length];

                if (enableLogging == true)
                {   
                    Console.WriteLine();
                    Console.WriteLine($"Выполняется копирование массива");
                }

                for (int i = 0; i < array.Length; i++)
			    {
                    copyArray[i] = array[i];
			    }

                return copyArray;
            }
    }
}