using microzaim1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace microzaim1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostItemController : ControllerBase
{
    private readonly ILogger<DataController> _logger;

    //private static List<Data> DataList = Enumerable.Range(0, 10).Select(x => new Data
    //{
    //    Id = Guid.NewGuid().ToString(),
    //    Header = $"Header #{x}",
    //    Text = $"This is some text #{x}"
    //}).ToList();

    private static List<PostItem> PostItemList = new List<PostItem>()
    {
      new PostItem(Guid.NewGuid().ToString(),"https://zecredit.com.ua/assets/images/logo.png","Перший кредит 0.01% до 10000 ","Сума мах 15000 ₴","Вік 18 до 65"),
      new PostItem(Guid.NewGuid().ToString(),"https://zecredit.com.ua/assets/images/logo.png","Ставка 0.01% до 10000 ","Сума мах 10000 ₴","Вік 18 до 65"),
       new PostItem(Guid.NewGuid().ToString(),"https://zecredit.com.ua/assets/images/logo.png","Ставка 0.01% до 10000 ","Сума мах 10000 ₴","Вік 18 до 65"),
        new PostItem(Guid.NewGuid().ToString(),"https://zecredit.com.ua/assets/images/logo.png","Ставка 0.01% до 10000 ","Сума мах 10000 ₴","Вік 18 до 65"),
      new PostItem(Guid.NewGuid().ToString(),"https://zecredit.com.ua/assets/images/logo.png","Повторный кредит 0.01%  ","Сума мах 15000 ₴","Вік 18 до 70")
      };



    public PostItemController(ILogger<DataController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<PostItem> Get()
    {
        _logger.LogInformation("Privet Kerim");
        return PostItemList;
    }

    [HttpPost]
    public string Post([FromBody] PostPostItemModel model)
    {
        var data = new PostItem
        {
            Id = Guid.NewGuid().ToString(),
            Reef = model.Reef,
            Post1 = model.Post1,
            Post2 = model.Post2,
            Post3 = model.Post3
};
        PostItemList.Add(data);

        return data.Id;
    }

    [HttpGet("{id}")]
    public PostItem GetById(string id)
    {
        return PostItemList.FirstOrDefault(x => x.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        var index = PostItemList.FindIndex(0, x => x.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        if (index != -1)
            PostItemList.RemoveAt(index);

        return StatusCode(204);
    }
}


public class PostPostItemModel// для пост запроса 
{
    
    public string Reef { get; set; }
    public string Post1 { get; set; }
    public string Post2 { get; set; }
    public string Post3 { get; set; }
}