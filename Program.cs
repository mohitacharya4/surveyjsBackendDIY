using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GettingQuestionOptionAndType;


namespace GettingQuestionOptionAndType
{
    class Program
    {

        static void Main(string[] args)
        {
            string downloadedDocument = "{\n \"pages\": [\n  {\n   \"name\": \"Annual Company Questionnaire\",\n   \"elements\": [\n    {\n     \"type\": \"text\",\n     \"name\": \"question1\"\n    },\n    {\n     \"type\": \"checkbox\",\n     \"name\": \"question2\",\n     \"choices\": [\n      \"item1\",\n      \"item2\",\n      \"item3\"\n     ]\n    },\n    {\n     \"type\": \"radiogroup\",\n     \"name\": \"question3\",\n     \"choices\": [\n      \"item1\",\n      \"item2\",\n      \"item3\"\n     ]\n    },\n    {\n     \"type\": \"dropdown\",\n     \"name\": \"question4\",\n     \"choices\": [\n      \"item1\",\n      \"item2\",\n      \"item3\"\n     ]\n    }\n   ],\n   \"title\": \"Annual Company Questionnaire\"\n  },\n  {\n   \"name\": \"Annual Plan Questionnaire\",\n   \"title\": \"Annual Plan Questionnaire\"\n  },\n  {\n   \"name\": \"Annual Form 5500 Questionnaire\",\n   \"title\": \"Annual Form 5500 Questionnaire\"\n  }\n ]\n}";
            var x = JsonConvert.DeserializeObject<RootObject>(downloadedDocument);
            Console.WriteLine(x);


        }
    }
}
