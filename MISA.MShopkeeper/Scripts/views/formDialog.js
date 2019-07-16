//Tạo class formDialog
//Người tạo NVMANH 7/6/2019

class FormDialog {

    //Phương thức khởi tạo
    //Người tạo NVMANH 7/6/2019
    constructor() {
        //Kiểm tra sự kiện nút Lưu trên dialog sửa hay thêm
        //Người tạo NVMANH 6/7/2019
        this.checkAdd = true;
        //Hàm khởi tạo sự kiện
        //Người tạo NVMANH 10/6/2019
        this.initEvent();
        //Khởi tạo dialog thêm mới nhân bản xem sửa
        //người tạo NVMANH 18/6/2019
        this.dialogDetail = new Dialog("#dialog-add-receipt", 900, 700);
        //Khởi tạo dialog chọn hóa đơn
        //người tạo NVMANH 18/6/2019
        this.dialogBill = new Dialog("#dialog-collect-debt", 840, 600);
        //Khởi tạo dialog chọn nhà cung cấp và nhân viên
        //người tạo NVMANH 18/6/2019
        this.dialogObject = new Dialog("#dialog-object-pay", 800, 600);
        //Khởi tạo dialog cảnh báo
        //Người tạo NVMANH 18/6/2019
        this.dialogAlert = new Dialog("#dialog-delete", 400, 156);
        //Id nhân viên khi sửa
        //Người tạo NVMANH 17/6/2019
        this.employeeIDEdit;
        //Id nhà cung cấp khi sửa
        //Người tạo NVMANH 17/6/2019
        this.supplierIDEdit;
        //Mã hóa đơn
        //Người tạo NVMANH 17/6/2019
        this.fundID;
    }

    //Hàm khởi tạo sự kiện
    //Người tạo NVMANH 10/6/2019
    initEvent() {
        //Hiện dialog khi nhấn các button trên thanh menu
        //Người tạo NVMANH 7/6/2019
        this.setButton();
        //Cài đặt phím tắt cho các chức năng
        //Người tạo NVMANH 12/6/2019
        this.setAllHotKey();
        //Hàm xử lý autofocus
        //Người tạo NVMANH 12/6/2019
        this.setFocus();
        //Xử lý số thu trên dialog Chọn hóa đơn thu nợ
        //Người tạo NVMANH 4/7/2019
        this.inputCollectMoney();
        //Tính tổng tiền trong bảng chi tiết
        //Người tạo NVMANH 8/7/2019
        this.inputMoneyDetail();
        //Hiển thị bảng chọn dữ liệu khách hàng
        //Người tạo NVMANH 13/7/2019
        this.displayTableEmployee();
        //Sự kiện cho button chọn nhân viên khi thêm phiếu thu nợ
        //Người tạo NVMANH 13/7/2019
        this.evtSelectEmployee();
        //Hàm thực hiện autocomplete danh sách đối tượng nộp
        //Người tạo NVMANH 15/7/2019
        this.autocompleteSupplier();
        //Hàm thực hiện autocomplete danh sách nhân viên
        //Người tạo NVMANH 15/7/2019
        this.autocompleteEmployee();
    }
    //Hiện dialog khi nhấn các button trên thanh menu
    //Người tạo NVMANH 7/6/2019
    setButton() {
        //sự kiện mở dialog thêm phiếu chi
        //Người tạo NVMANH 18/6/2019
        $('#add-pay').click(this.addPayMoney);
        //Sự kiện mở dialog Thêm phiếu thu
        //Người tạo NVMANH 18/6/2019
        $("#add-receipt").click(this.addCollectMoney);
        $(".dialog-header-item-add").click(this.addCollectMoney);
        //Sự kiện mở dialog nhân bản
        //Người tạo NVMANH 18/6/2019
        $('#toolbar-item-duplicate').click(this.dataDialogDuplicate);
        //Sự kiện mở dialog xem
        //Người tạo NVMANH 18/6/2019
        $('#toolbar-item-view').click(this.dataDialogView);
        $(document).on('click', '.format-voucher-number', this.dataDialogView);
        $(document).on('click', '.dialog-header-item-back', this.dataDialogView);
        $(document).on('dblclick', '.row-content', this.dataDialogView);
        //Sự kiện ẩn hiện menu trên thanh header chính
        //Người tạo NVMANH 18/6/2019
        $(document).on('click', '.check-content-table-main, .check-all', this.noCheckedTable);
        //Sự kiện mở dialog sửa
        //Người tạo NVMANH 18/6/2019
        $('#toolbar-item-edit').click(this.dataDialogEdit);
        $('.dialog-header-item-edit').click(this.dataDialogEdit);
        //Sự kiện mở dialog xóa
        //Người tạo NVMANH 18/6/2019
        $('#toolbar-item-delete').click(this.dataDialogDelete);
        $(document).on('click', '.dialog-header-item-delete', this.dataDialogDelete);
        //Sự kiện Nạp lại trang
        //Người tạo NVMANH 23/6/2019
        $('#toolbar-item-refresh').click(this.eventBtnRefresh);
        $('.icon-refresh').click(this.eventBtnRefresh);
        //Sự kiện mở dialog chọn hóa đơn thu nợ
        //Người tạo NVMANH 18/6/2019
        $('body').on('click', '.add-collect-money #btn-collect-debt', this.selectBillDialogCollect);
        //$('body').on('click', '.duplicate #btn-collect-debt', this.selectBillDialogCollect);
        $('body').on('click', '.bill-collect #btn-collect-debt', this.selectBillDialogCollect);
        //Sự kiện mở dialog chọn hóa đơn trả nợ
        //Người tạo NVMANH 24/6/2019
        $('body').on('click', '.add-pay-money #btn-collect-debt', this.selectBillDialogPay);
        $('body').on('click', '.bill-pay #btn-collect-debt', this.selectBillDialogPay);

        //Mở dialog chọn đối tượng
        //Người tạo NVMANH 18/6/2019
        $('#icon-input-search-object').click(this.selectObjectDialog);
        //Mở dialog chọn nhân viên
        //Người tạo NVMANH 18/6/2019
        $('.dialog-info-employee-input .icon-input-search').click(this.selectEmployeeDialog);
        //Sự kiện cho nút Đóng trên header Dialog
        //Người tạo NVMANH 18/6/2019
        $('.dialog-header-item-close').click(this.eventBtnClose);
        $(document).on('click', '[aria-describedby="dialog-add-receipt"] .icon-dialog-close', this.eventBtnClose);
        $(document).on('click', '[aria-describedby="dialog-collect-debt"] .icon-dialog-close', function () {
            $('#dialog-collect-debt').dialog('close');
            $('#collect-input-1').val("");
            $('#collect-input-3').val("0");
            $('.wrap-collect-table-body').html("");
            $('.col-table-footer-collected .wrap-text-footer-table').text("0");
            $('.col-table-footer-collect .wrap-text-footer-table').text("0");
        });
        $(document).on('click', '.dialog-btn-cancel', function () {
            $('#collect-input-1').val("");
            $('#collect-input-3').val("0");
            $('.wrap-collect-table-body').html("");
            $('.col-table-footer-collected .wrap-text-footer-table').text("0");
            $('.col-table-footer-collect .wrap-text-footer-table').text("0");
            $('.col-table-footer-collecting .wrap-text-footer-table').text("0");
        });
        //Lưu dữ liệu
        //Người tạo NVMANH 18/6/2019
        $('body').on('click', '.dialog-close-save, .dialog-header-item-save', this.eventBtnSave);
        //Không lưu dữ liệu
        //Người tạo NVMANH 18/6/2019
        $('.dialog-close-no-save').click(this.eventBtnNoSave);
        //Hủy form
        //Người tạo NVMANH 18/6/2019
        $('.btn-cancel').click(this.eventBtnCancel);
        //Sự kiện nút hủy trên form xóa
        //Người tạo NVMANH 18/6/2019
        $('.btn-delete-cancel').click(this.eventBtnDeleteCancel);
        //Sự kiện nút đồng ý trên form cảnh báo
        //Người tạo NVMANH 18/6/2019
        $('.dialog-warn-agree').click(this.agreeBtnWarn);
        //Sự kiện nút Sau trên dialog
        //Người tạo NVMANH 18/6/2019
        $('#combobox-after-down').click(this.nextRow);
        //Sự kiện nút Trước trên Dialog
        //Người tạo NVMANH 18/6/2019
        $('#combobox-before-down').click(this.prevRow);
        //Sự kiện ấn vào nút trợ giúp
        //Người tạo NVMANH 18/6/2019
        $('.dialog-header-item-help, .btn-help-select-bill').click(this.eventBtnHelp);
        //Nút xóa trên dialog Xóa
        $('.btn-delete-agree').click(this.deleteRowFund);
        //Disabled cho các trường trong dialog hóa đơn thu nợ
        //Người tạo NVMANH 22/6/2019
        $('#collect-input-1').keyup(this.checkInputNameCustomer);
        //Bắt sụ kiện cho nút Trả nợ
        //Người tạo NVMANH 2/7/2019
        $('body').on('click', '.dialog-btn-pay', this.eventBtnCollect);
        //Thêm dòng mới trong bảng chi tiết trên dialog
        //Người tạo NVMANH 3/7/2019
        $('body').on('click', '.context-menu', this.addRowTable);
        //Đồng ý chọn dòng nhà cung cấp
        //Người tạo NVMANH 9/7/2019
        $('body').on('click', '.object .wrap-btn-agree', this.evtBtnAgreeSupplier);
        //Đồng ý chọn dòng nhân viên
        //Người tạo NVMANH 9/7/2019
        $('body').on('click', '.employee .wrap-btn-agree', this.evtBtnAgreeEmployee);
        //Sự kiện click cho bảng chọn nhân viên và nhà cung cấp
        //Người tạ NVMANH 10/7/2019
        $('body').on('click', '.row-body-object-pay', this.clickRowPerson);
    }

