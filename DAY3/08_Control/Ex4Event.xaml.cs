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

namespace _08_Control
{
    /// <summary>
    /// Ex4Event.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex4Event : Window
    {
        public Ex4Event()
        {
            InitializeComponent();
        }

        private void txtbox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //1. txtbox의 값 꺼내기
            string s = txtbox.Text;

            if (s == String.Empty) return;

            //2. txtbox 비우기
            txtbox.Text = "";

            //3. txtbox에서 얻은 것 listbox에 추가하기
            listbox.Items.Add(s);

        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 1. listbox에서 선택된 항목 얻기
            int idx = listbox.SelectedIndex; //선택된 항목의 index
            string? s = listbox.SelectedItem.ToString();

            // 2. label 변경하기
            label.Content = s;
        }
    }
}
