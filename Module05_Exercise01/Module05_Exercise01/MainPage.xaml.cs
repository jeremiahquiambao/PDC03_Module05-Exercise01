using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module05_Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            DateTime birthDate = datePicker.Date;
            bool isStudent = studentSwitch.IsToggled;
            string studentStatus = isStudent ? "Yes" : "No";
            DisplayAlert("Hello!", $"Hello {name}! You were born on {birthDate.ToString("d")}. Are you a student? {studentStatus}", "OK");
        }
    }
}
