using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Zico estas pateando";
        }

        public string Corre()
        {
            return "Zico estas corriendo";
        }

        public string Passe()
        {
            return "Zico estas pasando";
        }
    }
}