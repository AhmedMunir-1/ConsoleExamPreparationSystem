using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Dynamic;
using Microsoft.VisualBasic;
using ExamSystem.Exam;
using ExamSystem.Question;
using ExamSystem.student;
using ExamSystem.Question.ChoiceQuestion;
using ExamSystem.Question.MultiChoice;
using ExamSystem.Question.TrueFalse;
using ExamSystem.proffessor;



namespace ExamSystem
{

    class Program
    {



        static void ExamMode()
        {
            Console.WriteLine("\n\t\t=============================================================");
            Console.WriteLine("\t\t\t\tchoose the mode you want to enter\n\n \t\t\t\t  1- Professor   2- Student ");
            Console.WriteLine("\t\t=============================================================\n");

        }

        static void Main()
        {

            // Update Creating a Two Modes One For Prof And Anther For the Student //

            Professor professor1 = new(Guid.NewGuid().ToString().Substring(1, 8), "Ahmed Munir");
            Student student1 = new(Guid.NewGuid().ToString().Substring(1, 8), "Ahmed Munir");
            ExamSystem.Exam.Exam exam1 = null;
            int Student_Grade = 0;

            Console.WriteLine("\n\t\t\t\t===========  ============");
            Console.WriteLine("\t\t\t\t\t RunTime ");
            Console.WriteLine("\t\t\t\t===========  ============");
            ExamMode();
            int mode = Convert.ToInt32(Console.ReadLine());
            
            if (mode == 1)
            {

                Console.WriteLine("Welcome Professor : " + professor1.prof_Name);
                exam1 = professor1.ExamPreperation();
                ExamMode();
                mode = Convert.ToInt32(Console.ReadLine());
            }

            if (mode == 2 && exam1 == null)
            {
                Console.WriteLine("No Exam Created Yet , Please Wait For The Professor To Create An Exam");
                   ExamMode();
                mode = Convert.ToInt32(Console.ReadLine());
            }
             if (mode == 2 && exam1 != null)
            {
                Console.WriteLine("Welcome Student : " + student1.student_Name);
                Console.WriteLine($"Student Name : {student1.student_Name} with ID : {student1.student_id}  Datetime = {DateTime.Now}");
                Student_Grade = student1.solving_Exam(exam1);
            }

            else
            {
                Console.WriteLine("Invalid Mode");
                return;
            }


            Console.Write(value: $"Student Name : {student1.student_Name} with ID : {student1.student_id}  Grade : {Student_Grade} / {exam1.ExamGrades} \n");

        }

    }



}