using Xamarin.Forms;

namespace MyApp.Pages
{
    //Elements defined in Xamarin.Forms for use in XAML are allowed to have one property flagged in the
    // ContentProperty attribute on the class:
    //      [ContentProperty("Content")]
    //      public class ContentPage : TemplatedPage
    //This means that the Content property-element tags are not required. Any XML content that appears between the
    // start and end ContentPage tags is assumed to be assigned to the Content property.

    public class Page1 : ContentPage
    {
        public Page1()
        {
            Title = "Page 1";

            Button button = new Button { Text = "RelativePage", Margin = new Thickness(20) };
            button.Clicked += async (sender, e) => await Navigation.PushAsync(new RelativePage());

            Content = new StackLayout
            {
                //StackLayout , Grid , AbsoluteLayout , and RelativeLayout all derive from Layout<View> , and if you look up
                // Layout < T > in the Xamarin.Forms documentation, you’ll see another ContentProperty attribute:
                //      [Xamarin.Forms.ContentProperty("Children")] 
                //      public abstract class Layout<T> : Layout...
                //That allows content of the layout to be automatically added to the Children collection without explicit Children
                // property-element tags.
                Children = {
                    //Other classes also have ContentProperty attribute definitions.For example, the content property of Label is Text.
					new Label { Text = "Welcome to Xamarin.Forms!" },
                    button
                }
            };
        }
    }
}