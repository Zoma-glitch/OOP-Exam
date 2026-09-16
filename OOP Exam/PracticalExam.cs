using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    public class PracticalExam : Exam
    {
        public PracticalExam(string title , int time) : base(title , time)
        {
        }

        public override void PrintExam()
        {
            Console.WriteLine("=== Practical Exam ===");
            Console.WriteLine("Title: " + Title);

            foreach (Question q in Questions)
            {
                q.PrintQuestion();
            }
        }
    }
}
