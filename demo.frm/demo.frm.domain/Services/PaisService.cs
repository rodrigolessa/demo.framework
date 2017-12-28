using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.domain.Entities;
using demo.frm.domain.Repositories;
using demo.frm.infrastructure;

namespace demo.frm.domain.Services
{
    public class PaisService : IPaisService
    {
        #region Atributos

        private readonly IPaisRepository _repository;

        #endregion

        #region Construtor

        public PaisService(IPaisRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region IPaisService membros

        public PaisView Obter(int id)
        {
            return _repository.Get(id);
        }

        public List<PaisView> Obter()
        {
            return _repository.GetAll().ToList();
        }

        public BusinessResponse<bool> Salvar(PaisView item)
        {
            _repository.Add(item);
            return new BusinessResponse<bool>((_repository.UnitOfWork.Commit() > 0));
        }

        public BusinessResponse<bool> Excluir(int id)
        {
            var pais = _repository.Get(id);
            if (pais != null)
            {
                _repository.Remove(pais);
                return new BusinessResponse<bool>((_repository.UnitOfWork.Commit() > 0));
            }
            else
                return new BusinessResponse<bool>(false, Messages.ValidationExcluirRegistroNaoEncontrado);
        }

        #endregion
    }
}