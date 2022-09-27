namespace VUB_MVC.Models;

public class Book{
    public int Id { get; set; }
    public string? Name { get; set;}
    public string? Description { get; set; }

    public int TypesId { get; set; }
  
    public BookType? Types { get; set; }

}