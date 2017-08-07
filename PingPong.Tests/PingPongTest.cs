using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPong.Models;
using System;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void PingPong_CountTo2_ListOfNumbers()
    {
      //Arrange
      PingPongGame testPingPong = new PingPongGame(2);
      List<object> expected = new List<object>(){1,2};
      //Act
      List<object> actual = testPingPong.PingPong();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PingPong_Replace3ByPing_ListOfNumbers()
    {
      PingPongGame testPingPong = new PingPongGame(4);
      List<object> expected = new List<object>(){1,2,"ping",4};
      List<object> actual = testPingPong.PingPong();
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void PingPong_Replace5ByPong_ListOfObject()
    {
      //Arrange
      PingPongGame testPingPong = new PingPongGame(6);
      List<object> expected = new List<object>(){1,2, "ping", 4, "pong", "ping"};
      //Act
      List<object> actual = testPingPong.PingPong();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void PingPong_Replace15ByPingPong_ListOfObject()
    {
      //Arrange
      PingPongGame testPingPong = new PingPongGame(15);
      List<object> expected = new List<object>(){1,2, "ping", 4, "pong", "ping",7,8,"ping","pong",11,"ping",13,14,"pingpong"};
      //Act
      List<object> actual = testPingPong.PingPong();
      //Assert
      CollectionAssert.AreEqual(expected,actual);
    }

  }
}
