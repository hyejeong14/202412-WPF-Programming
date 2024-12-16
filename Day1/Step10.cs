using System.Windows;

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;

//Step10. Layout
//#1. Content 속성에는 오직 한개의 객체만 연결 가능
//#2.여러개 자식을 부착하려면 Layout을 사용

//window.Content = layout;
//layout.Add(버튼1);
//layout.Add(버튼2);
//layout.Add(버튼3);

//Layout : 여러개 자식 컨트롤을 어떻게 배치할지 결정하는 클래스, Panel이라고도 하고 7~8정도 있음

class MainWindow : Window
{
    public MainWindow()
    {
        //StackPanel : 모든 자식컨트롤을 스택처럼 차례대로 쌓는 Layout
        StackPanel sp = new StackPanel();
        this.Content  = sp;
        //앞으로 자식들은 sp에 붙이라는 뜻

        //이제 다양한 컨트롤을 sp(stackpanel)에 붙이면
        //어떻게 컨트롤을 배치할지를 sp가 결정
        //윈도우 size 변경 시 sp가 알아서 자식 컨트롤의 위치, 크기를 자동으로 결정함

        sp.Children.Add(new Button { Content = "Button1"});
        sp.Children.Add(new Button { Content = "Button2" });
        sp.Children.Add(new Button { Content = "Button3" });

        // sp.Children : Collection 입니다.
        //               그래서 Add() 로 자식 컨트롤들을 넣으면됩니다.

        //Layout(Panel)도 다양한 속성이  이씅ㅁ
        sp.Orientation = Orientation.Horizontal; //버튼 세로로 쌓던거 가로로 쌓음
        sp.HorizontalAlignment = HorizontalAlignment.Stretch; // 이게멍미
        sp.HorizontalAlignment = HorizontalAlignment.Right; // 오른쪽
        //StackPanel 외에도 7~8개의 Layout이 있음

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
