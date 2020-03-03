using System;
class Path 
{
 public Point[] _allPoints;
 private int _nextPlace;
 public Path(int size)
 {
  _allPoints = new Point[size];
 }
 public void Add(int x, int y)
 {
   _allPoints[_nextPlace] = new Point(x, y);
   _nextPlace++;
 }
 public double Length()
 {
   double length = 0;
   for (int i =0; i < _nextPlace - 1 ; i++)
   {
    length += _allPoints[i].Distance(_allPoints[i+1]);
   }
   return length;
 }
    // This method compares between two paths by their length
    public bool Compare(Path other)
    {
        double l1 = this.Length();
        double l2 = other.Length();
        return Math.Abs(l1 - l2) < 0.01;
    }
}