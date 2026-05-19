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
using System.Windows.Threading;

namespace coockieGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double cookies = 0;
        double cookiesPerClick = 1;
        double cookiesPerSecond = 0;

        int totalClicks = 0;

        MainWindow mainWindow;
        

        public MainWindow()
        {
            InitializeComponent();

            txbCook.Text = "Sušenky: 0";

            txbCklk.Text = "Za klik: 1";

            txbCsec.Text = "Za sekundu: 0";

            mainWindow = window;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cookies += cookiesPerClick;

            totalClicks++;

            txbCook.Text = "Sušenky: " + cookies;

            txbCklk.Text = "Za klik: " + cookiesPerClick;

            txbCsec.Text = "Za sekundu: " + cookiesPerSecond;
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            menu shop = new menuWindow(this);

            shop.Show();
        }
    }
}