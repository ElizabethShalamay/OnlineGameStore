using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGameStore.DAL.Entities
{
    class Comment
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }

        public Game Game { get; set; }
        public string GameId { get; set; }

        public Publisher Author { get; set; }
        public string AuthorId { get; set; }

        public string Parent { get; set; }
    }
}
