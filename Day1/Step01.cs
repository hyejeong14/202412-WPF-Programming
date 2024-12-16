// See https://aka.ms/new-console-template for more information
using System;
using System.Windows;

//Console Project => wpf 사용하도록 변경하는 방법
//.csproj 파일 (프로젝트 이름 클릭)에서 아래 사항 변경

//<OutputType> WinExe </OutputType>
//<TargetFramework> net8.0-windows</TargetFramework>


//아래 1개 추가
//<UseWPF>true</UseWPF>

//아래 설정은 console창 유무
//<OutputType> Exe </OutputType>
//Exe : 콘솔 생성
//WinExe : 콘솔 없음

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, C#");
        MessageBox.Show("Hello, WPF"); //messagebox가 system.windows 안에 있는 클래스, using namespace 설정해도 에러나는 이유는 wpf 프로젝트 설정이 되어 있지 않았기 때문

    }
}


