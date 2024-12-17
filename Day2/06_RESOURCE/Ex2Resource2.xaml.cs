﻿using System;
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
    /// Ex2Resource2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2Resource2 : Window
    {
        public Ex2Resource2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //리소스를 변경할 때 나오는 효과 비교 (button1 vs button2 : static vs Dynamic)
            this.Resources["mybrush"] = new SolidColorBrush(Colors.PaleGreen);
        }
    }
}
