using System;
using System.Windows.Forms;
using Models;
using Controllers;

namespace Views
{
    public partial class frmCadastroAluno : Form
    {
        public int? AlunoID { get; set; }
        public Aluno _Aluno { get; set; }

        public frmCadastroAluno(int? idAluno)
        {
            InitializeComponent();

            if (idAluno.HasValue)
            {
                AlunoID = idAluno;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimparCampos()
        {
            AlunoID = null;
            _Aluno = null;
            txtNome = null;
            txtCpf = null;
            btnSalvar.Text = "Salvar";
        }

        private void CarregarFormulario()
        {
            if (AlunoID.HasValue)
            {
                AlunoController aluController = new AlunoController();
                _Aluno = aluController.Detalhes(AlunoID.Value);

                if(_Aluno != null)
                {
                    txtCpf.Text = _Aluno.CPF;
                    txtNome.Text = _Aluno.Nome;
                    btnSalvar.Text = "Atualizar";
                }
                else
                {
                    LimparCampos();
                }
            }
        }

        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {
            CarregarFormulario();
        }

        private bool Validar()
        {
            return !(String.IsNullOrEmpty(txtCpf.Text)) || !(String.IsNullOrEmpty(txtNome.Text));
        }

        private void Salvar()
        {
            try
            {
                if (Validar())
                {
                    if (AlunoID.HasValue)
                    {
                        AlunoController aluController = new AlunoController();
                        aluController.Editar(AlunoID.Value, txtCpf.Text, txtNome.Text);

                        MessageBox.Show("Aluno alterado com sucesso");
                        LimparCampos();
                        this.Close();
                    }
                    else
                    {
                        AlunoController aluController = new AlunoController();
                        aluController.Adicionar(txtCpf.Text, txtNome.Text);

                        MessageBox.Show("Aluno cadastrado com sucesso");
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Todos campos são obrigatórios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        
    }
}
