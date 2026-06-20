using System;
using System.Collections.Generic;
using System.Text;

namespace Onyx.Shared.Contracts.Responses
{
    public class NewJobResponse : Response
    {
        public NewJobResponse(string? errorMessage = "") : base(errorMessage)
        {
            
        }
    }
}
