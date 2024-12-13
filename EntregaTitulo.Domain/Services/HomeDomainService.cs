using EntregaTitulo.Domain.Entities;
using EntregaTitulo.Domain.Interfaces.Repositories;
using EntregaTitulo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Services
{
    public class HomeDomainService : IHomeDomainService
    {
        private readonly IHomeDomainService _homeDomainService;
        private readonly IEscalaRepository _escalaRepository;
        public HomeDomainService(IEscalaRepository escalaRepository)
        {
            _escalaRepository = escalaRepository;
        }




        public Escala Cadastrar(Escala escala)
        {
           
            _escalaRepository?.Add(escala);
            escala = _escalaRepository?.GetById(escala.Id);

            return escala;
        }

        public List<Escala> Consultar()
        {
            var escala = _escalaRepository?.GetAll();
            if (escala == null)
                return new List<Escala>();
           return escala.ToList();
        }

        public Escala ObterPorId(int id)
        {
            var escala = _escalaRepository.GetById(id);
            return escala;
            
        }
    }
}
