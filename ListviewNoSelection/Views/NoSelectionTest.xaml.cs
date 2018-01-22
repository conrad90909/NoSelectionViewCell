using Xamarin.Forms;

namespace ListviewNoSelection
{
    public partial class NoSelectionTest : ContentPage
    {
        public NoSelectionTest()
        {
            InitializeComponent();

            listView.ItemsSource = DataSource.GetList();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var item = (DataSource)listView.SelectedItem;

            await DisplayAlert("Alert", "You clicked - " + item.Name, "OK");

        }
    }
}
