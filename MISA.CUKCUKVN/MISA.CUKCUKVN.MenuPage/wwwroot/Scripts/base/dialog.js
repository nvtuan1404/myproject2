// Lớp Dialog chứa các hàm khởi tạo, build button động
// Created by NVTuan - 1/4/2019
class Dialog {
    constructor(element, width, height) {
        //if (buttons) {
        //    buttons = this.buildButtons();
        //}
        this.dialog = $(element).dialog({
            autoOpen: false,
            height: height,
            width: width,
            modal: true,
            close: function () {

            }
        });
    }
    //buildButtons() {
    //    var buttons = [
    //        {
    //            text: 'Lưu',
    //            icon: {
    //                primary: 'ui-icon-check' 
    //            },
    //            class: "confirmClass",
    //            id: "btnSave",
    //            click: function () {
    //                $(this).dialog('close');
    //            }
    //        },
    //        {
    //            text: 'Hủy',
    //            icons: {
    //                primary: 'ui-icon-cancel'
    //            },
    //            click: function () {
    //                $(this).dialog('close');
    //            }
    //        },
    //        {
    //            text: 'Giúp',
    //            icons: {
    //                primary: 'ui-icon-help'
    //            },
    //            click: function () {
    //                $(this).dialog('close');
    //            }
    //        }
    //    ];
    //    return buttons;
    //}
}