// Hàm format dữ liệu dạng tiền
// Created by NVTuan ngày 1/4/2019
Number.prototype.formatMoney = function () {
    return this.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1.");
};

var CusObject = Object.create({
    // Hàm build dữ liệu lên table
    // Created by NVTuan ngày 29/3/2019
    builDataIntoTable: function (data) {
        $.each(data, function (index, itemData) {
            var column = $('#tableCustomer thead tr th'); // Lấy thông tin các cột dữ liệu
            var rowHTML = '<tr></tr>';
            if (index === 0) {
                rowHTML = '<tr class = "rowSelected" customerId = "' + itemData.customerID + '"></tr>'; // Gán class rowSelected và id cho dòng đầu tiên
            }
            else {
                rowHTML = '<tr customerId = "' + itemData.customerID + '"></tr>'; // Gán id cho các dòng còn lại
            }
            $.each(column, function (index, itemCol) {
                var fieldData = $(itemCol).attr('fieldData'); // Lấy giá trị của các fieldData
                var typeData = $(itemCol).attr('dataType'); // Lấy giá trị của các dataType
                var valueField = itemData[fieldData] ? itemData[fieldData] : ""; // Lấy giá trị của từng cột, nếu có giá trị thì gán vào biến value, nếu không có giá trị (hoặc false) thì gán bằng ""
                switch (typeData) {
                    case "money": {
                        if (valueField) {
                            valueField = new Number(valueField);
                            valueField = valueField.formatMoney();
                            rowHTML = $(rowHTML).append('<td class="text-align-right">' + valueField + '</td>');
                        }
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
            $('#tbodyCustomer').append(rowHTML); // Thêm một row vào table
        });
    },

    // Chọn một bản ghi cụ thể
    // Created by NVTuan ngày 1/4/2019
    rowSelected: function () {
        $('tr').removeClass('rowSelected');
        $(this).addClass('rowSelected');
    },
});