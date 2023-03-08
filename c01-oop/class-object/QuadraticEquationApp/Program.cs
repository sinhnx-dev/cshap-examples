try
{
    // create object qe instance of class QuadraticEquation
    QuadraticEquation qe = new QuadraticEquation(1, 2, 1);

    double[] x = qe.Resolve();
    switch (x.Length)
    {
        case 0:
            Console.WriteLine("Phuong trinh vo nghiem");
            break;
        case 1:
            Console.WriteLine($"Phuong trinh co 1 nghiem x = {x[0]}");
            break;
        case 2:
            Console.WriteLine($"Phuong trinh co 2 nghiem x1={x[0]}, x2={x[1]}");
            break;
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}