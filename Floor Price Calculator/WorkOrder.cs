using System;
using System.Collections.Generic;
using System.Text;

namespace Floor_Price_Calculator
{
  class WorkOrder
  {
    public Room _room { get; }
    public Flooring _floor { get; private set; }
    public decimal _workCostPerSqFt = 1.53M;
    public decimal TotalCost { get; private set; }

    public WorkOrder(Room room, Flooring floor)
    {
      this._room = room;
      this._floor = floor;
    }

    public decimal GetCostOfWork()
    {
      return Math.Round(_room.squareFootage() * this._workCostPerSqFt, 2);
    }
    public decimal GetCostOfMaterials()
    {
      return Math.Round((_room.squareFootage() * _floor._pricePerSqFt), 2);
    }

    public decimal GetTotalCost()
    {
      this.TotalCost = Math.Round(this.GetCostOfMaterials() + this.GetCostOfWork(), 2);
      return this.TotalCost;
    }
  }
}
