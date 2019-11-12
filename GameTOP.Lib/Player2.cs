using GameTOP.Interface; 

namespace GameTOP.Lib
{
    public class Player2 : I_Player
    {
        public string Kick()
        {
            return "Maradona is Kicking \n";
        }

        public string Pass()
        {
            return "Maradona is Passing \n";
        }

        public string Run()
        {
            return "Maradona is Running \n";
        }
    }
}