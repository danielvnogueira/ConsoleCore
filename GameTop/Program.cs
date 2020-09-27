using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoBOM(
                new Jogador2(),
                new Jogador1(),
                new Jogador3()
                );
            jogo.IniciarJogo();
        }
    }

}

