class MoneyFund {

    //hàm khởi tạo của Class moneyFund
    //Người tạo NVMANH 13/6/2019
    constructor() {
        this.initEvent();
    }

    //Hàm khởi tạo sự kiện
    //Người tạo NVMANH 13/6/2019
    initEvent() {
        //Khởi tạo DateTimePicker
        //Người tạo NVMANH 13/6/2019
        this.initDatePicker();
        //Hàm đặt tiếng việt cho lịch
        //Người tạo NVMANH 13/6/2019
        this.setLangugeDatePicker();
        //Lấy ngày hôm nay cho button Hôm nay
        //Người tạo NVMANH 13/6/2019
        this.setToday();
        //Hiển thị lịch khi click vào icon lịch
        //Người tạo NVMANH 13/6/2019
        this.showDatePicker();
        //Hiên thị mặc định ngày hôm nay khi focus ra ngoài
        //Người tạo NVMANH 13/6/2019
        this.formatDateTime();
        //Hiển trị giá trị item lên đầu Combobox
        //Người tạo NVMANH 13/6/2019
        this.showItemCombobox();
        //Hiển thị kí hiện của item lên đầu combobox
        //Người tạo NVMANH 13/6/2019
        this.showAnotation();
        //Xử lý checkbox trong bẳng dữ liệu chính
        //Người tạo NVMANH 13/6/2019
        this.showCheckTable();
        //Hiển thị check vào tính vào trên dialog
        //Người tạo NVMANH 13/6/2019
        this.showCheckDialog();
        //Cuộn ngang bảng
        //Người tạo NVMANH 13/6/2019
        this.scrollTable();
        //Chọn tab chi tiết và chứng từ trên dialog
        //Người tạo NVMANH 13/6/2019
        this.selectTab();
        //Hiển thi outline của input khi focus vào ô input
        //Người tạo NVMANH 13/6/2019
        this.showOutline();
        //Ẩn outline input khi focus ra ngoài
        //Người tạo NVMANH 13/6/2019
        this.focusOutline();
        //Chọn tất cả nội dung Input khi click vào 
        //Người tạo NVMANH 13/6/2019
        this.selectContentInput();
        //Hiển thị dropbox khi nhân  vào icon
        //Người tạo NVMANH 13/6/2019
        this.showDropBox();
        //Thay đổi kicsch thước bảng chi tiết và bảng chính
        //Người tạo NVMANH 13/6/2019
        this.resizeTable();
        //Xử lý input trong bảng chi tiết trên Dialog
        //Người tạo NVMANH 13/6/2019
        this.inputTableDialog();
        //Hàm xử lý fill ngày từ ngày đến ngày khi click chọn chu kỳ
        //Người tạo 13/6/2019
        this.changeDate();
        //Hiển thị menu quỹ tiền
        //Người tạo NVMANH 17/6/2019
        this.showMenuFund();
        //Sự kiện click vào menu dọc chính
        //Người tạo NVMANH 17/6/2019
        this.clickMenu();
        //Click dòng trên bảng chi tiết
        //Người tạo NVMANH 17/6/2019
        this.clickRowTableDetail();
        //Hàm validate ô input trong dialog
        //Người tạo NVMANH 21/6/2019
        this.validateFormControl();
        // Tự điền vào combobox
        //Người tạo NVMANH 20/6/2019
        this.autoCompleteInput();
        //Gắn sự kiện định dạng tiền cho các ô input
        //Người tạo NVMANH 22/6/2019
        this.formatInputMoney();
        //Hàm định dạng input nhập họ tên khi nhập
        //Người tạo NVMANH 25/6/2019
        this.eventKeyUp();
        //Chọn checkbox trong bảng trên đialog chọn hóa đơn thu nợ
        //Người tạo NVMANH 25/6/2019
        this.checkTableBillCollect();
        //Chọn checkbox trong bảng trên đialog chọn hóa đơn trả nợ
        //Người tạo NVMANH 25/6/2019
        this.checkTableBillPay();
        //Điền giá trị vào ô nhập mục thu trong bảng chi tiết trên dialog
        //Người tạo NVMANH 27/6/2019
        this.fillItemCollect();
        //Tạo context menu trong bảng chi tiết trên dialog
        //Người tạo NVMANH 3/7/2019
        this.createContextMenu();
        //Xóa dòng khi nhấn vào thùng rác tên bảng chi tiết
        //Người tạo NVMANH 3/7/2019
        this.removeRowByTrash();
        //Hiện cảnh báo khi nhập giữ liệu sai
        //Người tạo NVMANH 9/7/2019
        this.showIconValidate();
        //Hiện thông tin cảnh báo khi hover vào icon validate
        //người tạo NVMANH 9/7/2019
        this.showHoverIconValidate();
    }

