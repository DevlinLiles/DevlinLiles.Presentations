using System.Collections.Generic;
using FrameworkExtension.Core.Interfaces;

namespace Core.Entities
{
    public abstract class WBSItem : Entity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Activity> Activities { get; set; } 
    }
}