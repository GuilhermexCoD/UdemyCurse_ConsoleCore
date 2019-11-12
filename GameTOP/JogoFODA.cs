using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly I_Player _interfacePlayer1;
        private readonly I_Player _interfacePlayer2;

        public JogoFODA(I_Player interfacePlayer1,I_Player interfacePlayer2)
        {
            _interfacePlayer1 = interfacePlayer1;
            _interfacePlayer2 = interfacePlayer2;
        }
        public void InitializeGame()
        {
            System.Console.Write(_interfacePlayer1.Run());
            System.Console.Write(_interfacePlayer1.Pass());
            System.Console.Write(_interfacePlayer1.Kick());

            System.Console.Write("Proximo jogador \n");

            System.Console.Write(_interfacePlayer2.Run());
            System.Console.Write(_interfacePlayer2.Pass());
            System.Console.Write(_interfacePlayer2.Kick());
        }
    }
}