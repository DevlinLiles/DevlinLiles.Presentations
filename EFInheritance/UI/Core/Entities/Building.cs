using System.Collections.Generic;

namespace Core.Entities
{
    public class Building : WBSItem
    {
        public Building()
        {
            Floors = new List<Floor>();
        }
        public string Color { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Floor> Floors { get; set; }

        public virtual Project Project { get; set; }
    }
}