using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstTry
{
    public partial interface IDBSession
    {
        int SaveChange(); //manage
    }
}
