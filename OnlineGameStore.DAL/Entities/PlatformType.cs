using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGameStore.DAL.Entities
{
    class PlatformType
    {
        [Key]
        public string Type { get; set; }
        public IEnumerable<Game> Games { get; set; }
    }
}
