using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HW2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BirthDateText.SelectedDate = DateTime.Today;
        }


        private void Run()
        {
            switch (BirthDateText.DisplayDate.Month)
            {
                case 1 when BirthDateText.DisplayDate.Day >= 20:
                case 2 when BirthDateText.DisplayDate.Day <= 18:
                    ZodiacSignsText.Content = "Aquarius";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/aquarius.jpg", UriKind.Relative));
                    break;
                case 2 when BirthDateText.DisplayDate.Day >= 19:
                case 3 when BirthDateText.DisplayDate.Day <= 20:
                    ZodiacSignsText.Content = "Pisces";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/pisces.jpg", UriKind.Relative));
                    break;
                case 3 when BirthDateText.DisplayDate.Day >= 21:
                case 4 when BirthDateText.DisplayDate.Day <= 19:
                    ZodiacSignsText.Content = "Aries";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/aries.jpg", UriKind.Relative));
                    break;
                case 4 when BirthDateText.DisplayDate.Day >= 20:
                case 5 when BirthDateText.DisplayDate.Day <= 20:
                    ZodiacSignsText.Content = "Taurus";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/taurus.jpg", UriKind.Relative));
                    break;
                case 5 when BirthDateText.DisplayDate.Day >= 21:
                case 6 when BirthDateText.DisplayDate.Day <= 21:
                    ZodiacSignsText.Content = "Gemini";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/gemini.jpg", UriKind.Relative));
                    break;
                case 6 when BirthDateText.DisplayDate.Day >= 22:
                case 7 when BirthDateText.DisplayDate.Day <= 22:
                    ZodiacSignsText.Content = "Cancer";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/cancer.jpg", UriKind.Relative));
                    break;
                case 7 when BirthDateText.DisplayDate.Day >= 23:
                case 8 when BirthDateText.DisplayDate.Day <= 22:
                    ZodiacSignsText.Content = "Leo";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/leo.jpg", UriKind.Relative));
                    break;
                case 8 when BirthDateText.DisplayDate.Day >= 23:
                case 9 when BirthDateText.DisplayDate.Day <= 22:
                    ZodiacSignsText.Content = "Virgo";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/virgo.jpg", UriKind.Relative));
                    break;
                case 9 when BirthDateText.DisplayDate.Day >= 23:
                case 10 when BirthDateText.DisplayDate.Day <= 22:
                    ZodiacSignsText.Content = "Libra";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/libra.jpg", UriKind.Relative));
                    break;
                case 10 when BirthDateText.DisplayDate.Day >= 23:
                case 11 when BirthDateText.DisplayDate.Day <= 21:
                    ZodiacSignsText.Content = "Scorpio";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/scorpio.jpg", UriKind.Relative));
                    break;
                case 11 when BirthDateText.DisplayDate.Day >= 22:
                case 12 when BirthDateText.DisplayDate.Day <= 21:
                    ZodiacSignsText.Content = "Sagittarius";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/sagittarius.jpg", UriKind.Relative));
                    break;
                case 12 when BirthDateText.DisplayDate.Day >= 22:
                case 1 when BirthDateText.DisplayDate.Day <= 19:
                    ZodiacSignsText.Content = "Capricorn";
                    ZodiacSignsImage.Source = new BitmapImage(new Uri(@"./Images/capricorn.jpg", UriKind.Relative));
                    break;
                default:
                    ZodiacSignsText.Content = "Invalid Data";
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {         
                Run();
        }
    }
}
