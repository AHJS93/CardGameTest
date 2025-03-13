using System.IO;
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

namespace cardGame1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void dealBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        slot1.Source = null;
        slot2.Source = null;
        slot3.Source = null;
        slot4.Source = null;
        slot5.Source = null;
        string[] cards = Directory.GetFiles("/images/cards/", "*.png");
        Random rng = new Random();
        int index = rng.Next(cards.Length);
    }
}