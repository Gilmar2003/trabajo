using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aporte5tod
{
    public partial class Nomina_de_empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Btn_calcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular ()
        {
            try
            {
                // Obtener los valores ingresados por el usuario
                string nombre = txtnombre.Text;
                int edad = Convert.ToInt32(txtedad.Text);
                decimal sueldoBase = Convert.ToDecimal(txtsueldobase.Text);
                int diasTrabajados = Convert.ToInt32(txtdiastrabajados.Text);
                decimal desdia = 10;
                decimal descuentodias = diasTrabajados*(desdia/100);

                // Calcular descuento del IESS
                decimal descuentoIESS = 9.45;

                // Calcular descuento del impuesto a la renta
                decimal descuentoIR = sueldoBase * 0.08m;

                
                txtdescuentoiess.Text = descuentoIESS.ToString();
                txtdescuentoir.Text = descuentoIR.ToString();
                decimal totalPagar = sueldoBase - descuentoIESS - descuentoIR;
                txtresultado.Text = totalPagar.ToString();

            }
            catch (Exception ex)
            {
                txtresultado.Text = $"Error: {ex.Message}";
            }
        }

        protected System.Void Btn_calcular_Click(System.Object sender, System.EventArgs e)
        {

        }
    }
}