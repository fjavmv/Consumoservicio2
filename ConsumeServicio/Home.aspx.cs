using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeServicio
{
    public partial class Home : System.Web.UI.Page
    {
        ServiceReference1.WebServiceEjemploSoapClient servicio = new ServiceReference1.WebServiceEjemploSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            LblAleatorio.Text = Convert.ToString(servicio.numeroAleatorio());
        }

        protected void BtnC1_Click(object sender, EventArgs e)
        {
            int tem = Convert.ToInt16(TxtTeperatura1.Text);
            
            LblFC.Text = Convert.ToString(servicio.convertirFtoC(tem));
        }

        protected void BtnC2_Click(object sender, EventArgs e)
        {
            int tem = Convert.ToInt16(TxtTeperatura1.Text);
            LblCF.Text = Convert.ToString(servicio.convertirCtoF(tem));
        }

        protected void BtnSuma_Click(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt16(Txtval1.Text);
            int val2 = Convert.ToInt16(Txtval2.Text);
            LblResultado.Text = Convert.ToString(servicio.suma(val1,val2));
        }


           }
}