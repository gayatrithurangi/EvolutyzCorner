using EC.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC.Domain.Interfaces
{
    public interface ILoginRepository
    {
        IEnumerable<Users> GetLoginViews();
    }
}
