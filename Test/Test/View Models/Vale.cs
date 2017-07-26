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
        public int Valor { get; set; }
    }

    public class Data
    {
        #region ProductList
        public static ObservableCollection<Vale> ProductList = new ObservableCollection<Vale>
        {
            new Vale { Entidade="OMB", Data="27/07/2017", Valor=50},
            new Vale { Entidade="OMB", Data="13/07/2017", Valor=100},
            new Vale { Entidade="OMB", Data="3/08/2017", Valor=10},
        };
        #endregion
    }
        
}
