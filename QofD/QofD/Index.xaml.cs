﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace QofD
{
    public partial class Index : ContentPage
    {
        List<QuestionItem> global = QItemSource.master;
        public Index(QuestionItem qi)
        {
            InitializeComponent();

            

            QuestionItem recieved = qi;
            global.Add(qi);

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

            List<QuestionItem> questSource = new List<QuestionItem>
            {
                new QuestionItem("How do you eat a porcupine safely?",new DateTime(2016,8,16,2,3,56),true),
                new QuestionItem("How many dogs does it take to make a pancake?",new DateTime(2016,12,12,12,35,56),true),
                new QuestionItem("Is Fiji water really just rich people spit?",new DateTime(2017,1,1,1,1,1),true),
                new QuestionItem("Are Burt and Ernie from California?",new DateTime(2017,1,6,3,56,56),true)
            };

            questSource.Add(recieved);

            ListView questionView = new ListView
            {
                SeparatorColor = Color.Gray,
                ItemsSource = global,
                VerticalOptions = LayoutOptions.Center,
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label questionLabel = new Label();
                    questionLabel.SetBinding(Label.TextProperty, "Question");
                    questionLabel.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));

                    Label createdLabel = new Label();
                    createdLabel.SetBinding(Label.TextProperty, "Created");
                    createdLabel.FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label));

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
                                        VerticalOptions = LayoutOptions.FillAndExpand,
                                        HorizontalOptions = LayoutOptions.FillAndExpand,
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
				Padding = Device.OnPlatform(new Thickness(0, 15, 0, 0), new Thickness(0), new Thickness(0)),

                Children =
                {
                    list, questionView
                }
            };
        }
    }
}
