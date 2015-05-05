namespace Events.Dal.Model
{
    using System.Data.Entity;

    public class EventsDataContext : DbContext
    {
        public EventsDataContext()
            : base("name=EventsDataContext")
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<EventTypes> EventTypes { get; set; }
        public virtual DbSet<InvitedFriends> InvitedFriends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>()
                .HasMany(e => e.InvitedFriends)
                .WithOptional(e => e.Events)
                .HasForeignKey(e => e.EventId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<EventTypes>()
                .HasMany(e => e.Events)
                .WithOptional(e => e.EventTypes)
                .HasForeignKey(e => e.EventType)
                .WillCascadeOnDelete();
        }
    }
}
