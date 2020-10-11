using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODOLIST.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public bool IsReady { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}