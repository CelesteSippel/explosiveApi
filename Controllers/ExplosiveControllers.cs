using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;




namespace explosiveApi.Controllers

{
  [ApiController]
  [Route("api/[controller]")]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("{numbers}")]
    public ActionResult<string> Get(string numbers)
    {
      // var bucket = "";
      // // foreach numbers in number
      // foreach (var number in numbers)
      // {
      //   for (var i = 1; i <= number; i++)
      //   {
      //     // add it our bucket
      //     bucket += number;
      //   }
      // }





      var x = String.Join("",
              numbers.Select(
                  number =>
                  String.Join("", Enumerable.Repeat(number, (int)Char.GetNumericValue(number)))));

      return x;
    }
  }
}