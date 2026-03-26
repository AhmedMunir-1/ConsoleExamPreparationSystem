namespace ExamSystem.Question.ChoiceQuestion
{
    class ChoiceQuestion : Question

    {

    List<string> options {get; set;}
    public string correctAnswer {get; set;}

        public ChoiceQuestion(string q_id, enQuestionType questionType, string question,enQuestionLevel questionLevel,List<string> option,string correctAnswer,int GradeOfTheQuestion) 
        : base(q_id, questionType, question, questionLevel,GradeOfTheQuestion)
        {
            this.options = option;
            this.correctAnswer = correctAnswer;
        }
        
    public void PrintOptions(){

        foreach(string option in options)
            {
                Console.WriteLine(option);
            }
    }    

    }  
    

    }


