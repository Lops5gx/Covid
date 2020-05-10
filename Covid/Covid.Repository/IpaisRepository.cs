using System;
using System.Collections.Generic;
using System.Text;

namespace Covid.Repository
{
    public interface IpaisRepository 
    {
        IEnumerable<DTO.Pais> ListarTodos();
    }
}
