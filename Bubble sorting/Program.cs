namespace Bubble_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 5, 2, 3, 1, 4, 6, 8, 7, 9 };
            Console.WriteLine(string.Join(" ", test));
            int[] result = BubbleSort(new int[] { 5, 2, 3, 1, 4, 6, 8, 7, 9 });
            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();
        }

        public static int[] BubbleSort(int[] list)
        {
            bool check = true;
            List<int> result = list.ToList();
            while (check)
            {
                check = false;
                for (int i = 0; i < list.Length - 1; i++)
                {
                    int next = result[i + 1];
                    int now = result[i];

                    if (now > next)
                    {
                        result[i] = next;
                        result[i + 1] = now;
                        check = true;
                    }
                }
            }
            return result.ToArray();
        }
    }
}