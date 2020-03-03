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

  public double Distance(Point other)
  {
        if (other == null)
            throw new PointNullException();
   int xDiff = this._xCoordinate - other._xCoordinate;
   int yDiff = this._yCoordinate - other._yCoordinate;
   return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
  }
  public double Distance(int otherX, int otherY)
  {
   return this.Distance(new Point(otherX, otherY));
  }
}