string[] arr_1 = {"Hello", "2", "world", ":-)"};
        string[] arr_2 = {"1234", "1567", "-2", "computer science"};
        string[] arr_3 = {"Russia", "Denmark", "Kazan"};
        
        int max_word_size = 3;
        
        string[] ArrOfTheShortWords(string[] arr)
        {
            int length = arr.Length;          
            string[] result = new string[length];
            int count = 0;
            
            for (int i = 0; i < length; i++)
            {
                if(arr[i].Length <= max_word_size)
                {
                    result[count] = arr[i];
                    count++;
                }
            }
            Array.Resize(ref result, count);
            
            return result;
        }
        
        void PrintArrayWord(string[] arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("Массив пуст");
            }
            else
            {
                Array.ForEach(arr, (str) => Console.Write($"{str} "));
                Console.WriteLine();
            }
        }
        
        void PrintTaskWord(string[] arr)
        {
            Console.WriteLine("Исходный массив: ");
            PrintArrayWord(arr);
            string[] ArrayShort = ArrOfTheShortWords(arr);
            Console.WriteLine($"Результирующий массив (слова меньше или равны {max_word_size} символам)");
            PrintArrayWord(ArrayShort);
            Console.WriteLine();
        }
        PrintTaskWord(arr_1);
        PrintTaskWord(arr_2);
        PrintTaskWord(arr_3);

