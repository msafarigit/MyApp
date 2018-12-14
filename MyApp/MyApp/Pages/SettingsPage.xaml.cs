
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            InitializeSettings();
            base.OnAppearing();
        }

        private void InitializeSettings()
        {
            //displayName.Text = "Mahdi";
            //bioEditor.Text = "Mahdi is developing Xamarin forms for interesting!!!";
            //articlesCountSlider.Value = 5;
            //categoryPicker.SelectedIndex = 2;
        }
    }
}