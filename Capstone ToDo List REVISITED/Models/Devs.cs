using System;
using System.Collections.Generic;

namespace Capstone_ToDo_List_REVISITED.Models
{
    public partial class Devs
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }
        public string UserId { get; set; }
        public string TaskName { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
