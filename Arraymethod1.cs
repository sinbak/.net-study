namespace Arraymethod1
{
    class Arraymethod
    {
        static void Main(string[] args)
        {
            int[] nArray1 = {1,2,3,4,5};
            Array.Clear(nArray1,2,3);
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();

            Array.Clear(nArray1, 0, nArray1.Length);
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();
        }
    }
}