    //Mở dialog Thêm mới phiếu thu
    //Người tạo NVMANH 7/6/2019
    addCollectMoney() {
        form.checkAdd = true;
        $('#dialog-add-receipt input').val("");
        $('#col-total-money span').text("0");
        $('.table-detail-body').html("");
        form.addRowTable();
        form.createIDCollect();
        moneyfund.formatDateTime();
        form.dialogDetail.resetDialog('#dialog-add-receipt');
        form.dialogDetail.openDialog();
        $('[aria-describedby="dialog-add-receipt"]').find('.ui-dialog-title').text("Thêm mới phiếu thu");
        $('[aria-describedby="dialog-add-receipt"]').find('.dialog-info-object-label').text("Khách hàng");
        $('[aria-describedby="dialog-add-receipt"]').find('.dialog-info-submitter-label').text("Người nộp");
        $('[aria-describedby="dialog-add-receipt"]').find('.dialog-info-reason-label').text("Lý do thu");
        $('[aria-describedby="dialog-add-receipt"]').find('.dialog-info-employee-label').text("Nhân viên thu");
        $("#dialog-add-receipt").addClass("add-collect-money");
        form.dialogDetail.resizeDialog('#dialog-add-receipt', ".add-collect-money", 700, 900);
        form.dialogDetail.convertTabByRadio('.add-collect-money');
        form.autoFocusDialog();
    }
    //Mở dialog Thêm mới phiếu chi
    //Người tạo NVMANH 7/6/2019
    addPayMoney() {
        form.checkAdd = true;
        $('#dialog-add-receipt input').val("");
        $('#col-total-money span').text("0");
        $('.table-detail-body').html("");
        form.addRowTable();
        form.createIDPay();
        moneyfund.formatDateTime();
        form.dialogDetail.resetDialog('#dialog-add-receipt');
        form.dialogDetail.openDialog();
        $('[aria-describedby="dialog-add-receipt"]').find('.ui-dialog-title').text("Thêm mới phiếu chi");
        $('[aria-describedby="dialog-add-receipt"]').find('.dialog-info-object-label').text("Nhà cung cấp");
        $('[aria-describedby="dialog-add-receipt"]').find('.dialog-info-submitter-label').text("Người nhận");
        $('[aria-describedby="dialog-add-receipt"]').find('.dialog-info-reason-label').text("Lý do chi");
        $('[aria-describedby="dialog-add-receipt"]').find('.dialog-info-employee-label').text("Nhân viên chi");
        $("#dialog-add-receipt").addClass("add-pay-money");
        form.dialogDetail.resizeDialog('#dialog-add-receipt', ".add-pay-money", 700, 900);
        form.dialogDetail.convertTabByRadio('.add-pay-money');
        form.autoFocusDialog();
    }
    //Mở dialog Nhân bản
    //Người tạo NVMANH 7/6/2019
    duplicateDialog() {
        form.addRowTable();
        form.checkAdd = true;
        $('#dialog-add-receipt input').val("");
        $('#col-total-money span').text("0");
        $('.table-detail-body').html("");
        moneyfund.formatDateTime();
        form.dialogDetail.resetDialog('#dialog-add-receipt');
        form.dialogDetail.openDialog();
        $('[aria-describedby="dialog-add-receipt"]').find('.ui-dialog-title').text("Nhân bản phiếu thu");
        $("#dialog-add-receipt").addClass("duplicate");
        form.createIDCollect();
        form.dialogDetail.resizeDialog('#dialog-add-receipt', ".duplicate", 700, 900);
        form.dialogDetail.convertTabByRadio('.duplicate');
        form.autoFocusDialog();
    }
    //Mở dialog Xem
    //Người tạo NVMANH 7/6/2019
    viewDialog() {
        $('#dialog-add-receipt input').val("");
        $('.table-detail-body').html("");
        form.dialogDetail.resetDialog('#dialog-add-receipt');
        form.dialogDetail.openDialog();
        $('[aria-describedby="dialog-add-receipt"]').find('.ui-dialog-title').text("Xem phiếu thu");
        $("#dialog-add-receipt").addClass("view");
        form.dialogDetail.resizeDialog('#dialog-add-receipt', ".view", 700, 900);
        $('.view #radio1').prop('checked', true);
        $('.view .dialog-panel-purpose-collect').hide();
        $('.view .dialog-body-debt').hide();
        $('.view .dialog-body-different').show();
        form.checkRow();
    }
    //Mở dialog Sửa phiếu thu
    //Người tạo NVMANH 7/6/2019
    editDialog() {
        form.checkAdd = false;
        $('#dialog-add-receipt input').val("");
        $('#col-total-money span').text("0");
        $('.table-detail-body').html("");
        moneyfund.formatDateTime();
        form.dialogDetail.resetDialog('#dialog-add-receipt');
        form.dialogDetail.openDialog();
        $('[aria-describedby="dialog-add-receipt"]').find('.ui-dialog-title').text("Sửa phiếu thu");
        $("#dialog-add-receipt").addClass("edit");
        form.dialogDetail.resizeDialog('#dialog-add-receipt', ".edit", 700, 900);
        form.dialogDetail.convertTabByRadio('.edit');
        form.autoFocusDialog();
    }
    //Mở dialog Chọn hóa đơn thu nợ
    //Người tạo NVMANH 7/6/2019
    selectBillDialogCollect() {
        form.dialogBill.resetDialog('#dialog-collect-debt');
        form.dialogBill.openDialog();
        $('[aria-describedby="dialog-collect-debt"]').find('.ui-dialog-title').text("Chọn hóa đơn thu nợ");
        $("#dialog-collect-debt").addClass("select-bill-collect");
        $('#collect-input-2, #collect-input-3, .wrap-dialog-get-data, .wrap-input-2, .wrap-input-3, .icon-down-2').addClass('input-disable');
        form.dialogBill.resizeDialog('#dialog-collect-debt', ".select-bill-collect", 600, 840);
        form.dialogCollect();
    }


