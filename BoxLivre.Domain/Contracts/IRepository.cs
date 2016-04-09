using System.Collections;
using System.Collections.Generic;

namespace BoxLivre.Domain.Contracts
{
    public interface IRepository<T> where T : class
    {
        bool Adicionar(T obj);
        bool Atualizar(T obj);
        bool Excluir(T obj);
        IEnumerable<T> Listar();
        T ListarPorId(int id);
    }
}