    //Khởi tạo DateTimePicker
    //Người tạo NVMANH 13/6/2019
    initDatePicker() {
        $(".begin-date, .end-date, .dialog-date-input, .dialog-input-calender-debt, #collect-input-2").datepicker({
            dateFormat: "dd/mm/yy",
            showOtherMonths: true,
            yearRange: "1900:2099",
            showButtonPanel: true
        }).mask("99/99/9999");
        $(".header-form-control-date").datepicker({
            dateFormat: "dd/mm/yy",
            showOtherMonths: true,
            yearRange: "1900:2099",
            showButtonPanel: true
        });
    }
    //Tạo context menu trong bảng chi tiết trên dialog
    //Người tạo NVMANH 3/7/2019
    createContextMenu() {
        $(document).on('click', function () {
            $('.context-menu').hide();
        });
        $('.dialog-body-different .dialog-detail-table-body').on('contextmenu', function (evt) {
            evt.preventDefault();
            var x = (evt.pageX - $(this).offset().left);
            var y = (evt.pageY - $(this).offset().top);
            if (y > 165 || x > 760) {
                $('.context-menu').show().css({
                    'left': x - 120,
                    'top': y - 32
                });
            } else {
                $('.context-menu').show().css({
                    'left': x,
                    'top': y
                });
            }
        });
    }
    //Hàm đặt tiếng việt cho lịch
    //Người tạo NVMANH 13/6/2019
    setLangugeDatePicker() {
        $.datepicker.regional["vi-VN"] =
            {
                closeText: "Đóng",
                prevText: "Trước",
                nextText: "Sau",
                currentText: "Hôm nay",
                monthNames: ["Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"],
                monthNamesShort: ["Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai"],
                dayNames: ["Chủ nhật", "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy"],
                dayNamesShort: ["CN", "Hai", "Ba", "Tư", "Năm", "Sáu", "Bảy"],
                dayNamesMin: ["CN", "T2", "T3", "T4", "T5", "T6", "T7"],
                weekHeader: "Tuần",
                dateFormat: "dd/mm/yyyy",
                firstDay: 0,
                isRTL: false,
                showMonthAfterYear: false,
                yearSuffix: ""
            };

        $.datepicker.setDefaults($.datepicker.regional["vi-VN"]);
    }

    //Lấy ngày hôm nay cho button Hôm nay
    //Người tạo NVMANH 13/6/2019
    setToday() {
        $.datepicker._gotoToday = function (id) {
            var inst = this._getInst($(id)[0]);

            var date = new Date();
            this._selectDay(id, date.getMonth(), date.getFullYear(), inst.dpDiv.find('td.ui-datepicker-today'));
        };
    }

    //Hiển thị lịch khi click vào icon lịch
    //Người tạo NVMANH 13/6/2019
    showDatePicker() {
        $("body").on('click', ".btn-icon-calender", function () {
            if ($('#ui-datepicker-div').is(':visible')) {
                $(this).prev().datepicker('hide');
            } else {
                $(this).prev().datepicker('show');
            }
        });
    }


