using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        //메뉴 exit버튼
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //메뉴 about 버튼
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("제출자 이름을 나타나게 해주세요.");
        }

        
        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //이름 숫자 입력 막기
        private void name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            short val; ;
            bool b = short.TryParse(e.Text, out val);
            if (b)
            {
                e.Handled = true;
            }
        }

        //버튼 클릭하면 리스트 박스에 추가
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            string n = name.Text;
            listbox.Items.Add(n);
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !string.IsNullOrEmpty(name.Text) &&
                           !string.IsNullOrEmpty(address.Text) == true;
        }
    }
}