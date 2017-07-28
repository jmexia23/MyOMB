using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Test
{
   public class Vale
    {
        public string Entidade { get; set;}
        public string Data { get; set; }
        public double Valor { get; set; }

        public string Informação
        {
            get
            {
                return string.Format("{0} - {1} ", Entidade, Data);
            }
        }

    }

    public class IndiceVales
    {
        #region ProductList
        public static ObservableCollection<Vale> ListaV = new ObservableCollection<Vale>
        {
            new Vale { Entidade="OMB", Data="27/07/2017", Valor=50.00},
            new Vale { Entidade="OMB", Data="13/07/2017", Valor=100.00},
            new Vale { Entidade="OMB", Data="3/08/2017", Valor=9.99},
        };
        #endregion
    }
        
}
