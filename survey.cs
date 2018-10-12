using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingQuestionOptionAndType
{
    public class Element
    {
        public string type { get; set; }
        public string name { get; set; }
        public List<string> choices { get; set; }
    }

    public class Page
    {
        public string name { get; set; }
        public List<Element> elements { get; set; }
    }

    public class RootObject
    {
        public List<Page> pages { get; set; }

    }
}
