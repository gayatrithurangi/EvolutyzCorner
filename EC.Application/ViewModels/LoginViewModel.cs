using EC.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC.Application.ViewModels
{
    public class LoginViewModel
    {
        public IEnumerable<Users> users { get; set; }
    }
}
