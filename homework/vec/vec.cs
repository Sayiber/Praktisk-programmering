using static System.Console;
public class vec{
    public double x, y, z;

    public vec(){
        x=y=z=0;
    }
    public vec(double a, double b, double c){
        x = a;
        y = b;
        z = c;
    }
    public void print(string s){
        Write(s);
        WriteLine($"({x} {y} {z})");
    }
    public void print(){
        this.print("");
    }

    public override string ToString()
    {
        return $"({x} {y} {z})";
    }

    public static vec operator*(vec v, double c){
        return new vec(c*v.x, c*v.y, c*v.z);
    }
    public static vec operator*(double c, vec v){
        return v*c;
    }
    public static double operator*(vec u, vec v){
        return u.dot(v);
    }
    public static vec operator+(vec u, vec v){
        return new vec(u.x+v.x, u.y+v.y, u.z+v.z);
    }
    public static vec operator-(vec u, vec v){
        return new vec(u.x-v.x, u.y-v.y, u.z-v.z);
    }
    public static vec operator-(vec u){
        return new vec(-u.x, -u.y, -u.z);
    }
    
    public double dot(vec other){
        return this.x*other.x + this.y*other.y + this.z*other.z;
    }
    public double dot(vec u, vec v){
        return u.x*v.x + u.y*v.y + u.z*v.z;
    }
    public vec cross(vec other){
        return new vec(this.y*other.z - this.z*other.y, this.z*other.x - this.x*other.z, this.x*other.y - this.y*other.x);
    }
    public vec cross(vec u, vec v){
        return new vec(u.y*v.z - u.z*v.y, u.z*v.x - u.x*v.z, u.x*v.y - u.y*v.x);
    }


}