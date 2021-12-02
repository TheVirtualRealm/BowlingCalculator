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

namespace BowlingCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double gameone;
        double gametwo;
        double gamethree;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Game1.Text, out gameone);
            Double.TryParse(Game1.Text, out gametwo);
            Double.TryParse(Game1.Text, out gamethree);

            Double answer = gameone + gametwo + gamethree;
            Double answer2 = (gameone + gametwo + gamethree) / 3;
            Double answer3 = (answer2 - 200) * 8;


            Series_Text.Text = answer.ToString();

            Average_Text.Text = answer2.ToString();

            Handicap_Text.Text = answer3.ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Clear_click(object sender, RoutedEventArgs e)
        {
            Game1.Text = "";
            Game2.Text = "";
            Game3.Text = "";
            Series_Text.Text = "";
            Average_Text.Text = "";
            Handicap_Text.Text = "";
        }

    

      
    }
}
