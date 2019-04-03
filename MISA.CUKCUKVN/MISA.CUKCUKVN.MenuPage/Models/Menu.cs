using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CUKCUKVN.MenuPage.Models
{
    /// <summary>
    /// Lớp Customer khai báo các thuộc tính của Khách hàng
    /// </summary>
    /// Created by NVTuan ngày 29/3/2019
    public class Menu
    {
        private Guid _menuID;
        private string _dishType;
        private string _dishCode;
        private string _dishName;
        private string _menuGroup;
        private string _dishUnit;
        private string _dishPrice;
        private bool _changeWithPrice;
        private string _quantify;
        private bool _showOnMenu;
        private bool _unsell;
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// Created by NVTuan ngày 29/3/2019
        public Menu() { }

        public static List<Menu> listMenu = new List<Menu>()
        {
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BAPCAI", DishName="Bắp cải",MenuGroup ="", DishUnit="Đĩa", DishPrice="20000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CADOCHIENDON", DishName="Cá dò chiên giòn",MenuGroup ="Cá biển", DishUnit="Đĩa", DishPrice="200000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell= false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="BABAXAOGUNG", DishName="Baba xào gừng",MenuGroup ="Ếch - baba - cua đinh", DishUnit="Đĩa", DishPrice="270000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="CACHEPCHIENXU", DishName="Cá chép chiên xù",MenuGroup ="Cá nước ngọt", DishUnit="Con", DishPrice="189000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DAUPHU", DishName="Đậu phụ",MenuGroup ="Rau lẩu", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="DUACHUOTCHE", DishName="Dưa chuột chẻ",MenuGroup ="Khai vị", DishUnit="Đĩa", DishPrice="10000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="GOISENBAOTU", DishName="Gỏi sen bao tử",MenuGroup ="Gỏi", DishUnit="Đĩa", DishPrice="127000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="HAUNE", DishName="Hàu né",MenuGroup ="Sò - Ốc", DishUnit="Đĩa", DishPrice="190000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="LAUHAISAN", DishName="Lẩu hải sản",MenuGroup ="Các món lẩu", DishUnit="Nồi", DishPrice="250000", ChangeWithPrice= false, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
            new Menu{MenuID = Guid.NewGuid(), DishType = "Món ăn", DishCode="TOMHUMMUTAT", DishName="Tôm hùm mù tạt",MenuGroup ="Tôm", DishUnit="Kg", DishPrice="1800000", ChangeWithPrice= true, Quantify= "Đã thiết lập", ShowOnMenu = true, Unsell=false},
        };

        public Guid MenuID { get => _menuID; set => _menuID = value; }
        public string DishType { get => _dishType; set => _dishType = value; }
        public string DishCode { get => _dishCode; set => _dishCode = value; }
        public string DishName { get => _dishName; set => _dishName = value; }
        public string MenuGroup { get => _menuGroup; set => _menuGroup = value; }
        public string DishUnit { get => _dishUnit; set => _dishUnit = value; }
        public string DishPrice { get => _dishPrice; set => _dishPrice = value; }
        public bool ChangeWithPrice { get => _changeWithPrice; set => _changeWithPrice = value; }
        public string Quantify { get => _quantify; set => _quantify = value; }
        public bool ShowOnMenu { get => _showOnMenu; set => _showOnMenu = value; }
        public bool Unsell { get => _unsell; set => _unsell = value; }
    }
}
