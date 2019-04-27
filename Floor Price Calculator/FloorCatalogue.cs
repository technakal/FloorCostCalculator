using System;
using System.Collections.Generic;
using System.Text;

namespace Floor_Price_Calculator
{
  class FloorCatalogue
  {
    public List<Flooring> _availableFloors { get; }

    public FloorCatalogue(List<Flooring> options)
    {
      this._availableFloors = options;
    }

    public void DisplayFloorOptions()
    {
      int counter = 1;
      foreach(Flooring floor in this._availableFloors)
      {
        Console.WriteLine($"{counter}.  {floor._type}, {floor._name}, ${floor._pricePerSqFt}");
        counter++;
      }
    }
  }
}
