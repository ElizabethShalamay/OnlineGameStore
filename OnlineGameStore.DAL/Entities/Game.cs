using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGameStore.DAL.Entities
{
    class Game
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Publisher Publisher { get; set; }
        public string PublisherId { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<PlatformType> Platforms { get; set; }
    }
}
