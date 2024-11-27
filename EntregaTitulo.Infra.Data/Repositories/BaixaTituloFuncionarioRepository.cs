using EntregaTitulo.Domain.Entities;
using EntregaTitulo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Infra.Data.Repositories
{
    public class BaixaTituloFuncionarioRepository : BaseRepository<BaixaTituloFuncionario, int>, IBaixaTituloFuncionarioRepository
    {
        public List<BaixaTituloFuncionario> GetBaixaTituloFuncionarioId(int tituloFuncionarioId)
        {
            throw new NotImplementedException();
        }

        public List<BaixaTituloFuncionario> GetByUsuarioId(int matricula)
        {
            throw new NotImplementedException();
        }
    }
}
