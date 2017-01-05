using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace QofD
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            Label list = new Label
            {
                Text = "This is where the list goes",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            List<String> questions = new List<String>();
            questions.Add("How do you eat a porcupine safely?");
            questions.Add("How many dogs does it take to make a pancake?");
            questions.Add("Is Fiji water really just rich people spit?");
            questions.Add("Are Burt and Ernie from California?");

            ListView questionView = new ListView
            {
                SeparatorColor = Color.Gray,
                ItemsSource = questions
            };
            Content = new StackLayout
            {
                Children =
                {
                    list, questionView
                }
            };
        }
    }
}
