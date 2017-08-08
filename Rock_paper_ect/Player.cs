using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_ect
{
    abstract class Player
    {
        public string name;
        public int score;
        public string gestureAnswer;


        public Random random = new Random();

        public Player()
        {

        }
        public abstract void ChooseGesture();
        public void GestureNumberTrans(string GestureNumber)
        {
            switch (GestureNumber)
            {
                case "1":
                    gestureAnswer = "rock";
                    break;
                case "2":
                    gestureAnswer = "paper";
                    break;
                case "3":
                    gestureAnswer = "scissors";
                    break;
                case "4":
                    gestureAnswer = "lizard";
                    break;
                case "5":
                    gestureAnswer = "spock";
                    break;
                default:
                    Console.WriteLine("Please try again");
                    ChooseGesture();
                    return;
                    
            }
            
        }

    }

}
