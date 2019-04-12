var mode = 1; // Biến mode dùng để kiểm tra trường hợp click vào nút Save của form Thêm hay Sửa
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
            dialogGeneral.dialog.dialog('open'); // Đóng dialog
            $('.row-unsell').css('display', 'none');
            mode = 1;
        });
        $(document).on('click', '#btnDupplicate', function () {
            dialogGeneral.dialog.dialog('open');
            $('.row-unsell').css('display', 'none');
            MJS.getRow(); // Gọi hàm lấy dữ liệu của dòng đang chọn
            mode = 2;
        });
        $(document).on('click', '#btnEdit', function () {
            dialogGeneral.dialog.dialog('open');
            $('.row-unsell').css('display', 'flex');
            MJS.getRow(); // Gọi hàm lấy dữ liệu của dòng đang chọn
            mode = 3;

        });
        $(document).on('click', '#btnCancel', function () {
            dialogGeneral.dialog.dialog('close');
            $('.form-dialog input').val(""); // Xóa hết dữ liệu trên các thẻ input
            $('.form-dialog input').prop('checked', false); // Đặt checkbox về trạng thái mặc định
        });
        $(document).on('click', '#btnSave', this.btnSave_OnClick.bind(this));
        $(document).on('click', '#btnDelete', this.deleteRow.bind(this));
        $(document).on('click', '#btnRefresh', this.refreshData.bind(this));
    }

    // Hàm lấy dữ liệu từ phía Database
    // Created by NVTuan ngày - 8/4/2019
    loadData() {
        $.ajax({
            url: "https://localhost:44345/api/Menu/GetAll",
            method: "GET",
            success: function (data) {
                MenuObject.builDataIntoTable(data);
            },
            error: function () {
                console.log("Có lỗi khi lấy dữ liệu");
            }
        });
    }

    // Hàm kiểm tra sự kiện click nút Save của dialog Thêm và Sửa
    btnSave_OnClick() {
        var fields = $('#formDish [fieldData]');
        var menu = new Object();
        $.each(fields, function (index, item) {
            var field = $(item).attr('fieldData');
            if (item.type === "checkbox") {
                menu[field] = $(item).is(":checked");/* Lấy giá trị của ô checkbox*/
                if (field === "showOnMenu") {
                    if (menu[field] === true) {
                        menu[field] = false;
                    } else {
                        menu[field] = true;
                    }
                }
            } else {
                menu[field] = $(item).val();
            }
        });
        menu.quantify = "Chưa thiết lập";
        if (mode === 1) { // Nếu mode = 1 thì thực hiện nút Save ở dialog Thêm
            this.addRow(menu);
        }
        else if (mode === 2) { // Nếu mode = 2 thì thực hiện nút Save ở dialog Nhân bản
            this.dupplicateRow(menu); 
        } else { // Ngược lại thì thực hiện nút Save ở dialog Sửa
            this.editRow(menu);
        }
        dialogGeneral.dialog.dialog('close'); // Đóng dialog lại khi đã thực hiện xong
    }

    // Hàm thêm một bản ghi
    //Created by NVTuan - 11/4/2019
    addRow(menu) {
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

    // Hàm nhân bản một bản ghi
    //Created by NVTuan - 12/4/2019
    dupplicateRow(menu) {
        this.addRow(menu);
    }

    // Hàm lấy một bản ghi
    // Created by NVTuan - 12/4/2019
    getRow() {
        // Lấy dữ liệu của bản ghi cần sửa để đổ lên các trường của dialog
        var id = $('.rowSelected').attr('id');
        $.ajax({
            url: "https://localhost:44345/api/Menu/Get",
            method: "GET",
            headers: {
                id: id
            },
            success: function (data) {
                //Bind dữ liệu lên form dialog
                var fields = $('#formDish [fieldData]');
                $.each(data, function (index, item) {
                    $.each(fields, function (key, value) {
                        var fieldData = $(value).attr('fieldData');
                        var typeData = $(value).attr('type');
                        if (index === fieldData) {
                            if (typeData === "checkbox") {
                                if (value.id === 'showOnMenu') {
                                    if (item === true) {
                                        $('#' + index).prop("checked", false);
                                    } else {
                                        $('#' + index).prop("checked", true);
                                    }
                                } else {
                                    if (item === true) {
                                        $('#' + index).prop("checked", true);
                                    } else {
                                        $('#' + index).prop("checked", false);
                                    }
                                }
                            }
                            else {
                                $('#' + index).val(item);
                            }
                        }
                    });
                });
            },
            error: function () {
                console.log("Có lỗi khi lấy bản ghi");
            }
        });
    }

    // Hàm sửa một bản ghi
    // Created by NVTuan - 12/4/2019
    editRow(menu) {
        var id = $('.rowSelected').attr('id');
        menu.MenuID = id;
        $.ajax({
            url: "https://localhost:44345/api/Menu/Update",
            method: "PUT",
            data: JSON.stringify(menu),
            contentType: "application/json",
            success: function (data) {
                $('#tbodyMenu').children().remove();
                MenuObject.builDataIntoTable(data.data);
                dia.dialog.dialog("close");
            },
            error: function () {
                console.log("Có lỗi khi sửa");
            }
        });
    }

    // Hàm xóa một bản ghi
    //Created by NVTuan 11/4/2019
    deleteRow() {
        var id = $('.rowSelected').attr('id');
        $.ajax({
            url: "https://localhost:44345/api/Menu/Delete",
            method: "DELETE",
            headers: {
                id: id
            },
            success: function (data) {
                MenuObject.builDataIntoTable(data.data);
            },
            error: function () {
                console.log("Có lỗi khi thêm");
            }
        });
    }

    // Hàm nạp dữ liệu
    //Created by NVTuan 12/4/2019
    refreshData() {
        this.loadData();
    }
}
var dialogGeneral = new Dialog('.dialogGeneral', 750, 515); // Khởi tạo dialog dùng chung cho Thêm, Sửa, Nhân Bản
var dialogConfirm = new Dialog('.dialogConfirm', 400,120); // Khởi tạo dialog xác nhận
var MJS = new MenuJS(); // Khởi tạo đối tượng