using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QofD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label greeting = new Label
            {
                Text = "What question would you like to know?",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            Editor question = new Editor();

            Button toIndex = new Button
            {
                Text = "Question List",
            };
            toIndex.Clicked += OnButtonClicked;

            Content = new StackLayout
            {
                Children =
                {
                    greeting, question, toIndex
                }
            };
        }

        async private void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
