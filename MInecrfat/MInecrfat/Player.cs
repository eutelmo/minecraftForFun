using System;
using System.Collections.Generic;
using System.Text;

namespace MInecrfat
{
    class Player
    {

        public string nome;
        public float vida;
        public int xP;
        public string genero;


        #region Construtor

        public Player(string nome, float vida, int xP,string genero)
        {
            this.genero = genero;
            this.nome = nome;
            this.vida = vida;
            this.xP = xP;

        }

        #endregion


        #region Methodos

        public void lutar(Alex a)
        {





        }

        #endregion

    }
}
