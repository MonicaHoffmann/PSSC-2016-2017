using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_App.Models.Generics
{
    public class SqlServerRepository : IRepository<IEntity>
    {
        private readonly IAggregateFactory _factory;
        private readonly ISettings _settings;

        public SqlServerRepository(IAggregateFactory factory, ISettings settings)
        {
            _factory = factory;
            _settings = settings;
        }
    }
}