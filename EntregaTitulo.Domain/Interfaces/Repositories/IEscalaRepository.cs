using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Repositories
{
    public interface IEscalaRepository : IBaseRepository<Escala,int>
    {
        List<Escala>Get(int id);
    }
}
