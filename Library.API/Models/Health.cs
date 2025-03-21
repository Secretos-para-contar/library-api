using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Library.API.Models;

[Table("health")]
public class Health : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }
    
    [Column("author")]
    public string Author { get; set; } = string.Empty;
    
    [Column("create_at")]
    public DateTime CreateAt { get; set; }
}