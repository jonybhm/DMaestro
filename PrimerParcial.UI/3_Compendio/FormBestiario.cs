﻿using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL;
using PrimerParcial.Entidades.SQL.ElementosDB;
using PrimerParcial.UI._1_Contenedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI
{
    public partial class FormBestiario : Form
    {
        private FormContenedor mdiParentForm;
        private FormIniciativa formIniciativa;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormBestiario.
        /// </summary>
        public FormBestiario(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;
            formIniciativa = new FormIniciativa(mdiParentForm);

        }


        /// <summary>
        /// Busca informacion en el data grid con respecto al texto en Text Box Buscador.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridBestiario.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridBestiario.DataSource = bindingSource;
        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormBestiario_Load(object sender, EventArgs e)
        {
            var enemigoDB = new EnemigosDB();
            FormAux.dataGrid_Actualizar(enemigoDB.Traer(), dataGridBestiario);
        }


        /// <summary>
        /// Evento que sucede al hacer click en el boton Mostrar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = true;
            bool mostrarBotonAgregarNuevo = false;
            try
            {
                Enemigo enemigo = new Enemigo(0, "");
                enemigo.AgregarInfo(FormAux.ArmarDictEnBaseAFila(dataGridBestiario));

                FormStatBlock statBlock = new FormStatBlock((Enemigo)enemigo, mostrarBotonAgregarNuevo, mostrarBotonEditar, dataGridBestiario);
                statBlock.MdiParent = mdiParentForm;
                statBlock.WindowState = FormWindowState.Normal;
                statBlock.Show();
                DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
                DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "Mostrar");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para mostrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Agregar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = false;
            bool mostrarBotonAgregarNuevo = true;

            //int idFinal = dataGridBestiario.Rows.Count;


            Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
            foreach (DataGridViewColumn column in dataGridBestiario.Columns)
            {

                switch (column.HeaderText)
                {
                    case "name":
                    case "meta":
                    case "challenge":
                    case "ac":
                    case "hp":
                    case "senses":
                    case "languages":
                    case "traits":
                    case "actions":
                    case "legendaryActions":
                    case "savingThrows":
                    case "skills":
                    case "size":
                    case "type":
                    case "alignment":
                    case "source":
                        dictDatosFilas[column.Name] = "COMPLETAR...";
                        break;

                    default:
                        dictDatosFilas[column.Name] = 0.ToString();
                        break;

                }

            }

            Enemigo enemigo = new Enemigo(0, "");
            enemigo.AgregarInfo(dictDatosFilas);

            FormStatBlock statBlock = new FormStatBlock((Enemigo)enemigo, mostrarBotonAgregarNuevo, mostrarBotonEditar, dataGridBestiario);

            statBlock.MdiParent = mdiParentForm;
            statBlock.WindowState = FormWindowState.Normal;


            statBlock.Show();

            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "Agregar");

        }

        /// <summary>
        /// Elimina la fila de la base de datos
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridBestiario.SelectedRows[0];
                var idEnemigo = selectedRow.Cells[0].Value;
                var enemigoDB = new EnemigosDB();
                enemigoDB.EliminarDatos(idEnemigo);
                FormAux.dataGrid_Actualizar(enemigoDB.Traer(), dataGridBestiario);
                MessageBox.Show("Monstruo Eliminado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
                DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "Eliminar");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// Exporta la info del datagrid a un archivo json.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonExportar_Click(object sender, EventArgs e)
        {
            var enemigoDB = new EnemigosDB();
            List<Dictionary<string, object>> listaDatosAExportar = enemigoDB.Traer();
            Archivos.ExportarAJSON(listaDatosAExportar, "Bestiario");
            MessageBox.Show("Datos Exportados", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "Exportar a json");
        }

        /// <summary>
        /// Despliega los botones del menu.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            flowLayoutPanelBotones.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelBotones.Visible = !flowLayoutPanelBotones.Visible;

            if (flowLayoutPanelBotones.Visible)
            {
                buttonPlus.Text = "-";
            }
            else
            {
                buttonPlus.Text = "+";
            }


        }

        private void buttonAddIniciativa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRowCollection = dataGridBestiario.SelectedRows;
            formIniciativa.MdiParent = mdiParentForm;

            formIniciativa.CargarDatos(selectedRowCollection);
            formIniciativa.Show();

        }
    }
}
