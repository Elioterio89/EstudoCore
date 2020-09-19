using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {


        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public string Correr()
        {
            return $"{_Nome} esta correndo! \n";
        }
        public string Chutar()
        {
            return $"{_Nome} esta chutando!\n";
        }
        public string Passar()
        {
            return $"{_Nome} esta passando!\n";
        }

    }
}