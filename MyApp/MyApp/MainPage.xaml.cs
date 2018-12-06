using Xamarin.Forms;

namespace MyApp
{
    //ContentPage is inherited Page Class.
    //Layout is a spetialized subtype of a View! and ultimatly act as a container for other layout or views
    //A layout contains logic to set the position and size of child controls and elements in application!

    //class TabbedPage : MultiPage<Page>
    //class CarouselPage : MultiPage<ContentPage>
    //class ContentPage : TemplatedPage
    //class TemplatedPage : Page
    //class NavigationPage : Page
    //class MasterDetailPage : Page
    //class Page : VisualElement
    //class VisualElement : Element
    public partial class MainPage : TabbedPage//ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //This is Loaded Event!! Add Control in runtime
        //protected override void OnAppearing()
        //{
        //    //class AbsoluteLayout : Layout<View>
        //    //class Grid : Layout<View>
        //    //class RelativeLayout : Layout<View>
        //    //class ScrollView : Layout
        //    //class StackLayout : Layout<View>
        //    //abstract class Layout<T> : Layout
        //    //abstract class Layout : View, ILayout
        //    //class View : VisualElement
        //    //class VisualElement : Element
        //    StackLayout layout = new StackLayout();

        //    //class Label : View
        //    Label firstNameLbl = new Label
        //    {
        //        Text = "Enter your First Name:",
        //        VerticalOptions = LayoutOptions.Center,
        //        HorizontalOptions = LayoutOptions.Center
        //    };
        //    layout.Children.Add(firstNameLbl);

        //    //class Entry : InputView
        //    //class InputView : View
        //    Entry firstNameEty = new Entry { Placeholder = "Enter your First Name:" };
        //    layout.Children.Add(firstNameEty);

        //    this.Content = layout;

        //    base.OnAppearing();
        //}
    }
}
