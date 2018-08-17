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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MakerLight.View
{
    /// <summary>
    /// AboutUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class AboutUserControl : UserControl
    {
        public AboutUserControl()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var btn = (Button)sender;
            btn.IsEnabled = false;
            var ani = new ColorAnimation(Color.FromRgb(255, 0, 0), new Duration(TimeSpan.FromSeconds(2)));
            ani.Completed += (s, a) => btn.IsEnabled = true;
            btn.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, ani);
        }
    }
}
