using System;
using System.Collections.Generic;
using System.Text;

namespace Floor_Price_Calculator
{
  class Room
  {
    public int _length { get; private set; }
    public int _width { get; private set; }

    public Room(int length, int width)
    {
      this._length = length;
      this._width = width;
    }

    public int squareFootage()
    {
      return _length * _width;
    }
  }
}
