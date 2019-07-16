//Hàm hiển thị dialog
//Người tạo NVMANH 27/5/2019
class Dialog {
    //Hàm khởi tạo dialog
    //Người tạo NVMANH 6/6/2019
    constructor(element,width, height) {
        this.dialog = this.createDialog(element, width, height);
    }

    //Tạo một dialog mới
    //Người tạo NVMANH 6/6/2019
    createDialog(element, width, height) {
        var dialog;
        dialog = $(element).dialog({
            autoOpen: false,
            resizable: false,
            height: height,
            width: width,
            modal: true,
            dialogClass: "no-close",
            beforeClose: function (event, ui) {
            }
        });
        return dialog;
    }

    //Mở một dialog
    //Người tạo NVMANH 7/6/2019
    openDialog() {
        //form.checkForm = true;
        //form.allowHotKey = false;
        $('#dialog-add-receipt').dialog("option", "position", { my: "center", at: "center", of: window });
        $('#dialog-add-receipt').dialog({
            resizable: false,
            height: 700,
            width: 900
        });
        this.dialog.dialog('open');
    }
    //Hàm hiển thị full màn hình cho dialog
    //Người tạo NVMANH 8/6/2019
    resizeDialog(id, input,heightDialog, widthDialog) {
        var myIcon = '<span class="icon-dialog-resize"></span>';
        $(input).prev().find(".ui-dialog-title").after(myIcon);
        $(input).prev().find(".ui-dialog-title").after('<span class="icon-dialog-close"></span>');
        $(input).prev().find(".ui-dialog-titlebar-close").css('display', 'none');
        $(id).prev().find('.icon-dialog-resize').on('click', function () {
            if ($(id).dialog('option', 'height') === heightDialog) {
                $(id).dialog({
                    resizable: false,
                    height: $(window).height(),
                    width: $(window).width()
                });
                $(id).dialog("option", "position", { my: "center", at: "center", of: window });
            } else {
                $(id).dialog({
                    resizable: false,
                    height: heightDialog,
                    width: widthDialog
                });
                $(id).dialog("option", "position", { my: "center", at: "center", of: window });
            }
        });
        $(id).prev().find(".ui-dialog-titlebar-close").on('click', function () {
            $(id).dialog({
                resizable: false,
                height: heightDialog,
                width: widthDialog
            });
            $(id).dialog("option", "position", { my: "center", at: "center", of: window });
        });
    }
    //Chuyển đổi giữa hai radio button Khác và Thu nợ
    //Người tạo NVMANH 8/6/2019
    convertTabByRadio(id) {
        $(id).find('#radio1').change(function () {
            if ($(this).is(":checked")) {
                $(id).find(".dialog-body-different").show();
                $(id).find(".dialog-body-debt").hide();
                $(id).find(".dialog-panel-purpose-collect").hide();
                $(".dialog-body-different").find('input').not('#employee-input-right').attr('disabled', false);
                $('#object-input-left').focus();
            }
        });
        $(id).find('#radio2').change(function () {
            if ($(this).is(":checked")) {
                $(id).find(".dialog-body-debt").show();
                $(id).find(".dialog-body-different").hide();
                $(id).find(".dialog-panel-purpose-collect").show();
                var debtInfoDisable = $('.dialog-body-debt .object-input-left,.dialog-body-debt .object-input-right,.dialog-body-debt .employee-input-right');
                debtInfoDisable.find('input').attr('disabled', true);
            }
        });
    }
    //Reset lại dialog về ban đầu
    //Người tạo NVMANH 8/6/2019
    resetDialog(input) {
        $(input).attr("class", "ui-dialog-content ui-widget-content");
        $(input).prev().find(".icon-dialog-resize").remove();
        $(input).prev().find(".icon-dialog-close").remove();
    }
}

//Tạo một đối tượng của lớp Dialog 
//Người tạo NVMANH 7/6/2019
var dialog = new Dialog();
