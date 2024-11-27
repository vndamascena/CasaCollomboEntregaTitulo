using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Repositories
{
    public interface ITituloReceberFuncionarioRespository: IBaseRepository<TituloReceberFuncionario,int>
    {
        List<TituloReceberFuncionario> GetAll(bool ativo);
    }
}
