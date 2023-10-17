using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Data;

namespace CapaLogica.ManejadorResult
{
    public class ManejadorResult
    {

        public ManejadorResult() 
        {
            dsResultado = new DataSet();
            _Error = null;
            MensajeError = string.Empty;
         
        }

        bool? _Error;
        public bool? Error { get { return _Error; } set { _Error = value; } }

        public DataSet dsResultado { get; set; }
        public string MensajeError { get; set; }
        //public byte[] respuestaPDF { get; set; }

        public bool? esError
        {
            get
            {
                if (_Error == null)
                {
                    if (dsResultado != null && dsResultado.Tables.Count > 0)
                    {
                        if (dsResultado.Tables[0].Rows.Count > 0)
                        {
                            DataColumn dc = dsResultado.Tables[0].Columns[0];
                            if (dc.ColumnName == "esError")
                            {
                                bool esError = (bool)dsResultado.Tables[0].Rows[0]["esError"];
                                _Error = esError;

                            }
                            else
                            {
                                _Error = false;
                            }
                        }
                        else
                        {
                            _Error = false;
                        }
                    }
                    else
                    {
                        _Error = false; ;
                    }
                }
                return _Error;

            }
            set { _Error = value; }
        }

    }
}
