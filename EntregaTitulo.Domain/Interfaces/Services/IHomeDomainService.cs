using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Services
{
    public interface IHomeDomainService
    {
        Escala Cadastrar(Escala escala);
        List<Escala>  Consultar();
        Escala ObterPorId(int id);
    }
}
