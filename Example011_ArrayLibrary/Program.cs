//Version 1
// internal partial class Program
// {
//     private static void Main(string[] args)
//     {
//         void FillArray(int[] collection)
//         {
//             int Length = collection.Length;
//             int index = 0;
//             while (index < Length)
//             {
//                 collection[index] = new Random().Next(1, 10);
//                 index++;

//             }
//         }       
        
//         void PrintArray(int[] col)
//         {
//             int count = col.Length;
//             int position = 0;
//             while (position < count)
//             {

//                 Console.WriteLine(col[position]);
//                 position++;
//             }

//         }

//         int[] array = new int [10];

//         FillArray(array);
//         PrintArray(array);
//     }
// }

//Version 2
internal partial class Program
{
    private static void Main(string[] args)
    {
        void FillArray(int[] collection)
        {
            int Length = collection.Length;
            int index = 0;
            while (index < Length)
            {
                collection[index] = new Random().Next(1, 10);
                index++;

            }
        }       
        
        void PrintArray(int[] col)
        {
            int count = col.Length;
            int position = 0;
            while (position < count)
            {

                Console.WriteLine(col[position]);
                position++;
            }

        }

        int indexOf(int[] collection, int find)
        {
            int count = collection.Length;
            int index = 0;
            int position = -1; //Хитрый ход поставить -1. Чтобы был вывод, что такой элемент не найден.

            while (index < count)
            {
                if(collection[index] ==find)
                {
                    position = index;
                    break; //Для вывода только одного первого значения при повторении.
                }
                index++;
            }
            return position;
        }
        int[] array = new int [10];

        FillArray(array);
        array[4] = 4;
        array[6] = 4;

        PrintArray(array);
        Console.WriteLine();

        int pos = indexOf(array, 5);
        Console.WriteLine(pos);

    }   

}
