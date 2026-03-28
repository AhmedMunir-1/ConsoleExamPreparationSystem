
                                                      # ConsoleExamPreparationSystem
                                                  --------------------------------------

                                      # Object-Oriented Design (OOD) for Exam Preparation System

## Overview
C# console app for exam creation (Professor) and solving (Student). Core entities:
- **Question** (abstract/base): Common properties (ID, type, text, level, grade).
- **True_False_Question**, **ChoiceQuestion**, **MultiChoiceQuestion**: Specialized questions.
- **Exam**: Composes lists of all question types + ID, total grades.
- **Professor**: Creates Exam via interactive input.
- **Student**: Solves Exam, calculates grade.
- **Program**: Entry point, mode selection.

## Key Relationships
- **Composition**: Exam contains `List<True_False_Question>`, `List<ChoiceQuestion>`, `List<MultiChoiceQuestion>`.
- **Usage**: Professor.ExamPreperation() → Exam
- **Usage**: Student.solving_Exam(Exam) → int grade
- **Inheritance**: Question subtypes extend Question functionality.



**Notes:**
- Enums: `enQuestionType` (TrueFalse=1, SingleChoice=2, MultiChoice=3), `enQuestionLevel` (Easy=1, Medium=2, Hard=3).
- Namespaces: ExamSystem.* (Question.*, Exam, proffessor, student).
- Improvements: Abstract Question class, polymorphism for printing/solving, input validation.


*** Class Diagram  ***
                            ----> Are on image Diagrams Files
*** Sequance Diagram ***      

Open OOD.md in VSCode Markdown preview to render diagrams interactively.