    //Mở dialog chọn hóa đơn trả nợ
    //Người tạo NVMANH 24/6/2019
    selectBillDialogPay() {
        form.dialogBill.resetDialog('#dialog-collect-debt');
        form.dialogBill.openDialog();
        $('[aria-describedby="dialog-collect-debt"]').find('.ui-dialog-title').text("Chọn hóa đơn trả nợ");
        $("#dialog-collect-debt").addClass("select-bill-pay");
        $('#collect-input-2, #collect-input-3, .wrap-dialog-get-data, .wrap-input-2, .wrap-input-3, .icon-down-2').addClass('input-disable');
        form.dialogBill.resizeDialog('#dialog-collect-debt', ".select-bill-pay", 600, 840);
        form.dialogPay();
    }
    //tùy chọn khi mở dialog chọn hóa đơn của dialog thu
    //Người tạo NVMANH 24/6/2019
    dialogCollect() {
        $(".select-bill-collect .collect-input-start .dialog-select-object label").text("Khách hàng");
        $(".select-bill-collect .collect-input-money .dialog-select-object label").text("Số thu");
        $(".select-bill-collect .col-table-header-collected div").text("Số phải thu");
        $(".select-bill-collect .col-table-header-collect div").text("Số chưa thu");
        $(".select-bill-collect .col-table-header-collecting div").text("Số thu");
    }
    //tùy chọn khi mở dialog chọn hóa đơn của dialog trả nợ
    //Người tạo NVMANH 24/6/2019
    dialogPay() {
        $(".select-bill-pay .collect-input-start .dialog-select-object label").text("Nhà cung cấp");
        $(".select-bill-pay .collect-input-money .dialog-select-object label").text("Số trả");
        $(".select-bill-pay .col-table-header-collected div").text("Số phải trả");
        $(".select-bill-pay .col-table-header-collect div").text("Số chưa trả");
        $(".select-bill-pay .col-table-header-collecting div").text("Số trả");
    }
    //Mở dialog Chọn đối tượng
    //Người tạo NVMANH 7/6/2019
    selectObjectDialog() {
        form.dialogObject.resetDialog('#dialog-object-pay');
        form.dialogObject.openDialog();
        $('[aria-describedby="dialog-object-pay"]').find('.ui-dialog-title').text("Chọn đối tượng");
        $('.wrap-body-object-pay').html("");
        $("#dialog-object-pay").addClass("object");
        $('.object .wrap-input-object-pay input').attr('placeholder', 'Nhập mã đối tượng, tên đối tượng');
        $('.header-object-pay-id div').text("Mã đối tượng nộp");
        $('.header-object-pay-name div').text("Tên đối tượng nộp");
        $('.header-object-pay-type div').text("Loại đối tượng nộp");
        $('.header-object-pay-address div').text("Địa chỉ");
        datatable.loadDataTableSearchSupplier();
        $('.wrap-input-object-pay input').focus();
    }
    //Mở dialog Chọn nhân viên
    //Người tạo NVMANH 7/6/2019
    selectEmployeeDialog() {
        form.dialogObject.resetDialog('#dialog-object-pay');
        form.dialogObject.openDialog();
        $('[aria-describedby="dialog-object-pay"]').find('.ui-dialog-title').text("Chọn nhân viên");
        $('.wrap-body-object-pay').html("");
        $("#dialog-object-pay").addClass("employee");
        $('.employee .wrap-input-object-pay input').attr('placeholder', 'Nhập mã nhân viên, tên nhân viên');
        $('.header-object-pay-id div').text("Mã nhân viên");
        $('.header-object-pay-name div').text("Tên nhân viên");
        $('.header-object-pay-type div').text("Số điện thoại");
        $('.header-object-pay-address div').text("Địa chỉ");
        datatable.loadDataTableSearchEmployee();
        $('.wrap-input-object-pay input').focus();
    }
    //Mở dialog Xóa dữ liệu
    //Người tạo NVMANH 7/6/2019
    deleteDialog() {
        form.dialogAlert.resetDialog('#dialog-delete');
        form.dialogAlert.openDialog();
        $('#dialog-delete').addClass('alert-delete');
        $('.alert-delete .content-alert-dialog').html("Bạn có chắc chắn muốn xóa Phiếu thu tiền mặt <span></span> không");
        $('.icon-warn').addClass('icon-question-mark');
        $('.icon-warn').removeClass('icon-warn-mark');
        $('.btn-delete-agree').focus();
    }
    //Mở dialog xác nhận thay đổi dữ liệu
    //Người tạo NVMANH 7/6/2019
    saveDialog() {
        form.dialogAlert.resetDialog('#dialog-delete');
        form.dialogAlert.openDialog();
        $('#dialog-delete').addClass('alert-save');
        $('.alert-save .content-alert-dialog').text("Dữ liệu đã thay đổi, bạn có muốn lưu không");
        $('.icon-warn').addClass('icon-question-mark');
        $('.icon-warn').removeClass('icon-warn-mark');
    }
    //Mở dialog cảnh báo chưa có dòng chi tiết
    //Người tạo NVMANH 7/6/2019
    warnDialog() {
        form.dialogAlert.resetDialog('#dialog-delete');
        form.dialogAlert.openDialog();
        $('#dialog-delete').addClass('alert-warn');
        $('.alert-warn .content-alert-dialog').text("Phải có ít nhất một dòng chi tiết, vui lòng thay đổi lại");
        $('.icon-warn').removeClass('icon-question-mark');
        $('.icon-warn').addClass('icon-warn-mark');
        $('.alert-warn .dialog-warn-agree').focus();
    }
    //Mở dialog cảnh báo số tiền phải khác 0
    //Người tạo NVMANH 7/6/2019
    warnDialogMoney() {
        form.dialogAlert.resetDialog('#dialog-delete');
        form.dialogAlert.openDialog();
        $('#dialog-delete').addClass('alert-warn');
        $('.alert-warn .content-alert-dialog').text("Số tiền phải lớn hơn 0. Vui lòng kiểm tra lại");
        $('.icon-warn').removeClass('icon-question-mark');
        $('.icon-warn').addClass('icon-warn-mark');
        $('.alert-warn .dialog-warn-agree').focus();
    }
    //Mở dialog cảnh báo chưa chọn chứng từ
    //Người tạo NVMANH 2/7/2019
    warnDialogVoucher() {
        form.dialogAlert.resetDialog('#dialog-delete');
        form.dialogAlert.openDialog();
        $('#dialog-delete').addClass('alert-warn');
        $('.alert-warn .content-alert-dialog').text("Bạn chưa chọn chứng từ nào. Vui lòng kiểm tra lại.");
        $('.icon-warn').removeClass('icon-question-mark');
        $('.icon-warn').addClass('icon-warn-mark');
        $('.alert-warn .dialog-warn-agree').focus();
    }
    //Bắt sự kiện nút Đóng trên header
    //Người tạo NVMANH 17/6/2019
    eventBtnClose() {
        if ($('#dialog-add-receipt').hasClass('view')) {
            $('#dialog-add-receipt input').attr('disabled', false);
            $('#dialog-add-receipt').dialog('close');
            $('#col-total-money span').text("0");
        } else {
            form.saveDialog();
        }
    }
    //Sự kiện cho nút trả nợ trên hóa đơn thu nợ
    //Người tạo NVMANH 4/7/2019
    eventBtnCollect() {
        $('.dialog-voucher-tab-body .dialog-tab-body').html('');
        if ($('.select-bill-collect .wrap-collect-table-body .col-table-body-check.checked').length > 0) {
            var listVoucherID = [];
            var listNumberCollect = [];
            var arrayRow = $('.select-bill-collect .wrap-collect-table-body .row-collect-table-body');
            $.each(arrayRow, function (index, item) {
                if ($(item).find('.col-table-body-check').hasClass('checked')) {
                    listVoucherID.push($(item).data('billID'));
                    listNumberCollect.push($(item).find('.type-money-bill').val());
                }
            });
            //console.log(listNumberCollect);
            $.ajax({
                method: "get",
                url: "/billcollect",
                success: function (res) {
                    var listBillSelect = [];
                    $.each(listVoucherID, function (index, item) {
                        listBillSelect.push(res.find(x => x.billID === item));
                    });
                    var totalBillDebt = 0;
                    var totalBillCollected = 0;
                    $.each(listBillSelect, function (index, item) {
                        var rowBill = $('.dialog-body-debt .row-bill-clone span');
                        $.each(rowBill, function (i, a) {
                            let fieldName = $(this).attr('fieldName');
                            let fieldData = $(this).attr('fieldData');
                            if (fieldData === "Number") {
                                $(this).text(datatable.formatNumber(item[fieldName]));
                            } else if (fieldData === "Time") {
                                $(this).text(new Date(item[fieldName]).toLocaleDateString('en-GB'));
                            } else {
                                $(this).text(item[fieldName]);
                            }
                        });
                        totalBillDebt += item['billDebt'];
                        totalBillCollected += item['billCollected'];

                        $('.dialog-voucher-tab-body .dialog-tab-body').append($('.row-bill-clone').html());
                        $('.dialog-voucher-tab-body .dialog-tab-body .row-tab-voucher:last-child').data('billID', item['billID']);
                        $('.dialog-tab-footer .dialog-tab-column-collected span').text(datatable.formatNumber(totalBillDebt));
                        $('.dialog-tab-footer .dialog-tab-column-collect span').text(datatable.formatNumber(totalBillCollected));
                    });
                    //Xử lý cột số thu trong tab chứng từ
                    var totalNumberCollect = 0;
                    for (var i = 0; i < listNumberCollect.length; i++) {
                        totalNumberCollect += datatable.convertStringJSToNumber(listNumberCollect[i]);
                        $('.dialog-voucher-tab-body .dialog-tab-body [fieldName="collect"]').eq(i).text(listNumberCollect[i]);
                    }
                    $('.dialog-tab-footer .dialog-tab-column-collecting span').text(datatable.formatNumber(totalNumberCollect));
                    $('.dialog-body-debt .dialog-table-column-money .wrap-text-footer-column span').text(datatable.formatNumber(totalNumberCollect));
                    $('.dialog-body-debt .input-detail-2').val(datatable.formatNumber(totalNumberCollect));
                },
                error: function () {
                    alert("fail");
                }
            });
            var debtInfo = $('.dialog-body-debt .dialog-info-submitter-input,.dialog-body-debt .dialog-info-address-input,.dialog-body-debt .dialog-info-reason-input,.dialog-body-debt .employee-input-left');
            debtInfo.removeClass('debt-background');
            debtInfo.find('input').attr('class', "");
            debtInfo.find('input').attr('disabled', false);
            $.ajax({
                method: 'GET',
                url: '/supplier/' + datatable.supplierID,
                success: function (res) {
                    var infoDebt = $('.dialog-body-debt .dialog-body-info-left input');
                    $.each(infoDebt, function (index, item) {
                        let fieldname = $(this).attr('fieldname');
                        $(this).val(res[fieldname]);
                    });
                    $('[fieldname="supplierReason"]').val("Thu nợ của " + res['supplierName']);
                    $('.dialog-body-debt .input-detail-1').val("Thu nợ của " + res['supplierName']);
                    $('.dialog-body-debt .input-detail-3').val("Thu nợ từ bán hàng");
                    //Chọn nhân viên đang đăng nhập mặc định là nhân viên thu
                    //Người tạo NVMANH 15/7/2019
                    $('.dialog-body-debt [fieldname="employeeId"]').val("NV0005");
                    $('.dialog-body-debt [fieldname="employeeName"]').val("Nguyễn Văn Mạnh");
                    datatable.employeeIDDebt = "082164b2-f728-41cc-a838-a9f37ffc4309";
                },
                error: function () {

                }
            });

            
            //Reset lại dialog Chọn hóa đơn thu nợ
            //Người tạo NVMANH 15/7/2019
            $('#dialog-collect-debt').dialog('close');
            $('#collect-input-1').val("");
            $('#collect-input-3').val("0");
            $('.wrap-collect-table-body').html("");
            $('.col-table-footer-collected .wrap-text-footer-table').text("0");
            $('.col-table-footer-collect .wrap-text-footer-table').text("0");
            $('.col-table-footer-collecting .wrap-text-footer-table').text("0");
            
            //console.log(listVoucherID);
        } else {
            form.warnDialogVoucher();
        }
    }
    //Sự kiện cho button chọn nhân viên khi thêm phiếu thu nợ
    //Người tạo NVMANH 13/7/2019
    evtSelectEmployee() {
        $('body').mouseover(function () {
            if ($('.dialog-body-debt .employee-input-left').hasClass('debt-background')) {
                $('.dialog-body-debt .employee-input-left').children().addClass('off-click');
            } else {
                $('.dialog-body-debt .employee-input-left').children().removeClass('off-click');
            }
        });
    }
    //Bắt sự kiện cho button Hủy bỏ trên dialog
    //Người tạo NVMANH 17/6/2019
    eventBtnCancel() {
        $("#dialog-collect-debt").dialog('close');
        $("#dialog-object-pay").dialog('close');
        $("#dialog-delete").dialog('close');
    }
    //Sự kiên nút đồng ý dialog cảnh báo
    //Người tạo NVMANH 4/7/2019
    agreeBtnWarn() {
        $("#dialog-delete").dialog('close');
    }
    eventBtnDeleteCancel() {
        $("#dialog-delete").dialog('close');
    }
    //Bắt sự kiện cho button Không lưu trên dialog
    //Người tạo NVMANH 17/6/2019
    eventBtnNoSave() {
        $("#dialog-delete").dialog('close');
        $('#dialog-add-receipt').dialog('close');
        $('.table-detail-body').html("");
        $('#col-total-money span').text('0');
        $('.dialog-voucher-tab-body .dialog-tab-body').html('');
        $('.dialog-tab-footer .dialog-tab-column-collected span').text('0');
        $('.dialog-tab-footer .dialog-tab-column-collect span').text('0');
        $('.dialog-tab-footer .dialog-tab-column-collecting span').text('0');
        var debtInfo = $('.dialog-body-debt .dialog-info-submitter-input,.dialog-body-debt .dialog-info-address-input,.dialog-body-debt .dialog-info-reason-input,.dialog-body-debt .employee-input-left');
        debtInfo.addClass('debt-background');
        debtInfo.find('input').attr('class', "input-blinking debt-background");
        debtInfo.find('input').attr('disabled', true);
    }
    //Bắt sự kiện cho button Lưu trên dialog
    //Người tạo NVMANH 17/6/2019
    eventBtnSave() {
        var rowDetail = $('.table-detail-body .row-tab-detail-radio');
        if (rowDetail.length > 0) {
            if ($('#col-total-money span').text() === '0') {
                form.warnDialogMoney();
            } else {
                //var typeCheck;
                //$('.add-collect-money .dialog-header-item-save').click(function () {
                //    typeCheck = "1";
                //});
                //$('.add-pay-money .dialog-header-item-save').click(function () {
                //    typeCheck = "2";
                //});
                $('.dialog-voucher-tab-body .dialog-tab-body').html('');
                $('.dialog-tab-footer .dialog-tab-column-collected span').text('0');
                $('.dialog-tab-footer .dialog-tab-column-collect span').text('0');
                $('.dialog-tab-footer .dialog-tab-column-collecting span').text('0');

                if (form.checkAdd) {
                    let fund = {};
                    fund['employeeID'] = datatable.employeeIDDifferent;
                    fund['supplierID'] = datatable.supplierID;
                    fund['fundDate'] = datatable.convertStringJSToStringCsharp($('.dialog-date-input'));
                    fund['fundNumberVoucher'] = $('#dialog-voucher-number-input').val();
                    fund['fundTypeVoucher'] = "Phiếu thu nợ";
                    fund['fundMoney'] = datatable.convertStringJSToNumber($('#col-total-money span').text());
                    fund['fundObject'] = $('#dialog-info-submitter-input').val();
                    fund['fundReason'] = $('#dialog-info-reason-input').val();
                    fund['typeCheck'] = "1";
                    $.ajax({
                        method: "Post",
                        url: "/fund/save",
                        async: false,
                        data: JSON.stringify(fund),
                        contentType: "application/json;charset=utf-8",
                        dataType: "json",
                        success: function (fund) {
                            $('.content-table-body').html('<div class="icon-loading"></div ><div id="overlay-main"></div>');
                            datatable.loadDataTableMain();
                            datatable.getTotal();
                        }
                    });
                    $.ajax({
                        method: "GET",
                        url: '/fund/getid/' + fund['fundNumberVoucher'],
                        async: false,
                        success: function (res) {
                            form.addRowDetail(res['fundID']);
                        },
                        error: function () {

                        }
                    });
                    
                } else {
                    let fund = {};
                    let listDetailID = [];
                    let listFundDetail = [];
                    if (datatable.employeeID && datatable.supplierID) {
                        fund['employeeID'] = datatable.employeeIDDifferent;
                        fund['supplierID'] = datatable.supplierID;
                    }
                    else {
                        fund['employeeID'] = form.employeeIDEdit;
                        fund['supplierID'] = form.supplierIDEdit;
                    }
                    fund['fundID'] = form.fundID;
                    fund['fundDate'] = datatable.convertStringJSToStringCsharp($('.dialog-date-input'));
                    fund['fundNumberVoucher'] = $('#dialog-voucher-number-input').val();
                    //fund['fundTypeVoucher'] = $('#select-item-collect').val();
                    fund['fundTypeVoucher'] = "Phiếu thu nợ";
                    fund['fundMoney'] = datatable.convertStringJSToNumber($('#col-total-money span').text());
                    fund['fundObject'] = $('#dialog-info-submitter-input').val();
                    fund['fundReason'] = $('#dialog-info-reason-input').val();
                    fund['typeCheck'] = "1";
                    $.ajax({
                        method: "Put",
                        url: "/fund/edit",
                        data: JSON.stringify(fund),
                        contentType: "application/json;charset=utf-8",
                        dataType: "html",
                        success: function () {
                            $('.content-table-body').html('<div class="icon-loading"></div ><div id="overlay-main"></div>');
                            datatable.loadDataTableMain();
                            datatable.getTotal();
                        },
                        error: function () {
                        }
                    });
                    var rowDetailTable = $('.table-detail-body .row-tab-detail-radio');
                    $.each(rowDetailTable, function (index, item) {
                        var row = $(item).find('input');
                        var _element = {};
                        $.each(row, function (i, e) {
                            _element['fundID'] = form.fundID;
                            let fieldname = $(this).attr('fieldname');
                            let fielddata = $(this).attr('fielddata');
                            if (fielddata === "Number") {
                                _element[fieldname] = datatable.convertStringJSToNumber($(this).val());
                            }
                            else {
                                _element[fieldname] = $(this).val();
                            }
                        });
                        _element['fundDetailID'] = $(item).data('fundDetailID');
                        listFundDetail.push(_element);
                        listDetailID.push($(item).data('fundDetailID'));
                    });
                    $.ajax({
                        method: "Put",
                        url: "/fund/editDeatil",
                        data: JSON.stringify(listFundDetail),
                        contentType: "application/json;charset=utf-8",
                        dataType: "html",
                        success: function () {
                            //$('.content-table-body').html('<div class="icon-loading"></div ><div id="overlay-main"></div>');
                            //datatable.loadDataTableMain();
                            //datatable.getTotal();
                        },
                        error: function () {
                        }
                    });
                }
                var debtInfo = $('.dialog-body-debt .dialog-info-submitter-input,.dialog-body-debt .dialog-info-address-input,.dialog-body-debt .dialog-info-reason-input,.dialog-body-debt .employee-input-left')
                debtInfo.addClass('debt-background');
                debtInfo.find('input').attr('class', "input-blinking debt-background");
                debtInfo.find('input').attr('disabled', true);
                $('#col-total-money span').text('0');
                $('#dialog-add-receipt').dialog('close');
                $('#dialog-delete').dialog('close');
                $('.table-detail-body').html("");
            }
        } else {
            form.warnDialog();
        }
    }
    //Thêm mới chi tiết cho hóa đơn
    //Người tạo NVMANH 9/7/2019
    addRowDetail(id) {
        let fundDetail = [];
        var rowDetail = $('.table-detail-body .row-tab-detail-radio');
        $.each(rowDetail, function (index, item) {
            let detail = {};
            var element = $(item).find('input');
            $.each(element, function (i, e) {
                let fieldname = $(this).attr('fieldname');
                let fielddata = $(this).attr('fielddata');
                if (fielddata === 'Number') {
                    detail[fieldname] = datatable.convertStringJSToNumber($(this).val());
                } else {
                    detail[fieldname] = $(this).val();
                }
            });
            detail['fundID'] = id;
            fundDetail.push(detail);
        });
        $.ajax({
            method: "POST",
            url: "/fund/savedetail",
            data: JSON.stringify(fundDetail),
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (fund) {
            }
        });
    }
    //Mở trợ giúp
    //Người tạo NVMANH 18/6/2019
    eventBtnHelp() {
        window.open("http://help.mshopkeeper.vn/170103_quy_tien_mat.htm", '_blank');
    }
    eventBtnRefresh() {
        $('.content-table-body').html('<div class="icon-loading"></div ><div id="overlay-main"></div>');
        datatable.loadDataTableMain();
    }


