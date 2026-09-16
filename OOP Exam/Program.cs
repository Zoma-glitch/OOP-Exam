namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Exam Type (1 for Practical, 2 for Final): ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Exam Time (30 - 180 minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numQuestions = int.Parse(Console.ReadLine());

            Exam exam;

            if (examType == 1)
                exam = new PracticalExam(title, time);
            else
                exam = new FinalExam(title, time);

            for (int i = 1; i <= numQuestions; i++)
            {
                Console.WriteLine($"\nEnter details for question {i}:");

                Question q;

                if (exam is PracticalExam)
                {
                    // Practical Exam → MCQ فقط
                    Console.Write("Please enter the question body: ");
                    string body = Console.ReadLine();

                    Console.Write("Please enter the question mark: ");
                    int mark = int.Parse(Console.ReadLine());

                    string[] choices = new string[4];
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Please enter choice number {j + 1}: ");
                        choices[j] = Console.ReadLine();
                    }

                    Console.Write("Please enter the ID of the correct answer (1 to 4): ");
                    int correctAnswer = int.Parse(Console.ReadLine());

                    q = new MCQQuestion("MCQ", body, mark, choices, correctAnswer);
                }
                else
                {
                    // Final Exam → المستخدم يختار نوع السؤال
                    Console.Write("Choose question type (1 for MCQ, 2 for True/False): ");
                    int questionType = int.Parse(Console.ReadLine());

                    Console.Write("Please enter the question body: ");
                    string body = Console.ReadLine();

                    Console.Write("Please enter the question mark: ");
                    int mark = int.Parse(Console.ReadLine());

                    if (questionType == 1)
                    {
                        string[] choices = new string[4];
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write($"Please enter choice number {j + 1}: ");
                            choices[j] = Console.ReadLine();
                        }

                        Console.Write("Please enter the ID of the correct answer (1 to 4): ");
                        int correctAnswer = int.Parse(Console.ReadLine());

                        q = new MCQQuestion("MCQ", body, mark, choices, correctAnswer);
                    }
                    else
                    {
                        Console.Write("Please enter the ID of the correct answer (1 for True, 2 for False): ");
                        int correctAnswer = int.Parse(Console.ReadLine());
                        bool correctBool = correctAnswer == 1;

                        q = new TrueFalseQuestion("True/False", body, mark, correctBool);
                    }
                }

                exam.AddQuestion(q);
            }



            Console.WriteLine("\n--- Exam Details ---");
            exam.PrintExam();

            Console.Write("\nDo You Want To Start Exam (Y | N): ");
            string startChoice = Console.ReadLine();

            if (startChoice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\n--- Exam Started ---");

                int totalMarks = 0;
                int userScore = 0;

                foreach (Question q in exam.Questions)
                {
                    q.PrintQuestion();

                    Console.Write("\nEnter your answer ID: ");
                    int userAnswer = int.Parse(Console.ReadLine());

                    if (q is MCQQuestion mcq)
                    {
                        if (userAnswer == mcq.CorrectAnswer)
                        {
                            Console.WriteLine("✅ Correct!\n");
                            userScore += mcq.Mark;
                        }
                        else
                        {
                            Console.WriteLine($"❌ Wrong! Correct answer is: {mcq.Choices[mcq.CorrectAnswer - 1]}\n");
                        }
                        totalMarks += mcq.Mark;
                    }
                    else if (q is TrueFalseQuestion tf)
                    {
                        bool userBool = userAnswer == 1;
                        if (userBool == tf.CorrectAnswer)
                        {
                            Console.WriteLine("✅ Correct!\n");
                            userScore += tf.Mark;
                        }
                        else
                        {
                            Console.WriteLine($"❌ Wrong! Correct answer is: {(tf.CorrectAnswer ? "True" : "False")}\n");
                        }
                        totalMarks += tf.Mark;
                    }
                }

                Console.WriteLine($"Your Grade: {userScore} from {totalMarks}");
                Console.WriteLine("Thank you!");
            }
            else
            {
                Console.WriteLine("Exam cancelled.");
            }

        }
    }
}
