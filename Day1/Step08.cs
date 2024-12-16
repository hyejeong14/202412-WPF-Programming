using System.Windows;

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

//Step08. App와 Window 간의 서로 참조 얻기
//#1. app에서 window 객체의 참조가 필요하면
//  => this.MainWindow 사용하면 됨
//  => 그런데, this.MainWindow가 Window class 타입이므로
//  => MainWindow 클래스가 추가한 고유 멤버 접근시에는 아래처럼 캐스팅이 필요하다

class MainWindow : Window 
{
    public MainWindow()
    {
    } 
    //App의 OnStartup에서 아래 메소드를 호출해보자
    public void Foo()
    {
        Console.WriteLine("MainWindow Foo");

    }
}

class App : Application 
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        //여기서 window의 타이틀을 "Hello"로 변경해보자
        this.MainWindow.Title = "Hello";
        // App 객체는 MainWindow 속성에 주 윈도우 참조를 가지고 있음. step03 참고
        // Application 상속받앗음~
        //this.MainWindow.Foo; //error this.MainWindow의 데이터 타입은 Window인데, Foo는 MainWindow 클래스에 있음
        ((MainWindow)this.MainWindow).Foo(); //타입 캐스팅해서 사용해야 함
    }
    public App()
    {

    }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        win.Show();
//      app.MainWindow = win; 예전에는 해당 코드가 필수였으나 이제 안해두댐
        app.Run();
    }
}



// app는 내부적으로 MainWindow가 존재
// MainWindow로 win에 접근 가능 => this.MainWindow는 window class타입