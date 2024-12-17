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
    /// Ex2KeyEvent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2KeyEvent : Window
    {
        public Ex2KeyEvent()
        {
            InitializeComponent();
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"KeyEvent : {e.RoutedEvent},{e.Key}");

        }

        private void MyTextInput(object sender, TextCompositionEventArgs e)
        {
            Console.WriteLine($"MyTextInput : {e.RoutedEvent},{e.Text}");
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine($"TextChanged : {e.RoutedEvent},{e.RoutedEvent}");
        }
    }
}

//키보드를 누르면 keydown과 keyup이 필수 발생 
//(화살표나 shift 같이 텍스트 입력이 되지 않는 경우는 textinput, changed 발생하지 않음)

//키보드를 누르면
//previewkeydown
//keydown (대소문자 구별 없음)

//(누른 키보드 문자가 아스키문자라면 textinput 발생 (인자 대소문자 구별))
//= PreviewTextInput
//= TextChanged            <=  TextBox가 변경되어 발생

//previewkeyup
//keyup