using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAluno cadAluno = new frmCadastroAluno(null);
            cadAluno.MdiParent = this;
            cadAluno.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemAlunos listAlunos = new frmListagemAlunos();
            listAlunos.MdiParent = this;
            listAlunos.Show();
        }
    }
}
