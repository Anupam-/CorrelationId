using System;
using System.Collections.Generic;
using System.Text;

namespace CorrelationId.Abstractions
{
    public interface ICorrelationContextFactory
    {
        CorrelationContext HttpContext { get; set; }
    }
}
