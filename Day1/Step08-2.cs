using System.Windows;

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step08-2
//App 에서 MainWindow 접근 : this.MainWindow 또는 ((MainWindow)this.MainWindwow)
//MainWindow에서 App 접근 : Application.Current 또는 ((App)Application.Current)

class MainWindow : Window 
{
    public MainWindow()
    {
    }
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);

        //Application.Current : 프로그램의 어디에서라도 app 객체의 참조가 필요할 때 사용
        //해당 이벤트에서 프로그램을 종료하려면 App 객체의 Shutdown 메소드를 호출하면 됨. (마우스 좌클릭 시 app shutdown)
        //Application.Current.Shutdown();


        //App의 Foo 호출은?
        ((App)Application.Current).Foo(); //app 타입으로 타입 캐스팅 
    }
}

class App : Application 
{
    public void Foo()
    {
        Console.WriteLine("App.Foo");
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

        app.Run();
    }
}
