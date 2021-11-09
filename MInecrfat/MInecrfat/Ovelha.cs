using System;
using System.Collections.Generic;
using System.Text;

namespace MInecrfat
{
    class Ovelha : Animais
    {
        string corLa;

        #region Construtor

        public Ovelha(bool estaVivo, string corLa) : base(estaVivo)
        {

            estaVivo = true;
            this.corLa = corLa;

        }


        #endregion


    }
}