    //Hiên thị mặc định ngày hôm nay khi focus ra ngoài
    //Người tạo NVMANH 13/6/2019
    formatDateTime() {
        var now = new Date();
        var dd = now.getDate();
        var mm = now.getMonth() + 1;
        if (dd < 10) {
            dd = '0' + dd;
        }

        if (mm < 10) {
            mm = '0' + mm;
        }
        var today = dd + '/' + mm + '/' + now.getFullYear();
        $(".show-calender").val(today);
        $('body').on('focusout', '.show-calender',function () {
            if ($(this).val() === "__/__/____" || !datatable.checkDate(this)) {
                $(this).val(today);
            }
        });
        $('body').on('keyup', '.show-calender', function () {
            var a = datatable.checkDate(this);
            if (!datatable.checkDate(this)) {
                $(this).parent().css({
                    'border': '1px solid red'
                });
            } else {
                $(this).parent().css({
                    'border': '1px solid rgb(95, 162, 221)'
                });
            }
        });
    }

    //Hiển trị giá trị item lên đầu Combobox
    //Người tạo NVMANH 13/6/2019
    showItemCombobox() {
        $('.item-value').on('click', function () {
            $(this).parent().parent().find('input').val($(this).html());
        });
        $('.combobox').focusout(function () {
            if ($(this).val() === "") {
                $(this).val($(this).parent().find('.item-value').first().html());
            }
        });
    }

    //Hiển thị kí hiện của item lên đầu combobox
    //Người tạo NVMANH 13/6/2019
    showAnotation() {
        $('.anotation').on('click', function () {
            var content = $(this).find('span').text();
            $(this).parent().prev().find('span').text(content);
            $(this).parent().prev().find('span').attr('value', ($(this).attr('value')));
        });
    }

    //Xử lý checkbox trong bẳng dữ liệu chính
    //Người tạo NVMANH 13/6/2019
    showCheckTable() {
        $("body").on("click", ".row-content-date, .row-content-number-voucher, .row-content-type-voucher, .row-content-total, .row-content-object, .row-content-reason", function () {
            if (event.ctrlKey) {
                $(this).parent().addClass("row-content-active");
                $('#toolbar-item-duplicate, #toolbar-item-view, #toolbar-item-edit').addClass('dialog-header-item-off');
            } else {
                $('#toolbar-item-duplicate, #toolbar-item-view, #toolbar-item-edit, #toolbar-item-delete').removeClass('dialog-header-item-off');
                $(".row-content").removeClass("row-content-active");
                $(this).parent().addClass("row-content-active");
                datatable.checkTypeFund();
            }
            $(".wrap-box-detail-table-body").html("");
            datatable.getDataTableDetailByID();
        });
        $(".header-column-inner .check-all").on("click", function () {
            $(this).toggleClass('checked');
            if ($(this).hasClass("checked")) {
                $(".row-content-check").addClass("checked");
                $(".row-content").addClass("row-content-active");
            }
            else {
                $(".row-content-check").removeClass("checked");
                $(".row-content").removeClass("row-content-active");
            }
        });
        $("body").on("click", ".row-content-check", function () {
            $(this).toggleClass('checked');
            if ($(this).hasClass("checked")) {
                $(this).parent().addClass("row-content-active");
            } else {
                $(this).parent().removeClass("row-content-active");
            }
            var checked = $('.content-table-body').find('.row-content-check.checked').length;
            var all = $('.content-table-body').find('.row-content-check').length;
            if (checked === all)
                $('.header-column-inner .check-all').addClass('checked');
            else
                $('.header-column-inner .check-all').removeClass('checked');
        });
    }
    //Hiển thị check vào tính vào trên dialog
    //Người tạo NVMANH 13/6/2019
    showCheckDialog() {
        $("body").on("click", ".btn-check-calc-collect", function () {
            $(".btn-check-calc-collect").children().toggle();
        });
        $("body").on("click", ".btn-check-calc-pay", function () {
            $(".btn-check-calc-pay").children().toggle();
        });
    }

