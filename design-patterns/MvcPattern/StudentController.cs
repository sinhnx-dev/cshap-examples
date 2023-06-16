public class StudentController
{
  private Student model;
  private StudentView view;

  public StudentController(Student model, StudentView view)
  {
    this.model = model;
    this.view = view;
  }

  public string StudentName
  {
    set { model.Name = value; }
    get { return model.Name; }
  }
  public string StudentRollNo
  {
    set { model.RollNo = value; }
    get { return model.RollNo; }
  }

  public void UpdateView()
  {
    view.PrintStudentDetails(model);
  }
}