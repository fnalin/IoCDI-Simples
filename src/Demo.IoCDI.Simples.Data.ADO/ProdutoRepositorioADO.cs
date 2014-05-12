using Demo.IoCDI.Simples.Dominio.Entidades;
using Demo.IoCDI.Simples.Dominio.Global;
using Demo.IoCDI.Simples.Dominio.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Demo.IoCDI.Simples.Data.ADO
{
    public class ProdutoRepositorioADO : IProdutoRepositorio
    {
        //Exemplo de implementação usando ADO
        public IList<Produto> Produtos
        {
            get { return RetornarADO(); }
        }

        private IList<Produto> RetornarADO()
        {
            IList<Produto> prods = new List<Produto>();

            using (var conexao = new SqlConnection(ConnectionStrings.SQLExpress))
            {
                conexao.Open();
                var comando = new SqlCommand("SELECT * FROM tbProd", conexao);
                var dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    prods.Add(new Produto
                    {
                        ID = (int)dr[0],
                        Nome = dr[1].ToString(),
                        Descricao = dr[2].ToString(),
                        Preco = (decimal)dr[3],
                        Categoria = dr[4].ToString()
                    });
                }
                dr.Close();
            }


            return prods;
        }
    }
}
