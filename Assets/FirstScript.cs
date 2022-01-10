using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    // string say = "Hello world";
    // string name = "rm";
    // // const string say = "Hello world const";
    // Debug.Log(say + ":" + name); // Hello world:rm
    // Debug.Log(string.Format("{0}:{1}", say, name)); // Hello world:rm

    // int x = 100;
    // string y = "200";
    // Debug.Log(x + y); // 100200

    // string characterType = "player";
    // switch (characterType)
    // {
    //   case "player":
    //     Debug.Log("P");
    //     break;
    //   case "enemy":
    //     Debug.Log("E");
    //     break;
    //   case "friend":
    //     Debug.Log("F");
    //     break;
    //   default:
    //     Debug.Log("D");
    //     break;
    // }

    // int x = 0;
    // while (x <= 10)
    // {
    //   if (x == 3)
    //   {
    //     x++;
    //     continue;
    //   }
    //   if (x > 7)
    //   {
    //     break;
    //   }
    //   Debug.Log(x);
    //   x++;
    // }
    // for (int y = 0; y <= 10; y++)
    // {
    //   Debug.Log(y);
    // }

    // int[] xList = new int[3];
    // xList[0] = 1;
    // xList[1] = 2;
    // xList[2] = -3;

    // int[] yList = new int[3] { 1, 2, -3 };
    // Debug.Log(xList.Length + yList.Length);

    // List<int> numbers = new List<int>() { 1, 2, -3 };
    // Debug.Log(numbers[1]);
    // // change
    // numbers[1] = 4;
    // Debug.Log(numbers[1]);
    // // add
    // numbers.Add(5);
    // Debug.Log(numbers[3]);
    // // count
    // Debug.Log(numbers.Count);
    // // remove
    // // numbers.RemoveAt(1);
    // // numbers.Remove(-3);
    // // Debug.Log(numbers);

    // List<int> numbers2 = new List<int>();
    // for (int i = 0; i < 100; i++)
    // {
    //   numbers2.Add(i);
    // }
    // Debug.Log(numbers2.Count);
    // foreach (int num in numbers2)
    // {
    //   if (num % 10 == 0)
    //   {
    //     Debug.Log(num);
    //   }
    // }

    // Log("1");
    // Log("a");
    // Debug.Log(LogMsg("?"));

    Debug.Log(GetNum(1, 50));
  }

  // Update is called once per frame
  void Update()
  {
    // Debug.Log("Update");
  }

  // Original Function
  void Log(string log)
  {
    Debug.Log(log);
  }
  string LogMsg(string log)
  {
    return "Str :" + log;
  }

  int GetNum(int x, int y)
  {
    int sum = 0;
    for (; x <= y; x++)
    {
      sum += x;
    }
    return sum;
  }
}
