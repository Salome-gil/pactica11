using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libRnDescVta
{
    public class clsRnDescVta
    {
        #region "Atributos"
        private int intCod;
        private int intCant;
        private float fltDesc;
        private string strError;
        #endregion      
        #region "Propiedades"
            public int Codigo
            {
                set { intCod = value; }
            }
            public int Cantidad
            {
                set { intCant = value; }
            }
            public float Descuento
            {
                get { return fltDesc; }
            }
            public string Error
            {
                get { return strError; }
            }

            #endregion 
        #region "Constructor"
        public clsRnDescVta()
        {
            intCod = 0;
            intCant = 0;
            fltDesc = 0;
            strError = string.Empty;
        }
     
        #endregion  
        #region "Metodos privados"
        private bool Validar()
        {
            if (intCod >= 0 && intCant >= 0) ;
            return false;

        }
        private bool leerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Descuentos.txt";
                int intCant = 0, intCodleido, intCantleido;
                float fltPorcLeido;
                string strLinea;
                string[] vectorConLinea;
                intCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return false;
                StreamReader Archivo = new StreamReader(@strPath);
                while ((strLinea = Archivo.ReadLine()) != null)
                {
                    vectorConLinea = strLinea.Split(':');
                    intCodleido = Convert.ToInt32(vectorConLinea[0]);
                    intCantleido = Convert.ToInt32(vectorConLinea[1]);
                    fltPorcLeido = Convert.ToInt32(vectorConLinea[2]);
                    if (intCod == intCodleido && intCant > intCantleido)
                    {
                        fltDesc = fltPorcLeido;
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }

        }
        #endregion  
        #region "Metodos Publicos"
        public bool hallarDescto()
        {
            if (!Validar())
            return false;
            leerArchivo();
            return true;
        }
        #endregion  
    }
}
