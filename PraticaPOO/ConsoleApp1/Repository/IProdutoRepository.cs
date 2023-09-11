using ConsoleApp1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public interface IProdutoRepository
    {
        public void ListarTodos();
        public void Cadastrar(Produto produto);
        public void Atualizar(Produto produto);
        public void Deletar(int id);
    }
}
