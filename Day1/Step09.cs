using System.Windows;

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;

//Step09. Content라는 속성 : wpf의 핵심 


class MainWindow : Window 
{
    public MainWindow()
    {
        this.Title = "Hello"; //윈도우의 캡션 문자열

        //#1. Content 속성
        //this.Content = "Hello"; //윈도우 화면에 문자열

        //#2. Content에는 문자열, 자식 윈도우, 그림 등 다양한 것을 연결 가능
        //Button btn = new Button();
        //btn.Content = "확인";
        //this.Content = btn;

        //#3. 위 3줄은 아래처럼도 가능
        //객체{}초기화로 속성을 지정하는 코드
        Button btn = new Button{ Content = "확인" };
        this.Content =  btn;

        //버튼 누를 때 메세지 박스 나타나게는?
        btn.Click += Btn_Click;

    }

    private void Btn_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Button Click");
    }
}

class App : Application 
{

    public App()
    {

    }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        win.Show();

        app.Run();
    }
}
