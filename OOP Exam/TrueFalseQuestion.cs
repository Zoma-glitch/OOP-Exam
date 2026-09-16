using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string header, string body, int mark, bool correctAnswer)
            : base(header, body, mark)
        {
            CorrectAnswer = correctAnswer;
        }

        public override void PrintQuestion()
        {
            Console.WriteLine($"Question: {Body}");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
            Console.WriteLine($"Mark: {Mark}");
        }
    }
}
