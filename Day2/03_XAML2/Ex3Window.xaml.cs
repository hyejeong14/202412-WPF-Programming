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

namespace _03_XAML2
{
    /// <summary>
    /// Ex3Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3Window : Window
    {
        public Ex3Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //WPF에서 새로운 창을 나타내고 싶으면 아래와 같이 수행
            Ex1Window ex1 = new Ex1Window();
            //ex1.ShowDialog(); //showdialog로 자식창을 띄우면 부모창은 사용하지 못함
                              //흔히 모달(Modal)이라고 함
            ex1.Show(); //Modaless. 부모창 사용가능
                        //이 경우 자식 창을 여러개 띄우지 않도록 주의해야 함
        }
    }
}
