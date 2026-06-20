using System;
using System.Collections.Generic;
using System.Text;

namespace Onyx.Shared.Contracts.Responses
{
    public class CreateInvoiceResponse : Response
    {
        public CreateInvoiceResponse(string? errorMessage = "") : base(errorMessage)
        {
            
        }
    }
}
