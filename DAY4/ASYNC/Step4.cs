class step4
{
    public static Task<int> SumAsync(int first, int last)
    {
        Task<int> t = Task.Run(() =>
        {

            int s = 0;
            for (int i = first; i <= last; i++)
            {
                s += i;
                Thread.Sleep(10);
                //Console.WriteLine($"Sum {i}");
            }
            return s;
        });
        return t;
    }

    public static async void ButtonClick()
    {
        
        Console.WriteLine($"Start {Thread.CurrentThread.ManagedThreadId}");
        int ret = await SumAsync(1, 500);
        Console.WriteLine($"Finish {Thread.CurrentThread.ManagedThreadId}");
        // => 서로 다른 스레드

    }

    public static void Main()
    {
        ButtonClick();
        Console.ReadLine();
    }
}
