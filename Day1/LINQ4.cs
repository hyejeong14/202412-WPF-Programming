using System.Windows.Controls;

//grid.Children은 Collection(List<UIElement>)
// => 다양한 컨트롤을 보관하기 위해
// => 각 컨트롤의 기반 클래스인 UIElement type으로 보관
var col1 = Grid.children; 

//grid 내부 collection의 모든 요소를 Imagfe 타입으로 볼 수 있도록
var collection = grid.Children.Cast<Image>(); // LINQ

//col2의 모든 Image 객체 중에서, Grid에 x1,y1에 있는 것을 찾는 코드

Image? img1 = collection.FirstOrDefault(img => Grid.GetRow(img) == y1 && Grid.GetColumn(img) == x1);


//WPF 사용시
//grid의 3,4 위에 있는 컨트롤을 찾고 싶을 때 위처럼 사용해야 함.
