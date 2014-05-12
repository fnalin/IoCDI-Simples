using Demo.IoCDI.Simples.Data.ADO;
using Demo.IoCDI.Simples.Data.EF.Repositorio;
using Demo.IoCDI.Simples.Data.NHibernate.Repositorio;
using Demo.IoCDI.Simples.Dominio;
using Demo.IoCDI.Simples.Dominio.Interfaces;

namespace Demo.IoCDI.Simples.Infra
{
    /*
     * Container do Ninject
     */
    public class ModuloInjecao:Ninject.Modules.NinjectModule
    {
        private Enums.BindContainner _bind;
        public ModuloInjecao(Enums.BindContainner bind)
        {
            this._bind = bind;
        }

        public override void Load()
        {
            switch (_bind)
            {
                case Enums.BindContainner.ADO:
                    Bind<IProdutoRepositorio>().To<ProdutoRepositorioADO>();
                    break;
                case Enums.BindContainner.EF:
                    Bind<IProdutoRepositorio>().To<ProdutoRepositorioEF>();
                    break;
                case Enums.BindContainner.NHibernate:
                    Bind<IProdutoRepositorio>().To<ProdutoRepositorioNH>();
                    break;
                default:
                    break;
            }
        }
    }
}
