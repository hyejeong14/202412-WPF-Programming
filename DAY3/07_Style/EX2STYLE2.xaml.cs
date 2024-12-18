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

namespace _07_Style
{
    /// <summary>
    /// EX2STYLE2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EX2STYLE2 : Window
    {
        public EX2STYLE2()
        {
            InitializeComponent();
        }

        private SolidColorBrush yellow_brush = new SolidColorBrush(Colors.Yellow);

        private void mouse_enter(object sender, MouseEventArgs e)
        {
            label2.Background = new SolidColorBrush(Colors.Yellow);
        }
        
        private void mouse_leave(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse_leave");
            label2.Background = null;
        }
    }
}