    //Cài đặt phím tắt cho các chức năng
    //Người tạo NVMANH 12/6/2019
    setAllHotKey() {
        $(window).keydown(function (event) {
            if (event.keyCode === 45) {
                if (!$("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen")) {
                    $('.combobox-item').show();
                }
                event.preventDefault();
            }
            //Nhấn Ctrl + 1 mở thêm mới phiếu thu
            if (event.ctrlKey && event.keyCode === 49) {
                if (!$("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen")) {
                    form.addCollectMoney();
                }
                event.preventDefault();
            }
            //Nhấn Ctrl + 2 mở thêm mới phiếu chi 
            if (event.ctrlKey && event.keyCode === 50) {
                if (!$("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen")) {
                    form.addPayMoney();
                }
                event.preventDefault();
            }
            //Nhấn Ctril + 3 mở nhân bản
            if (event.ctrlKey && event.keyCode === 51) {
                if (!$("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen")) {
                    form.dataDialogDuplicate();
                }
                event.preventDefault();
            }
            //Nhấn Ctrl + 4 mở xem
            if (event.ctrlKey && event.keyCode === 52) {
                if (!$("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen")) {
                    form.dataDialogView();
                }
                event.preventDefault();
            }
            //Nhấn Ctrl + S lưu bản ghi
            if (event.ctrlKey && event.keyCode === 83) {
                if ($("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen") && !$("#dialog-collect-debt").dialog("isOpen") && !$("#dialog-add-receipt").hasClass('view')) {
                    form.eventBtnSave();
                }
                event.preventDefault();
            }
            //Nhấn Ctrl + Q để đóng dialog
            if (event.ctrlKey && event.keyCode === 81) {
                if ($("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-collect-debt").dialog("isOpen")) {
                    form.eventBtnClose();
                }
                event.preventDefault();
            }
            //Nhấn F1 để mở trọ giúp
            if (event.keyCode === 112) {
                window.open("http://help.mshopkeeper.vn/170103_quy_tien_mat.htm", '_blank');
                event.preventDefault();
            }

            //Nhấn Phím lên trong bảng di chuyển dòng được chọn lên trên
            if (event.keyCode === 38) {
                if (!$("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen")) {
                    var rowCurrentPrev = $('.content-table-body .row-content-active').first();
                    if (!$('.content-table-body .row-content:first').hasClass("row-content-active")) {
                        rowCurrentPrev.removeClass('row-content-active');
                        rowCurrentPrev.prev().addClass('row-content-active');
                        form.autoRenderScrollTop();
                        $(".wrap-box-detail-table-body").html("");
                        datatable.getDataTableDetailByID();
                    }
                }
                if ($('#dialog-object-pay').dialog('isOpen')) {
                    var rowPersonPrev = $('.wrap-body-object-pay .row-body-object-pay.selected-supplier');
                    if (!$('.wrap-body-object-pay .row-body-object-pay:first').hasClass('selected-supplier')) {
                        rowPersonPrev.removeClass('selected-supplier');
                        rowPersonPrev.prev().addClass('selected-supplier');
                        rowPersonPrev.find('input').attr('checked', false);
                        rowPersonPrev.prev().find('input').attr('checked', true);
                    }
                }
                event.preventDefault();
            }

            //Nhấn Phím xuống trong bảng di chuyển dòng được chọn xuống dưới
            if (event.keyCode === 40) {
                if (!$("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen")) {
                    var rowCurrentNext = $('.content-table-body .row-content-active').first();

                    if (!$('.content-table-body .row-content:last').hasClass("row-content-active")) {
                        rowCurrentNext.removeClass('row-content-active');
                        rowCurrentNext.next().addClass('row-content-active');
                        form.autoRenderScrollTop();
                        $(".wrap-box-detail-table-body").html("");
                        datatable.getDataTableDetailByID();
                    }
                }
                if ($('#dialog-object-pay').dialog('isOpen')) {
                    var rowPersonNext = $('.wrap-body-object-pay .row-body-object-pay.selected-supplier');
                    if (!$('.wrap-body-object-pay .row-body-object-pay:last').hasClass('selected-supplier')) {
                        rowPersonNext.removeClass('selected-supplier');
                        rowPersonNext.next().addClass('selected-supplier');
                        rowPersonNext.find('input').attr('checked', false);
                        rowPersonNext.next().find('input').attr('checked', true);
                    }
                }
                event.preventDefault();
            }
            //Nhấn ctrl + E mở dialog sửa
            if (event.ctrlKey && event.keyCode === 69) {
                if (!$("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen") && !$("#dialog-collect-debt").dialog("isOpen") && $("#dialog-add-receipt").hasClass('view')) {
                    form.dataDialogEdit();
                }
                event.preventDefault();
            }
            //Nhấn Ctrl + D mở xóa bản ghi
            if (event.ctrlKey && event.keyCode === 68) {
                if (!$("#dialog-delete").dialog("isOpen") && !$("#dialog-collect-debt").dialog("isOpen") && $("#dialog-add-receipt").hasClass('view')) {
                    form.dataDialogDelete();
                }
                event.preventDefault();
            }
            //Nhấn esc để đóng dialog
            //if (event.keyCode === 27) {
            //    if ($("#dialog-add-receipt").dialog("isOpen") && !$("#dialog-delete").dialog("isOpen") && !$("#dialog-delete").hasClass('view')) {
            //        form.eventBtnClose();
            //    }
            //    event.preventDefault();
            //}
            //Nhấn Enter để click vào button được focus
            $('.btn-dialog-close, .dialog-warn-agree, .btn-delete-cancel, .wrap-column-icon-delete, .wrap-btn-agree, .wrap-btn-cancel').keydown(function (e) {
                if (e.keyCode === 13) {
                    e.preventDefault();
                    $(this).click();
                }
            });
        });
    }

