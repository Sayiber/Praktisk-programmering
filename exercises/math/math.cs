using static System.Console;
using static System.Math;
class math{
    static void Main(){
    
        double sqrt2 = Sqrt(2.0);
        double exppi = Exp(System.Math.PI);
        double piexp = Pow(PI,E);
        WriteLine($"sqrt(2) = {sqrt2}");
        WriteLine($"exppi = {exppi}");
        WriteLine($"piexp = {piexp}");
        WriteLine($"sqrt2*sqrt2 = {sqrt2*sqrt2} (should be equal 2)");
        WriteLine($"ln(exppi) = {Log(exppi)} (should be equal {PI})");
        WriteLine($"log10(piexp) = {Log(piexp)/Log(PI)} (should be equal {E})");
    }
}