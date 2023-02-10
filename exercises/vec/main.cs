using static System.Console;
class hwvec{
    static vec u = new vec(1, 2, 3);
    static vec v = new vec(4, 5, 6);

    static void Main(){
        u.print("The u vector is: ");
        v.print("The u vector is: ");

        WriteLine($"The sum of the two vectors are {u+v}");
        WriteLine($"The difference of the two vectors are {u-v}");
        WriteLine($"3 * u is: {3*u}");
        WriteLine($"u * 3 is: {u*3}");
        WriteLine($"-u is: {-u}");
        WriteLine($"u * v is: {u*v}");
        WriteLine($"u.dot(v) is: {u.dot(v)}");
        WriteLine($"u.cross(v) is: {u.cross(v)}");
        WriteLine($"v.cross(u) is: {v.cross(u)}");
    }
}