using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Test
{
    public class Parceiro
    {
        public string Nome { set; get; }
        public string Descrição { set; get; }
    }
    public class IndiceParceiros
    {
        #region ListaP
        public static ObservableCollection<Parceiro> ListaP = new ObservableCollection<Parceiro>
        {
            new Parceiro{Nome= "Gináseio ForceX" , Descrição="10% em óculos de sol" },
            new Parceiro{Nome= "Vantagem 2", Descrição="Descrição de vantagem 2" },
           new Parceiro{Nome= "Vantagem 3", Descrição="Descrição de vantagem 3" },
        };
        #endregion
    }
}
