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

namespace _02_XAML
{
    /// <summary>
    /// Ex3Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3Window : Window
    {
        public Ex3Window()
        {
            //btn1.Background = new SolidColorBrush(Colors.Red);error 위치 조심

            //InitializeComponent -> Xaml 초기화
            //컨트롤 이름(참조변수)와 실제 컨트롤의 연결 수행
            //따라서 XAML에서 만든 컨트롤의 이름(참조변수)는 이 함수 아래부터 사용 가능
            Console.WriteLine($"{btn1 == null}"); //true

            InitializeComponent(); //XAML 초기화 수행

            Console.WriteLine($"{btn1 == null}"); //False

            //XAML로 만든 컨트롤로 이름(name or x:name)으로 c#에서 자유롭게 접근 가능
            btn1.Background = new SolidColorBrush(Colors.Red);
            btn2.Background = new SolidColorBrush(Colors.Yellow);

        }
    }
}
