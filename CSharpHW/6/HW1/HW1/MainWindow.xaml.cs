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

namespace HW1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _counter = 2;
        private int _number2;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            CounterLabel.Content = "Number of attempts - " + _counter;
            _number2 = GenerateNumber();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RunGame();
        }

        private void RunGame()
        {
            var text = NumberField.Text;
            var result = int.TryParse(text, out var number1);
            if (!result)
            {
                MessageBox.Show("Invalid Data", "HW1");
                return;
            }

            if (CheckAnswer(number1, _number2))
            {
                MessageBox.Show("You guessed", "HW1");
                NumberField.Text = "";
                _counter = 2;
                CounterLabel.Content = "Number of attempts - " + _counter;
            }

            else
            {
                _counter -= 1;
                NumberField.Text = "";

                switch (_counter)
                {
                    case 0:
                        MessageBox.Show("You loose", "HW1");
                        _counter = 2;
                        break;
                    default:
                        MessageBox.Show("Try again", "HW1");
                        break;
                }
            }

            CounterLabel.Content = "Number of attempts - " + _counter;
            InfoLabel.Content = "The last mysterious number: " + _number2;
            _number2 = GenerateNumber();
        }

        private static int GenerateNumber()
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(1, 11);
        }

        private static bool CheckAnswer(int number1, int number2)
        {
            return number1 == number2;
        }
    }
}
