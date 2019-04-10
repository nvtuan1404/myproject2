// Lớp Dialog chứa hàm khởi tạo dialog
// Created by NVTuan - 9/4/2019
class Dialog {
    constructor(element, width, height) {
        this.dialog = $(element).dialog({
            autoOpen: false,
            height: height,
            width: width,
            modal: true,
            close: function () {

            }
        });
    }
}