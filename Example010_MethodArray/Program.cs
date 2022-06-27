//вариант 1
internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 11, 12, 31, 41, 15, 61, 19, 18, 19 };

        int n = array.Length;
        int find = 19;
        int index = 0;
        while(index < n)
        {
            if(array[index] == find)
            {
                Console.WriteLine(index);
                break; //без этого оператора прога будет выдовать несколько занчений
            }
            //index = index + 1;
            index++;
        }
    }
}


