namespace DefaultNamespace;

/*
entity Rating {
   *Id : int
   UserId : int <<FK>>
   BookId : int <<FK>>
   ---
   Stars : int
   Review : varchar(1024)
   }
   
 */
public class Rating: Base Entity
{
    public int Stars { get; set; }
    public string Review { get; set; }
    public int UserId { get; set; }
    public virtual User ?User { get; set; }
    public int BookId { get; set; }
    public virtual Book ?Book { get; set; }
    
}