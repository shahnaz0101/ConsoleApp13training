namespace arrays
{
    public static class Program
    {
        //public static void Main()
        //{
        //    int[] arrayofInt = new int[5] { 17, 4, 11, 7, 3 };
        //    for (int i = 0; i < arrayofInt.Length; i++)
        //        Console.WriteLine(arrayofInt[i]);
        //int[] arrayofInt = new int[3] { 49, 178, 63 };
        //int max = 0;
        //for (int i = 0; i < arrayofInt.Length; i++)
        //{
        //    if(arrayofInt[i] > max)
        //    {
        //        max = arrayofInt[i];

        //    }  

        //}
        //Console.WriteLine(max);
        //}
        public static void Main()
        {
            int previous = 0;
            int current = 1;
            int next = 1;
            int length = 20;
            int[] array = new int[length];

                Console.WriteLine(previous);
                Console.WriteLine(current);

            for(int i=0; i<length; i++)
            {
                previous = current;
                current = next;
                Console.WriteLine(current);
                next = previous + current;

                
            }
            
        }
    }
}
