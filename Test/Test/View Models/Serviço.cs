using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Test
{
     public class Serviço
    {
        public string Nome { set; get; }

    }

    public class IndiceServiços
    {
        #region ListaS
        public static ObservableCollection<Serviço> ListaS = new ObservableCollection<Serviço>
        {
            new Serviço {Nome= "Seguro Protecção óculos" },
            new Serviço {Nome= "Entrega ao domicílio" },
            new Serviço {Nome= "Lentes TCR" },
        };
        #endregion
    }
}
