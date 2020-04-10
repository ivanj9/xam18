using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xam18
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            // Shell.Current.FlyoutIsPresented = false;
            DisplayAlert("Alert","Message to show", "OK");

        }
    }
}
