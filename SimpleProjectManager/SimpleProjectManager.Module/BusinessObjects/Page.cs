using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using DevExpress.ExpressApp.DC;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SimpleProjectManager.Module.BusinessObjects
{
    [NavigationItem("Social Media")]
    public class Page
    {
        [Key]
        [Browsable(false)]
        public virtual int Id { get; set; }
        [Required]
        [FieldSize(63)]
        public virtual string PageName { get; set; }
        [FieldSize(255)]
        public virtual string PageDescription { get; set; }
        [Required]
        public virtual int FollowersCount { get; set; }
        public virtual IList<User> ManagedBy { get; set; } = new ObservableCollection<User>();
    }
}
