using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Repositories
{
    public interface IBaixaTituloFuncionarioRepository: IBaseRepository<BaixaTituloFuncionario, int>
    {
        List<BaixaTituloFuncionario> GetBaixaTituloFuncionarioId(int tituloFuncionarioId);
        List<BaixaTituloFuncionario> GetByUsuarioId(int matricula);

    }
}
