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
            ProjectMembers = new List<ProjectMembers>();
        }
        public int Id { get; set; }
        public virtual ICollection<ProjectMembers> ProjectMembers { get; set; }
        public string Name { get; set; }
        public EMemberTitle MemberTitle { get; set; }
        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

        
        public int? TeamId { get; set; }
    }
}
