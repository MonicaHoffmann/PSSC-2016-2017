using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_App.Models.Generics
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}
