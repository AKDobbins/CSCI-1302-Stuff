using System;

// A line that starts with two forward slashes is considered a comment.
// A comment line starts with a space after the slashes then capitalized letter.
// A class name follows Pascal Casing convention.
class Program {
  // A method name follows Pascal Casing convention.
  public static void Main () {
    // References (pointers, names), objects, assignment operator, and equality operator.
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
  }
}