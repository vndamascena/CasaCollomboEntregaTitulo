﻿using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Repositories
{
    public interface IPagamentoRepository: IBaseRepository<Pagamento, int>
    {
        List<Pagamento> GetByUsuarioId(string matricula);
        List<Pagamento> GetAll(bool ativo);
    }
}
