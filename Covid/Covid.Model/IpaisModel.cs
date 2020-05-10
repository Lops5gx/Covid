using System;
using System.Collections.Generic;
using System.Text;

namespace Covid.Model
{
    public interface IpaisModel
    {
        IEnumerable<DTO.Pais> ListarTodos();
    }
}
