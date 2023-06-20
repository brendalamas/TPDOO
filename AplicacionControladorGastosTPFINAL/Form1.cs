using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionControladorGastosTPFINAL
{
    public partial class Form1 : Form
    {
        List<ListaMovimiento> listaMovimiento = new List<ListaMovimiento>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (validarMonto() == false)
            {
                return;
            }
            if (validarTipo() == false)
            {
                return;
            }
            if (validarCategoria() == false)
            {
                return;
            }
            if (validarFecha() == false)
            {
                return;
            }

            ListaMovimiento listaMov = new ListaMovimiento();
            decimal monto;

            if (decimal.TryParse(txtMonto.Text, out monto))
            {
                listaMov.Monto = monto;
            }
            listaMov.TipoCheck = checkIngreso.Checked ? "Ingreso" : "Gasto";
            if (cmbCategoria.SelectedItem != null)
            {
                listaMov.Categoria = cmbCategoria.SelectedItem.ToString();
            }
            listaMov.Fecha = dateTimePicker1.Value.Date;
            listaMovimiento.Add(listaMov);

            //dgvDatos.DataSource = null;
            //dgvDatos.DataSource = listaMovimiento;
            MessageBox.Show("¡Agregado!");
            limpiarControles();
            txtMonto.Focus();

        }

        private void limpiarControles()
        {
            txtMonto.Clear();
            checkIngreso.Checked = false;
            checkGasto.Checked = false;
            cmbCategoria.SelectedIndex = 0;
            dateTimePicker1.ResetText();
        }

        private bool validarFecha()
        {
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                erpError.SetError(dateTimePicker1, "Debe seleccionar una fecha anterior o igual a la fecha actual");
                return false;
            }
            else
            {
                erpError.SetError(dateTimePicker1, "");
                return true;
            }
        }


        private void checkGasto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGasto.Checked)
            {
                cmbCategoria.Items.Clear();
                cmbCategoria.Items.AddRange(new object[] { "Salidas", "Belleza", "Regalo", "Educación", "Alimentación", "Casa", "Servicios", "Otro" });
            }

            cmbCategoria.Enabled = checkGasto.Checked;
        }

        private void checkIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIngreso.Checked)
            {
                cmbCategoria.Items.Clear();
                cmbCategoria.Items.AddRange(new object[] { "Sueldo", "Regalo", "Intereses", "Otro" });
            }

            cmbCategoria.Enabled = checkIngreso.Checked;
        }

        private bool validarCategoria()
        {
            if (!checkIngreso.Checked && !checkGasto.Checked)
            {
                erpError.SetError(checkGasto, "Debe seleccionar un tipo");
                return false;
            }

            erpError.SetError(checkGasto, "");
            return true;
        }




        private bool validarTipo()
        {
            if (!checkIngreso.Checked && !checkGasto.Checked)
            {
                erpError.SetError(checkGasto, "Debe seleccionar un tipo");
                return false;
            }

            return true;
        }


        private bool validarMonto()
        {
            if (string.IsNullOrEmpty(txtMonto.Text))
            {
                erpError.SetError(txtMonto, "Debe ingresar un valor numérico");
                return false;
            }
            return true;
        }
    }
}

