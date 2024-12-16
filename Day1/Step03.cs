// See https://aka.ms/new-console-template for more information
using System;
using System.Windows;

//Step03. Application 클래스와 event loop

class Program
{
    [STAThread]
    public static void Main()
    {
        //#1. Application 객체 생성
        //Application 클래스 : evet loop를 담당해줌
        Application app = new Application(); 
                        //1. WPF 라이브러리 관련 초기화를 수행 하는 클래스
                        //2. 따라서 Main에서 다른 작업 하기 전에 먼저 생성해야 함


        //#2. UI(윈도우)생성
        Window win = new Window();//window 클래스 객체 생성
        win.Show(); //윈도우 창 보여주기

//        Window win2 = new Window();//두번째 윈도우 생성
//        win2.Show(); 


        //#3.UI 를 app 등록 후 , event loop 수행
//        app.MainWindow = win; //위에서 만든 윈도우를 Main 윈도우로 등록 (여러개 생성하고 주 윈도우 설정하는거)
//        app.Run(); //프로그램 종료하지 말고 event 루프 수행
       
        app.Run(win); // 해당 코드로도 #3 번 대체 가능
        app.Run(); //윈도우가 한개인 경우는 이렇게도 대체 가능

    }
}

// app.MainWindow 속성에 주 윈도우 참조가 저장되었다는 점 꼭 기억하기
