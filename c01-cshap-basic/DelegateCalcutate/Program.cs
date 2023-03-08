Calculator cal = new Calculator();

double a = 7, b = 5;
Calculate calculate = new Calculate(cal.Add);

Console.WriteLine($"calculate(a, b) = {calculate(a, b)}");

calculate = cal.Sub;
Console.WriteLine($"calculate(a, b) = {calculate(a, b)}");

//Lambda Expression
calculate = new Calculate((a, b) => a*b);
Console.WriteLine($"calculate(a, b) = {calculate(a, b)}");

//Lambda Expression
calculate = (a, b) =>{
    return a/b;
};
Console.WriteLine($"calculate(a, b) = {calculate(a, b)}");