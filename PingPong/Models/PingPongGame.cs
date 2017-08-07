using System.Collections.Generic;

namespace PingPong.Models
{
  public class PingPongGame
  {
    private int _number;
    private List<object> _numberList = new List<object>();

    public PingPongGame(int number)
    {
      _number = number;
    }
    public int GetNumber()
    {
      return _number;
    }

    public List<object> PingPong()
    {
      for (int i = 1; i <= _number; i++)
      {

        if (i % 15 == 0) //replace with pingpong if divisible by 15
        {
          _numberList.Add("pingpong");
        }
        else if (i % 3==0) //replace with ping if divisible by 3
        {
          _numberList.Add("ping");
        }
        else if (i % 5 == 0) //replace with pong if divisible by 5
        {
            _numberList.Add("pong");
        }

        else
        {
          _numberList.Add(i);
        }
      }
      return _numberList;
    }
  }
}
