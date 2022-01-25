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

namespace MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.tbFrst = tbFrstNum;
            Model.tbScnd = tbScndNum;
            Model.tbEqual = tbEqual;
            cbOper.ItemsSource = Model.operList;
        }

        private void buttEqual_Click(object sender, RoutedEventArgs e)
        {
            Model.frstNum = Convert.ToInt32(tbFrstNum.Text);
            Model.scndNum = Convert.ToInt32(tbScndNum.Text);
            Model.cbOper = cbOper.SelectedIndex;
            tbEqual.Text = Model.Equal;
        }
    }
}
