using Livraria.Domain.Entidades;
using Livraria.Domain.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfaces.Repositories
{
    public interface ILivroRepository
    {
        long Inserir(Livro livro);
        void Atualizar(Livro livro);
        void Excluir(long id);
        List<LivroQueryResult> Listar();
        LivroQueryResult Obter(long id);
        bool CheckId(long id);
    }
}
