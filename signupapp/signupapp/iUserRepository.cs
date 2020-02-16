using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signupapp
{
    public interface iUserRepository
    {
        Task<bool> Insert(User user);
    }
}
