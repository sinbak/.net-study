namespace Arrayclone
{
    class clone
    {
        static void Main(string[] args)
        {
            int[] nArray1 = {1,2,3,4,5};
            int[] nCloneArray = (int[])nArray1.Clone();

            nCloneArray[2] = 30;
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();

            foreach (int m in nCloneArray)
                Console.Write(m);
            Console.WriteLine();

            string[] Days = {"일", "월", "화", "수", "목", "금", "토"};
            string[] DaysClone = (string[])Days.Clone();
            foreach (string str in DaysClone)
                Console.Write(str);
        }
    }
}