using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataEntryPage : ContentPage
    {
        public DataEntryPage()
        {
            InitializeComponent();
        }

        private void Return_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ContactsListViewPage());
            Navigation.PopAsync();
        }
    }
}