using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QofD
{
    public class QuestionItem
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
}
