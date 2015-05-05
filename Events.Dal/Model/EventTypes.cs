namespace Events.Dal.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class EventTypes
    {
        public EventTypes()
        {
            Events = new HashSet<Events>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Events> Events { get; set; }
    }
}
