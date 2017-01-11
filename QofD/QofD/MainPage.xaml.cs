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

            Button saver = new Button
            {
                Text = "Save"
            };
            saver.Clicked += HandleTouchUpInside;

           

            Content = new StackLayout
            {
                Children =
                {
                    greeting, question, toIndex, saver
                }
            };
        }

        async private void OnButtonClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.ToString());
            DateTime now = DateTime.Now.ToLocalTime();
            QuestionItem newEntry = new QuestionItem(question.Text, now, false);
            await Navigation.PushAsync(new Index(newEntry));
        }

        void HandleTouchUpInside(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Saved", "OK");
        }
    }
}
