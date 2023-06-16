public class StudentView
{
  public void PrintStudentDetails(Student student)
  {
    System.Console.WriteLine("Student:\n\tName: {0}\n\tRoll No: {1}", student.Name, student.RollNo);
  }
}