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

namespace _10_BINDING
{
    /// <summary>
    /// Ex5DataBinding5.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex5DataBinding5 : Window
    {
        public Ex5DataBinding5()
        {
            //Fonts.SystemFontFamilies => 현재 pc에 설치된 모든 폰트 목록을 가진 collection
            InitializeComponent();


            listbox.ItemsSource = Fonts.SystemFontFamilies;
        }
    }
}


//1.slider-label 폰트 크기 연결 : element binding
//2. text 변하면 label 문자열 변경
//3. listbox 선택 변경 시, label 폰트 변경