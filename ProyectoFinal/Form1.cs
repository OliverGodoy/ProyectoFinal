using Mysqlx.Cursor;
using ProyectoFinal.Data;
using ProyectoFinal.Data.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoFinal
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        ConexionMySql finales = new ConexionMySql();
        Final fn = new Final();


       
        

        public Form1()
        {
            InitializeComponent();
            //finales = new ConexionMySql("localhost","root","Lg_(098765)");
        }


        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (finales.ProbarConexion())
            {
                MessageBox.Show("Conexión exitosa");
            }
            else
            {
                MessageBox.Show("Error en la conexión");
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = finales.LeerFinales();
        }

        
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            fn.anio = (int)numericUpDownAño .Value;
            fn.finalista1 = textBoxPrimerEquipo .Text;
            fn.finalista2 = textBoxSegundoEquipo .Text;
            fn.campeon = textBoxCampeon .Text;
            fn.resultado = textBoxResultado .Text;
            fn.fecha = dateTimePicker1.Value;
            fn.cede = textBoxCede .Text;
            fn.goleador = textBoxGoleador .Text;
            fn.cantidad = (int)numericUpDownCantidad .Value;
            finales.Insertar1(fn);
            //finales.Insertar((int)numericUpDownAño.Value, textBoxPrimerEquipo.Text, textBoxSegundoEquipo.Text, textBoxCampeon.Text, textBoxResultado.Text, dateTimePicker1.Value, textBoxCede.Text, textBoxGoleador.Text , (int)numericUpDownCantidad .Value);
            MessageBox.Show("Registro agregado correctamente");
        }


        private void BuscarPorAño()
        {
            int anio = (int)numericUpDownAño.Value;

            DataTable finalEncontrada = finales.BuscarPorAño(anio);

            if (finalEncontrada.Rows.Count > 0)
            {
                //El registro fue encontrado
                int año = (int)finalEncontrada.Rows[0]["año"];
                string finalista1 = finalEncontrada.Rows[0]["finalista1"].ToString();
                string finalista2 = finalEncontrada.Rows[0]["finalista2"].ToString();
                string campeon = finalEncontrada.Rows[0]["campeon"].ToString();
                string resultado = finalEncontrada.Rows[0]["resultado"].ToString();
                DateTime fecha = (DateTime)finalEncontrada.Rows[0]["fecha"];
                string cede = finalEncontrada.Rows[0]["cede"].ToString();
                string goleador = finalEncontrada.Rows[0]["goleador"].ToString();
                int cantidad = (int)finalEncontrada.Rows[0]["cantidad"];

                numericUpDownAño.Value = año;
                textBoxPrimerEquipo.Text = finalista1;
                textBoxSegundoEquipo.Text = finalista2;
                textBoxCampeon.Text = campeon;
                textBoxResultado.Text = resultado;
                dateTimePicker1.Value = fecha;
                textBoxCede.Text = cede;
                textBoxGoleador.Text = goleador;
                numericUpDownCantidad.Value = cantidad;
            }
            else
            {
                textBoxPrimerEquipo.Clear();
                textBoxSegundoEquipo.Clear();
                textBoxCampeon.Clear();
                textBoxResultado.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBoxCede.Clear();
                textBoxGoleador.Clear();
                numericUpDownCantidad.Value = numericUpDownCantidad.Minimum;
                MessageBox.Show("No se encontró el registro con el año especificado.");
               
            }
        }
        private void buttonBuscarPorAño_Click(object sender, EventArgs e)
        {
            BuscarPorAño();
        }


        private void ActualizarFinal()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de actualizar el registro?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                fn.anio = (int)numericUpDownAño.Value;
                fn.finalista1 = textBoxPrimerEquipo.Text;
                fn.finalista2 = textBoxSegundoEquipo.Text;
                fn.campeon = textBoxCampeon.Text;
                fn.resultado = textBoxResultado.Text;
                fn.fecha = dateTimePicker1.Value;
                fn.cede = textBoxCede.Text;
                fn.goleador = textBoxGoleador.Text;
                fn.cantidad = (int)numericUpDownCantidad.Value;
                finales.ActualizarFinal(fn);
                MessageBox.Show("Registro actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Actualización cancelada.");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ActualizarFinal();
        }

        public void EliminarRegistro()
        {
            int finalElimiar = (int)numericUpDownAño.Value;

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el registro de la final del año " + finalElimiar + "?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                bool Eliminarfinal = finales.EliminarRegistro(finalElimiar);

                if (Eliminarfinal)
                {
                    MessageBox.Show("Registro de la final eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la final del año: " + finalElimiar);
                }

            }
            else
            {
                MessageBox.Show("Eliminación cancelada.");
            }
            
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }


    }
}
