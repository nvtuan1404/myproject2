// Hàm format dữ liệu dạng tiền
// Created by NVTuan - 8/4/2019
Number.prototype.formatMoney = function () {
    return this.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1.");
};

var menu = new Object();
menu.dishType = $('#dishType').val();
menu.dishCode = $('#dishCode').val();
menu.dishName = $('#dishName').val();
menu.menuGroup = $('#menuGroup').val();
menu.dishUnit = $('#dishUnit').val();
menu.dishPrice = $('#dishPrice').val();
menu.changeWithPrice = $('#changeWithPrice').is(":checked");
menu.quantify = $('#quantify').val();
menu.showOnMenu = $('#showOnMenu').is(":checked");
menu.featured = $('#featured').is(":checked");
menu.changeWithFree = $('#changeWithFree').is(":checked");
menu.processingAddress = $('#processingAddress').val();
menu.description = $('#description').val();
menu.costPrice = $('#costPrice').val();
menu.dishIndex = $('#dishIndex').val();

var MenuObject = Object.create({
    // Hàm build dữ liệu lên table
    // Created by NVTuan - 8/4/2019
    builDataIntoTable: function (data) {
        $.each(data, function (index, itemData) {
            var column = $('#tableMenu thead tr th'); // Lấy thông tin các cột dữ liệu
            var rowHTML = '<tr></tr>';
            if (index === 0) {
                rowHTML = '<tr class = "rowSelected" id = "' + itemData.menuID + '"></tr>'; // Gán class rowSelected và id cho dòng đầu tiên
            }
            else {
                rowHTML = '<tr id = "' + itemData.menuID + '"></tr>'; // Gán id cho các dòng còn lại
            }
            $.each(column, function (index, itemCol) {
                var fieldData = $(itemCol).attr('fieldData'); // Lấy giá trị của các fieldData
                var typeData = $(itemCol).attr('dataType'); // Lấy giá trị của các dataType
                var valueField = itemData[fieldData] ? itemData[fieldData] : ""; // Lấy giá trị của từng cột, nếu có giá trị thì gán vào biến value, nếu không có giá trị (hoặc false) thì gán bằng ""
                switch (typeData) {
                    case "money": {
                        valueField = new Number(valueField);
                        valueField = valueField.formatMoney();
                        rowHTML = $(rowHTML).append('<td class="text-align-right">' + valueField + '</td>');
                        break;
                    }
                    case "checkbox": {
                        var checkbox = '<input type="checkbox" disabled/>';
                        if (valueField) {
                            checkbox = '<input type="checkbox" checked="checked" disabled />';
                        }
                        rowHTML = $(rowHTML).append('<td class="text-align-center">' + checkbox + '</td>');
                        break;
                    }
                    default: {
                        rowHTML = $(rowHTML).append('<td class="text-align-left">' + valueField + '</td>');
                        break;
                    }
                }
            });
            $('#tbodyMenu').append(rowHTML); // Thêm một row vào table
        });
    },

    // Chọn một bản ghi cụ thể
    // Created by NVTuan - 8/4/2019
    rowSelected: function () {
        $('tr').removeClass('rowSelected');
        $(this).addClass('rowSelected');
    }
});