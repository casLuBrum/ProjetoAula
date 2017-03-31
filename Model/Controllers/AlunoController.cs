using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class AlunoController
    {
        private static List<Aluno> listaAlunos = new List<Aluno>();

        public void Adicionar(string cpf, string nome)
        {
            Aluno alu = new Aluno();
            alu.AlunoID = listaAlunos.Count + 1;
            alu.CPF = cpf;
            alu.Nome = nome;

            listaAlunos.Add(alu);
        }

        private Aluno BuscarPorId(int id)
        {
            foreach(Aluno alu in listaAlunos)
            {
                if(alu.AlunoID == id)
                {
                    return alu;
                }
            }
            return null;
        }

        public Aluno Detalhes(int id)
        {
            return BuscarPorId(id);
        }

        public void Editar(int id, string novoCpf, string novoNome)
        {
            Aluno alu = BuscarPorId(id);

            if(alu != null)
            {
                alu.CPF = novoCpf;
                alu.Nome = novoNome;
            }
        }

        public List<Aluno> Listar()
        {
            return listaAlunos;
        }
    }
}
