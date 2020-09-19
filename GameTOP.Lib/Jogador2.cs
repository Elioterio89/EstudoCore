using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chutar()
        {
           return "Neymar esta Chutando \n";
        }

        public string Correr()
        {
            return "Neymar esta Correndo \n";
        }

        public string Passar()
        {
            return "Neymar esta Passando \n";
        }
    }
}