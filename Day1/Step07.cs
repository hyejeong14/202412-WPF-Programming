using System.Windows;

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step07. wpf 프로그램의 기본 구조
// 기본적으로 2개의 클래스로 구성

// MainWindow : 주 윈도우 (GUI). 윈도우에서 발생하는 이벤트를 처리함
// APP : Not gui, 프로그램의 시작과 끝(Startup & Exit), 상태 변화에 따른 EVENT 처리
//       RUN 메소드에서 evet loop 수행
//       Main 메소드 제공

// 아래 코드는 Wpf 프로그램의 전형적인 모양
// => 오후 수업은 이 코드를 계속 복사해서 사용할 예정

class MainWindow : Window //gui, gui(윈도우)에서 발생하는 이벤트를 처리함
{
    public MainWindow()
    {
    }
}

class App : Application  //프로그램의 시작과 끝(Startup & Exit), 상태 변화에 따른 EVENT 처리
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

/*class Program //Main을 제공하기 위해 만들었던 class, main은 어디든 있으면 됨. -> 앱의 시작 기능이니까 app 클래스로 이동
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        win.Show();

        app.Run();
    }
}*/