using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        public void Eliminar()
        {
            id.Text = "";
            nombre.Text = "";
            corte1.Text = "";
            corte2.Text = "";
            corte3.Text = "";
            definitiva.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            string ide = id.Text;
            string name = nombre.Text;
            string nota1 = corte1.Text;
            string nota2 = corte2.Text;
            string nota3 = corte3.Text;

            if (ide == "" || name == "" || nota1 == "" || nota2 == "" || nota3 == "")
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
            else
            {
                c.Insertar(id.Text, nombre.Text, corte1.Text, corte2.Text, corte3.Text);
                Eliminar();

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

 

        private void calcular_nota_Click(object sender, EventArgs e)
        {
            string ide = id.Text;
            string name = nombre.Text;
            string nota1 = corte1.Text;
            string nota2 = corte2.Text;
            string nota3 = corte3.Text;

            if (ide == "" || name == "" || nota1 == "" || nota2 == "" || nota3 == "" )
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
            else
            {
                decimal final = (decimal.Parse(corte1.Text) * 35 / 100) + (decimal.Parse(corte2.Text) * 35 / 100) + (decimal.Parse(corte3.Text) * 30 / 100);
                definitiva.Text = final.ToString();
                if (final < 3)
                {
                    MessageBox.Show("El estudiante no aprobo el curso");
                }
                else
                {
                    MessageBox.Show("El estudiante aprobo el curso");
                }
                
            }
            
        }

        private void definitiva_Click(object sender, EventArgs e)
        {

        }
    }
}
