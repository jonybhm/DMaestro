﻿using PrimerParcial.Entidades.Models;
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

namespace PrimerParcial.UI
{
    public partial class FormCombateDificultad : Form
    {

        public FormCombateDificultad()
        {
            InitializeComponent();
        }

        private void dataGridEnemigos_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridEnemigos.DataSource = null;

            var bestiario = Archivos.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridEnemigos.DataSource = bestiario;
        }

        private void textBoxResultadoCR_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridEnemigos.DataSource;
            if (string.IsNullOrEmpty(textBoxResultadoCR.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"CR LIKE '{textBoxResultadoCR.Text}'";
            }
            dataGridEnemigos.DataSource = bindingSource;

        }


        private void dataGridTablaReferencia_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridTablaReferencia.DataSource = null;

            var tablaUno = Archivos.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridTablaReferencia.DataSource = tablaUno;
        }

        private void dataGridNivelDificultad_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridNivelDificultad.DataSource = null;

            var tablaDos = Archivos.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridNivelDificultad.DataSource = tablaDos;
        }

        private void dataGridCantidadModificador_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridCantidadModificador.DataSource = null;

            var tablaTres = Archivos.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridCantidadModificador.DataSource = tablaTres;
        }
        private void FormCombateDificultad_Load_1(object sender, EventArgs e)
        {

            dataGridEnemigos_Actualizar(Archivos.LeerInfoEnemigos());
            dataGridTablaReferencia_Actualizar(Archivos.LeerInfoTablaUno());
            dataGridNivelDificultad_Actualizar(Archivos.LeerInfoTablaDos());
            dataGridCantidadModificador_Actualizar(Archivos.LeerInfoTablaTres());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int XP = Enemigo.CalcularXP(int.Parse(textBoxNivelPC.Text), int.Parse(textBoxCantidadPC.Text), comboBoxDificultad.Text, Archivos.LeerInfoTablaDos());
            textBoxResultadoXP.Text = XP.ToString();
            textBoxResultadoXPporPC.Text = (XP / int.Parse(textBoxCantidadPC.Text)).ToString();

            string CR = Enemigo.CalcularCR(XP, Archivos.LeerInfoTablaUno());
            textBoxResultadoCR.Text = CR;

        }

        private void textBoxCantidadPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //la caja de texto acepta solo numeros y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNivelPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBoxCantidadEnemigos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridEnemigos.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"Name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridEnemigos.DataSource = bindingSource;
        }

        /*private void button_Pin_Click(object sender, EventArgs e)
        {
            var agregarRegla = new FormAgregarRegla();
            if (agregarRegla.ShowDialog() == DialogResult.OK)
            {
                enemigo.Add(agregarRegla.ReglaNueva);
                dataGrid_Estados_Actualizar(enemigo);
            }
            else
            {
                MessageBox.Show("Error al agregar regla");
            }
        }*/

        /*private void button1_Click(object sender, EventArgs e)
        {
            Enemigo enemigo = (Enemigo)dataGridEnemigos.SelectedRows[0].DataBoundItem;

            MessageBox.Show(enemigo.Mostrar());
        }*/


    }
}
