using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _06_RESOURCE
{
    /// <summary>
    /// Ex1Resource1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Resource1 : Window
    {
        public Ex1Resource1()
        {           
            //App이나 Window 안에는 Resources라는 속성이 있는데 Dictionary 타입임 (key와 value를 보관)
            //Util.ShowHierachy(this.Resources);

            //자주 사용하는 브러쉬(자원)을 미리 생성해서 리소스(dictionary)에 보관한 것
            this.Resources["mybrush1"] = new SolidColorBrush(Colors.Yellow);
            //mytitle c#에서 하는 법
            //this.Resources["mytitle"] = "hello";


            //아래 메소드 안에서 xaml의 속성 초기화 등이 수행됨
            //따라서 Xaml에서 사용할 리소스를 C#에서 만드려면 initializecomponent 호출 전에 만들어야 함
            InitializeComponent();

 
        }
    }
}
