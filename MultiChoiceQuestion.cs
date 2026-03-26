

namespace ExamSystem.Question.MultiChoice
{

    class MultiChoiceQuestion : Question
    {

        public MultiChoiceQuestion(string q_id, enQuestionType questionType, string question, enQuestionLevel questionLevel, int GradeOfTheQuestion, List<string> option, List<string> correctAnswers)
        : base(q_id, questionType, question, questionLevel, GradeOfTheQuestion)
        {
            this.options = option;
            this.CorrectAnswers = correctAnswers;
        }

        List<string> options { get; set; }

        public List<string> CorrectAnswers { get; set; }

        public void Printoptions()
        {

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }

    }


}
