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

namespace _05_EVENT
{
    /// <summary>
    /// Ex4ButtonEvent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex4ButtonEvent : Window
    {
        public Ex4ButtonEvent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("button1 click");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //sender가  이벤트를 발생시킨 버튼의 참조
            //object 타입이므로 button으로 캐스팅해서 사용하기
            Button btn = (Button)sender;
            Console.WriteLine($"{btn.Content} click {btn.Tag}");
            if(btn == button2)
            {
                Console.WriteLine("button2 click");
            }
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            //1. sender는 StackPanel 아래 하이어라키 조사하면 나옴
            //Util.ShowHierachy(sender);

            //2. 소스는 이벤트를 발생한 버튼이당
            //Util.ShowHierachy(e.Source);
            Button btn = (Button)e.Source;
            Console.WriteLine($"StackPanel : {btn.Content} click {btn.Tag}");
        }
    }
}
