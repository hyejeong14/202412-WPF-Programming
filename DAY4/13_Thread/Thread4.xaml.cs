using System;
using System.Collections.Generic;
using System.IO;
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
    /// Thread4.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Thread4 : Window
    {
        public Thread4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("a1.txt", FileMode.Create))
            {
                byte[] buff = new byte[1024 * 1024 * 2000]; // 2G

                fs.Write(buff); //  동기적으로 쓰기
                                //  (여기서 멈춰있기 때문에 윈도우창 움직이지 않음 - ui사용 불가)

                Console.WriteLine("WriteSync Finish");
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("a2.txt", FileMode.Create))
            {
                byte[] buff = new byte[1024 * 1024 * 2000]; // 1G

                fs.WriteAsync(buff); //  비동기적으로 쓰기 - 다른 스레드에서 쓰기 작업 실행
                                     //  (주스레드는 요청만 하고 즉시 리턴  - ui 사용 가능)


                Console.WriteLine("WriteSync Finish"); //주스레드가 즉시 리턴이기 때문에 바로 실행됨 (쓰기 작업이 끝나지 않았을 때)
            }
        }

        private async void Button3_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("a3.txt", FileMode.Create))
            {
                byte[] buff = new byte[1024 * 1024 * 2000]; // 1G

                await fs.WriteAsync(buff); //  비동기적으로 쓰기 - 다른 스레드에서 쓰기 작업 실행
                                     //  (주스레드는 요청만 하고 즉시 리턴  - ui 사용 가능)
                                     //await의 경우 주스레드는 메세지처리 루프로 가서 계속 메세지처리를 할 수 있고
                                     //작업이 종료되면 메세지q에 종료 event를 수신
                                     //주스레드로 돌아와서 뒤의 이벤트를 수행

                Console.WriteLine("WriteSync Finish"); //await
            }
        }
    }
}
