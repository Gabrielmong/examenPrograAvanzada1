using Pregunta1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pregunta1 {
    public partial class IngresarDeducciones : System.Web.UI.Page {

        cDeducciones cd = new cDeducciones();
        protected void Page_Load(object sender, EventArgs e) {


            
        }
        protected void handleSave(object sender, EventArgs e) {
            if (txtCodigo.Text == "" | txtIdEmpleado.Text == "" | txtCoop.Text == "" | txtPrestamo.Text == "" | txtAhorro.Text == "") {
                Response.Write("<script>alert('Debe llenar todos los campos');</script>");
            } else {
                cd.addDeducciones(
                    Convert.ToInt32(txtCodigo.Text),
                    Convert.ToInt32(txtIdEmpleado.Text),
                    Convert.ToInt32(txtCoop.Text),
                    Convert.ToInt32(txtPrestamo.Text),
                    Convert.ToInt32(txtAhorro.Text)
                    );
                Response.Write("<script>alert('Agregado correctamente');</script>");
                Response.Redirect("Planilla.aspx");
            }

        }
        }
    }


