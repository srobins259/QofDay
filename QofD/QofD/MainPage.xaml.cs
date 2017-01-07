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
        Editor question = new Editor();
        List<QuestionItem> master = new List<QuestionItem>();
        public MainPage()
        {

            InitializeComponent();

            Label greeting = new Label
            {
                Text = "What question would you like to know?",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

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
            DateTime now = DateTime.Now.ToLocalTime();
            QuestionItem newEntry = new QuestionItem(question.Text, now, false);
            master.Add(newEntry);
            QItemSource passable = new QItemSource(master);
            await Navigation.PushAsync(new Index(newEntry));
        }
    }
}
