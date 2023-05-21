using System;       
namespace controlWork    
{
    class Massiv   
    {
        static void Main(string[] str) 
        {
            int setVal()
            {   // ввод размера массива
                Console.Write("Введите размер массива : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            
            string[] setArray(int length)
            {   // формирование массива строк
                string[] result = new string[length];
                for(int i = 0; i < length; i ++)
                {
                    Console.Write($"Введите {i+1}-ю строку : ");
                    result[i] = Console.ReadLine();
                }
                return result;
            }
            
            void outputArray(string[] arr)
            {   // вывод массива
                string text = "['" + string.Join("', '", arr) + "']";
                Console.WriteLine(text);
            }

            string[] setArray3symbol(string[] arr)
            {
                string[] array3symol = new string[arr.Length];
                int lenRes = 0;
                for(int i = 0; i < arr.Length; i ++)
                {
                    if(arr[i].Length <= 3)
                    {
                        array3symol[lenRes] = arr[i];
                        lenRes++;
                    }                
                }
                string[] res = new string[lenRes];
                for(int i = 0; i < lenRes; i ++)
                    res[i] = array3symol[i];
                return res;
            }


            int size = setVal();
            string[] ishArray = setArray(size);
            
            string[] resArray = setArray3symbol(ishArray);
            
            Console.WriteLine("Исходный массив:");
            outputArray(ishArray); 
            Console.WriteLine("Массив строк длиной до 3х символов:");
            outputArray(resArray); 
        }
    }
}