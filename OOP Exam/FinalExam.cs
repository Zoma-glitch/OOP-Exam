using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    public class FinalExam : Exam
    {
        public FinalExam(string title , int time) : base(title , time)
        {
        }

        public override void PrintExam()
        {
            Console.WriteLine("=== Final Exam ===");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Time: " + Time + " minutes");
            foreach ( Question q in Questions)
            {
                q.PrintQuestion();
            }
        }
    }
}
