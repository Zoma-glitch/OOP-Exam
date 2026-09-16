using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    public abstract class Question
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark {  get; set; }
        //public int CorrectAnswer { get;  set; }

        public Question(string header , string body , int mark)
        {
            Header = header;

            Body = body;

            Mark = mark;
        }
        public virtual void PrintQuestion()
        {
            Console.WriteLine("=== Question ===");
            Console.WriteLine("Header: " + Header);
            Console.WriteLine("Body: " + Body);
            Console.WriteLine("Mark: " + Mark);
        }
    }
}
