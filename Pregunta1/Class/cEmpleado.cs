using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pregunta1.Model;

namespace Pregunta1.Class {
    public class cEmpleado {

        CASO1Entities db = new CASO1Entities();

        public void addEmplado(int codigo_empleado, string Nombre, decimal Horas_laboradas, decimal Salario_Hora, decimal Salario_Bruto) {
            empleado emp = new empleado();
            emp.codigo_empleado = codigo_empleado;
            emp.Nombre = Nombre;
            emp.Horas_laboradas = Horas_laboradas;
            emp.Salario_Hora = Salario_Hora;
            emp.Salario_Bruto = Salario_Bruto;
            db.empleadoes.Add(emp);
            db.SaveChanges();
        }

        public empleado getEmpleado(int codigo_empleado) {
            return db.empleadoes.Single(x => x.codigo_empleado == codigo_empleado);
        }
        
        public List<empleado> getEmpleados() {
            return db.empleadoes.ToList();
        }


        public empleado deleteEmpleado(int codigo_empleado) {
            empleado emp = db.empleadoes.Single(x => x.codigo_empleado == codigo_empleado);
            db.empleadoes.Remove(emp);
            db.SaveChanges();
            return emp;
        }

    }
}