    //Cuộn ngang bảng
    //Người tạo NVMANH 13/6/2019
    scrollTable() {
        $(".content-table-main").scroll(function () {
            $(".content-table-total, .content-table-header").scrollLeft($(".content-table-main").scrollLeft());
        });
        $(".box-detail-table-body").scroll(function () {
            $(".box-detail-table-total, .box-detail-table-header").scrollLeft($(".box-detail-table-body").scrollLeft());
        });
        $(".dialog-voucher-tab-body").scroll(function () {
            $(".dialog-voucher-tab-footer, .dialog-voucher-tab-header").scrollLeft($(".dialog-voucher-tab-body").scrollLeft());
        });
    }

    //Chọn tab chi tiết và chứng từ trên dialog
    //Người tạo NVMANH 13/6/2019
    selectTab() {
        $(".tab-label-detail").on('click', function () {
            $(".tab-label-detail").addClass("tab-label-click");
            $(".tab-label-voucher").removeClass("tab-label-click");
            $(".dialog-content-tab-voucher").hide();
            $(".dialog-content-tab-detail").show();
        });
        $(".tab-label-voucher").on('click', function () {
            $(".tab-label-voucher").addClass("tab-label-click");
            $(".tab-label-detail").removeClass("tab-label-click");
            $(".dialog-content-tab-detail").hide();
            $(".dialog-content-tab-voucher").show();
        });
    }

    //Hiển thi outline của input khi focus vào ô input
    //Người tạo NVMANH 13/6/2019
    showOutline() {
        $('body').on('focus', "input[type='text']", function () {
            $(this).parent().css("border-color", "#5fa2dd");
        });
        $('body').on('focus', ".header-select input[type='text']", function () {
            $(this).css("border-left", "1px solid #5fa2dd");
        });
    }

    //Ẩn outline input khi focus ra ngoài
    //Người tạo NVMANH 13/6/2019
    focusOutline() {
        $('body').on('focusout', "input[type='text']", function () {
            $(this).parent().css("border-color", "#d0d0d0");
        });
        $('body').on('focusout', ".header-select input[type='text']", function () {
            $(this).css("border-left", "1px solid #d0d0d0");
        });
    }


    //Chọn tất cả nội dung Input khi click vào 
    //Người tạo NVMANH 13/6/2019
    selectContentInput() {
        $("body").not(".select-object-item").on("focus", "input[type='text']", function () {
            $(this).select();
        });
    }
    
    //Hiển thị dropbox khi nhân  vào icon
    //Người tạo NVMANH 13/6/2019
    showDropBox() {
        $('body').on('click', '.arrow-down', function (event) {
            event.stopPropagation();
            $(".dialog-table-select").not($(this).parent().find('.dialog-table-select')).hide();
            $(this).parent().find(".dialog-table-select").toggle();
            $(".dialog-table-select").on('click', function () {
                $(".dialog-table-select").hide();
            });
        });
        //$('.dialog-table-select').on("click", function (event) {
        //    event.stopPropagation();
        //});
        $(document).on("click", function () {
            $('.dialog-table-select').hide();
        });
    }

    //Thay đổi kicsch thước bảng chi tiết và bảng chính
    //Người tạo NVMANH 13/6/2019
    resizeTable() {
        $(".table-bottom").resizable({
            minHeight: 100,
            maxHeight: $(window).height() - 370,
            minWidth: $(window).width() - 162,
            maxWidth: $(window).width() - 162,
            create: function (event, ui) {
                $(".ui-resizable-n").css("cursor", "row-resize");
            },
            handles: "n"
        });
        $('.table-bottom').resize(function () {
            $('.table-top').height($(".content-table").height() - $(".table-bottom").height());
        });
    }

