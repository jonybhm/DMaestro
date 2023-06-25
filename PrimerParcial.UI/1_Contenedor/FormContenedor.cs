using PrimerParcial.Entidades.Models;
using PrimerParcial.UI._1_Contenedor;
using PrimerParcial.UI._6_Usuarios;

namespace PrimerParcial.UI
{
    public partial class FormContenedor : Form
    {
        public Usuario usuarioActual;
        private List<Usuario> _listaUsuario;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormContenedor.
        /// </summary>
        public FormContenedor(Usuario usuarioActual, List<Usuario> listaUsuario)
        {
            InitializeComponent();

            this.usuarioActual = usuarioActual;
            _listaUsuario = listaUsuario;

        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormContenedor_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            if (usuarioActual.IsAdmin == false)
            {
                encuentrosToolStripMenuItem.Enabled = false;
                stripMenuCrearUsuario.Enabled = false;
                stripMenuCampañas.Enabled = false;
                stripMenuPantallaDM.Enabled = false;
                stripMenuPantallaDM.Enabled = false;
                stripMenuEditarUsuario.Enabled = false;
            }
        }

        //FORMS DEL MENU PRINCIPAL

        /// <summary>
        /// Evento que sucede al hacer click en Pantalla DM en el Menu.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuPantallaDM_Click(object sender, EventArgs e)
        {
            string nombreForm = "FormPantallaDM";
            CerrarFormsConMismoNombre("FormPantallaDM");
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);

            var hijo = new FormPantallaDM();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Maximized;
            hijo.Show();
        }

       

        /// <summary>
        /// Evento que sucede al hacer click en alguno de los botones de Dados.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonDados_Click(object sender, EventArgs e)
        {
            string nombreForm = "FormCalculadoraDados";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            
            var calculadora = new FormCalculadoraDados(this);
            calculadora.MdiParent = this;
            calculadora.WindowState = FormWindowState.Normal;
            calculadora.Show();
        }

