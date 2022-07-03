namespace microzaim1.Models;
public class PostItem
{
    public string Id { get; set; }
    public string Reef { get; set; }
    public string Post1 { get; set; }
    public string Post2 { get; set; }
    public string Post3 { get; set; }
    public PostItem()
    {

    }
    public PostItem(string Id, string Reef, string Post1, string Post2, string Post3)
    {
        this.Id = Id;
        this.Reef = Reef;
        this.Post1 = Post1;
        this.Post2 = Post2;
        this.Post3 = Post3;
    }
}
