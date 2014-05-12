using System.Collections.Generic;

namespace Demo.IoCDI.Simples.Dominio.Interfaces
{
    /*
     * Interface que garante o desacoplamento com o Framework de persistência
     */
    public interface IProdutoRepositorio
    {
        IList<Entidades.Produto> Produtos { get; }
    }
}