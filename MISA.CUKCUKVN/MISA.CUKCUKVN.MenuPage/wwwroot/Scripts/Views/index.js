// Lớp CustomerJS chứa các hàm thêm, sửa, xóa, nạp, nhân bản và hàm khởi tạo các sự kiện
// Created by NVTuan - 29/3/2019
class CustomerJS {

    constructor() {
        this.loadData(); // Gọi hàm load dữ liệu lên bảng
        this.initEvents(); // Khởi tạo hàm chứa các sự kiện
    }

    // Hàm khởi tạo các sự kiện
    // Created by NVTuan - 1/4/2019
    initEvents() {
        $('#tableMenu').on('click', '#tbodyMenu tr', CusObject.rowSelected); // Gọi hàm chọn một bản ghi 
        $(document).on('click', '#btnAdd', function () {
            dia.dialog.dialog('open');
        });
        $(document).on('click', '#btnDupplicate', function () {
            dia.dialog.dialog('open');
        });
        $(document).on('click', '#btnEdit', function () {
            dia.dialog.dialog('open');
        });
        //$(document).on('click', '#btnAdd', this.addRow.bind(this));
    }

    // Hàm loadData để gọi api lấy dữ liệu đổ về
    // Created by NVTuan ngày 29/3/2019
    loadData() {
        $.ajax({
            url: "https://localhost:44345/api/Menu/Get",
            method: "GET",
            success: function (data) {
                CusObject.builDataIntoTable(data);
            },  
            error: function () {
                console.log("Có lỗi khi lấy dữ liệu");
            }
        });
    }


    // Hàm thêm một row
    //Created by NVTuan ngày 1/4/2019
    addRow() {

    } 

    // Hàm nhân bản một row
    //Created by NVTuan ngày 1/4/2019
    dupplicateRow() {

    }

    // Hàm sửa một row
    //Created by NVTuan ngày 1/4/2019
    editRow() {

    }

    // Hàm xóa một row
    //Created by NVTuan ngày 1/4/2019
    deleteRow() {

    }

    // Hàm nạp dữ liệu
    //Created by NVTuan ngày 1/4/2019
    refreshData() {

    }
}
var dia = new Dialog('.dialogCustomer', 680, 386);
var CJS = new CustomerJS(); // Khởi tạo đối tượng