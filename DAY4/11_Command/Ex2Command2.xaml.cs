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
    //버튼에  연결한 Command 객체
    //1. 명령이 선택될 때(버튼을 누를 때) 해야할 일
    //2. 명령을 지금 실행할 수  있는지 여부 (버튼 Enable 여부)
    public class LogInCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) //명령 수행 가능 여부
        {
            return true;
        }

        public void Execute(object? parameter) //선택됐을 때 해야할 일
        {
            MessageBox.Show("Log In 진행");
        }
    }

    //아래 코드처럼 명령 객체를 코드로 만들어도 되지만
    //대부분 XAML의 리소스로 만들어서 사용
    //public static LogInCommand logincmd = new LogInCommand();

    public partial class Ex2Command2 : Window
    {
        //객체 생섣
        //public static LogInCommand logincmd = new LogInCommand();

        public Ex2Command2()
        {
            InitializeComponent();
        }
    }
}
