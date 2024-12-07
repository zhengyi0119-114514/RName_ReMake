using RName_ReMake.Models;
using RName_ReMake.ModelViews;
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

namespace RName_ReMake.Views
{
    /// <summary>
    /// SettingWindows.xaml 的交互逻辑
    /// </summary>
    public partial class SettingWindows : Window
    {
        private SettingsBinding binding;
        public SettingWindows(SettingsBinding settingsBinding)
        {
            InitializeComponent();
            this.DataContext = this.binding = settingsBinding;
        }
    }
}
