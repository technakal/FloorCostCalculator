using System;
using System.Collections.Generic;

namespace Floor_Price_Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Helper helper = new Helper();

      // Create catalogue of available flooring options

      FloorCatalogue catalogue = new FloorCatalogue(new List<Flooring>()
      {
        new Flooring("plank", "Weathered Oak", 4.95M),
        new Flooring("tile", "Seashell White", 6.20M),
        new Flooring("carpet", "Cream", 3.44M)
      });

      int length = 0;
      int width = 0;
      int floorSelection = 0;
      Flooring floor = null;

      Console.WriteLine("*****************************************");
      Console.WriteLine();
      Console.WriteLine("Welcome to the Work Order Cost Calculator");
      Console.WriteLine();
      Console.WriteLine("*****************************************");
      Console.WriteLine();

      // Create room
      Console.WriteLine("First up, we need to define the dimensions of the room you're addressing.");
      Console.WriteLine("We'll need the length and width from you.");

      while (length == 0)
      {
        Console.WriteLine("Enter the length of the room.");
        try
        {
          length = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
          Console.WriteLine("Invalid entry. Please enter a whole number.");
          continue;
        }
      }

      Console.WriteLine();

      while (width == 0)
      {
        Console.WriteLine("Enter the width of the room.");
        try
        {
          width = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
          Console.WriteLine("Invalid entry. Please enter a whole number.");
          continue;
        }
      }

      Room room = new Room(length, width);
      helper.AddSpace();

      // Create flooring
      Console.WriteLine("Next, we'll need to pick a type of flooring.");
      Console.WriteLine("Here are the floors we currently have available.");
      catalogue.DisplayFloorOptions();
      Console.WriteLine("What is the price per square foot of the flooring you selected?");

      while (floorSelection == 0)
      {
        Console.WriteLine("Enter the number corresponding to the flooring you want.");
        try
        {
          floorSelection = Convert.ToInt32(Console.ReadLine());
          floor = catalogue._availableFloors[floorSelection - 1];
        }
        catch(FormatException)
        {
          Console.WriteLine("Invalid selection. Please use the number corresponding to the floor you like.");
          continue;
        }
        catch (ArgumentOutOfRangeException)
        {
          Console.WriteLine("Invalid entry. Please select one of the available floors.");
          floorSelection = 0;
          continue;
        }
      }

      floor = catalogue._availableFloors[floorSelection - 1];

      helper.AddSpace();

      // Create work order
      WorkOrder order1 = new WorkOrder(room, floor);

      // Return cost
      Console.WriteLine();
      Console.WriteLine($"The dimensions of the room are {room._length} × {room._width}.");
      Console.WriteLine($"The square footage of the room is {room.squareFootage()}.");
      Console.WriteLine($"The cost of the {floor._name} {floor._type} is ${floor._pricePerSqFt} per square foot.");
      Console.WriteLine($"The cost of flooring materials is ${order1.GetCostOfMaterials()}.");
      Console.WriteLine($"The cost of labor for installing the flooring is ${order1.GetCostOfWork()}.");
      Console.WriteLine($"The total cost of the job is ${order1.GetTotalCost()}.");
    }
  }
}
