namespace VUB_MVC.Models;

public class BookService{
    public VUB_MVCDbContext Db { get; }

    public BookService( VUB_MVCDbContext context){
        Db = context;
    }
    
}