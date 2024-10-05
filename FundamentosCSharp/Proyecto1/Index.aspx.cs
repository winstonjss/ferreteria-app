using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarMensaje();
        }
        //Metodo
        public void mostrarMensaje() {
            //CRear un objeto de car
            Car objCar = new Car();
            LblMensaje.Text = objCar.stop(); 

        }
    }
}