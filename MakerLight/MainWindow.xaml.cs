using MakerLight.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MakerLight
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 关于页面
        /// </summary>
        private AboutUserControl auc;
        private CatalogUserControl cuc;
        public MainWindow()
        {
            InitializeComponent();

            Width = SystemParameters.WorkArea.Width * 0.8;
            Height = SystemParameters.WorkArea.Height * 0.8;

            auc = new AboutUserControl(this);
            cuc = new CatalogUserControl(this);
            gMain.Children.Add(auc);
        }
        public void ToCatalogUserControl() {
            gMain.Children.Clear();
            gMain.Children.Add(cuc);
        }
    }
}
