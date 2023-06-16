public class Program
{
  public static void Main(string[] args)
  {
    //fetch student record based on his roll no from the database
    Student model = RetriveStudentFromDatabase();

    //Create a view : to write student details on console
    StudentView view = new StudentView();

    StudentController controller = new StudentController(model, view);

    controller.UpdateView();

    controller.StudentName = "John";
    controller.UpdateView();
  }

  private static Student RetriveStudentFromDatabase()
  {
    Student student = new Student();
    student.Name = "Robert";
    student.RollNo = "10";
    return student;
  }
}