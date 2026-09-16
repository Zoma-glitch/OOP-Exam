using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    public abstract class Exam
    {
        public string Title { get; set; }

        public int Time { get; set; }

        public List<Question> Questions { get; set; }

        public Exam(string title , int time)
        {
            Title = title;

            Time = time;

            Questions = new List<Question>();
        }
        public void AddQuestion(Question q)
        {
              Questions.Add(q);

        }
        public abstract void PrintExam();
    }   
}
