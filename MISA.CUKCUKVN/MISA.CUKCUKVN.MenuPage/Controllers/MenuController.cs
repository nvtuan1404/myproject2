using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MISA.CUKCUKVN.MenuPage.Models;

namespace MISA.CUKCUKVN.MenuPage.Controllers
{
    /// <summary>
    /// Lớp MenuController chứa các controller GetAll, Get,  Add, Update, Delete
    /// </summary>
    /// Created by NVTuan - 8/4/2019
    [Route("api/Menu/[action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        /// <summary>
        /// Hàm lấy tất cả các bản ghi
        /// </summary>
        /// <returns>Trả về một danh sách các bản ghi</returns>
        /// Created by NVTuan - 11/4/2019
        [HttpGet]
        public IEnumerable<Menu> GetAll()
        {
            return Menu.listMenu.OrderByDescending(x => x.ModifiedDate);
        }
        /// <summary>
        /// Hàm lấy một bản ghi
        /// </summary>
        /// <param name="id">Là id của bản ghi muốn lấy</param>
        /// <returns>Trả về bản ghi tìm được</returns>
        /// Created by NVTuan - 11/4/2019
        [HttpGet]
        public ActionResult<Menu> Get([FromHeader] string id)
        {
            return Menu.listMenu.FirstOrDefault((x => x.MenuID.ToString() == id));
        }
        /// <summary>
        /// Hàm thêm một bản ghi
        /// </summary>
        /// <param name="menu">Bản ghi muốn thêm vào</param>
        /// <returns>Trả về một dánh sách các bản ghi</returns>
        /// Created by NVTuan - 11/4/2019
        [HttpPost]
        public IActionResult Add(Menu menu)
        {
            menu.ModifiedDate = DateTime.Now;
            menu.MenuID = Guid.NewGuid();
            Menu.listMenu.Add(menu);
            return Ok(new { Success = 200, Data = Menu.listMenu.OrderByDescending(x => x.ModifiedDate) });
        }
        /// <summary>
        /// Hàm sửa một bản ghi
        /// </summary>
        /// <param name="menuEdited">Bản ghi đã chỉnh sửa</param>
        /// <returns>Trả về một danh sách các bản ghi</returns>
        /// Created by NVTuan - 12/4/2019
        [HttpPut]
        public IActionResult Update([FromBody] Menu menuEdited)
        {
            menuEdited.ModifiedDate = DateTime.Now;
            var itemIndex = Menu.listMenu.FindIndex(x => x.MenuID == menuEdited.MenuID);
            Menu.listMenu.RemoveAt(itemIndex);
            Menu.listMenu.Add(menuEdited);
            return Ok(new { Success = 200, Data = Menu.listMenu.OrderByDescending(x => x.ModifiedDate) });
        }
        /// <summary>
        /// Hàm xóa một bản ghi
        /// </summary>
        /// <param name="id">Là Id của bản ghi muốn xóa</param>
        /// <returns>Trả về một danh sách các bản ghi</returns>
        /// Created by NVTuan - 11/4/2019
        [HttpDelete]
        public IActionResult Delete([FromHeader]string id)
        {
            var itemIndex = Menu.listMenu.FindIndex(x => x.MenuID.ToString() == id);
            Menu.listMenu.RemoveAt(itemIndex);
            return Ok(new { Success = 200, Data = Menu.listMenu.OrderByDescending(x => x.ModifiedDate) });
        }
    }
}
