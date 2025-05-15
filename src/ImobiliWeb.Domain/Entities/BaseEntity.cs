using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobiliWeb.Domain.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public Guid Key { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime UpdatedAtUtc { get; set; }
    }
}
