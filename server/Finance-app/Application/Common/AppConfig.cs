using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public class AppConfig
    {
        public string PostgresConnection { get; set; }
        public string RedisConnection { get; set; }
    }
}