    //Xử lý input trong bảng chi tiết trên Dialog
    //Người tạo NVMANH 13/6/2019
    inputTableDialog() {
        //$('body').on('focus', '.wrap-text-body-column', function () {
        //    if ($(this).children('input').val() === "") {
        //        $(this).children('input').not('#col-detail-money').attr("placeholder", "Nhập giá trị");
        //    }
        //    //$(this).parent().parent().find('input').css('background-color', '#c3ecff');
        //    $(this).css({
        //        'background-color': '#fff',
        //        'border': "1px solid #5fa2dd"
        //    });
        //    $(this).css('background-color', '#c3ecff');
        //});
        //$('body').on('focusout', '.wrap-text-body-column', function () {
        //    $(this).children('input').attr("placeholder", "");
        //    $(this).css({
        //        'border': "1px solid #c3ecff"
        //    });
        //    $(this).css('background-color', '#fff');
        //});
        //$('body').on('focusout', '.row-tab-detail-radio', function () {
        //    $('.wrap-text-body-column').children('input').attr("placeholder", "");
        //    //$('.wrap-text-body-column').parent().parent().find('input').css('background-color', '#c3ecff');
        //    $('.wrap-text-body-column').children('input').css({
        //        'background-color': '#fff',
        //        'border': "1px solid #fff"
        //    });
        //});

    }
    //Hàm xử lý fill ngày từ ngày đến ngày khi click chọn chu kỳ
    //Người tạo 13/6/2019
    changeDate() {
        $('body').on('click', '.ui-autocomplete .ui-menu-item', function () {
            var val = $(this).attr('value');
            var date = new Date();
            var startDate;
            var endDate;
            switch (val) {
                case '1':
                    startDate = date;
                    endDate = date;
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '2':
                    startDate = new Date(date.setDate(date.getDate() - 1));
                    endDate = startDate;
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '3':
                    startDate = new Date(date.setDate(date.getDate() - date.getDay()));
                    endDate = new Date();
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '4':
                    startDate = new Date(date.setDate(date.getDate() - 7 - date.getDay()));
                    endDate = new Date(new Date().setDate(startDate.getDate() + 6));
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '5':
                    startDate = new Date(date.setDate(1));
                    endDate = new Date();
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '6':
                    startDate = new Date(date.setMonth(date.getMonth() - 1));
                    startDate = new Date(date.setDate(1));
                    endDate = new Date(startDate.getFullYear(), startDate.getMonth() + 1, 0);
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '7':
                    startDate = new Date(date.setMonth(date.getMonth() - parseInt(date.getMonth() % 3)));
                    startDate.setDate(1);
                    endDate = new Date();
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '8':
                    startDate = new Date(date.setMonth(date.getMonth() - 3 - parseInt(date.getMonth() % 3)));
                    startDate.setDate(1);
                    endDate = new Date(startDate.getFullYear(), startDate.getMonth() + 3, 0);
                    $('.begin-date').datepicker("setDate", startDate);
                    $('.end-date').datepicker("setDate", endDate);
                    break;
                case '9':
                    startDate = new Date(date.setMonth(date.getMonth() - 6));
                    startDate.setDate(1);
                    date = new Date();
                    endDate = new Date(date.setMonth(date.getMonth()));
                    endDate.setDate(0);
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '10':
                    startDate = new Date(date.getFullYear(), 0, 1);
                    endDate = new Date();
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '11':
                    startDate = new Date(date.getFullYear() - 1, 0, 1);
                    endDate = new Date(date.getFullYear() - 1, 12, 0);
                    $('.begin-date').datepicker('setDate', startDate);
                    $('.end-date').datepicker('setDate', endDate);
                    break;
                case '12':

                    break;
            }

        });
    }
    //Hiển thị menu quỹ tiền
    //Người tạo NVMANH 17/6/2019
    showMenuFund() {
        $('#menu-fund').on("click", function () {
            $(".menu-fund").toggle();
        });
        $(".menu-fund").on("click", function () {
            $(".menu-fund").hide();
        });
    }
    //Sự kiện click vào menu dọc chính
    //Người tạo NVMANH 17/6/2019
    clickMenu() {
        $('.menu-item').on('click', function () {
            $('.menu-item').removeClass('menu-active');
            $(this).addClass('menu-active');
        });
    }

