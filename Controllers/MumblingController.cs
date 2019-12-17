using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace explosiveApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("{letters}")]
    public ActionResult<string> GetAction(string letters)
    {
      return string.Join("-", letters.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
  }
}


// var bucket = "";
// // foreach letter in string
// foreach (var letter in letters)
// {
//   for (var i = 1; i <= letter; i++)
//   {
//     // add it our bucket
//     bucket += letter;
//   }
// }