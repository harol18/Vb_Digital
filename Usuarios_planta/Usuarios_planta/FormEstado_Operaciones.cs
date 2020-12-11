using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios_planta
{
    public partial class FormEstado_Operaciones : Form
    {
        Comandos cmds = new Comandos();

        public FormEstado_Operaciones()
        {
            InitializeComponent();
        }

        private void btnVer_pte_Correos_Click(object sender, EventArgs e)
        {
            cmds.Estado_Operaciones(dgvDatos,cmbEstado_Operacion);
        }
    }
}
