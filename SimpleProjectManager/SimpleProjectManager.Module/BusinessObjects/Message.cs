using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleProjectManager.Module.BusinessObjects
{
    [NavigationItem("Social Media")]
    public class Message
    {
        [Key]
        [Browsable(false)]
        public virtual int Id { get; set; }
        [Required]
        public virtual DateTime SentTime { get; set; }
        [FieldSize(1023)]
        [Required]
        public virtual string Text { get; set; }
        [FieldSize(127)]
        public virtual string Attachment { get; set; }
        [ForeignKey("Sender")]
        [Browsable(false)]
        public virtual int SenderId { get; set; }
        public virtual User Sender { get; set; }

        [ForeignKey("Receiver")]
        [Browsable(false)]
        public virtual int ReceiverId { get; set; }
        public virtual User Receiver { get; set; }
    }
}
