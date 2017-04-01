using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public partial class frmListagemAlunos : Form
    {
        public frmListagemAlunos()
        {
            InitializeComponent();
        }

        private void CarregarGridViewAlunos()
        {
            dgvAlunos.DataSource = null;
            AlunoController aluController = new AlunoController();
            dgvAlunos.DataSource = aluController.Listar();
        }

        private void frmListagemAlunos_Load(object sender, EventArgs e)
        {
            CarregarGridViewAlunos();
        }

        private void dgvAlunos_SelectionChanged(object sender, EventArgs e)
        {
            if(((DataGridView)sender).SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);

                frmCadastroAluno cadAluno = new frmCadastroAluno(idSelecionado);

                cadAluno.ShowDialog();

                CarregarGridViewAlunos();
            }
        }
    }
}
