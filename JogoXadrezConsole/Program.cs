﻿using tabuleiro;
using System;

namespace JogoXadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Peca , new Posicao(0, 0));
            tab.colocarPeca(new Peca , new Posicao(1, 3));
            tab.colocarPeca(new Peca , new Posicao(2, 4));






            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}