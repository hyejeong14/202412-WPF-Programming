// See https://aka.ms/new-console-template for more information
using System;
using System.Windows;

// Step02. Window 만들기
// #1. 프로그램에서 ui를 생성하는 경우 반드시 main 함수위에 [STAThread] 표기해야 함
// #2. 윈도우를 만드려면 Window 클래스 사용 필요
class Program
{
    [STAThread]
    public static void Main()
    {
        
        Window win = new Window();//window 클래스 객체 생성
        MessageBox.Show("Hello, WPF"); 
    }
}


