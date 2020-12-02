using EC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC.Application.Interfaces
{
    public interface ILoginServices
    {
        IEnumerable<LoginViewModel> GetLoginViews(); 
    }
}
