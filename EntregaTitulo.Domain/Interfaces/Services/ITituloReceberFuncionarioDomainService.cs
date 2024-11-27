using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Services
{
    public interface ITituloReceberFuncionarioDomainService
    {
        

        TituloReceberFuncionario Cadastrar(TituloReceberFuncionario tituloReceberFuncionario, string matricula);
        TituloReceberFuncionario Atualizar(TituloReceberFuncionario tituloReceberFuncionario, string matricula);
        TituloReceberFuncionario Delete(int id);
        List<TituloReceberFuncionario> Consultar();
        List<BaixaTituloFuncionario> ConsultarBaixa();
        BaixaTituloFuncionario BaixaTituloFuncionario(int id, string matricula);
        TituloReceberFuncionario ObterPorId(int id);
    }
}
