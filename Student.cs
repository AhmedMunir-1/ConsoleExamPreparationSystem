using System.ComponentModel.Design;
using ExamSystem.Exam;
using ExamSystem.Question;
using ExamSystem.Question.ChoiceQuestion;
using ExamSystem.Question.MultiChoice;
using ExamSystem.Question.TrueFalse;
using ExamSystem.proffessor;


namespace ExamSystem.student

{

    class Student
    {
        public Student(string student_id, string student_Name)
        {
            this.student_id = student_id;
            this.student_Name = student_Name;
        }

        public string student_id { get; init; }
        public string student_Name { get; set; }


        public int solveExam()
        {

            int Student_Degree = 0;

            return Student_Degree;

        }


        public int solving_Exam(ExamSystem.Exam.Exam exam)
        {

            int Student_Grade = 0;

            Console.WriteLine("True OR False Questions");

            foreach (var True_False_Question in exam.true_False_Questions)

            {
                int TrueFalseStudentAnswer;

                Console.WriteLine(True_False_Question.question);
                Console.WriteLine("===========================");
                Console.WriteLine("  1-True  2-False  ");
                Console.WriteLine("===========================");

                do
                {

                    TrueFalseStudentAnswer = Convert.ToInt32(Console.ReadLine());

                } while (TrueFalseStudentAnswer < 1 || TrueFalseStudentAnswer > 2);


                if (TrueFalseStudentAnswer == 1 && True_False_Question.CorrectAnswer == true) Student_Grade += True_False_Question.GradeOfTheQuestion;
                else if (TrueFalseStudentAnswer == 2 && True_False_Question.CorrectAnswer == false) Student_Grade += True_False_Question.GradeOfTheQuestion;

            }

            Console.WriteLine("-----------------------------------------------");


            foreach (var choiceQuestion in exam.choiceQuestions)
            {
                Console.WriteLine(choiceQuestion.question);
                Console.WriteLine("===========================");
                choiceQuestion.PrintOptions();
                Console.WriteLine("===========================");

                string Choice_Student_Answer;
                do
                {
                    Console.WriteLine("Enter The Correct Answer Option : ");
                    Choice_Student_Answer = Console.ReadLine()!.Trim().ToUpper();
                } while (Choice_Student_Answer != "A" && Choice_Student_Answer != "B" && Choice_Student_Answer != "C" && Choice_Student_Answer != "D");

                if (Choice_Student_Answer == choiceQuestion.correctAnswer) Student_Grade += choiceQuestion.GradeOfTheQuestion;

            }

            Console.WriteLine("-----------------------------------------------");


            foreach (var multiChoiceQuestion in exam.multiChoiceQuestions)
            {
                Console.WriteLine(multiChoiceQuestion.question);
                Console.WriteLine("===========================");
                multiChoiceQuestion.Printoptions();
                Console.WriteLine("===========================");

                List<string> Multble_Choice_Student_Answer = new();

                Console.WriteLine("Enter The CorrectAnswerOptions (choose A,B,C,D Can be more than choice answer) : ");
                string[] answers = Console.ReadLine()!.Split(" ");
                foreach (var answer in answers)
                {
                    Multble_Choice_Student_Answer.Add(answer.Trim().ToUpper());
                }


                if (Multble_Choice_Student_Answer.SequenceEqual(multiChoiceQuestion.CorrectAnswers)) Student_Grade += multiChoiceQuestion.GradeOfTheQuestion;

            }
            return Student_Grade;

        }

    }


}