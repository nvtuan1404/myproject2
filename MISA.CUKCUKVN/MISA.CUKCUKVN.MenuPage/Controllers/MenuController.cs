using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MISA.CUKCUKVN.MenuPage.Models;

namespace MISA.CUKCUKVN.MenuPage.Controllers
{
    /// <summary>
    /// Lớp MenuController chứa các hàm Thêm, Sửa, Xóa 
    /// </summary>
    /// Created by NVTuan - 8/4/2019
    [Route("api/Menu/[action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        // GET api/Menu
        [HttpGet]
        public IEnumerable<Menu> Get()
        {
            return Menu.listMenu;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/Menu
        [HttpPost]
        public IActionResult Add(Menu menu)
        {
            menu.CreatedDate = DateTime.Now;
            menu.MenuID = Guid.NewGuid();
            Menu.listMenu.Add(menu);
            return Ok(new { Success = 200, Data = Menu.listMenu.OrderByDescending(x => x.CreatedDate)});
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public IActionResult Delete([FromHeader]string id)
        {
            var menu = Menu.listMenu.Where(x => x.MenuID.ToString() == id).FirstOrDefault();
            Menu.listMenu.Remove(menu);
            return Ok(new {Success = 200, Data = Menu.listMenu.OrderByDescending(x => x.CreatedDate)});
        }
    }
}
