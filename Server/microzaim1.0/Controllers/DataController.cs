using microzaim1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace microzaim1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController : ControllerBase
{
    private readonly ILogger<DataController> _logger;

    //private static List<Data> DataList = Enumerable.Range(0, 10).Select(x => new Data
    //{
    //    Id = Guid.NewGuid().ToString(),
    //    Header = $"Header #{x}",
    //    Text = $"This is some text #{x}"
    //}).ToList();

    private static List<Data> DataList = new List<Data>() 
    {
        new Data(Guid.NewGuid().ToString(),"Гроші на картку миттєво","Іноді може виникнути ситуація, коли необхідні додаткові кошти, і від цього нікуди не дінешся. Кредит на картку протягом 8-15 хвилин - це один з найпопулярніших і простих варіантів для вирішення цієї проблеми."),
        new Data(Guid.NewGuid().ToString(),"Получи деньги в течение 8-15 минут","Завдяки сучасним технологіям кредити на карту дозволяють клієнтам отримати гроші, коли вони особливо необхідні. Сума кредиту після підтвердження доступна клієнту на банківській картці. Після схвалення позики, гроші надходять на карту клієнта миттєво."),
         new Data(Guid.NewGuid().ToString(),"Кредит на картку ","Кредит на картку доступний до 30 000 грн. з терміном повернення до 12 місяців. Новим клієнтам сума кредиту обмежена, в основному до 17 000 грн."),
         new Data(Guid.NewGuid().ToString(),"Кредит на картку ","Кредит на картку доступний до 30 000 грн. з терміном повернення до 12 місяців. Новим клієнтам сума кредиту обмежена, в основному до 17 000 грн."),
         new Data(Guid.NewGuid().ToString(),"Кредит на картку ","Кредит на картку доступний до 30 000 грн. з терміном повернення до 12 місяців. Новим клієнтам сума кредиту обмежена, в основному до 17 000 грн."),
         new Data(Guid.NewGuid().ToString(),"Кредит на картку ","Кредит на картку доступний до 30 000 грн. з терміном повернення до 12 місяців. Новим клієнтам сума кредиту обмежена, в основному до 17 000 грн."),
         new Data(Guid.NewGuid().ToString(),"Кредит на картку ","Кредит на картку доступний до 30 000 грн. з терміном повернення до 12 місяців. Новим клієнтам сума кредиту обмежена, в основному до 17 000 грн."),
         new Data(Guid.NewGuid().ToString(),"Кредит на картку ","Кредит на картку доступний до 30 000 грн. з терміном повернення до 12 місяців. Новим клієнтам сума кредиту обмежена, в основному до 17 000 грн.")


    };



    public DataController(ILogger<DataController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Data> Get()
    {
        _logger.LogInformation("Privet Kerim");
        return DataList;
    }

    [HttpPost]
    public string Post([FromBody] PostDataModel model)
    {
        var data = new Data
        {
            Id = Guid.NewGuid().ToString(),
            Header = model.Header,
            Text = model.Text
        };
        DataList.Add(data);

        return data.Id;
    }

    [HttpGet("{id}")]                                                                    
    public Data GetById(string id)
    {
        return DataList.FirstOrDefault(x => x.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        var index = DataList.FindIndex(0, x => x.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        if (index != -1)
            DataList.RemoveAt(index);

        return StatusCode(204);
    }
}


public class PostDataModel
{
    public string Header { get; set; }
    public string Text { get; set; }
}