using static System.Console;
class hwvec{
    vec u = new vec(1, 2, 3);
    vec v = new vec(4, 5, 6);

    static void Main(){
        u.print("The u vector is:");
        v.print("The u vector is:");

        PrintLine($"The sum of the two vectors are {u+v}");
        PrintLine($"The difference of the two vectors are {u-v}");
        PrintLine($"3 * u is: {3*u}");
        PrintLine($"u * 3 is: {u*3}");

    }
}