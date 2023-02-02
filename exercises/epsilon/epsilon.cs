using static System.Console;
using static System.Math;

class epsilon{
    static double x;
    static float y;

    static void Main(){
        exercise1();
        exercise2();
        exercise3();
    }

    static void exercise1(){
        WriteLine("Exercise 1");
        int i = 0;
        while(i+1>i) i++;
        WriteLine($"My max int is {i}");
        WriteLine($"The max int is {int.MaxValue}\n");
        
        int ni = 0;
        while(ni-1<ni) ni--;
        WriteLine($"My min int is {ni}");
        WriteLine($"The min int is {int.MinValue}");
    }

    static void exercise2(){
        WriteLine("\nExercise 2");
        x = 1;
        while(x+1 != 1) x/=2;
        x*=2;

        y = 1F;
        while ((float)(1F + y) != 1F ) y /= 2F;
        y *= 2F;

        WriteLine($"x is {x} and should be {System.Math.Pow(2,-52)}");
        WriteLine($"x/2 is {x/2+1}");
        WriteLine($"y is {y} and should be {System.Math.Pow(2,-23)}");
        WriteLine($"y/2 is {y/2F+1F}");
    }

    static void exercise3(){
        WriteLine("\nExercise 3");
        // float tiny = y/2;
        // sumA=1+tiny+tiny+...+tiny;
        // sumB=tiny+tiny+...+tiny+1;
        // sumA-1 != sumB-1


        int n=(int)1e6;
        double epsilon=Pow(2,-52);
        double tiny=epsilon/2;
        double sumA=0,sumB=0;

        sumA+=1; 
        for(int i=0;i<n;i++){sumA+=tiny;}
        WriteLine($"sumA-1 = {sumA-1:e} should be {n*tiny:e}");

        for(int i=0;i<n;i++){sumB+=tiny;} 
        sumB+=1;
        WriteLine($"sumB-1 = {sumB-1:e} should be {n*tiny:e}");
        
        //WriteLine();
    }
}

