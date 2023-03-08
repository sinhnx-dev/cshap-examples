delegate double Calculate(double a, double b);

public class Calculator{
    public double Add(double a, double b){
        return a + b;
    }
    public double Sub(double a, double b){
        return a - b;
    }
}