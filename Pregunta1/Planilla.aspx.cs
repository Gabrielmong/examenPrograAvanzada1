using Pregunta1.Class;
using Pregunta1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pregunta1 {
    public partial class Planilla : System.Web.UI.Page {

        cEmpleado cn = new cEmpleado();
        cDeducciones cd = new cDeducciones();
        protected void Page_Load(object sender, EventArgs e) {
            GridView1.DataSource = cn.getEmpleados();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {

            hf_Control.Value = Convert.ToString(GridView1.DataKeys[GridView1.SelectedRow.RowIndex].Value);
            Panel1.Visible = true;
            empleado emp = cn.getEmpleado(Convert.ToInt32(hf_Control.Value));
            deduccione de = cd.getDeduccion(Convert.ToInt32(hf_Control.Value));
            if (de == null) {
                txtNombre.Text = emp.Nombre;
                txtCooperativa.Text = Convert.ToString(0);
                txtPrestamo.Text = Convert.ToString(0);
                txtAhorro.Text = Convert.ToString(0);
                txtSalBruto.Text = Convert.ToString(emp.Salario_Bruto);
                txtSalNeto.Text = Convert.ToString(emp.Salario_Bruto);
                txtTotal.Text = Convert.ToString(0);
            } else {
                decimal deducciones = (decimal)(de.cooperativa + de.prestamo + de.ahorro);
                decimal salNeto = (decimal)(emp.Salario_Bruto - deducciones);
                txtNombre.Text = emp.Nombre;
                txtCooperativa.Text = Convert.ToString(de.cooperativa);
                txtPrestamo.Text = Convert.ToString(de.prestamo);
                txtAhorro.Text = Convert.ToString(de.ahorro);
                txtSalBruto.Text = Convert.ToString(emp.Salario_Bruto);
                txtSalNeto.Text = Convert.ToString(salNeto);
                txtTotal.Text = Convert.ToString(deducciones);
            }

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e) {
            if (e.Row.RowType == DataControlRowType.DataRow) {
                e.Row.Attributes.Add("onMouseOver", "this.style.cursor = 'pointer'");
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(GridView1, "select$" + e.Row.RowIndex.ToString()));
            }

        }

        protected void handleClose(object sender, EventArgs e) {
            Panel1.Visible = false;
        }

        protected void handleDelete(object sender, EventArgs e) {
            cd.deleteDeduccion(Convert.ToInt32(hf_Control.Value));
            cn.deleteEmpleado(Convert.ToInt32(hf_Control.Value));
            Response.Write("<script>alert('Eliminado correctamente');</script>");
            Response.Redirect("Planilla.aspx");
        }


    }
}