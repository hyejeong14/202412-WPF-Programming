// See https://aka.ms/new-console-template for more information
using System;
using System.Windows;
using System.Windows.Media;

//Step04. Window 클래스는 다양한 속성 (property)를 제공

class Program
{
    [STAThread]
    public static void Main()
    {
  
        Application app = new Application();
      
        Window win = new Window();//window 클래스 객체 생성
        //win. 하면 속성 확인 가능
        win.Show(); // @@ 위치는 상관없나,??
        
        win.Title = "Hello, WPF"; // 윈도우 이름 변경
        
        win.Width = 500;
        win.Height = 500; // 윈도우 사이즈 조절
        
        win.Left = 100; 
        win.Top = 100; // 윈도우 시작 위치 변경
        
        win.Topmost = true; //최상위 윈도우 (맨 앞으로 이동 설정, 백그라운드 클릭해도 뒤로 가지 않음)
        win.Background = new SolidColorBrush(Colors.Red); //배경색깔 설정



        app.Run();

    }
}

