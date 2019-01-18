using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCS_220718_tut1.Model
{
    public class Element : IDataErrorInfo
    {
        public string UserInput { get; set; }

        public Element()
        {
            
        }

        public string this[string columnName]
        {
            get
            {

            }
        }

        public string Error { get; }
    }
}
