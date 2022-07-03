namespace microzaim1.Models;
public class Data
{
    public string Id { get; set; }
    public string Header { get; set; }
    public string Text { get; set; }
    public Data()
    {

    }
    public Data(string Id, string Header, string Text)
    {
        this.Id= Id; 
        this.Header= Header;   
        this.Text= Text;    
    }
}
