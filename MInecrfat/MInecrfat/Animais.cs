using System;
using System.Collections.Generic;
using System.Text;

namespace MInecrfat
{
    class Animais
    {
        bool estaVivo;
        

        #region construtor

        public Animais(bool estaVivo)
        {

            estaVivo = true;
            

        }

        #endregion




        #region methodos

       

        public void drop(Steve s)
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
