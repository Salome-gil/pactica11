using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libRnDescVta;
namespace libOpeDescVta
{
    public class clsOpeDescVta
    {
        #region "Atributos"
        private int intCod;
        private int intCant;
        private float fltVrDoc;
        private float fltPorcIVA;
        private float fltSubTot;
        private float fltVlrIVA;
        private float fltToltAPag;
        private string strError;
        #endregion      
        #region "Constructor"
        public clsOpeDescVta()
        {
            intCod = 0;
            intCant = 0;
            fltVrDoc = 0;
            fltPorcIVA = 0;
            fltSubTot = 0;
            fltVlrIVA = 0;
            fltToltAPag = 0;
            strError = string.Empty;
        }
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
        public float vrDocena
        {
            set { fltVrDoc= value; }
        }
        public float porcIVA
        {
            set { fltPorcIVA = value; }
        }
        public float subTotal
        {
            get { return fltSubTot; }
        }
        public float porcDescto
        {
            get { return fltVrDoc; }
        }
        public float vrDescto
        {
            get { return fltSubTot; }
        }
        public float vrIVA
        {
            get { return fltVlrIVA; }
        }
        public float TotalAPagar
        {
            get { return fltToltAPag; }
        }
        public string Error
        {
            get { return strError; }
        }

        #endregion
        #region "Metodos privados"
        private bool Validar()
        {
            if (intCod >= 0 && intCant >= 0&& fltVrDoc >=0 &&fltPorcIVA>0&&fltPorcIVA<19)
            {
                strError = " Codigo invalido";
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion
        #region "Metodos publicos"
        public bool Facturar()
        {
            return true;
        }
        #endregion
    }
}
