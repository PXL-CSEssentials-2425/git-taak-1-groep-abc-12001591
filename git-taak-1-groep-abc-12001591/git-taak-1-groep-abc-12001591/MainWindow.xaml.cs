using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace git_taak_1_groep_abc_12001591
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

        private void pxlPicture_MouseEnter(object sender, MouseEventArgs e)
        {
           
            mainGrid.Background = Brushes.Black;
        }

        private void pxlPicture_MouseLeave(object sender, MouseEventArgs e)
        {
            mainGrid.Background = Brushes.LightGray;
        }

        private void rodeBloem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurCodeTextBox.Text = "#FF0000";
        }

        private void geleBloem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurCodeTextBox.Text = "#FFFF00";
        }

        private void groeneBloem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurCodeTextBox.Text = "#008000";
        }

        private void blauweBloem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurCodeTextBox.Text = "#0000FF";
        }
    }
}
