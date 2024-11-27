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
    public class TituloReceberFuncionarioDomainService : ITituloReceberFuncionarioDomainService
    {
        private readonly IBaixaTituloFuncionarioRepository _baixaTituloFuncionarioRepository;
        private readonly ITituloReceberFuncionarioRespository _tituloReceberFuncionarioRepository;

        public TituloReceberFuncionarioDomainService(IBaixaTituloFuncionarioRepository baixaTituloFuncionarioRepository,
            ITituloReceberFuncionarioRespository tituloReceberFuncionarioRespository)
        {
            _baixaTituloFuncionarioRepository = baixaTituloFuncionarioRepository;
            _tituloReceberFuncionarioRepository = tituloReceberFuncionarioRespository;
        }



        public TituloReceberFuncionario Atualizar(TituloReceberFuncionario tituloReceberFuncionario, string matricula)
        {
            var registro = ObterPorId(tituloReceberFuncionario.Id);
            if (registro == null)
                throw new ApplicationException("Título não encontrado para edição.");

            var tituloAtualizado = new TituloReceberFuncionario
            {
                Id = registro.Id,


                NomeCliente = tituloReceberFuncionario.NomeCliente,
                NumeroNota = tituloReceberFuncionario.NumeroNota,
                Valor = tituloReceberFuncionario.Valor,
                DataVenda = registro.DataVenda,
                Observacao = tituloReceberFuncionario.Observacao,
                Ativo = registro.Ativo,
                ImagemUrl = registro.ImagemUrl,
                DataCadastro = registro.DataCadastro,
                UsuarioId = registro.UsuarioId,
                Vendedor = registro.Vendedor,
                Loja = registro.Loja,
                UsuarioIdAtualizador = matricula,
                
                DataAlteracao = DateTime.Now,
                DataPrevistaPagamento = tituloReceberFuncionario.DataPrevistaPagamento







            };
            if (registro.DataCadastro == null)
            {
                tituloAtualizado.DataCadastro = DateTime.Now;
            }

            _tituloReceberFuncionarioRepository?.Update(tituloAtualizado);
            return _tituloReceberFuncionarioRepository?.GetById(tituloReceberFuncionario.Id);
        }

        public BaixaTituloFuncionario BaixaTituloFuncionario(int id, string matricula)
        {
            var titulo = _tituloReceberFuncionarioRepository.GetById(id);
            if (!titulo.Ativo)
            {
                throw new ApplicationException("Não é possível dar baixa em uma título inativo.");


            }

            var baixaTitulo = new BaixaTituloFuncionario
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
                
                DataPrevistaPagamento = titulo.DataPrevistaPagamento



            };

            _baixaTituloFuncionarioRepository.Add(baixaTitulo);
            titulo.Ativo = false;
            _tituloReceberFuncionarioRepository.Update(titulo);

            return baixaTitulo;
        }

        public TituloReceberFuncionario Cadastrar(TituloReceberFuncionario tituloReceberFuncionario, string matricula)
        {
            tituloReceberFuncionario.UsuarioId = matricula;
            tituloReceberFuncionario.Ativo = true;
            _tituloReceberFuncionarioRepository?.Add(tituloReceberFuncionario);
            tituloReceberFuncionario = _tituloReceberFuncionarioRepository?.GetById(tituloReceberFuncionario.Id);

            return tituloReceberFuncionario;
        }

        public List<TituloReceberFuncionario> Consultar()
        {
            var tituloReceber = _tituloReceberFuncionarioRepository?.GetAll(true);

            if (tituloReceber == null)
                return new List<TituloReceberFuncionario>();

            return tituloReceber.Where(p => p.Ativo).ToList();
        }

        public List<BaixaTituloFuncionario> ConsultarBaixa()
        {
            var baixaTitulo = _baixaTituloFuncionarioRepository?.GetAll();

            if (baixaTitulo == null)
                return new List<BaixaTituloFuncionario>();

            return baixaTitulo.ToList();
        }

        public TituloReceberFuncionario Delete(int id)
        {
            var tituloReceber = ObterPorId(id);
            if (tituloReceber == null)
                throw new ApplicationException("Título nao encontrada para exclução");



            _tituloReceberFuncionarioRepository.Delete(tituloReceber);
            return tituloReceber;
        }

        public TituloReceberFuncionario ObterPorId(int id)
        {
            var tituloReceber = _tituloReceberFuncionarioRepository?.GetById(id);
            return tituloReceber;
        }
    }
}
