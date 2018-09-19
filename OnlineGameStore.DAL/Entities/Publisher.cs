using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGameStore.DAL.Entities
{
    class Publisher
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Game> Games { get; set; }
    }
}