    //Mở dialog view để xem dữ liệu
    //Người tạo NVMANH 12/6/2019
    dataDialogView() {
        form.viewDialog();
        form.loadDataToDialog();
        form.focusRow();
    }
    //Load dữ liệu lên dialog sửa
    //NGười tạo NVMANH 12/6/2019
    dataDialogEdit() {
        form.editDialog();
        form.loadDataToDialog();
        form.focusRow();
        $('#dialog-add-receipt input').attr('disabled', false);
    }
    //Load dữ liệu lên dialog nhân bản
    //Người tạo NVMANH 12/6/2019
    dataDialogDuplicate() {
        form.duplicateDialog();
        form.loadDataToDialog();
        form.focusRow();
    }
    //Tạo mã phiếu thu khi thêm mới hoặc nhân bản bản ghi
    //Người tạo NVMANH 18/6/2019
    createIDCollect() {
        $.ajax({
            method: 'GET',
            url: '/fund/getcollect'
        }).done(function (res) {
            var idNumber = res['fundNumberVoucher'].substring(2);
            var idCollect = "PT00" + (parseInt(idNumber) + 1);
            $('.dialog-voucher-number-input input').val(idCollect);
        }).fail(function () {

        });
    }
    //Tạo mã phiếu chi khi thêm mới bản ghi
    //Người tạo NVMANH 24/6/2019
    createIDPay() {
        $.ajax({
            method: 'GET',
            url: '/fund/getpay'
        }).done(function (res) {
            var idNumber = res['fundNumberVoucher'].substring(2);
            var idCollect = "PC00" + (parseInt(idNumber) + 1);
            $('.dialog-voucher-number-input input').val(idCollect);
        }).fail(function () {

        });
    }
    //Hàm xử lý autofocus
    //Người tạo NVMANH 12/6/2019
    setFocus() {
        $(".end-tab").focus(function () {
            $(".table-detail-body .input-detail-1:first").focus();
        });
        $(".start-tab").focus(function () {
            $(".last-tab").focus();
        });
        $(".end-button").focus(function () {
            $(".dialog-close-save").focus();
        });
        $(".start-button").focus(function () {
            $(".dialog-close-cancel").focus();
        });
        $(".end-btn-delete").focus(function () {
            $(".btn-delete-agree").focus();
        });
        $(".start-btn-delete").focus(function () {
            $(".btn-delete-cancel").focus();
        });
        $('.select-end-tab').focus(function () {
            $('.wrap-input-object-pay input').focus();
        });
        $('.select-start-tab').focus(function () {
            $('.btn-object-pay-cancel').focus();
        });
    }
    //Lấy mã hóa đơn để load vào dialog xóa
    //Người tạo NVMANH 18/6/2019
    dataDialogDelete() {
        if ($('.row-content-active').length > 1) {
            $('.content-alert-dialog span').text("");
        } else {
            var rowSelect = $('.row-content-active').data('fundID');
            $.ajax({
                method: 'GET',
                url: '/fund/view/' + rowSelect
            }).done(function (res) {
                $('.content-alert-dialog span').text(res['fundNumberVoucher']);
            }).fail(function () {

            });
        }
        form.deleteDialog();
    }

