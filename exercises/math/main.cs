using static System.Console;
using static System.Math;
//using static sfuns;
class math{
    static void Main(){
        exercise1();
        exercise2();
        exercise3();
    }
    static void exercise1(){
        WriteLine($"Exercise 1");
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
    static void exercise2(){
        WriteLine($"\nExercise 2");
        WriteLine($"gamma(1)={sfuns.gamma(1)}");
        WriteLine($"gamma(2)={sfuns.gamma(2)}");
        WriteLine($"gamma(3)={sfuns.gamma(3)}");
        WriteLine($"gamma(10)={sfuns.gamma(10)}");
    }

    static void exercise3(){
        WriteLine($"\nExercise 3");
        WriteLine($"lngamma(1) = {sfuns.lngamma(1)}");
        WriteLine($"lngamma(2) = {sfuns.lngamma(2)}");
        WriteLine($"lngamma(3) = {sfuns.lngamma(3)}");
        WriteLine($"lngamma(10) = {sfuns.lngamma(10)}");
        WriteLine($"Then we can get");
        WriteLine($"Exp(lngamma(1)) = {Exp(sfuns.lngamma(1))}");
        WriteLine($"Exp(lngamma(2)) = {Exp(sfuns.lngamma(2))}");
        WriteLine($"Exp(lngamma(3)) = {Exp(sfuns.lngamma(3))}");
        WriteLine($"Exp(lngamma(10)) = {Exp(sfuns.lngamma(10))}");

    }
}