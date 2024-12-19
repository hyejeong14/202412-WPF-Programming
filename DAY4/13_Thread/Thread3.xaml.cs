using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _13_Thread
{
    /// <summary>
    /// Thread3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Thread3 : Window
    {
        public Thread3()
        {
            InitializeComponent();
        }


        public static Task<int> SumAsync(int first, int last) //비동기라 다 끝날때까지 대기하는게 아니라 바로 return
        {
            Task<int> t = Task.Run(() =>
            {
                Console.WriteLine($"Sum {Thread.CurrentThread.ManagedThreadId}");
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


        private async void button_Click(object sender, RoutedEventArgs e)
        {
            //Task<int> t = SumAsync(1, 500);
            //int n = t.Result; // blocking 발생 =>> await 필요 (함수에 async 명시)



            //1. 주스레드에서 sumasync를 수행하면
            //2. event 루프가 다른 스레드에서 수행
            //3. sumaync가 끝나면 다시 돌아와서 나머지 작업을 수행
            // 비동기를 동기처럼 사용 가능
            Console.WriteLine($"Start {Thread.CurrentThread.ManagedThreadId}");
            int ret = await SumAsync(1, 500); // 여기서는 다른 스레드가 돌아감
            Console.WriteLine($"Finish {Thread.CurrentThread.ManagedThreadId}");
                        //=> 같은 스레드 반환, 바로 주스레드로 돌아오기 때문에 UI 사용 가능
            label.Content = ret.ToString();
        }
    }
}
