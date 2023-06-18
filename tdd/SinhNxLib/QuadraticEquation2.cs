namespace SinhNxLib;
public class QuadraticEquation2
{
  public double A { set; get; }
  public double B { set; get; }
  public double C { set; get; }
  public double[] SolveEquation()
  {
    double delta = B * B - 4 * A * C;
    if (delta < 0)
    {
      return new double[0];
    }
    else if (delta == 0)
    {
      double[] rs = new double[1];
      rs[0] = -B / (2 * A);
      return rs;
    }
    else
    {
      double[] rs = new double[2];
      rs[0] = (-B + Math.Sqrt(delta)) / (2 * A);
      rs[1] = (-B - Math.Sqrt(delta)) / (2 * A);
      return rs;
    }
  }
}