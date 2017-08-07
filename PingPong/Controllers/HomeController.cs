using Microsoft.AspNetCore.Mvc;
using PingPong.Models;
using System.Collections.Generic;
using System;

namespace PingPong.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/PingPongResult")]
    public ActionResult PingPongResult()
    {
      int userNumber = int.Parse(Request.Form["number"]);
      PingPongGame newGame = new PingPongGame(userNumber);

      return View(newGame);

    }
  }
}
