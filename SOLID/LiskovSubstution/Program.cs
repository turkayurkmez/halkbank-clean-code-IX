// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
/*
 * Liskov's notion of a behavioural subtype defines a notion of substitutability for objects; that is, if S is a subtype of T, then objects of type T in a program may be replaced with objects of type S without altering any of the desirable properties of that program (e.g. correctness).
 * 
 * T: Gitar
 * S: ElektroGitar
 * 
 *
 *
public class Gitarist
{
    public void Cal(Gitar gitar)
    {

    }

    public Gitar CaldigiGitar()
    {
       return new ElektroGitar();
    }


}
 *
 *
 * 
 */

Rectangle rectangle = new Rectangle();
rectangle.Width = 10;
rectangle.Height = 5;

Console.WriteLine(rectangle.GetArea());

//Square square = new Square();
//square.Width = 10;
//Console.WriteLine(square.GetArea());

var dortgen = Geometry.GetRectangle(5,20);


//dortgen.Width = 8;
//dortgen.Height = 5;

Console.WriteLine(dortgen.GetArea());
