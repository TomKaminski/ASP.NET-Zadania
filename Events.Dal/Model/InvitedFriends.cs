namespace Events.Dal.Model
{
    using System.ComponentModel.DataAnnotations;

    public class InvitedFriends
    {
        public int Id { get; set; }

        public int? EventId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual Events Events { get; set; }
    }
}
