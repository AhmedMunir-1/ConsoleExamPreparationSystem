# Fixing CS0118: 'Exam' is a namespace but used like a type

## Steps:
- [x] Step 1: Edit Professor.cs to use fully qualified ExamSystem.Exam.Exam in ExamPreperation return statement.
- [x] Step 2: Run `dotnet build` to verify fix. (Fixed additional CS0118 in Student.cs, Professor.cs method return type, Program.cs variable. Now builds successfully with 1 warning.)
- [x] Step 3: Tested successfully (CS0118 fixed).

All steps complete. CS0118 fixed across Program.cs, Professor.cs, and Student.cs by using fully qualified ExamSystem.Exam.Exam where namespace conflict occurred.
