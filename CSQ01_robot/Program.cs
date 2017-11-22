using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 이동 반환

delegate void ControlDelegate();
delegate string GetControlDelegate(string input);

class Robot //콜백 
{    
    public void Dir(string input,GetControlDelegate getControl)
    {
        Console.WriteLine(" 조작한 방향: " + getControl(input));
    }
}
class Joystic
{
    public string Input(string input)
    {
        return input;
    }
    public void InputUpMoveForward()
    {
        Console.Write("앞으로 걷기,");
    }
    public  void InputUpEyeLitght()
    {
        Console.Write("눈에 불빛켜짐,");
    }

    public  void InputDownMoveBack()
    {
        Console.Write("뒤로 걷기,");
    }
    public  void InputDownRotHead()
    {
        Console.Write("머리가 돌아감,");
    }

    public  void InputWorkArm( )
    {
        Console.Write("팔을 휘저음.");   
    }

    public void Controller(string input)
    {
        Robot ctrl = new Robot();
        ctrl.Dir(input, new GetControlDelegate(this.Input));
    }
}

//delegate string GetControlDelegate(string input);

namespace CSQ01_robot
{    
    class Program
    {
        static void Main(string[] args)
        {
            Joystic joystic = new Joystic();
            ControlDelegate up = joystic.InputUpMoveForward;

            up += joystic.InputUpEyeLitght;
            up += joystic.InputWorkArm;

            joystic.Controller("up");
            up();

            Console.WriteLine();
            Console.WriteLine();

            ControlDelegate down = joystic.InputDownMoveBack;

            down += joystic.InputDownRotHead;
            down += joystic.InputWorkArm;

            joystic.Controller("down");
            down();
            
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
