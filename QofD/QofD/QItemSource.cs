using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QofD
{
    class QItemSource
    {
        public QItemSource(List<QuestionItem> qi)
        {
            this.QuestionSource = qi;
            
        }

        public List<QuestionItem> QuestionSource { private set; get; }
    };
}
