using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleManager.Client.Models
{
    public class MenuItem
    {
        public string Url { get; set; }

        public string Icon { get; set; }
        public string Caption { get; set; }
        public bool Active { get; set; }
    }
}
