using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Repositories
{
    public interface IImpressaoRepository: IBaseRepository <Impressao, int>
    {

        List<Impressao> GetByUsuarioId(string matricula);
        List<Impressao> GetAll(bool ativo);
    }
}
