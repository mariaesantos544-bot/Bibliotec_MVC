using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec_MVC.Models;

namespace Bibliotec_MVC.Interfaces
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> BuscarLivrosAsync();

        Task<IEnumerable<Categoria>> ListarCategoriasAsync();

        Task CadastrarLivro(Livro l);

        Task CadastrarCatLivroAsync(LivroCategoria lc);

        Task DeletarLivroAsync(Livro l);

        Task DeletarCatLivroAsync(int idLivro);

        Task<Livro> BuscarLivroPorIdAsync(int id);



    }
}