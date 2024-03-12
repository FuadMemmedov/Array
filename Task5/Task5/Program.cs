namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 11, 2, 23 };
            string[] arr2 = new string[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = Convert.ToString(arr[i]);
                
                Console.WriteLine(arr2[i]);
            }


           
        }
    }
}
