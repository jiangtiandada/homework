namespace Programming1
{
    internal class Programming1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1,50);//这是不包含50的不知道题目中1-50之间包不包含50
                sum += arr[i];
                Console.WriteLine(arr[i]);
            }
            avg = (double)sum / 10;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }
}
