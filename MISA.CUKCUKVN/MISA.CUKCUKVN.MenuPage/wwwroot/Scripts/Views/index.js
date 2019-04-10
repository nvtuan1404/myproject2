// Lớp MenuJS chứa các hàm thêm, sửa, xóa, nạp, nhân bản và hàm khởi tạo các sự kiện
// Created by NVTuan - 8/4/2019
class MenuJS {

    constructor() {
        this.loadData(); // Gọi hàm load dữ liệu lên bảng
        this.initEvents(); // Khởi tạo hàm chứa các sự kiện
    }

    // Hàm khởi tạo các sự kiện
    // Created by NVTuan - 8/4/2019
    initEvents() {
        $('#tableMenu').on('click', '#tbodyMenu tr', MenuObject.rowSelected); // Gọi hàm chọn một bản ghi 
        $(document).on('click', '#btnAdd', function () {
            dia.dialog.dialog('open');
            $('.row-unsell').css('display', 'none');
        });
        $(document).on('click', '#btnDupplicate', function () {
            dia.dialog.dialog('open');
            $('.row-unsell').css('display', 'none');
        });
        $(document).on('click', '#btnEdit', function () {
            dia.dialog.dialog('open');
            $('.row-unsell').css('display', 'flex');
        });
        $(document).on('click', '#btnCancel', function () {
            dia.dialog.dialog('close');
        });
        $(document).on('click', '#btnSave', this.addRow.bind(this));
        $(document).on('click', '#btnDelete', this.deleteRow.bind(this));
    }

    // Hàm loadData để gọi api lấy dữ liệu đổ về
    // Created by NVTuan ngày 8/4/2019
    loadData() {
        $.ajax({
            url: "https://localhost:44345/api/Menu/Get",
            method: "GET",
            success: function (data) {
                MenuObject.builDataIntoTable(data);
            },  
            error: function () {
                console.log("Có lỗi khi lấy dữ liệu");
            }
        });
    }


    // Hàm thêm một row
    //Created by NVTuan 8/4/2019
    addRow() {
        var fields = $('#formDish [fieldData]');
        var menu = new Object();
        $.each(fields, function (index, item) {
            var field = $(item).attr('fieldData');
            if (item.type === "checkbox") {
                menu[field] = $(item).is(":checked");
            } else {
                menu[field] = $(item).val();
            }
        });
        $.ajax({
            url: "https://localhost:44345/api/Menu/Add",
            method: "POST",
            data: JSON.stringify(menu),
            contentType: "application/json",
            success: function (data) {
                $('#tbodyMenu').children().remove();
                MenuObject.builDataIntoTable(data.data);
                dia.dialog.dialog("close");
            },
            error: function () {
                console.log("Có lỗi khi thêm");
            }
        });
    } 

    // Hàm nhân bản một row
    //Created by NVTuan 8/4/2019
    dupplicateRow() {

    }

    // Hàm sửa một row
    //Created by NVTuan 8/4/2019
    editRow() {

    }

    // Hàm xóa một row
    //Created by NVTuan 8/4/2019
    deleteRow() {
        var id = $('.rowSelected').attr('id');
        $.ajax({
            url: "https://localhost:44345/api/Menu/Delete",
            method: "DELETE",
            headers: {
                id: id
            },
            success: function (data) {
                $('#tbodyMenu').children().remove();
                MenuObject.builDataIntoTable(data.data);
            },
            error: function () {
                console.log("Có lỗi khi thêm");
            }
        });
    }

    // Hàm nạp dữ liệu
    //Created by NVTuan 8/4/2019
    refreshData() {

    }
}
var dia = new Dialog('.dialogMenu', 750, 515);
var MJS = new MenuJS(); // Khởi tạo đối tượng