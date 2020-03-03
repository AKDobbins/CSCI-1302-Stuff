using System;

class Point
{
  // A field name follows the Camel Casing convention with/without being prefixed with underscore.
  private int _xCoordinate, _yCoordinate;
  
  public Point()
  {
    _xCoordinate = 0;
    _yCoordinate = 0;
  }
  
  // A parameter follows the Camel Casing convention.
  public Point(int xCoord, int yCoord)
  {
    _xCoordinate = xCoord;
    _yCoordinate = yCoord;
  }

  public void Show()
  {
    // This line uses composite format string.
    Console.Write("({0},{1}) ", _xCoordinate, _yCoordinate);    
    // This line uses string interpolation. The $ character identifies a string as interpolated.
    Console.WriteLine($"({_xCoordinate},{_yCoordinate})");    
  }
}