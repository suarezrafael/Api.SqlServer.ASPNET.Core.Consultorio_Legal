using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Core.Shared.ModelViews
{
    /// <summary>
    /// Objeto utilizado para a atulização de um cliente existente
    /// </summary>
    public class AlteraCliente : NovoCliente
    {
        public int Id { get; set; }
    }
}
