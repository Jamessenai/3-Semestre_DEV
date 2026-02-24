using Filmes.WebAPI.BdContextFilme;
using Filmes.WebAPI.Interfaces;
using Filmes.WebAPI.Models;

namespace Filmes.WebAPI.Repositorys;

public class GeneroRepositorys : IGeneroRepositorys
{
    private readonly FilmeContext _context;

    public GeneroRepositorys(FilmeContext context)
    {
        _context = context;
    }
    public void AtualizarIdCorpo(Genero generoAtualizado)
    {
        throw new NotImplementedException();
    }

    public void AtualizarIdUrl(Guid id, Genero generoAtualizado)
    {
        throw new NotImplementedException();
    }

    public Genero BuscarPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Cadastra(Genero novoGenero)
    {
        try
        {
            _context.Generos.Add(novoGenero);
            _context.SaveChanges();
        }

        catch (Exception)
        {
            throw;
        }
        
    }

    public void Cadastrar(Genero novoGenero)
    {
        throw new NotImplementedException();
    }

    public void Deletar(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Genero> Listar()
    {
        throw new NotImplementedException();
    }
}
