using System;

// A line that starts with two forward slashes is considered a comment.
// A comment line starts with a space after the slashes then capitalized letter.
// A class name follows Pascal Casing convention.
class Program {
  // A method name follows Pascal Casing convention.
  public static void Main () {
    Point p1;
    p1 = new Point();
    Point p2 = new Point();
    Point p3 = new Point(3, 7);
    Point p4;
    Point p5 = new Point(3, 7);
    p4 = p3;
    p1.Show();
    p2.Show();
    Console.WriteLine(p1 == p2);
    p1 = p4;
    p4.Show();
    p1.Show();
    Console.WriteLine(p1 == p2);
    Console.WriteLine(p1 == p4);
    Console.WriteLine(p5 == p4);

    Console.WriteLine(p1.Distance(p2));
    Console.WriteLine(p1.Distance(new Point(4,6)));
    Console.WriteLine(p1.Distance(4,6));


    Path pt = new Path(5);
    pt.Add(2,3);
    pt.Add(4,7);
    pt.Add(1,8);
    Console.WriteLine($"{pt.Length():F2}");
    Path pt2 = new Path(5);
    pt2.Add(2, 3);
    pt2.Add(4, 7);
    pt2.Add(1, 8);
    Console.WriteLine($"{pt2.Length():F2}");

   Console.WriteLine(pt.Compare(pt2));



    }
}