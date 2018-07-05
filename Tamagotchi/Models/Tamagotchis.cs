using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pets
  {
    private string _name;
    private int _food;
    private int _attention;
    private int _rest;

    public static Pets globalPet = new Pets();

    public Pets()
    {
      _food = 75;
      _attention = 75;
      _rest = 75;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetName()
    {
      return _name;
    }

    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetFood()
    {
      return _food;
    }

    public void SetAttention(int newAttention)
    {
      _attention = newAttention;
    }
    public int GetAttention()
    {
      return _attention;
    }

    public void SetRest(int newRest)
    {
      _rest = newRest;
    }
    public int GetRest()
    {
      return _rest;
    }

    public void Feed()
    {
      _food += 10;
      _attention -= 7;
      _rest -= 7;
    }

    public void Play()
    {
      _food -= 6;
      _attention += 9;
      _rest -= 8;
    }

    public void Sleep()
    {
      _food -= 7;
      _attention -= 5;
      _rest += 11;
    }

    public void Reset()
    {
        _food = 75;
        _attention = 75;
        _rest = 75;
    }
  }
}
