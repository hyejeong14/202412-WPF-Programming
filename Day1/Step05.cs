// See https://aka.ms/new-console-template for more information
using System;
using System.Windows;
using System.Windows.Media;

//Step05. Window event 처리
//방법 #1.window의 delegate(event)에 메소드 등록
//아래 코드의 특징 "window의 event"를 Program 클래스에서 처리
 
class Program
{
    [STAThread]
    public static void Main()
    {

        Application app = new Application();

        Window win = new Window();
     
        win.Show();

        win.MouseLeftButtonDown += Win_MouseLeftButtonDown;


        app.Run();

    }

    private static void Win_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
                                        // 첫번째 인자 sender : 이벤트를 발생시킨 객체의 참조 (현재 코드에서는 win 객체 object -> win 캐스팅)
                                        // 2번째 인자 e : 이벤트에 대한 추가 정보 (마우스 좌표 등)
    {
        Window win = (Window)sender;
        Point pt = e.GetPosition(win); //win을 기준으로 좌표 얻기
        win.Title = pt.X + " " + pt.Y; //win 제목을 x+y 좌표로 설정 (클릭할 때마다)
        //MessageBox.Show("Click");
        //throw new NotImplementedException();
    }
}

