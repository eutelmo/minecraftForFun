using System;
using System.Collections.Generic;
using System.Text;

namespace MInecrfat
{
    class Alex : Player
    {

        public string camisola;

        #region construtor
        public Alex(string nome, float vida, int xP,string genero, string camisola) : base(nome, vida, xP,genero)
        {

            this.nome = nome;
            vida = 10.0f;
            xP = 0;
            camisola = "Verde";
            genero = "femenino";



        }

        #endregion

        #region methodos

        public void dropOvelha(Ovelha a)
        {

            Random rd = new Random();
            int valorDoDado = rd.Next(0, 3);

            if (valorDoDado == 3)
            {
                Console.WriteLine("deu carne e la");
            }

            if (valorDoDado == 2)
            {
                Console.WriteLine("deu carne");

            }
            else if (valorDoDado == 1)
            {
                Console.WriteLine("deu la");

            }
            else
            {
                Console.WriteLine("Nao deu nada");

            }


        }





        #endregion

    }
}
