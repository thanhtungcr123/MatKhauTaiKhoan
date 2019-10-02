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

namespace LamQuen4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Co_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ten : " + Ten_dang_nhap.Text + "\nMat khau : " + Mat_khau.Text);
        }

        private void Khong_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
