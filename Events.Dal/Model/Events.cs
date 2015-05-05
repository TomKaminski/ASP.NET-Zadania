namespace Events.Dal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Events
    {
        public Events()
        {
            InvitedFriends = new HashSet<InvitedFriends>();
        }

        public int Id { get; set; }

        public int? EventType { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public DateTime? Created { get; set; }

        public virtual EventTypes EventTypes { get; set; }

        public virtual ICollection<InvitedFriends> InvitedFriends { get; set; }
    }
}
