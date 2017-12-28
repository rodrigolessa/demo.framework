using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.domain.Entities;
using demo.frm.infrastructure;

namespace demo.frm.domain.Services
{
    public interface IPaisService
    { 
            PaisView Obter(int id);
            List<PaisView> Obter();
            BusinessResponse<Boolean> Salvar(PaisView item);
            BusinessResponse<Boolean> Excluir(int id);
    }
}
