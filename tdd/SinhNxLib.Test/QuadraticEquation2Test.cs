namespace SinhNxLib.Test;

public class QuadraticEquation2Test
{
  [Fact]
  public void SolveEquationTest0()
  {
    QuadraticEquation2 qe2 = new QuadraticEquation2();
    qe2.A = 1;
    qe2.B = 1;
    qe2.C = 4;
    double[] expected = { };
    double[] result = qe2.SolveEquation();
    Assert.Equal(result, expected);
  }
  [Fact]
  public void SolveEquationTest1()
  {
    QuadraticEquation2 qe2 = new QuadraticEquation2();
    qe2.A = 1;
    qe2.B = 2;
    qe2.C = 1;

    double[] expected = { -1 };
    double[] result = qe2.SolveEquation();
    Assert.Equal<double[]>(expected, result);
  }
  [Theory]
  [InlineData(1, 4, 3, new double[] { -1, -3 })]
  [InlineData(1, -4, 3, new double[] { 1, 3 })]
  [InlineData(1, -10, 9, new double[] { 1, 9 })]
  [InlineData(1, -20, 19, new double[] { 1, 19 })]
  public void SolveEquationTest2(double a, double b, double c, double[] expected)
  {
    QuadraticEquation2 qe2 = new QuadraticEquation2();
    qe2.A = a;
    qe2.B = b;
    qe2.C = c;

    double[] result = qe2.SolveEquation();
    Array.Sort(expected);
    Array.Sort(result);
    Assert.Equal<double[]>(expected, result);
  }
}