using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Repositories
{
    public interface ITituloReceberRepository: IBaseRepository<TituloReceber, int>
    {
        List<TituloReceber> GetAll(bool ativo);
    }
}
