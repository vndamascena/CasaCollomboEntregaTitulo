﻿using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Services
{
    public interface ITituloReceberDomainService
    {
        TituloReceber Cadastrar(TituloReceber tituloReceber, string matricula);
        TituloReceber Atualizar(TituloReceber tituloReceber, string matricula);
        TituloReceber Delete(int id);
        List<TituloReceber> Consultar();
        List<BaixaTitulo> ConsultarBaixa();
        BaixaTitulo BaixaTitulo(int id, string matricula);
        TituloReceber ObterPorId(int id);
    }
}