    //Hàm xử lý ẩn menu xem sửa nhân bản theo check box trong bảng chính
    //Người tạo NVMANH 12/6/2019
    noCheckedTable() {
        if ($('.content-table-body').find('.row-content.row-content-active').length === 0) {
            $('#toolbar-item-duplicate, #toolbar-item-view, #toolbar-item-edit, #toolbar-item-delete').addClass('dialog-header-item-off');
        } else if ($('.content-table-body').find('.row-content.row-content-active').length === 1) {
            $('#toolbar-item-duplicate, #toolbar-item-view, #toolbar-item-edit, #toolbar-item-delete').removeClass('dialog-header-item-off');
        } else if ($('.content-table-body').find('.row-content.row-content-active').length > 1) {
            $('#toolbar-item-duplicate, #toolbar-item-view, #toolbar-item-edit, #toolbar-item-delete').addClass('dialog-header-item-off');
            $('#toolbar-item-delete').removeClass('dialog-header-item-off');
        }
    }

    //Cuộn bảng theo dòng được chọn
    //Người tạo NVMANH 13/6/2019
    autoRenderScrollTop() {
        let scrollTop = $('.content-table-body .row-content-active').offset().top - 255;

        let heightTableData = $(".content-table-main").height() - 90;
        if (scrollTop > heightTableData) {
            $(".content-table-main").scrollTop($(".content-table-main").scrollTop() + heightTableData);
        } else if (scrollTop < 0) {
            $(".content-table-main").scrollTop($(".content-table-main").scrollTop() - heightTableData + 35);
        }
    }
    //Chuyển lên dòng trên so  với dòng được chọn
    //Người tạo NVMANH 18/6/2019
    prevRow() {
        var rowCurrentPrev = $('.content-table-body .row-content-active').first();
        if (!$('.content-table-body .row-content:first').hasClass("row-content-active")) {
            rowCurrentPrev.removeClass('row-content-active');
            rowCurrentPrev.prev().addClass('row-content-active');
            form.autoRenderScrollTop();
            $(".wrap-box-detail-table-body").html("");
            datatable.getDataTableDetailByID();
        }
        form.dataDialogView();
    }
    //Chuyển xuống dòng dưới so  với dòng được chọn
    //Người tạo NVMANH 18/6/2019
    nextRow() {
        var rowCurrentNext = $('.content-table-body .row-content-active').first();
        if (!$('.content-table-body .row-content:last').hasClass("row-content-active")) {
            rowCurrentNext.removeClass('row-content-active');
            rowCurrentNext.next().addClass('row-content-active');
            form.autoRenderScrollTop();
            $(".wrap-box-detail-table-body").html("");
            datatable.getDataTableDetailByID();
        }
        form.dataDialogView();
    }
    //Kiểm tra dòng để vố hiệu hóa nút trước hoặc sau
    //Người tạo NVMANH 18/6/2019
    checkRow() {
        if (!$('.content-table-body .row-content:first').hasClass('row-content-active')) {
            $('.view .dialog-header-item-backward').removeClass('dialog-header-item-off');
        } else {
            $('.view .dialog-header-item-backward').addClass('dialog-header-item-off');
        }
        if ($('.content-table-body .row-content:last').hasClass('row-content-active')) {
            $('.view .dialog-header-item-forward').addClass('dialog-header-item-off');
        } else {
            $('.view .dialog-header-item-forward').removeClass('dialog-header-item-off');
        }
    }
    //Load dữ liệu lên dialog
    //Người tạo NVMANH 15/6/2019
    loadDataToDialog() {
        var rowSelect = $('.content-table-body .row-content.row-content-active').data("fundID");
        var total = 0;
        $('#col-total-money span').text("0");
        $.ajax({
            method: 'GET',
            url: '/fund/view/' + rowSelect,
            beforeSend: function () {
                $('.icon-loading').show();
                $('#overlay').show();
            },
            complete: function (data) {
                $('.icon-loading').hide();
                $('#overlay').hide();
            }
        }).done(function (res) {
            var data = res;
            if (data['typeCheck'] === "1") {
                $('#dialog-add-receipt').addClass('bill-collect');
                $('#dialog-add-receipt').removeClass('bill-pay');
            }
            if (data['typeCheck'] === "2") {
                $('#dialog-add-receipt').removeClass('bill-collect');
                $('#dialog-add-receipt').addClass('bill-pay');
            }
            if (!$('#dialog-add-receipt').hasClass('duplicate')) {
                $(".dialog-date-input").val(new Date(data['fundDate']).toLocaleDateString('en-GB'));
                $(".dialog-voucher-number-input input").val(data['fundNumberVoucher']);
            }
            form.employeeIDEdit = data['employeeID'];
            form.supplierIDEdit = data['supplierID'];
            form.fundID = data['fundID'];
            $("#dialog-info-reason-input").val(data['fundReason']);
            //Lấy dữ liệu từ bảng employ cho phiếu thu
            //Người tạo NVMANH 17/6/2019
            $("#employee-input-left").val(data['employeeId']);
            $("#employee-input-right").val(data['employeeName']);
            //Lấy dữ liệu từ bảng nhà cung cấp
            //Người tạo NVMANH 17/6/2019
            $("#object-input-left").val(data['supplierId']);
            $("#object-input-right").val(data['supplierName']);
            $("#dialog-info-submitter-input").val(data['fundObject']);
            $("#dialog-info-address-input").val(data['supplierAddress']);
        }).fail(function () {

        });
        
    }
    focusRow() {
        var rowSelect = $('.content-table-body .row-content.row-content-active').data("fundID");
        var total = 0;
        $.ajax({
            async: false,
            method: 'GET',
            url: '/fund/detail/' + rowSelect,
            success: function (res) {
                var data = res;
                $('.table-detail-body').html('');
                $.each(data, function (index, item) {
                    var rowClone = $(".row-clone-detail input");
                    $.each(rowClone, function (i, e) {
                        let fieldName = $(this).attr("fieldName");
                        let fieldData = $(this).attr("fieldData");
                        if (fieldData === "Number") {
                            total += item[fieldName];
                            $(this).val(datatable.formatNumber(item[fieldName]));
                        }
                        else {
                            $(this).val(item[fieldName]);
                        }
                    });
                    $(".table-detail-body").append($(".row-clone-detail .row-tab-detail-radio").clone(true));
                    $(".table-detail-body .row-tab-detail-radio:last-child").data('fundDetailID', item['fundDetailID']);
                    $('#col-total-money span').text(datatable.formatNumber(total));

                });
            },
            error: function () {

            }
        });

    }
    //Xóa dữ liệu trên bảng fund
    //Người tạo NVMANH 19/6/2019
    deleteRowFund() {
        datatable.deleteFund();
        $('.content-table-body').html('<div class="icon-loading"></div ><div id="overlay-main"></div>');
        datatable.loadDataTableMain();
        datatable.getTotal();
        $('#dialog-delete').dialog('close');
        $('#dialog-add-receipt').dialog('close');
    }
    //Kiểm tra giá trị input trên dialog chọn khách hàng
    //Người tạo NVMANH 30/6/2019
    checkInputNameCustomer() {
        if ($('#collect-input-1').val() === "0") {
            $('#collect-input-2, #collect-input-3, .wrap-dialog-get-data, .wrap-input-2, .wrap-input-3, .icon-down-2').addClass('input-disable');
            $('.wrap-collect-table-body').html("");
            $('.check-all').removeClass('checked');
            $('.col-table-footer-collected .wrap-text-footer-table').text('0');
            $('.col-table-footer-collect .wrap-text-footer-table').text('0');
            $('.col-table-footer-collecting .wrap-text-footer-table').text('0');
            $('#collect-input-3').val('0');
        } else {

            $('#collect-input-2, #collect-input-3, .wrap-dialog-get-data, .wrap-input-2, .wrap-input-3, .icon-down-2').removeClass('input-disable');
        }
    }
    //Kiểm tra có hóa đơn được chọn
    //Người tạo NVMANH 2/7/2019
    checkSelectVoucher() {
        if ($('.select-bill-pay .collect-table-body .checked').length === 0) {
            form.warnDialogVoucher();
        } else {
            alert(1);
        }
    }
    //Thêm một dòng cho bảng chi tiết
    //Người tạo NVMANH 3/7/2019
    addRowTable() {
        $('.table-detail-body').append($('.row-clone-detail').html());
    }
    //Xử lý số thu trên dialog Chọn hóa đơn thu nợ
    //Người tạo NVMANH 4/7/2019
    inputCollectMoney() {
        //Xử lý số thu trên tiêu đề
        //Người tạo NVMANH 4/7/2019
        $('body').on('keyup', '.select-bill-collect #collect-input-3', function () {
            var numberCollect = datatable.convertStringJSToNumber($(this).val());
            var totalNumberCollect = datatable.convertStringJSToNumber($(this).val());
            var totalCollect = 0;
            // TODO: Toi dang dung tại day

            var arrayRow = $('.wrap-collect-table-body .row-collect-table-body');
            $(arrayRow).find('.type-money-bill').val(0);
            $.each(arrayRow, function (index, item) {
                var collect = datatable.convertStringJSToNumber($(item).find('[fieldname="billCollected"]').text());
                totalCollect += collect;
                if (numberCollect - collect > 0) {
                    numberCollect -= collect;
                    $(item).find('.type-money-bill').val(datatable.formatNumber(collect));
                    $('.select-bill-collect .col-table-footer-collecting .wrap-text-footer-table').text(datatable.formatNumber(totalCollect));
                } else {
                    $(item).find('.type-money-bill').val(datatable.formatNumber(numberCollect));
                    $('.select-bill-collect .col-table-footer-collecting .wrap-text-footer-table').text(datatable.formatNumber(totalNumberCollect));
                    return false;
                }
            });
            //Số thu lớn hơn 0 thì tick vào đầu dòng
            $.each(arrayRow, function (index, item) {
                var collect = datatable.convertStringJSToNumber($(item).find('[fieldname="billCollected"]').text());
                if (datatable.formatNumber($(item).find('.type-money-bill').val()) > 0) {
                    $(item).find('.col-table-body-check').addClass('checked');
                } else {
                    $(item).find('.col-table-body-check').removeClass('checked');
                }
            });
            //chọn check tất cả khi những dòng dưới được chọn
            var rowChecked = $('.select-bill-collect .collect-table-body .checked').length;
            var rowCheck = $('.select-bill-collect .collect-table-body .col-table-body-check').length;
            if (rowChecked === rowCheck) {
                $('.select-bill-collect .check-all').addClass('checked');
            } else {
                $('.select-bill-collect .check-all').removeClass('checked');
            }
            //$('.select-bill-collect .col-table-footer-collecting .wrap-text-footer-table').text($(this).val());
        });
        //Xử lý nhập số thu trong bảng
        //Người tạo NVMANH 4/7/2019
        $('body').on('keyup focusout', '.select-bill-collect .type-money-bill', function () {
            var arrayMoney = $('.select-bill-collect .type-money-bill');
            var total = 0;
            $.each(arrayMoney, function (index, item) {
                total += datatable.convertStringJSToNumber($(item).val());
            });
            $('.select-bill-collect #collect-input-3').val(datatable.formatNumber(total));
            $('.select-bill-collect .col-table-footer-collecting .wrap-text-footer-table').text(datatable.formatNumber(total));
            if (datatable.convertStringJSToNumber($(this).val()) === 0) {
                $(this).parents(".row-collect-table-body").find('.col-table-body-check').removeClass('checked');
            } else {
                $(this).parents(".row-collect-table-body").find('.col-table-body-check').addClass('checked');
            }
        });
    }
    //Tính tổng tiền trong bảng chi tiết
    //Người tạo NVMANH 8/7/2019
    inputMoneyDetail() {
        $('body').on('keyup', '.table-detail-body .input-detail-2', function () {
            var rowDetail = $('.table-detail-body .input-detail-2');
            var total = 0;
            $.each(rowDetail, function (index, item) {
                total += datatable.convertStringJSToNumber($(item).val());
            });
            $('#col-total-money span').text(datatable.formatNumber(total));
        });
    }
    //Sự kiện chọn đối tượng nhà cung cấp và nhân viên
    //Người tạo NVMANH 8/7/2019
    clickRowPerson() {
        $('.row-body-object-pay').find('input').attr('checked', false);
        $('.row-body-object-pay').removeClass('selected-supplier');
        $(this).find('input').attr('checked', true);
        $(this).addClass('selected-supplier');
    }
    //Sự kiện cho nút đồng ý trên bảng chọn nhà cung cấp
    //Người tạo NVMANH 9/7/2019
    evtBtnAgreeSupplier() {
        var rowSelect = $('.object .row-body-object-pay.selected-supplier');
        $('#object-input-left').val($(rowSelect).find('[fieldname="supplierId"]').text());
        $('#object-input-right').val($(rowSelect).find('[fieldname="supplierName"]').text());
        $('#dialog-info-submitter-input').val($(rowSelect).find('[fieldname="supplierName"]').text());
        $('#dialog-object-pay').dialog('close');
        datatable.supplierID = $(rowSelect).data('supplierID');
        $('#dialog-info-address-input').focus();
        $('#object-input-left').parent().css({
            'border': '1px solid #d0d0d0'
        });
    }
    //Sự kiện cho nút đồng ý trên bảng chọn Nhân viên
    //Người tạo NVMANH 9/7/2019
    evtBtnAgreeEmployee() {
        var rowSelect = $('.employee .row-body-object-pay.selected-supplier');
        if ($('#radio1').is(":checked")) {
            $('.dialog-body-different [fieldname="employeeId"]').val($(rowSelect).find('[fieldname="employeeId"]').text());
            $('.dialog-body-different [fieldname="employeeName"]').val($(rowSelect).find('[fieldname="employeeName"]').text());
            datatable.employeeIDDifferent = $(rowSelect).data('employeeID');
        }
        if ($('#radio2').is(":checked")) {
            $('.dialog-body-debt [fieldname="employeeId"]').val($(rowSelect).find('[fieldname="employeeId"]').text());
            $('.dialog-body-debt [fieldname="employeeName"]').val($(rowSelect).find('[fieldname="employeeName"]').text());
            datatable.employeeIDDebt = $(rowSelect).data('employeeID');
        }
        $('#dialog-object-pay').dialog('close');
        $(".table-detail-body .input-detail-1:first").focus();
        $('#employee-input-left').parent().css({
            'border': '1px solid #d0d0d0'
        });
    }
    
