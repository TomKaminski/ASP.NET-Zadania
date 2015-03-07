using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Test.Entities
{
    public class Project
    {
        public Project()
        {
            ProjectMembers = new List<ProjectMembers>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProjectMembers> ProjectMembers { get; set; }
    }

    public class ProjectMembers
    {
        [Key]
        public int  ProjectMembersId { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual Member Member { get; set; }
    }
}
