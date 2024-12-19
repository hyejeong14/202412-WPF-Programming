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

namespace _11_Command
{
    /// <summary>
    /// Ex1Command1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Command1 : Window
    {
        public Ex1Command1()
        {
            InitializeComponent();
        }

        //여러 개의 컨트롤의 상태가 변경될 때마다 버튼의 Enable/Disable 여부가 변경되어야 함.
        //이러한 판단을 하는 함수를 별로도 만들면 편함
        //  => 디자인 패턴에서 "중재자(Mediator)"라고 불리는 패턴임

        private void ChangeButtonState()
        {
            button.IsEnabled = !string.IsNullOrEmpty(txtbox.Text) && checkbox.IsChecked==true;
        }

        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeButtonState();
        }

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            ChangeButtonState();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("로그인 과정 처리");
        }

        //1. 버튼을 누를 때 해야하는 일
        //2. 버튼을 누를 수 있는지(명령 수행이 가능한지) 결정하는 함수
        // 위의 두개를 하나의 클래스로 만드는 것이 WPF Command 기술
    }
}
