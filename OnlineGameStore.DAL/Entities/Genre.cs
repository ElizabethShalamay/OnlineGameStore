using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGameStore.DAL.Entities
{
    class Genre
    {
        [Key]
        public string Name { get; set; }
        public Genre Subgenre { get; set; }

        public IEnumerable<Game> Games { get; set; }
    }
}
