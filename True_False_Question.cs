


namespace ExamSystem.Question.TrueFalse
{
    class True_False_Question : Question
    {

        public True_False_Question(string q_id, enQuestionType questionType, string question, enQuestionLevel questionLevel, int GradeOfTheQuestion, bool correctAnswer)
        : base(q_id, questionType, question, questionLevel, GradeOfTheQuestion)
        {

            CorrectAnswer = correctAnswer;

        }

        public bool CorrectAnswer { get; set; }


    }

}
