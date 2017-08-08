using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_ect
{
    class Computer : Player
    {
       

        public Computer()
        {
            name = "RoboCop";
            score = 0; 

        }
        
        public override void ChooseGesture()
        {   
          gestureAnswer = random.Next(1, 6).ToString();
            GestureNumberTrans(gestureAnswer);
            Console.WriteLine($"{name} Choose {gestureAnswer}");

        }

    }
}
