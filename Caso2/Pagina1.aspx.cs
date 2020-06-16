using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caso2
{
    delegate double MetodoMultiplicar(double n1);

        
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            MetodoMultiplicar fnMultiplicar = Calculos.MultiplicarNumeros;
            double num1 = Convert.ToDouble(txtNumero.Text);
            double resultado = fnMultiplicar(num1);
            txtResultado.Text = resultado.ToString();

            Action<string> fn2 = Calculos.bitacora;
            string guardar = String.Format("Se multiplica el numero {0} por el nunmero 2 y da como resultado {1}", num1, resultado);
            fn2(guardar);
        }
    }
}