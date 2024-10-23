using BasicMVC.Models.IdentityModels;

namespace BasicMVC.Models.DomainModels
{
    public record Post(
        int Id,
        DateTime CreatedDate, 
        DateTime EditDate,
        string PostText,
        string OwnerId,
        MVCUser Owner,
        ICollection<Comment> Comments
        ) {
        public Post() : this(0, DateTime.Now, DateTime.Now, "", "", null, new List<Comment>()) { } 
    };

    /*   public class Post
       {

           public int Id { get; set; }
           public DateTime CreatedDate { get; set; }
           public DateTime EditDate { get; set; }
           public string PostText { get; set; } = string.Empty;
       }*/
}
