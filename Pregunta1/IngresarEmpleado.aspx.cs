using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pregunta1.Class;
using Pregunta1.Model;

namespace Pregunta1 {
    public partial class IngresarEmpleado : System.Web.UI.Page {

        cEmpleado cn = new cEmpleado();
        protected void Page_Load(object sender, EventArgs e) {

            
        }

        protected void handleSave(object sender, EventArgs e) {
            if (txtCodigo.Text == "" | txtNombre.Text == "" |  txtHoras.Text == "" | txtSalHora.Text == "") {
                Response.Write("<script>alert('Debe llenar todos los campos');</script>");
            } else {
                decimal salBruto = Convert.ToInt32(txtHoras.Text) * Convert.ToInt32(txtSalHora.Text);
                cn.addEmplado(
                    Convert.ToInt32(txtCodigo.Text),
                    txtNombre.Text,
                    Convert.ToInt32(txtHoras.Text),
                    Convert.ToInt32(txtSalHora.Text),
                    salBruto
                    ) ;
                Response.Write("<script>alert('Agregado correctamente');</script>");
                Response.Redirect("IngresarDeducciones.aspx");
            }
        }

    }
}