    //Hiển thị bảng chọn dữ liệu khách hàng
    //Người tạo NVMANH 13/7/2019
    displayTableEmployee() {
        if ($('#radio2').is(":checked")) {
            
            $('.dialog-body-debt .dialog-info-employee .icon-input-down').after($('.dialog-body-different .dialog-info-employee .table-select-employee').clone(true));
        }
        if ($('#radio1').is(":checked")) {
            $('.dialog-body-debt .dialog-info-employee .icon-input-down').next().remove();
        }
    }
    //Hàm focus vào ô input đầu tiên trên dialog
    //Người tạo NVMANH 11/7/2019
    autoFocusDialog() {
        $('#object-input-left').focus();
        $('#object-input-left').parent().css({
            'border':'1px solid rgb(95, 162, 221)'
        });
    }
    //Hàm thực hiện autocomplete danh sách đối tượng nộp
    //Người tạo NVMANH 15/7/2019
    autocompleteSupplier() {
        var array = [];
        $.ajax({
            async: false,
            method: 'get',
            url: "/supplier",
            success: function (data) {
                array = data.map(function (item) {
                    return {
                        label: item.supplierId,
                        value: item.supplierId,
                        supplierId: item.supplierId,
                        supplierID: item.supplierID,
                        supplierName: item.supplierName,
                        supplierAddress: item.supplierAddress
                    };
                });
            }
        });
        $("#object-input-left").autocomplete({
            appendTo: '#dialog-add-receipt',
            source: array,
            minLength: 1,
            select: function (event, ui) {
                $("#object-input-left").val(ui.item.supplierId);
                $("#object-input-right").val(ui.item.supplierName);
                $("#dialog-info-submitter-input").val(ui.item.supplierName);
                $("#dialog-info-address-input").focus();
                datatable.supplierID = ui.item.supplierID;
                return false;
            },
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
                $('.li-supplier').parent().css({
                    'max-height': '300px',
                    'overflow-y': 'auto',
                    'overflow-x': 'hidden'
                });
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            }
        }).autocomplete("instance")._renderItem = function (ul, item) {
            return $("<li class='li-supplier'>")
                .data('supplierID', item.supplierID)
                .append("<div class='supplierId'>" + item.supplierId + "</div><div class='supplierName'>" + item.supplierName + "</div><div class='supplierAddress'>" + item.supplierAddress + "</div>")
                .appendTo(ul);
        };
    }
    //Hàm thực hiện autocomplete danh sách nhân viên
    //Người tạo NVMANH 15/7/2019
    autocompleteEmployee() {
        var array = [];
        $.ajax({
            async: false,
            method: 'get',
            url: "/employee",
            success: function (data) {
                array = data.map(function (item) {
                    return {
                        label: item.employeeId,
                        value: item.employeeId,
                        employeeId: item.employeeId,
                        employeeID: item.employeeID,
                        employeeName: item.employeeName
                    };
                });
            }
        });
        $("[fieldname='employeeId']").autocomplete({
            appendTo: '#dialog-add-receipt',
            source: array,
            minLength: 1,
            select: function (event, ui) {
                if ($('#radio1').is(":checked")) {
                    $(".dialog-body-different [fieldname='employeeId']").val(ui.item.employeeId);
                    $(".dialog-body-different [fieldname='employeeName']").val(ui.item.employeeName);
                    $(".table-detail-body .input-detail-1:first").focus();
                    datatable.employeeIDDifferent = ui.item.employeeID;
                }
                if ($('#radio2').is(":checked")) {
                    $(".dialog-body-debt [fieldname='employeeId']").val(ui.item.employeeId);
                    $(".dialog-body-debt [fieldname='employeeName']").val(ui.item.employeeName);
                    datatable.employeeIDDebt = ui.item.employeeID;
                }
                return false;
            },
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
                $('.li-employee').parent().css({
                    'max-height': '300px',
                    'overflow-y': 'auto',
                    'overflow-x': 'hidden'
                });
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            }
        }).autocomplete("instance")._renderItem = function (ul, item) {
            return $("<li class='li-employee'>")
                .data('supplierID', item.employeeID)
                .append("<div class='employeeId'>" + item.employeeId + "</div><div class='employeeName'>" + item.employeeName + "</div>")
                .appendTo(ul);
        };
    }
}

//Khởi tạo một đối tượng của class FormDialog
//Người tạo NVMANH 7/6/2019
var form = new FormDialog();
