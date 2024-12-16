using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step08-1. 객체의 수명에 주의

//1. App(Application) 객체 생성
//2. MainWindow 객체 생성

// App.Onstartup() 호출. this.MainWindow 사용가능

//3. MainWindow 객체 파괴

// App.OnExit() 호출. this.MainWindow 사용 불가능

//4. Application 객체 파괴

//App 메소드에서 MainWindow 접근 : MainWindow가 파괴되었을 수 있으므로 항상 조심해야 함
//MainWindow 메소드에서 App 접근 : 항상 안전함 . app은 프로그램 종료시 마지막에 파괴되는 객체이므로.

class MainWindow : Window
{
    public MainWindow()
    {
    }

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

        this.MainWindow.Title = "Hello"; 
        ((MainWindow)this.MainWindow).Foo();
    }

    //OnExit 만들고 MainWindow의 Foo 호출하기
    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
        //((MainWindow)this.MainWindow).Foo(); //runtime error
        Console.WriteLine($"{this.MainWindow == null}"); //true MainWindow는 null(파괴)
    }

    public App()
    {

    }

    [STAThread]
    public static void Main()
    {
        App app = new App();               //

        MainWindow win = new MainWindow();
        win.Show();

        app.Run();
    }

}