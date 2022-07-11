/*   
 *   Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
 *   [1 2 3 4 5] -> [5 4 3 2 1]
 *   [6 7 3 6] -> [6 3 7 6]
 *   
 */

namespace App_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите длину массива: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = AddArray(length);

            PrintArray(array);
            ReverseArray(ref array, true);
            PrintArray(array);

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

        // реверс массива
        static void ReverseArray(ref int[] array, bool enableLogging = false)
        {
            int[] reverseArray = new int[array.Length];

            if (enableLogging == true)
            {   
                Console.WriteLine();
                Console.WriteLine($"Выполняется реверс");
            }

            for (int i = 0; i < array.Length; i++)
			{
                reverseArray[i] = array[array.Length - ( i + 1 )];
			}

            array = reverseArray;
        }
    }
}