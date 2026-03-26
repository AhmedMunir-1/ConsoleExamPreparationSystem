namespace ExamSystem.Question
{

    public enum enQuestionType
    {
        TrueFalse = 1,
        SingleChoice = 2,
        MultiChoice = 3
    }


    public enum enQuestionLevel
    {
        Easy = 1,
        Medium = 2,
        Hard = 3
    }



    class Question

    {
        public Question(string q_id, enQuestionType questionType, string question, enQuestionLevel questionLevel, int GradeOfTheQuestion)
        {
            this.q_id = q_id;
            this.typeOfQuestion = questionType;
            this.question = question;
            this.QuestionLevel = questionLevel;
            this.GradeOfTheQuestion = GradeOfTheQuestion;
        }

        string q_id { get; init; }
        public enQuestionType typeOfQuestion { get; set; }
        public enQuestionLevel QuestionLevel { get; set; }
        public string question { get; set; }
        public int GradeOfTheQuestion { get; set; } // add it into the other functions 

    }

}
