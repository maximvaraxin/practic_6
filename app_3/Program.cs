/*   
 *   Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
 *   45 -> 101101
 *   3 -> 11
 *   2 -> 10   
 *   
 */

namespace App_3
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.Write($"Введите число для преобразования: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число в десятичной системе счисления: { num }");

            List<int> list = ConversionType( num, false );
            
            ReverseList( ref list );
            PrintList( list );
        }

        // переводит десятичной в двоичную систему счисления(необходим разворот результирующего списка)
        static List<int> ConversionType(int number, bool enableLogging = false)
        {  
            List<int> resultList = new List<int>();
           
            while (number >= 1)
            {
                int item = number % 2;
                resultList.Add(item);
                number = number / 2;
            }

            if (enableLogging)
	        {
                foreach (var item in resultList)
	            {
                    Console.Write(item);
	            }
                Console.WriteLine();
	        }
                

           return resultList;
        }

        // разворачивает полученный список
        static void ReverseList( ref List<int> list)
        {   
            List<int> resultList = new List<int>();

            for (int i = 1; i <= list.Count; i++)
			{
                resultList.Add( list[ list.Count - i] );
			}

            list = resultList;
        }

        // выводит список в консоль
        static void PrintList(List<int> list)
        {   
            Console.Write($"Число в двоичной СС: ");

            foreach (var item in list)
	        {
                Console.Write(item);
	        }
        }
    }
}