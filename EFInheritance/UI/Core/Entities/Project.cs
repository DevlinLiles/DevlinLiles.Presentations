using System.Collections.Generic;

namespace Core.Entities
{
    public class Project : WBSItem
    {
        public Project()
        {
            Buildings = new List<Building>();
        }
        public string ProjectName { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
    }
}