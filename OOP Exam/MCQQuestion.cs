using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    public class MCQQuestion : Question
    {
        public string[] Choices { get; set; }
        public int CorrectAnswer { get; set; }

        public MCQQuestion(string header ,string body, int mark , string[] choices , int correctAnswer) : base("MCQ",body, mark)
        {
            Choices = choices;

            CorrectAnswer = correctAnswer;
        }
        public virtual void PrintQuestion()
        {
            Console.WriteLine($"Question: {Body}");
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            }
            Console.WriteLine($"Mark: {Mark}");
        }
    }
}
