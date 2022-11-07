using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;
using System.Data;

using SystemaCom1.Clogica;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace turnos.CapaDatos
{
	internal class CLSDATos
	{
		public void agregard(CLSDATos )
		{
			SqlConnection conexion = new SqlConnection("server=SALVI\\SQLEXPRESS04; database=Turnos; integrated security = true");
			string cadena = "INSERT INTO Alumno(ID,Nombre,Apellido,Promedio,AnoDeCursado,Email,Telefono) VALUES(" + oalumno.Id + ",'" + oalumno.Nombre + "','" + oalumno.Apellido + "'," + oalumno.Promedio + ",'" + oalumno.AnoDeCursado + "','" + oalumno.Email + "','" + oalumno.Telefono + "')";
			conexion.Open();
			SqlCommand comando = new SqlCommand(cadena, conexion);
			comando.ExecuteNonQuery();
			MessageBox.Show("Los datos se guardaron correctamente ");
			conexion.Close();
		}
	}
}