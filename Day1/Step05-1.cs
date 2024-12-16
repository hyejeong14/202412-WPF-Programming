// See https://aka.ms/new-console-template for more information
using System;
using System.Windows;
using System.Windows.Media;

//Step05-1. Window event 처리
// #1. Window의 파생 클래스를 만들어서 사용

//아래 코드의 의미
// => Window에서 발생한 이벤트는 Window의 메소드에서 처리

class MainWindow : Window //Window로부터 상속을 받는 클래스 생성, Window가 가지고 있는 모든 특징을 물려받음
{
    public MainWindow()
    {
        // 아래 코드에서 this는 상속을 받았기때문에 없어도 됨.
        this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
    }

    private void MainWindow_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("Click");
    }
}
class Program
{
    [STAThread]
    public static void Main()
    {

        Application app = new Application();

        MainWindow win = new MainWindow();

        win.Show();


        app.Run();

    }

}



