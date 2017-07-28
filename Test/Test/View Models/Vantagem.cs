using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Test
{
   public class Vantagem
    {
        public string Nome { set; get; }
    }

    public class IndiceVantagens
    {
        #region ListaV
        public static ObservableCollection<Vantagem> ListaV = new ObservableCollection<Vantagem>
        {
            new Vantagem{Nome= "Vantagem 1" },
            new Vantagem{Nome= "Vantagem 2" },
            new Vantagem{Nome= "Vantagem 3" },
        };
        #endregion
    }

}
