using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SimpleProjectManager.Module.BusinessObjects
{
    [NavigationItem("Social Media")]
    public class User
    {
        [Key]
        [Browsable(false)]
        public virtual int Id { get; set; }
        [Required]
        [FieldSize(31)]
        public virtual String FirstName { get; set; }
        [Required]
        [FieldSize(31)]
        public virtual String LastName { get; set; }
        [Required]
        [FieldSize(63)]
        public virtual String Email { get; set; }
        [Required]
        [FieldSize(63)]
        public virtual String UserName { get; set; }

        public String FullName
        {
            get
            {
                return ObjectFormatter.Format("{FirstName} {LastName}",
            this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }
        public virtual IList<Post> Posts { get; set; } = new ObservableCollection<Post>();
        public virtual IList<Message> SentMessages { get; set; } = new ObservableCollection<Message>();
        public virtual IList<Message> ReceivedMessages { get; set; } = new ObservableCollection<Message>();
        public virtual IList<Page> ManagesPages { get; set; } = new ObservableCollection<Page>();
    }
}
