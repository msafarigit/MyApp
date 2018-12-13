using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp.Pages
{
    public partial class TestListViewPage2 : ContentPage
    {
        public TestListViewPage2()
        {
            InitializeComponent();

            BindingContext = new ListViewPageViewModel();
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e) => ((ListView)sender).SelectedItem = null;

        private async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            await DisplayAlert("Selected", e.SelectedItem.ToString(), "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }

    internal class ListViewPageViewModel : INotifyPropertyChanged
    {
        //ObservableCollection: Represents a dynamic data collection that provides notifications when items get
        //     added, removed, or when the whole list is refreshed.
        public ObservableCollection<Item> Items { get; }
        public ObservableCollection<Grouping<string, Item>> ItemsGrouped { get; }

        public ICommand RefreshDataCommand { get; }

        public ListViewPageViewModel()
        {
            Items = new ObservableCollection<Item>(new[]
            {
                new Item { Text = "Baboon", Detail = "Africa & Asia" },
                new Item { Text = "Capuchin Monkey", Detail = "Central & South America" },
                new Item { Text = "Blue Monkey", Detail = "Central & East Africa" },
                new Item { Text = "Squirrel Monkey", Detail = "Central & South America" },
                new Item { Text = "Golden Lion Tamarin", Detail= "Brazil" },
                new Item { Text = "Howler Monkey", Detail = "South America" },
                new Item { Text = "Japanese Macaque", Detail = "Japan" },
            });

            IEnumerable<Grouping<string, Item>> sorted = from item in Items
                                                         orderby item.Text
                                                         group item by item.Text[0].ToString() into itemGroup
                                                         select new Grouping<string, Item>(itemGroup.Key, itemGroup);

            ItemsGrouped = new ObservableCollection<Grouping<string, Item>>(sorted);

            RefreshDataCommand = new Command(async () => await RefreshData());
        }

        private async Task RefreshData()
        {
            IsBusy = true;
            //Load Data Here
            await Task.Delay(2000);

            IsBusy = false;
        }

        private bool busy;
        public bool IsBusy
        {
            get { return busy; }
            set
            {
                busy = value;
                OnPropertyChanged();
                ((Command)RefreshDataCommand).ChangeCanExecute();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public class Item
        {
            public string Text { get; set; }
            public string Detail { get; set; }

            public override string ToString() => Text;
        }

        public class Grouping<K, T> : ObservableCollection<T>
        {
            public K Key { get; private set; }

            public Grouping(K key, IEnumerable<T> items)
            {
                Key = key;
                foreach (T item in items)
                    Items.Add(item);
            }
        }
    }
}
