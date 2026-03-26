using ExamSystem.Exam;
using ExamSystem.Question;
using ExamSystem.Question.ChoiceQuestion;
using ExamSystem.Question.MultiChoice;
using ExamSystem.Question.TrueFalse;
using ExamSystem.proffessor;

namespace ExamSystem.proffessor
{
    class Professor
    {

        public Professor(string prof_id, string prof_Name)
        {
            this.prof_id = prof_id;
            this.prof_Name = prof_Name;
        }

        string prof_id { get; init; }

        public string prof_Name { get; set; }


        static public void Print_QuestionType()
        {

            Console.WriteLine("====================================================");
            Console.WriteLine("  1-TrueFalse   2- SingleChoice  3-MultiChoice  ");
            Console.WriteLine("====================================================");

        }

        static public void Print_QuestionLevel()
        {

            Console.WriteLine("====================================================");
            Console.WriteLine("  1-Easy  2- Mediam  3-Hard ");
            Console.WriteLine("====================================================");

        }



        public ExamSystem.Exam.Exam ExamPreperation()

        {

            Console.WriteLine("Enter Number of Question You Want to add : ");
            int NumOfQuestionInTheExam;

            do
            {
                NumOfQuestionInTheExam = Convert.ToInt32(Console.ReadLine());

            } while (NumOfQuestionInTheExam < 0 || NumOfQuestionInTheExam > 15);



            int SumOfAllQuestionsGrades = 0;

            List<True_False_Question> true_False_Questions = new();
            List<ChoiceQuestion> choiceQuestions = new();
            List<MultiChoiceQuestion> multiChoiceQuestions = new();

            do
            {
                int QuestionLvl;
                int QuestionType;
                int GradeOfTheQuestion;
                int True_False_CorrectAnswer;


                do
                {
                    Print_QuestionType();
                    QuestionType = Convert.ToInt32(Console.ReadLine());
                } while (QuestionType < 1 || QuestionType > 3);




                switch (QuestionType)
                {
                    case 1:



                        do
                        {
                            Print_QuestionLevel();
                            QuestionLvl = Convert.ToInt32(Console.ReadLine());
                        } while (QuestionLvl < 1 || QuestionLvl > 3);


                        do
                        {
                            Console.Write("Enter The Grade OF the Question (Should be 1 or 2 marks) : ");
                            GradeOfTheQuestion = Convert.ToInt32(Console.ReadLine());
                        } while (GradeOfTheQuestion < 1 || GradeOfTheQuestion > 2);

                        SumOfAllQuestionsGrades += GradeOfTheQuestion;


                        Console.WriteLine("Please Enter The Question : ");
                        string Question = Console.ReadLine()!;


                        do
                        {

                            Console.WriteLine("===========================");
                            Console.WriteLine("  1-True  2-False  ");
                            Console.WriteLine("===========================");

                            True_False_CorrectAnswer = Convert.ToInt32(Console.ReadLine());

                        } while (True_False_CorrectAnswer < 1 || True_False_CorrectAnswer > 2);



                        bool True_False = false;

                        if (True_False_CorrectAnswer == 1) True_False = true;

                        else if (True_False_CorrectAnswer == 2) True_False = false;


                        True_False_Question true_False_Question = new(Guid.NewGuid().ToString().Substring(1, 4), enQuestionType.TrueFalse, Question, (enQuestionLevel)QuestionLvl, GradeOfTheQuestion, True_False);


                        true_False_Questions.Add(true_False_Question);

                        break;



                    case 2:

                        List<string> options = new();


                        do
                        {
                            Print_QuestionLevel();
                            QuestionLvl = Convert.ToInt32(Console.ReadLine());

                        } while (QuestionLvl < 1 || QuestionLvl > 3);


                        do
                        {
                            Console.Write("Enter The Grade OF the Question " + "(Should be 1 or 2 marks) : ");
                            GradeOfTheQuestion = Convert.ToInt32(Console.ReadLine());

                        } while (GradeOfTheQuestion < 1 || GradeOfTheQuestion > 2);

                        SumOfAllQuestionsGrades += GradeOfTheQuestion;


                        Console.WriteLine("Please Enter The Question : ");
                        string Choice_Question = Console.ReadLine()!;


                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Enter Question option {i + 1} : ");
                            string option = Console.ReadLine()!;
                            options.Add(option);
                        }



                        string Correct_Answer;
                        do
                        {
                            Console.WriteLine("Enter The CorrectAnswerOption : ");
                            Correct_Answer = Console.ReadLine()!.Trim().ToUpper();
                        } while (Correct_Answer != "A" && Correct_Answer != "B" && Correct_Answer != "C" && Correct_Answer != "D");


                        ChoiceQuestion ChoiceQuestion = new(Guid.NewGuid().ToString().Substring(1, 4), enQuestionType.SingleChoice, Choice_Question, (enQuestionLevel)QuestionLvl, options, Correct_Answer, GradeOfTheQuestion);

                        choiceQuestions.Add(ChoiceQuestion);

                        break;

                    case 3:

                        List<string> MultbleChoiceoptions = new();
                        List<string> Correct_Answers = new();


                        do
                        {
                            Print_QuestionLevel();
                            QuestionLvl = Convert.ToInt32(Console.ReadLine());

                        } while (QuestionLvl < 1 || QuestionLvl > 3);


                        do
                        {

                            Console.Write("Enter The Grade OF the Question (Should be 1 or 2 marks or 3 marks) : ");
                            GradeOfTheQuestion = Convert.ToInt32(Console.ReadLine());

                        } while (GradeOfTheQuestion < 1 || GradeOfTheQuestion > 3);

                        SumOfAllQuestionsGrades += GradeOfTheQuestion;

                        Console.WriteLine("Please Enter The Question : ");
                        string Multible_Question = Console.ReadLine()!;


                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Enter Question options {i + 1} : ");
                            string option = Console.ReadLine()!;
                            MultbleChoiceoptions.Add(option);
                        }

                        Console.WriteLine("Enter The CorrectAnswerOptions : ");
                        string[] answerParts = Console.ReadLine()!.Split(" ");
                        foreach (var ans in answerParts)
                        {
                            Correct_Answers.Add(ans.Trim().ToUpper());
                        }


                        MultiChoiceQuestion MultiChoiceQuestion = new(Guid.NewGuid().ToString().Substring(1, 4), enQuestionType.MultiChoice, Multible_Question, (enQuestionLevel)QuestionLvl, GradeOfTheQuestion, MultbleChoiceoptions, Correct_Answers);

                        multiChoiceQuestions.Add(MultiChoiceQuestion);

                        break;

                }

            } while (--NumOfQuestionInTheExam != 0);



            // Return an Exam

            return new ExamSystem.Exam.Exam(Guid.NewGuid().ToString().Substring(1, 4), SumOfAllQuestionsGrades, true_False_Questions, choiceQuestions, multiChoiceQuestions);



        }


    }


}


