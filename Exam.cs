using ExamSystem.Question;
using ExamSystem.Question.ChoiceQuestion;
using ExamSystem.Question.MultiChoice;
using ExamSystem.Question.TrueFalse;
using ExamSystem.proffessor;

namespace ExamSystem.Exam

{
    class Exam
    {
        
        public Exam(string exam_id, int examGrades, List<True_False_Question> true_False_Questions, List<ChoiceQuestion> choiceQuestions, List<MultiChoiceQuestion> multiChoiceQuestions)
        {
            Exam_id = exam_id;
            ExamGrades = examGrades;
            this.true_False_Questions = true_False_Questions;
            this.choiceQuestions = choiceQuestions;
            this.multiChoiceQuestions = multiChoiceQuestions;
        }


        string Exam_id {get; set;}

        public  int ExamGrades {get; set;}

        public List<True_False_Question>  true_False_Questions = new();

        public List<ChoiceQuestion> choiceQuestions = new();

        public List<MultiChoiceQuestion> multiChoiceQuestions =new();
        
    }
    
    
}


