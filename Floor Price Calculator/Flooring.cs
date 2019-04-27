using System;
using System.Collections.Generic;
using System.Text;

namespace Floor_Price_Calculator
{
  class Flooring
  {
    public string _type { get; private set; }
    public string _name { get; }
    public decimal _pricePerSqFt { get; private set; }

    public Flooring(string type, string name, decimal pricePerSqFt)
    {
      this._type = type;
      this._name = name;
      this._pricePerSqFt = pricePerSqFt;
    }
  }
}