        /// <summary>
        /// Evento que sucede al hacer click en Bestiario en el Menu Compendio.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuBestiario_Click(object sender, EventArgs e)
        {
            
            string nombreForm = "FormBestiario";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormBestiario(this);
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        /// <summary>
        /// Evento que sucede al hacer click en Hechizos en el Menu de Compendio.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuHechizos_Click(object sender, EventArgs e)
        {
            string nombreForm = "FormHechizos";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormHechizos(this);
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();

        }

        /// <summary>
        /// Evento que sucede al hacer click en Objetos y Tesoros en el Menu de Compendio.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenusObjetosYTesoros_Click(object sender, EventArgs e)
        {
            
            string nombreForm = "FormobjetosYTesoros";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormItems(this);
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        /// <summary>
        /// Evento que sucede al hacer click en Clases en el Menu de Personajes en Compendio.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuClasesCompendio_Click(object sender, EventArgs e)
        {
           
            string nombreForm = "FormClases";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormClases();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        /// <summary>
        /// Evento que sucede al hacer click en Razas en el Menu de Personajes en Compendio.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenusRazasCompendio_Click(object sender, EventArgs e)
        {
            
            string nombreForm = "FormRazas";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormRazas();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        /// <summary>
        /// Evento que sucede al hacer click en Campañas en el Menu.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuCampañas_Click(object sender, EventArgs e)
        {
            string nombreForm = "FormListaDeCampañas";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormListaDeCampañas(this);
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        /// <summary>
        /// Evento que sucede al hacer click en Calculo de Dificultad en el Menu de combate.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuCalculoDificultad_Click(object sender, EventArgs e)
        {
            string nombreForm = "FormCombateDificultad";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormCalculoDeDificultad(this);
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        /// <summary>
        /// Evento que sucede al hacer click en Iniciativa en el Menu Combate.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuIniciativa_Click(object sender, EventArgs e)
        {
            string nombreForm = "FormIniciativa";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormIniciativa();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }


        /// <summary>
        /// Evento que sucede al hacer click en Crear Usuario en el Menu.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuCrearUsuario_Click(object sender, EventArgs e)
        {
            string nombreForm = "FormUsuarioNuevo";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormUsuarioNuevo(_listaUsuario);
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        /// <summary>
        /// Evento que sucede al hacer click en Editar Usuario en el Menu.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuEditarUsuario_Click(object sender, EventArgs e)
        {
            string nombreForm = "FormEditarUsuario";
            CerrarFormsConMismoNombre(nombreForm);
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            var hijo = new FormEditarUsuario(_listaUsuario, this);
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }


        /// <summary>
        /// Evento que sucede al hacer click en Cambiar de Usuario en el Menu.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void stripMenuCambiarUsuario_Click(object sender, EventArgs e)
        {
            string nombreForm = "Login";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            this.Close();
            var login = new FormLogin();
            login.Show();
        }

        //FORMS DE REGLAS EN GENERAL


        /// <summary>
        /// Evento que sucede al hacer click en Alineamientos en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Alineamientos_Click(object sender, EventArgs e)
        {
            string nombreForm = "Alineamiento";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Alineamientos);
        }



        /// <summary>
        /// Evento que sucede al hacer click en Ventaja y Desventaja en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void VentajaYDesventaja_Click(object sender, EventArgs e)
        {
            string nombreForm = "VentajaYDesventaja";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(VentajaYDesventaja);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Combatir Bajo el  Agua en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void CombatirBajoElAgua_Click(object sender, EventArgs e)
        {
            string nombreForm = "CombatirBajoElAgua";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(CombatirBajoElAgua);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Competencia en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Competencia_Click(object sender, EventArgs e)
        {
            string nombreForm = "Competencia";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Competencia);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Estados en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Estados_Click(object sender, EventArgs e)
        {
            string nombreForm = "Estados";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Estados);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Inspiracion en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Inspiracion_Click(object sender, EventArgs e)
        {
            string nombreForm = "Inspiracion";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Inspiracion);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Feats en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Feats_Click(object sender, EventArgs e)
        {
            string nombreForm = "Feats";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Feats);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Enfermedades en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Enfermedades_Click(object sender, EventArgs e)
        {
            string nombreForm = "Enfermedades";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Enfermedades);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Locura en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Locura_Click(object sender, EventArgs e)
        {
            string nombreForm = "Locura";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Locura);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Trampas en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Trampas_Click(object sender, EventArgs e)
        {
            string nombreForm = "Trampas";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Trampas);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Venenos en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Venenos_Click(object sender, EventArgs e)
        {
            string nombreForm = "Venenos";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Venenos);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Acciones en Combate en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void AccionesEnCombate_Click(object sender, EventArgs e)
        {
            string nombreForm = "AccionesEnCombate";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(AccionesEnCombate);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Realizar un Ataque en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void RealizarUnAtaque_Click(object sender, EventArgs e)
        {
            string nombreForm = "RealizarUnAtaque";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(RealizarUnAtaque);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Movimiento y Posicion en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void MovimientoYPosicion_Click(object sender, EventArgs e)
        {
            string nombreForm = "MovimientoYPosicion";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(MovimientoYPosicion);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Orden de Combate en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void OrdenDeCombate_Click(object sender, EventArgs e)
        {
            string nombreForm = "OrdenDeCombate";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(OrdenDeCombate);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Cobertura en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Cobertura_Click(object sender, EventArgs e)
        {
            string nombreForm = "Cobertura";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Cobertura);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Combatir desde Montura en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void CombatirDesdeMontura_Click(object sender, EventArgs e)
        {
            string nombreForm = "CombatirDesdeMontura";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(CombatirDesdeMontura);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Clases en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Clases_Click(object sender, EventArgs e)
        {
            string nombreForm = "Clases";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Clases);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Razas en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Razas_Click(object sender, EventArgs e)
        {
            string nombreForm = "Razas";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Razas);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Idiomas en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Idiomas_Click(object sender, EventArgs e)
        {
            string nombreForm = "Idiomas";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Idiomas);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Trasfondos en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Trasfondos_Click(object sender, EventArgs e)
        {
            string nombreForm = "Trasfondos";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Trasfondos);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Multiclaseo en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Multiclaseo_Click(object sender, EventArgs e)
        {
            string nombreForm = "Multiclaseo";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Multiclaseo);
        }

        /// <summary>
        /// Evento que sucede al hacer click en NPCs en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void NPC_Click(object sender, EventArgs e)
        {
            string nombreForm = "NPC";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(NPC);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Que es un conjuro en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void QueEsUnConjuro_Click(object sender, EventArgs e)
        {
            string nombreForm = "QueEsUnConjuro";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(QueEsUnConjuro);
        }


        /// <summary>
        /// Evento que sucede al hacer click en Lanzar un Conjuro en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void LanzarUnConjuro_Click(object sender, EventArgs e)
        {
            string nombreForm = "LanzarUnConjuro";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(LanzarUnConjuro);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Armadura en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Armadura_Click(object sender, EventArgs e)
        {
            string nombreForm = "Armadura";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Armadura);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Armas en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Armas_Click(object sender, EventArgs e)
        {
            string nombreForm = "Armas";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Armas);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Equipo de Aventuras en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void EquipoDeAventuras_Click(object sender, EventArgs e)
        {
            string nombreForm = "EquipoDeAventuras";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(EquipoDeAventuras);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Herramientas en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Herramientas_Click(object sender, EventArgs e)
        {
            string nombreForm = "Herramientas";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Herramientas);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Monedas en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Monedas_Click(object sender, EventArgs e)
        {
            string nombreForm = "Monedas";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Monedas);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Monturas en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Monturas_Click(object sender, EventArgs e)
        {
            string nombreForm = "Monturas";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Monturas);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Packs Iniciales en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void PacksIniciales_Click(object sender, EventArgs e)
        {
            string nombreForm = "PacksIniciales";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(PacksIniciales);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Productos Comerciales en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void ProductosComerciales_Click(object sender, EventArgs e)
        {
            string nombreForm = "ProductosComerciales";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(ProductosComerciales);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Objetos en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Objetos_Click(object sender, EventArgs e)
        {
            string nombreForm = "Objetos";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Objetos);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Objetos Magicos en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void ObjetosMagicos_Click(object sender, EventArgs e)
        {
            string nombreForm = "ObjetosMagicos";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(ObjetosMagicos);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Entre Aventuras en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void EntreAventuras_Click(object sender, EventArgs e)
        {
            string nombreForm = "EntreAventuras";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(EntreAventuras);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Descasar en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Descansar_Click(object sender, EventArgs e)
        {
            string nombreForm = "Descansar";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Descansar);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Entorno en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Entorno_Click(object sender, EventArgs e)
        {
            string nombreForm = "Entorno";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Entorno);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Movimiento en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Movimiento_Click(object sender, EventArgs e)
        {
            string nombreForm = "Movimiento";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Movimiento);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Tiempo en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Tiempo_Click(object sender, EventArgs e)
        {
            string nombreForm = "Tiempo";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Tiempo);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Planos en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Planos_Click(object sender, EventArgs e)
        {
            string nombreForm = "Planos";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Planos);
        }

        /// <summary>
        /// Evento que sucede al hacer click en Mitologia en el Menu de Reglas.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void Mitologia_Click(object sender, EventArgs e)
        {
            string nombreForm = "Mitologia";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(usuarioActual.UserName, nombreForm);
            MostrarRegla(Mitologia);
        }

        /// <summary>
        /// Muestra un texto en formato enriquezido con la información detallada de la regla.
        /// </summary>
        /// <param name="ReglaBoton">Toma el nombre de la regla desde el boton que lleva a la misma.</param>
        private void MostrarRegla(ToolStripMenuItem ReglaBoton)
        {
            string nombreArchivo = ReglaBoton.Text;
            FormReglas regla = new FormReglas(nombreArchivo);
            regla.MdiParent = this;
            regla.WindowState = FormWindowState.Normal;
            regla.Show();
        }


        public void CerrarFormsConMismoNombre(string nombreForm)
        {

            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == nombreForm)
                {
                    this.MdiChildren[i].Close();
                }
            }
        }


    }
}