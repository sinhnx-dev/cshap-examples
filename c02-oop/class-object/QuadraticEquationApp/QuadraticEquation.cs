public class QuadraticEquation{
    // field
    private double a;
    //property
    public double A {
        set{
            if(value == 0){
                throw new Exception("a can't set to 0.");
            } 
            a = value; }
        get{ return a; }
    }
    //property
    public double B {set; get;}
    //property
    public double C {set; get;}

    //method
    public double[] Resolve(){
        // code here
        double delta = B*B - 4*a*C;
        if(delta == 0){
            return new double[]{-B/(2*A)};
        } else if(delta > 0) {
            return new double[]{(-B + Math.Sqrt(delta))/2/A,(-B - Math.Sqrt(delta))/2/A};
        }
        return new double[0];
    }

    //constructor
    public QuadraticEquation(double a, double b, double c){
        if(a == 0){
            throw new Exception("a can't set to 0.");
        }
        this.a = a;
        B = b;
        C = c;
    }
}