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
    public class TituloReceberDomainService : ITituloReceberDomainService
    {
        private readonly IBaixaTituloRepository _baixaTituloRepository;
        private readonly ITituloReceberRepository _tituloReceberRepository;

        public TituloReceberDomainService(IBaixaTituloRepository baixaTituloRepository, ITituloReceberRepository tituloReceberRepository)
        {
            _baixaTituloRepository = baixaTituloRepository;
            _tituloReceberRepository = tituloReceberRepository;
        }

        public TituloReceber Atualizar(TituloReceber tituloReceber, string matricula)
        {
            var registro = ObterPorId(tituloReceber.Id);
            if (registro == null)
                throw new ApplicationException("Título não encontrado para edição.");

            var tituloAtualizado = new TituloReceber
            {
                Id = registro.Id,

              
                NomeCliente = tituloReceber.NomeCliente,
                NumeroNota = tituloReceber.NumeroNota,
                Valor = tituloReceber.Valor,
                DataVenda = registro.DataVenda,
                Observacao = tituloReceber.Observacao,
                Ativo = registro.Ativo,
                ImagemUrl = registro.ImagemUrl,
                DataCadastro = registro.DataCadastro,
                UsuarioId = registro.UsuarioId,
                Vendedor = registro.Vendedor,
                Loja = registro.Loja,
                UsuarioIdAtualizador = matricula,
                Telefone = tituloReceber.Telefone,
                DataAlteracao = DateTime.Now,
                DataPrevistaPagamento = tituloReceber.DataPrevistaPagamento
                
               





            };
            if (registro.DataCadastro == null)
            {
                tituloAtualizado.DataCadastro = DateTime.Now;
            }

            _tituloReceberRepository?.Update(tituloAtualizado);
            return _tituloReceberRepository?.GetById(tituloReceber.Id);
        }

        public BaixaTitulo BaixaTitulo(int id, string matricula)
        {
            var titulo = _tituloReceberRepository.GetById(id);
            if (!titulo.Ativo)
            {
                throw new ApplicationException("Não é possível dar baixa em uma título inativo.");


            }

            var baixaTitulo = new BaixaTitulo
            {
                TituloId = titulo.Id,
                NumeroNota = titulo.NumeroNota,
                NomeCliente = titulo.NomeCliente,
                Valor = titulo.Valor,
                ImagemUrl = titulo.ImagemUrl,
                Vendedor = titulo.Vendedor,
                DataTime = DateTime.Now,
                DataVenda = titulo.DataVenda,
                Observacao = titulo.Observacao,
                Loja = titulo.Loja,
                UsuarioId = matricula,
                Telefone = titulo.Telefone,
                DataPrevistaPagamento = titulo.DataPrevistaPagamento
                


            };

           _baixaTituloRepository.Add(baixaTitulo);
            titulo.Ativo = false;
            _tituloReceberRepository.Update(titulo);

            return baixaTitulo;
        }

        public TituloReceber Cadastrar(TituloReceber tituloReceber, string matricula)
        {
            tituloReceber.UsuarioId = matricula;
            tituloReceber.Ativo = true;
            _tituloReceberRepository?.Add(tituloReceber);
            tituloReceber = _tituloReceberRepository?.GetById(tituloReceber.Id);

            return tituloReceber;
        }

        public List<TituloReceber> Consultar()
        {
            var tituloReceber = _tituloReceberRepository?.GetAll(true);

            if (tituloReceber == null)
                return new List<TituloReceber>();

            return tituloReceber.Where(p => p.Ativo).ToList();
        }

        public List<BaixaTitulo> ConsultarBaixa()
        {
            var baixaTitulo = _baixaTituloRepository?.GetAll();

            if (baixaTitulo == null)
                return new List<BaixaTitulo>();

            return baixaTitulo.ToList();
        }

        public TituloReceber Delete(int id)
        {
            var tituloReceber = ObterPorId(id);
            if (tituloReceber == null)
                throw new ApplicationException("Título nao encontrada para exclução");



            _tituloReceberRepository.Delete(tituloReceber);
            return tituloReceber;
        }

        public TituloReceber ObterPorId(int id)
        {
           var tituloReceber = _tituloReceberRepository?.GetById(id);
            return tituloReceber;
        }
    }
}
