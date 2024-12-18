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

namespace _09_Control2
{
    /// <summary>
    /// Ex1VisualTree.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1VisualTree : Window
    {
        public Ex1VisualTree()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //visual tree 개념 : 현재 ui의 자식 컨트롤을 나타내는 tree 구조
            int cnt = VisualTreeHelper.GetChildrenCount(this);

            Console.WriteLine($"자식윈도우 객수 : {cnt}");
            for(int i = 0; i < cnt; i++)
            {
                object obj = VisualTreeHelper.GetChild(this, i);
                Console.WriteLine(obj.GetType().Name);
            }
        }

        //모든 자식 열거
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowChild(this, "");
        }

        public void ShowChild(DependencyObject obj, string sep)
        {
            Console.WriteLine($"{sep}{obj.GetType().Name}({obj.ToString()})");

            int cnt = VisualTreeHelper.GetChildrenCount(obj);

      
            for (int i = 0; i < cnt; i++)
            {
                DependencyObject childobj = VisualTreeHelper.GetChild(obj, i);

                ShowChild(childobj, sep + "   ");
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            VisualTree vt = new VisualTree();
            vt.Process(this);
            vt.Show();
        }
    }
}
