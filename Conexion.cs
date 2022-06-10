using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ejemplo
{

	class Conexion
	{

		SqlConnection cn;
		SqlCommand cmd;

        public Conexion()
        {
            try
            {
				cn = new SqlConnection("Data Source=EDUARDO\\SQLEXPRESS;Initial Catalog=nota_poli;User ID=sa;Password=123456789");
				cn.Open();
            }
			 catch(Exception ex)
            {
				MessageBox.Show(ex.ToString());
            }
        }

		public void Insertar(string id, string nombre, string corte1, string corte2, string corte3)
		{
			decimal final = (decimal.Parse(corte1) * 35 / 100) + (decimal.Parse(corte2) * 35 / 100) + (decimal.Parse(corte3) * 30 / 100);
			Console.WriteLine(final);
			string nota = final.ToString();
			Console.WriteLine(nota);
			string salida = "Registro Cargado";
			try
			{
				cmd = new SqlCommand("insert into notas (id, estudiante, corte1, corte2, corte3, notaDefinitiva) values ('"+id+"', '"+nombre+"', '"+corte1+"', '"+corte2+"', '"+corte3+"', '"+ nota + "')" ,cn);
                cmd.ExecuteNonQuery();
				MessageBox.Show(salida);
				MessageBox.Show("Por favor ingrese el nuevo registro");
			}
			catch (Exception ex)
            {
				Console.WriteLine(ex.StackTrace);
				salida = "no se pudo cargar el registro" + ex.ToString();
				MessageBox.Show(salida);
            }
        }
	}
}
