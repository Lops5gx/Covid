using Covid.DTO;
using Covid.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid.Model
{
    public class PaisModel : IpaisModel
    {
        private readonly IpaisRepository _ipaisRepository;
        public PaisModel(IpaisRepository ipais)
        {
            _ipaisRepository = ipais;
        }

        public IEnumerable<Pais> ListarTodos()
        {
            return _ipaisRepository.ListarTodos();
        }
    }
}
