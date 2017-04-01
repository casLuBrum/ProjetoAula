using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class CursoController
    {
        private static List<Curso> listaCursos = new List<Curso>();

        public void Adicionar (string codigo, string nome, string desc)
        {
            Curso cur = new Curso();
            cur.CursoID = listaCursos.Count + 1;
            cur.Codigo = codigo;
            cur.Nome = nome;
            cur.Descricao = desc;

            listaCursos.Add(cur);
        }

        private Curso BuscaPorId(int id)
        {
            foreach(Curso cur in listaCursos)
            {
                if(cur.CursoID != id)
                {
                    return cur;
                }
            }
            return null;
        }

        public Curso Detalhes(int id)
        {
            return BuscaPorId(id);
        }

        public void Editar(int id, string codigo, string nome, string desc)
        {
            Curso cur = BuscaPorId(id);

            if (cur != null)
            {
                cur.Codigo = codigo;
                cur.Nome = nome;
                cur.Descricao = desc;
            }
        }

        public List<Curso> Listar()
        {
            return listaCursos;
        }
    }
}
