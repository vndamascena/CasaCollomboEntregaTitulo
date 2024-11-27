using EntregaTitulo.Domain.Entities;
using EntregaTitulo.Domain.Interfaces.Repositories;
using EntregaTitulo.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Infra.Data.Repositories
{
    public class TituloReceberFuncionarioRepository : BaseRepository<TituloReceberFuncionario, int>, ITituloReceberFuncionarioRespository
    {

        protected readonly DataContext _dataContext;
        public List<TituloReceberFuncionario> GetAll(bool ativo)
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<TituloReceberFuncionario>()

                    .OrderBy(p => p.NomeCliente)

                    .ToList();
        }

        public override List<TituloReceberFuncionario> GetAll()
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<TituloReceberFuncionario>()

                    .OrderBy(p => p.NomeCliente)

                    .ToList();
        }
    }
}
