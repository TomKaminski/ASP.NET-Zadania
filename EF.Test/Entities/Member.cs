using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Test.Entities
{
    public enum EMemberTitle
    {
        Developer,
        TeamLeader,
        ScrumMaster,
        Tester
    }
    public class Member
    {
        public Member()
        {
            Projects = new List<Project>();
        }
        public int Id { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public string Name { get; set; }
        public EMemberTitle MemberTitle { get; set; }
        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

        
        public int? TeamId { get; set; }
    }
}
