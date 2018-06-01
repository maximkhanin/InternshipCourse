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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
            BirthDateText.SelectedDate = DateTime.Today;
        }

        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
            var registrationForm = new RegistrationForm
            {
                AdditionalInfo = AdditionalInfoText.Text,
                BirthDate = BirthDateText.SelectedDate.ToString(),
                FirstName = FirstNameText.Text,
                Email = EmailText.Text,
                Gender = GenderText.Text,
                LastName = LastNameText.Text,
                PhoneNumber = PhoneNumberText.Text
            };
            Validate(registrationForm);
        }

        private void Validate(RegistrationForm registrationForm)
        {
            FirstNameValidationResult.Content = RegistrationFormValidation.NameValidation(registrationForm.FirstName);
            LastNameValidationResult.Content = RegistrationFormValidation.NameValidation(registrationForm.LastName);
            GenderValidationResult.Content = RegistrationFormValidation.GenderValidation(registrationForm.Gender);
            EmailValidationResult.Content = RegistrationFormValidation.EmailValidation(registrationForm.Email);
            PhoneNumberValidationResult.Content =
                RegistrationFormValidation.PhoneNumberValidation(registrationForm.PhoneNumber);
            AdditionalInfoValidationResult.Content =
                RegistrationFormValidation.AdditionalInfoValidation(registrationForm.AdditionalInfo);
        }
    }
}
