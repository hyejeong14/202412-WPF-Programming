using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

// Step10-1. Grid Layout
// => 엑셀 같은 형태의 격자로 자식 컨트롤 배치

class MainWindow : Window
{
    public MainWindow()
    {
        //#1. Layout 만들고, Window의 Content 속성에 연결

        Grid grid = new Grid();
        this.Content = grid;

        //#2. Row, Col의 개수를 지정해야 함

        //일반적인 라이브러리들의 코드
        //grid.SetRowsCols(2, 2); 각 객체당 넓이 이런거 어케할건지 안정해져있ㅇㅁ

        //wpf : 잘설계된 객체지향 라이브러리,column, row 모두 객체임
        RowDefinition rd1 = new RowDefinition();

        //rd1.Height = 20; //에러, 숫자만 넣을 수 없음 GridLength라는 타입의 객체가 필요함
        //rd1.Height = new GridLength(200); //가능. 200pixel
        rd1.Height = new GridLength(20, GridUnitType.Star); //20%
        

        RowDefinition rd2 = new RowDefinition();
        rd2.Height = new GridLength(80, GridUnitType.Star);

        grid.RowDefinitions.Add(rd1);
        grid.RowDefinitions.Add(rd2);

        ColumnDefinition cd1 = new ColumnDefinition();
        ColumnDefinition cd2 = new ColumnDefinition();

        grid.ColumnDefinitions.Add(cd1);
        grid.ColumnDefinitions.Add(cd2);
        
        //--------------------------------------------------
        //#3. 필요한 자식 컨트롤 생성
        Button btn1 = new Button { Content = "button1" };
        Button btn2 = new Button { Content = "button2" };
        Button btn3 = new Button { Content = "button3" };

        Label lbl1 = new Label { Content = "label1"};


        //#4. 각 컨트롤이 Grid에 어느 위치에 놓일지 설정 필요
        //grid 클래스의 static 메소드 사용
        //복잡해보여도 xml로 보면 ㄱㅊ음
        Grid.SetRow(btn1,0); Grid.SetColumn(btn1, 0);
        Grid.SetRow(btn2, 0); Grid.SetColumn(btn2, 1);
        Grid.SetRow(btn3, 1); Grid.SetColumn(btn3, 0);
        Grid.SetRow(lbl1, 1); Grid.SetColumn(lbl1, 1);


        //#5. 각 자식을 grid의 Collection에 추가
        grid.Children.Add(btn1);
        grid.Children.Add(btn2);
        grid.Children.Add(btn3);
        grid.Children.Add(lbl1);
  
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