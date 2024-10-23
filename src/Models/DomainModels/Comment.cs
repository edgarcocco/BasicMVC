using BasicMVC.Models.IdentityModels;

namespace BasicMVC.Models.DomainModels
{
    public record Comment(
        int Id,
        DateTime CreatedDate,
        DateTime EditDate,
        string CommentText,
        int PostId,
        Post Post,
        string OwnerId,
        MVCUser Owner
        )
    {
        public Comment() : this(0, DateTime.Now, DateTime.Now, "", 0, null, "", null) { } 
    };
}
