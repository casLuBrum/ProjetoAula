using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;

namespace Views
{
    public partial class frmCadastroCurso : Form
    {
        public int? CursoID { get; set; }
        public Aluno _Aluno { get; set; }
        public frmCadastroCurso(int? idCurso)
        {
            InitializeComponent();

            if (idCurso.HasValue)
            {
                CursoID = idCurso;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimparCampos()
        {
            CursoID = null;
            _Aluno = null;
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            btnSalvar.Text = "Atualizar";
        }

        private void CarregarFormulario()
        {
            if (CursoID.HasValue)
            {

            }
        }

    }
}
