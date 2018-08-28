using System;
using System.Collections.Generic;
using System.Text;

namespace LinkManager.Data
{
    public class Group
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public Group Subgroup { get; set; }
    }
}
