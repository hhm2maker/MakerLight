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
        MainWindow mw;
        public AboutUserControl(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void ToCatalogUserControl(object sender, RoutedEventArgs e)
        {
            mw.ToCatalogUserControl();
        }
    }
}
