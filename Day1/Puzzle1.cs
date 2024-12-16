using System.Windows;

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;


class MainWindow : Window
{
    public MainWindow()
    {
        //#1. Uri : 그림, 음악, 동영상 등을 Load할 때 경로를 관리하는 클래스
        Uri uri = new Uri("C:\\IMG.png");

        //#2. BitmapImage 객체 생성
        // => 순수하게 그림에 대한 데이터를 관리하는 클래스
        BitmapImage bitmap = new BitmapImage(uri);

        //#3. Image : 그림을 화면에 출력하는 컨트롤 (ui, 버튼,윈도우 같은 클래스)
        Image img = new Image();

        img.Source = bitmap;

        // #4. Content 속성으로 image 객체 연결
        this.Content = img;
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
