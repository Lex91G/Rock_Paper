using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_ect
{
    class Human : Player
    {
        public Human()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            score = 0;
        }
        public override void ChooseGesture()
        {
            Console.WriteLine( $"{name} Pick a hand gesture \n 1 = Rock \n 2 = Paper \n 3 = Scissors \n 4 = Lizard \n 5 = Spock \n 6 = Exit");
            string gestureAnswer = Console.ReadLine();
            GestureNumberTrans(gestureAnswer);


        }
    }
}

