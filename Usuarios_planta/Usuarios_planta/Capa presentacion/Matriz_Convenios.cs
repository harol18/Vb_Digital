using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Usuarios_planta.Capa_presentacion
{
    public partial class Matriz_Convenios : Form
    {

        MySqlConnection con = new MySqlConnection("server=;Uid=;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");

        Comandos cmds = new Comandos();

        public Matriz_Convenios()
        {
            InitializeComponent();
        }

        public void Cargar_dirigido()
        {
            string cadena = TxtCodigo_Convenio.Text;
            string codigo_convenio = cadena.Substring(0, 3);

            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select Dirigido from matriz_convenios where Codigo=@Codigo", con);
            cmd.Parameters.AddWithValue("Codigo", codigo_convenio);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            DataRow dr = dt.NewRow();
            dr["Dirigido"] = "No aplica";
            dt.Rows.InsertAt(dr, 0);
            cmbDirigido.ValueMember = "Dirigido";
            cmbDirigido.DisplayMember = "Dirigido";
            cmbDirigido.DataSource = dt;
        }

        private void Buscar_Matriz(object sender, EventArgs e)
        {
            string cadena = TxtCodigo_Convenio.Text;
            string codigo_convenio = cadena.Substring(0, 3);

            if (cmbDirigido.Text == "Pensionados")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-PEN";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);

            }
            else if (cmbDirigido.Text == "Administrativo")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-ADM";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Educadores")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-EDU";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Seccional Ciudades")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-CIU";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Seccional Bogota")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-BOG";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Express")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-EXP";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Aduanas")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-ADU";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Forwarding")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-FOR";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                    TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                    TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Supply")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-SUP";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Zona Franca")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-FRA";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Docentes")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-DOC";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Salud")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-SAL";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Ciudades")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-CIU";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                    TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                    TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Bogotá")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-BOG";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Distrito Capital")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-DC";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Cundinamarca")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-CUN";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else if (cmbDirigido.Text == "Nariño")
            {
                usuario.Codigo_matriz2 = codigo_convenio + "-NAR";
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
            else
            {
                usuario.Codigo_matriz2 = codigo_convenio;
                cmds.Buscar_matriz(TxtNombre_Convenio, TtxRestriccion, TxtDocumentos_Requeridos,
                                   TxtHorarios_Gestion, TxtCondiciones_Especiales, TxtPaz_Salvo,
                                   TxtContacto_Convenio, TxtContacto_Gic, TxtFecha_Actualizacion_Matriz);
            }
        }


        private void cmbDirigido_Click(object sender, EventArgs e)
        {
            if (TxtCodigo_Convenio.Text != "")
            {
                Cargar_dirigido();
            }
            else if (TxtCodigo_Convenio.Text == "")
            {
                MessageBox.Show("Primero debe digitar codigo del convenio correspondiente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
