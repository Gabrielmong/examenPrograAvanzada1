using Pregunta1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pregunta1.Class {
    public class cDeducciones {
        CASO1Entities db = new CASO1Entities();

        public void addDeducciones(int codigo_deduccion, int id_empleado, decimal cooperativa, decimal prestamo, decimal ahorro) {
            deduccione de = new deduccione();
            de.codigo_deduccion = codigo_deduccion;
            de.id_empleado = id_empleado;
            de.cooperativa = cooperativa;
            de.prestamo = prestamo;
            de.ahorro = ahorro;
            db.deducciones.Add(de);
            db.SaveChanges();
        }

        public deduccione getDeduccion(int id_empleado) {
            try {
                return db.deducciones.Single(x => x.id_empleado == id_empleado);
            } catch (Exception) {
                return null;
            }
        }

        public deduccione deleteDeduccion(int id_empleado) {
            deduccione de = db.deducciones.Single(x => x.id_empleado == id_empleado);
            db.deducciones.Remove(de);
            db.SaveChanges();
            return de;
        }
    }
}