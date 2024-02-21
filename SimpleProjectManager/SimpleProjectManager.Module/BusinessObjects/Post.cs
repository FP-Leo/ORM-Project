using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleProjectManager.Module.BusinessObjects
{
    [NavigationItem("Social Media")]
    public class Post
    {
        [Key]
        [Browsable(false)]
        public virtual int Id { get; set; }
        [Required]
        public virtual DateTime CreateTime { get; set; }
        [Required]
        [FieldSize(255)]
        public virtual string Content { get; set; }
        [Required]
        [FieldSize(63)]
        public virtual string Location { get; set; }
        [Required]
        [ForeignKey("Poster")]
        [Browsable(false)]
        public virtual int PosterId { get; set; }
        public virtual User Poster { get; set; }
    }
}
