using GameTop.Interface;

namespace GameTop
{
    public class JogoBOM
    {
        private readonly iJogador _jogadorA ;

        private readonly iJogador _jogadorB ;

        private readonly iJogador _jogadorC ;

        public JogoBOM(iJogador jogadorA, iJogador jogadorB, iJogador jogadorC)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
            _jogadorC = jogadorC;
        }

        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogadorA.Chuta());
            System.Console.WriteLine(_jogadorA.Corre());
            System.Console.WriteLine(_jogadorA.Passe());

            System.Console.WriteLine("\n PRÓXIMO JOGADOR \n");
            
            System.Console.WriteLine(_jogadorB.Chuta());
            System.Console.WriteLine(_jogadorB.Corre());
            System.Console.WriteLine(_jogadorB.Passe());

            System.Console.WriteLine("\n PRÓXIMO JOGADOR \n");
            
            System.Console.WriteLine(_jogadorC.Chuta());
            System.Console.WriteLine(_jogadorC.Corre());
            System.Console.WriteLine(_jogadorC.Passe());
        }
    }
}