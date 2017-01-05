using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace QofD
{
    public partial class Index : ContentPage
    {

        class QuestionItem
        {
            public QuestionItem(string question, DateTime created, Boolean searched)
            {
                this.Question = question;
                this.Created = created;
                this.Searched = searched;
            }

            public string Question { private set; get; }

            public DateTime Created { private set; get; }

            public Boolean Searched { private set; get; }
        };

        public Index()
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
                ItemsSource = questions,
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label questionLabel = new Label();
                    questionLabel.SetBinding(Label.TextProperty, "Question");

                    Label createdLabel = new Label();
                    createdLabel.SetBinding(Label.TextProperty,
                        new Binding("Asked", BindingMode.OneWay,
                            null, null, "first {0:d}"));

                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                                {
                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Center,
                                        Spacing = 0,
                                        Children =
                                        {
                                            questionLabel,
                                            createdLabel
                                        }
                                        }
                                }
                        }
                    };
                })
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
