using Demo.IoCDI.Simples.Dominio;

namespace Demo.IoCDI.Simples.Infra
{
    public class InfraKernel : Ninject.StandardKernel
    {
        public InfraKernel(Enums.BindContainner bind)
            :base(new ModuloInjecao(bind))
        {}
    }
}
