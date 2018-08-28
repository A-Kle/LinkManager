using System;

namespace LinkManager.Data
{
    public class Link
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
    }
}
