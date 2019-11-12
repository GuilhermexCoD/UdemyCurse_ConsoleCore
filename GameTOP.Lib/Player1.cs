using GameTOP.Interface; 

namespace GameTOP.Lib
{
    public class Player1 : I_Player
    {

        public readonly string _name;

        public Player1(string name)
        {
            _name = name;
        }
        public string Kick()
        {
            return ($"{_name} is Kicking\n");
        }

        public string Run()
        {
            return ($"{_name} is Runing\n");
        }

        public string Pass()
        {
            return ($"{_name} is Passing\n");
        }
    }
}