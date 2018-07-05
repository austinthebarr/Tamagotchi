using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamagotchiController : Controller
  {
    [HttpGet("/Tamagotchi/add")]
    public ActionResult Add()
    {
      return View();
    }
    [HttpGet("/Tamagotchi/status")]
    public ActionResult Status()
    {
      return View();
    }
    [HttpPost("/Tamagotchi/status")]
    public ActionResult NewPet(string newpet)
    {
      Pets.globalPet.SetName(newpet);
      return View("status", Pets.globalPet);
    }

    [HttpPost("/Tamagotchi/feed")]
    public ActionResult FeedPet()
    {
      Pets.globalPet.Feed();
      if(Pets.globalPet.GetFood() <= 0 || Pets.globalPet.GetAttention() <= 0 || Pets.globalPet.GetRest() <= 0 || Pets.globalPet.GetFood() >= 100 || Pets.globalPet.GetAttention() >= 100 || Pets.globalPet.GetRest() >= 100 )
      {
        Pets.globalPet.Reset();
        return View("gameover");
      }
      else
      {
        return View("status", Pets.globalPet);
      }
    }

    [HttpPost("/Tamagotchi/play")]
    public ActionResult PlayPet()
    {
      Pets.globalPet.Play();
      if(Pets.globalPet.GetFood() <= 0 || Pets.globalPet.GetAttention() <= 0 || Pets.globalPet.GetRest() <= 0 || Pets.globalPet.GetFood() >= 100 || Pets.globalPet.GetAttention() >= 100 || Pets.globalPet.GetRest() >= 100 )
      {
        Pets.globalPet.Reset();
        return View("gameover");
      }
      else
      {
        return View("status", Pets.globalPet);
      }
    }

    [HttpPost("/Tamagotchi/sleep")]
    public ActionResult SleepPet()
    {
      Pets.globalPet.Sleep();
      if(Pets.globalPet.GetFood() <= 0 || Pets.globalPet.GetAttention() <= 0 || Pets.globalPet.GetRest() <= 0 || Pets.globalPet.GetFood() >= 100 || Pets.globalPet.GetAttention() >= 100 || Pets.globalPet.GetRest() >= 100 )
      {
        Pets.globalPet.Reset();
        return View("gameover");
      }
      else
      {
        return View("status", Pets.globalPet);
      }
    }
  }
}
