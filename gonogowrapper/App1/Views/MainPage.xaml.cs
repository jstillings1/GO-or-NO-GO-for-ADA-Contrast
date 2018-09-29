using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;

namespace App1.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.Title = "No Go Go ADA Checker";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void Forground_Color_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {

            ResultUpdate(GoNoGoCalcAA(sender, Background_Color), GoNoGoCalcAAA(Forground_Color, sender));
        }
    

        private void Background_Color_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            ResultUpdate(GoNoGoCalcAA(sender, Background_Color),GoNoGoCalcAAA(Forground_Color, sender));
        }
        private string GoNoGoCalcAA(ColorPicker front, ColorPicker back)
        { string result = "";

            result = " this is a test for AA";
            return result;

        }
        private string GoNoGoCalcAAA(ColorPicker front, ColorPicker back)
        {
            string result = "";

            result = " this is a test for AAA";
            return result;

        }

        private void ResultUpdate( string aa, string aaa)
        {
            AA_Result.Text = aa;
            AAA_Result.Text = aaa;
        }

    }
}
