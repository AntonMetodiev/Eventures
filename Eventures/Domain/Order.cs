using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Domain
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public DateTime OrderedOn { get; set; }
        public string EventureId { get; set; }
        public Eventure Eventure { get; set; }
        public string CustomerId { get; set; }
        public EventuresUser Customer { get; set; }
        public int TicketsCount { get; set; }
    }
}