    //Click dòng trên bảng chi tiết
    //Người tạo NVMANH 17/6/2019

    clickRowTableDetail() {
        $('body').on('click', '.row-content-detail', function () {
            $('.row-content-detail').removeClass('row-content-active');
            $(this).addClass('row-content-active');
        });
    }
    //Hàm validate ô input trong dialog
    //Người tạo NVMANH 21/6/2019

    validateFormControl() {
        this.validateInput("#dialog-info-reason-input", 255);
        this.validateInputMoney("#col-detail-money", 16);
        this.validateInputMoney(".input-detail-2", 16);
        this.validateInputMoney(".type-money-bill", 16);
        this.validateInputMoney("#collect-input-3", 16);
    }


    //Hàm validate ô nhập tring dialog
    //Người tạo 19/6/2019
    validateInput(input, length) {
        $(input).keydown(function () {
            if ($(input).val().length > length) {
                $(input).parent().addClass('border-validate');
            } else {
                $(input).parent().removeClass('border-validate');
            }
        });
    }

    //Validate ô nhập tiền
    //Người tạo NVMANH 19/6/2019
    validateInputMoney(input, length) {
        $('body').on('keydown', input, function () {
            if ($(this).val().length >= length) {
                $(this).addClass('border-validate');
            } else {
                $(this).removeClass('border-validate');
            }
        });
        $(input).focusout(function () {
            $('#col-total-money span').text($(input).val());
        });
    }
    // Tự điền vào combobox
    //Người tạo NVMANH 20/6/2019
    autoCompleteInput() {
        $('#tags').focus(function () {
            $('.ui-menu').addClass('ui-menu-range-item');
        });
        $('#tags').focusout(function () {
            $('.ui-menu').removeClass('ui-menu-range-item');
        });
        var availableTags = [
            {
                value: "1",
                label: "Hôm nay"
            },
            {
                value: "2",
                label: "Hôm qua"
            },
            {
                value: "3",
                label: "Tuần này"
            },
            {
                value: "4",
                label: "Tuần trước"
            },
            {
                value: "5",
                label: "Tháng này"
            },
            {
                value: "6",
                label: "Tháng trước"
            },
            {
                value: "7",
                label: "Quý này"
            },
            {
                value: "8",
                label: "Quý trước"
            },
            {
                value: "9",
                label: "6 tháng trước"
            },
            {
                value: "10",
                label: "Năm nay"
            },
            {
                value: "11",
                label: "Năm trước"
            },
            {
                value: "12",
                label: "Khác "
            }
        ];
        $("#tags").autocomplete({
            //autoFocus: true,
            //minLength: 0,
            source: availableTags,
            focus: function (event, ui) {
                $("#tags").val(ui.item.label);
                return false;
            },
            select: function (event, ui) {
                $("#tags").val(ui.item.label);
                return false;
            }
        }).autocomplete("instance")._renderItem = function (ul, item) {
                return $("<li class='li-date-range'>")
                    .attr("value", item.value)
                    .append(item.label)
                    .appendTo(ul);
            };
        $('.icon-down-range-item').click(function () {
            if ($('.ui-autocomplete .ui-menu-item:visible').length > 0) {
                $('#tags').autocomplete('close');
            } else {
                $('.ui-menu').addClass('ui-menu-range-item');
                $('#tags').autocomplete('search', " ");
            }

        });
    }
    //Tự động định dạng tiền tệ sau khi focusout ra khỏi ô nhập tiền
    //Người tạo NVMANH 21/6/2019
    formatMoney(money) {
        //var money = $('#col-detail-money');
        $('body').on('keyup', money, function (event) {
            if ($.inArray(event.keyCode, [38, 40, 37, 39]) !== -1) {
                return;
            }
            var $this = $(this);
            var input = $(this).val();
            input = input.replace(/[\D\s\._\-]+/g, "");
            input = input ? parseInt(input, 10) : 0;
            $this.val(function () {
                return input === "0" ? "0" : input.toLocaleString('it-IT');
            });
        });
    }
    //Gắn sự kiện định dạng tiền cho các ô input
    //Người tạo NVMANH 22/6/2019
    formatInputMoney() {
        this.formatMoney('#col-detail-money');
        this.formatMoney('#collect-input-3');
        this.formatMoney('.type-money-bill');
        this.formatMoney('.input-detail-2');
        this.formatMoney('#money-header');
    }
    //Hàm định dạng input nhập họ tên khi nhập
    //Người tạo NVMANH 25/6/2019
    eventKeyUp() {
        $('body').on('keyup', '#object-input-right', function (event) {
            if ($(this).val() === " ") {
                $(this).val("");
            }
            var name = $('#object-input-right').val();
            name = name.replace(/\s+/g, ' ').replace(/(?<=^).|(?<=\s)./g, s => s.toUpperCase());
            $('#object-input-right').val(name);
        });
    }
    //Chọn checkbox trong bảng trên đialog chọn hóa đơn thu nợ
    //Người tạo NVMANH 25/6/2019
    checkTableBillCollect() {
        $('body').on('click', '.select-bill-collect .collect-table-body .row-collect-table-body', function () {
            $(this).find('.col-table-body-check').toggleClass('checked');
            var rowChecked = $('.select-bill-collect .collect-table-body .checked').length;
            var rowCheck = $('.select-bill-collect .collect-table-body .col-table-body-check').length;
            if (rowChecked === rowCheck) {
                $('.select-bill-collect .check-all').addClass('checked');
            } else {
                $('.select-bill-collect .check-all').removeClass('checked');
            }
        });
        $('body').on('click', '.select-bill-collect .collect-table-header .col-table-header-check', function () {
            $(this).find('.check-all').toggleClass('checked');
            if ($(this).find('.checked').is(":visible")) {
                $('.select-bill-collect .col-table-body-check').addClass('checked');
            } else {
                $('.select-bill-collect .col-table-body-check').removeClass('checked');
            }
        });
    }
    //Chọn checkbox trong bảng trên đialog chọn hóa đơn trả nợ
    //Người tạo NVMANH 25/6/2019
    checkTableBillPay() {
        $('body').on('click', '.select-bill-pay .collect-table-body .row-pay-table-body', function () {
            $(this).find('.col-table-body-check').toggleClass('checked');
            var rowChecked = $('.select-bill-pay .collect-table-body .checked').length;
            var rowCheck = $('.select-bill-pay .collect-table-body .col-table-body-check').length;
            if (rowChecked === rowCheck) {
                $('.select-bill-pay .check-all').addClass('checked');
            } else {
                $('.select-bill-pay .check-all').removeClass('checked');
            }
        });
        $('body').on('click', '.select-bill-pay .collect-table-header .col-table-header-check', function () {
            $(this).find('.check-all').toggleClass('checked');
            if ($(this).find('.checked').is(":visible")) {
                $('.select-bill-pay .col-table-body-check').addClass('checked');
            } else {
                $('.select-bill-pay .col-table-body-check').removeClass('checked');
            }
        });
    }
    //Điền giá trị vào ô nhập mục thu trong bảng chi tiết trên dialog
    //Người tạo NVMANH 27/6/2019
    fillItemCollect() {
        $('body').on('click', '#dialog-add-receipt .dialog-table-select-item span', function () {
            $(this).parent().siblings('#select-item-collect').val($(this).text());
        });
        $('body').on('click', '#dialog-add-receipt .dialog-table-select-item span', function () {
            $(this).parent().siblings('.input-detail-3').val($(this).text());
        });
    }
    //Xóa dòng khi nhấn vào thùng rác tên bảng chi tiết
    //Người tạo NVMANH 3/7/2019
    removeRowByTrash() {
        $('body').on('click', '.table-detail-body .wrap-column-icon-delete', function () {
            $(this).parents(".row-tab-detail-radio").remove();
            var rowDetail = $('.table-detail-body .input-detail-2');
            var total = 0;
            $.each(rowDetail, function (index, item) {
                total += datatable.convertStringJSToNumber($(item).val());
            });
            $('#col-total-money span').text(datatable.formatNumber(total));
        });
    }
    //Hiện combobox cho lúc thêm dòng
    //Người tạo NVMANH 3/7/2019
    showRowAdd() {
        $('body').on('click', 'arrow-row-add', function () {

        });
    }
    //Hiện cảnh báo khi nhập giữ liệu sai
    //Người tạo NVMANH 9/7/2019
    showIconValidate() {
        $('body').on('keyup', '.dialog-voucher-number-input input, .dialog-voucher-date-input input', function () {
            if ($(this).val().length < 1 || $(this).val().length > 16) {
                $(this).parent().next().show();
                $(this).parent().css({
                    'width': 'calc(100% - 118px)',
                    'border':'1px solid red'
                });
            } else {
                $(this).parent().next().hide();
                $(this).parent().css({
                    'width': 'calc(100% - 100px)',
                    'border': '1px solid rgb(95, 162, 221)'
                });
            }
        });
        $('body').on('focusout', '.dialog-voucher-number-input input, .dialog-voucher-date-input input', function () {
            if ($(this).val().length < 1 || $(this).val().length > 16) {
                $(this).parent().next().show();
                $(this).parent().css({
                    'width': 'calc(100% - 118px)',
                    'border': '1px solid red'
                });
            } else {
                $(this).parent().next().hide();
                $(this).parent().css({
                    'width': 'calc(100% - 100px)',
                    'border': '1px solid #d0d0d0'
                });
            }
        });
        this.checkValitade('#object-input-left, #employee-input-left', 1, 16, 'keyup', 'focusout');
        this.checkValitade('#object-input-right', 0, 128, 'keyup', 'focusout');
        this.checkValitade('#dialog-info-submitter-input, #dialog-info-address-input, #dialog-info-reason-input', 0, 255, 'keyup', 'focusout');
        $('body').mouseover(function () {
            if (!$('#dialog-add-receipt').dialog('isOpen')) {
                $('.dialog-body-info-left input').parent().css({
                    'border': '1px solid #d0d0d0'
                });
            }
        });
    }
    //Hàm kiểm tra valide dữ liệu trên hóa đơn thu nợ khác
    //Người tạo NVMANH 10/7/2019
    checkValitade(input, length_1, length_2, event_1, event_2) {
        $('body').on(event_1, input, function () {
            if ($(this).val().length < length_1 || $(this).val().length > length_2) {
                $(this).parent().css({
                    'border': '1px solid red'
                });
            } else {
                $(this).parent().css({
                    'border': '1px solid rgb(95, 162, 221)'
                });
            }
        });
        $('body').on(event_2, input, function () {
            if ($(this).val().length < length_1 || $(this).val().length > length_2) {
                $(this).parent().css({
                    'border': '1px solid red'
                });
            } else {
                $(this).parent().css({
                    'border': '1px solid #d0d0d0'
                });
            }
        });
    }
    //Hiện thông tin cảnh báo khi hover vào icon validate
    //người tạo NVMANH 9/7/2019
    showHoverIconValidate() {
        $('body').on('mouseover', '.icon-warn-validate', function () {
            $(this).next().show();
        });
        $('body').on('mouseout', '.icon-warn-validate', function () {
            $(this).next().hide();
        });
    }
}

//Tạo đối tương cho moneyFund()
//Người tạo NVMANH 13/6/2019
var moneyfund = new MoneyFund();