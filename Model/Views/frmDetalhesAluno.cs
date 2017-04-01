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
using Models;

namespace Views
{
    public partial class frmDetalhesAluno : Form
    {
        public frmDetalhesAluno(int alunoID)
        {
            InitializeComponent();

            AlunoController aluController = new AlunoController();
            Aluno alu = aluController.Detalhes(alunoID);

            if(alu != null)
            {
                lblID.Text = alu.AlunoID.ToString();
                lblCpf.Text = alu.CPF;
                lblNome.Text = alu.Nome;
                this.Show();
            }
            else
            {
                MessageBox.Show("Aluno não encontrado", "Erro");
                this.Close();
            }
        }
    }
}
