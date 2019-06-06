using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    using Xamarin.Forms.PlatformConfiguration;

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TestEntry_OnCompleted(Object sender,
                                           EventArgs e)
        {
            this.TestPicker.Focus();
        }

        private void TestPicker_OnFocused(Object sender,
                                          FocusEventArgs e)
        {
            Plugin.Toast.CrossToastPopUp.Current.ShowToastMessage("Picker Focused");
        }

        private void TestPicker_OnUnfocused(Object sender,
                                            FocusEventArgs e)
        {
            Plugin.Toast.CrossToastPopUp.Current.ShowToastMessage("Picker unfocused");
            this.SaveButton.Focus();
        }

        private void SaveButton_OnFocused(Object sender,
                                          FocusEventArgs e)
        {
            Plugin.Toast.CrossToastPopUp.Current.ShowToastMessage("Button Focused");
        }

        private void SaveButton_OnClicked(Object sender,
                                          EventArgs e)
        {
            Plugin.Toast.CrossToastPopUp.Current.ShowToastMessage("Button Clicked");
        }
    }
}
