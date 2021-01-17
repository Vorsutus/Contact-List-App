using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ContactsApp.ViewModels;

namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsListViewPage : ContentPage
    {
        public ContactsListViewPage()
        {
            InitializeComponent();

            contactsListView.ItemSelected += (sender, args) =>
            {
                if (contactsListView.SelectedItem == null) return;
                Navigation.PushModalAsync(new EditDeleteContactViewPage());
            };
        }

        private void AddContact_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DataEntryPage());
        }

        protected override void OnAppearing()
        {
            contactsListView.SelectedItem = null;
            contactsListView.ItemsSource = ContactsViewModel.Contacts;
        }
    }
}