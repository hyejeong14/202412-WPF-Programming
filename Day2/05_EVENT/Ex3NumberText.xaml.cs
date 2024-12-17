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
    /// Ex3NumberText.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3NumberText : Window
    {
        public Ex3NumberText()
        {
            InitializeComponent();
        }

        private void txtbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            short val; ;
            bool b = short.TryParse(e.Text, out val);
            if (b)
            {
                Console.WriteLine("숫자이므로 event 전달 중지");
                e.Handled = true;
            }
        
        }

        private void txtbox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}

//KEYDOWN, KEYUP, PREVIEW KEYDOWN, PREVIEW KEYUP
//위의 이벤트 인자로 들어오는 것은 가상 키코드(키보드 번호)로 대소문자  구별이 안됨

//TEXTINPUT
//위의 이벤트 인자로 들어오는 것은 아스키 코드로 대소 문자 구별 가능

//아래 두개는 키보드 번호, 소문자를 누르나 대문자를 누르나 같은 번호가 부여됨
//SCAN CODE : 키보드 배열 순서대로 정의된 키보드 번호 (EX. Q KEY:16, W KEY:17, E KEY:18, R KEY:19)
//가상 키 코드 : 키보드 번호, 단 알파벳 순서대로 번호가 부여됨 (EX. A KEY:65 , B KEY:66, C KEY:67)

//ASCII 코드 : 키보드가 아닌 문자 자체에 부여된 번호 (EX. A:65, a:97)