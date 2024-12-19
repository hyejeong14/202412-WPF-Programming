class program
{
    public static int Sum(int first, int last)
    {
        int s = 0;
        for (int i = first; i <= last; i++)
        {
            s += i;
            Thread.Sleep(10);
        }
        return s;
    }

    public static void Main()
    {
        //아래 코드는 스레드를 직접 생성한 것
        Thread t = new Thread(() => { Sum(1, 500); });
        t.Start();

        //아래 코드는 thread pool에 있는 스레드를 가지고 실행하는 것
        Task t = Task.Run(() => { Sum(1, 500); });
        
    }
}
