//Class cho bảng dữ liệu
//Người tạo NVMANH 12/6/2019
class DataTableMain {

    constructor() {
        //Hàm khởi tạo sự kiện cho load dữ liệu
        //Người tạo NVMANH 20/6/2019
        this.initEvent();
        //Mã nhà cung cấp
        //Người tạo NVMANH 15/6/2019
        this.supplierID;
        //Mã nhân viên khác
        //Người tạo NVMANH 15/6/2019
        this.employeeIDDifferent;
        //Mã nhân viên Khi thêm phiếu thu nợ
        //Người tạo NVMANH 15/6/2019
        this.employeeIDDebt;
        //Mã khách hàng
        //Người tạo NVMANH 15/6/2019
        this.customerID;
        //Mã nhà cung cấp được chọn
        //Người tạo NVMANH 17/6/2019
        this.selectTypeSupplier;
        //Mã hóa đơn
        //Người tạo NVMANH 17/6/2019
        this.fundID;
    }
    //Hàm khởi tạo sự kiện cho load dữ liệu
    //Người tạo NVMANH 20/6/2019
    initEvent() {
        //Hàm load dữ liệu cho bảng dữ liệu chính
        //Người tạo NVMANH 20/6/2019
        this.filterFund('', 1, 50);
        //Hàm load dữ liệu cho bảng nhà cũng cấp
        //Người tạo NVMANH 20/6/2019
        this.loadDataTableSupplier();
        //Hàm lấy dữ liệu cho bảng nhà cung cấp
        //Người tạo NVMANH 25/6/2019
        this.loadDataTableSupplierDialog();
        //Hàm load dữ liệu cho bảng nhân viên
        //Người tạo NVMANH 20/6/2019
        this.loadDataTableEmployee();
        //Hàm lấy dữ liệu cho bảng nhân viên khi ấn vào tìm kiếm nhân viên
        //Người tạo NVMANH 20/6/2019
        this.loadDataTableSearchEmployee();
        //Hàm lấy dữ liệu cho bảng nhà cung cấp khi ấn vào tìm kiếm nhà cung cấp
        //Người tạo NVMANH 20/6/2019
        this.loadDataTableSearchSupplier();
        //Hàm lấy dữ liệu cho bảng khách hàng
        //Người tạo NVMANH 20/6/2019
        this.loadDataTableCustomer();
        //Hàm tự động điền input trong dialog
        //Người tạo NVMANH 20/6/2019
        this.autoFillDialog();
        //Load tên nhà cung cấp khi nhấn vào bảng nhà cung cấp
        //Người tạo NVMANH 21/6/2019
        this.loadFillSupplier();
        //Load tên nhà cung cấp khi nhấn vào bảng nhà cung cấp
        //Người tạo NVMANH 21/6/2019
        this.loadFillEmployee();
        //Điền tên khách hàng khi click vào dòng
        //Người tạo NVMANH 20/6/2019
        this.autoFillNameCustomer();
        //Điền tên nhà cung cấp khi click vào dòng
        //Người tạo NVMANH 20/6/2019
        this.autoFillNameSupplier();
        //Lấy loại nhà cung cấp vào combo box
        //Người tạo NVMANH 8/7/2019
        this.loadDataSupplierType();
        //Load nhà cung cấp tương ứng với loại được chọn
        //Người tạo NVMANH 8/7/2019
        this.loadSupplierByType();
        //Căn chỉnh lại cột khi có thanh cuộn
        //Người tạo NVMANH 9/7/2019
        this.resizeColhasScroll();
        //Hàm tính tổng cho bang dữ liệu chính
        //Người tạo NVMANH 12/6/2019
        this.getTotal();
        //Thêm data cho dòng dữ liệu
        //Người tạo NVMANH 1/7/2019
        this.addData();
        //Hàm lấy ngày hiện tại
        Date.prototype.getFullTimeCurrent = function () {
            let formatted = (this.getHours() < 10 ? "0" + this.getHours() : this.getHours()) +
                ":" + (this.getMinutes() < 10 ? "0" + this.getMinutes() : this.getMinutes()) +
                ":" + (this.getSeconds() < 10 ? "0" + this.getSeconds() : this.getSeconds());
            return " " + formatted;
        };
        //Kiểm tra ngày có giá trị không
        Date.prototype.isValid = function () {
            return this.getTime() === this.getTime();
        };
        //Hàm hiểm tra có thanh cuộn
        (function ($) {
            $.fn.hasScrollBar = function () {
                return this.get(0).scrollHeight > this.height();
            };
        })(jQuery);
    }
    //Hàm load dữ liệu cho bảng dữ liệu chính
    //Người tạo NVMANH 20/6/2019
    loadDataTableMain(Url) {
        $.ajax({
            method: "GET",
            url: Url,
            beforeSend: function () {
                $('.icon-loading').show();
                $('#overlay').show();
            },
            complete: function (data) {
                $('.icon-loading').hide();
                $('#overlay').hide();
            }
        }).done(function (response) {
            var data = response;
            $.each(data.Data, function (index, item) {
                $(".row-clone span").each(function () {
                    let fieldName = $(this).attr("fieldName");
                    let fieldData = $(this).attr("fieldData");
                    if (fieldData === "Time") {
                        $(this).text(new Date(item[fieldName]).toLocaleDateString('en-GB'));
                    } else {
                        $(this).text(item[fieldName]);
                    }
                    if (fieldData === "Number") {
                        $(this).text(datatable.formatNumber(item[fieldName]));
                    }
                });

                $('.content-table-body').append($('.row-clone').html());
                $('.content-table-body .row-content:last-child').data('FundID', item["FundID"]);
            });
            $('.content-table-body .row-content-date:first').trigger('click');
            //datatable.fundID = $('.content-table-body .row-content:first').data('fundID');
        }).fail(function (response) {

        });
    }
    //Hàm để lọc dữ liệu
    //Người tạo NVMANH 29/7/2019
    filterFund(condition, pageNumber, pageSize) {
        $.ajax({
            method: "POST",
            url: '/fund/filter/' + pageNumber + '/' + pageSize,
            data: JSON.stringify(condition),
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            beforeSend: function () {
                $('.icon-loading').show();
                $('#overlay').show();
            },
            complete: function (data) {
                $('.icon-loading').hide();
                $('#overlay').hide();
            }
        }).done(function (response) {
            var pageSize = $('.btn-paging-select option:selected').val();
            var pageNumber = $('#page-number').val();
            if (response.Data.length === 0) {
                $('#toolbar-item-duplicate, #toolbar-item-view, #toolbar-item-edit, #toolbar-item-delete').addClass('dialog-header-item-off');
            }
            $('.content-table-body').html('<div class="icon-loading"></div ><div id="overlay-main"></div>');
            var data = response;
            var total = 0;
            $.each(data.Data, function (index, item) {
                $(".row-clone span").each(function () {
                    let fieldName = $(this).attr("fieldName");
                    let fieldData = $(this).attr("fieldData");
                    if (fieldData === "Time") {
                        $(this).text(new Date(item[fieldName]).toLocaleDateString('en-GB'));
                    } else {
                        $(this).text(item[fieldName]);
                    }
                    if (fieldData === "Number") {
                        $(this).text(datatable.formatNumber(item[fieldName]));
                        total += item[fieldName];
                    }
                });

                $('.content-table-body').append($('.row-clone').html());
                $('.content-table-body .row-content:last-child').data('FundID', item["FundID"]);
            });
            $('#cell-total-money').text(datatable.formatNumber(total));
            $('.start-row').text((pageNumber - 1) * pageSize + 1);
            $('.end-row').text((pageNumber - 1) * pageSize + response.Data.length);
            $('.total-row').text(response.Data[0].TotalCount);
            $('.total-page').text(parseInt(response.Data[0].TotalCount / pageSize) + 1);
            $('.content-table-body .row-content-date:first').trigger('click');
            if (pageNumber >= parseInt(response.Data[0].TotalCount / pageSize) + 1) {
                $('.icon-step-forward').addClass('dialog-header-item-off');
            } else {
                $('.icon-step-forward').removeClass('dialog-header-item-off');
            }
            if (pageNumber <= 1) {
                $('.icon-step-backward').addClass('dialog-header-item-off');
            } else {
                $('.icon-step-backward').removeClass('dialog-header-item-off');
            }
        }).fail(function (response) {

        });
    }
    //Hàm load dữ liệu cho bảng nhà cũng cấp
    //Người tạo NVMANH 20/6/2019
    loadDataTableSupplier() {
        $.ajax({
            method: "GET",
            url: '/supplier'
        }).done(function (response) {
            var data = response.Data;
            $.each(data, function (index, item) {
                $(".row-clone-supplier span").each(function () {
                    let fieldName = $(this).attr("fieldName");
                    let fieldData = $(this).attr("fieldData");
                    if (fieldData === "Time") {
                        $(this).text(new Date(item[fieldName]).toLocaleDateString('en-GB'));
                    } else {
                        $(this).text(item[fieldName]);
                    }
                    if (fieldData === "Number") {
                        $(this).text(datatable.formatNumber(item[fieldName]));
                    }
                });

                $('.wrap-select-object-content').append($('.row-clone-supplier').html());
                $('.wrap-select-object-content .row-select-object:last-child').data('SupplierID', item["SupplierID"]);
            });
        }).fail(function (response) {

        });
    }
    //Hàm load dữ liệu cho bảng nhân viên
    //Người tạo NVMANH 20/6/2019
    loadDataTableEmployee() {
        $.ajax({
            method: "GET",
            url: '/employee'
        }).done(function (response) {
            var data = response.Data;
            $.each(data, function (index, item) {
                $(".row-clone-employee span").each(function () {
                    let fieldName = $(this).attr("fieldName");
                    let fieldData = $(this).attr("fieldData");
                    if (fieldData === "Time") {
                        $(this).text(new Date(item[fieldName]).toLocaleDateString('en-GB'));
                    } else {
                        $(this).text(item[fieldName]);
                    }
                    if (fieldData === "Number") {
                        $(this).text(datatable.formatNumber(item[fieldName]));
                    }
                });
                $('.wrap-select-employee-content').append($('.row-clone-employee').html());
                $('.wrap-select-employee-content .row-employee-object:last-child').data('EmployeeID', item["EmployeeID"]);
            });
        }).fail(function (response) {

        });
    }
    //Hàm kiểm tra phiếu thu nợ/phiếu khác
    //Người tạo NVMANH 17/7/2019
    checkTypeFund() {
        var fundCode = $('.content-table-body .row-content.row-content-active').data("FundID");
        $.ajax({
            method: "GET",
            url: "/fund/" + fundCode,
            success: function (res) {
                var data = res.Data;
                if (!data.CheckDifferent) {
                    $('#toolbar-item-duplicate').addClass('dialog-header-item-off');
                } else {
                    $('#toolbar-item-duplicate').removeClass('dialog-header-item-off');
                }
            },
            error: function () {

            }
        });
    }
    //Hàm lấy dữ liệu theo id cho bảng chi tiết dưới bảng chính
    //Người tạo NVMANH 20/6/2019
    getDataTableDetailByID() {
        var fundCode = $('.content-table-body .row-content.row-content-active').data("FundID");
        var total = 0;
        $('.detail-column-total-money div').text('0');
        
        $.ajax({
            method: 'GET',
            url: '/fund/detail/' + fundCode,
            beforeSend: function () {
                $('.icon-loading-detail').show();
            },
            complete: function (data) {
                $('.icon-loading-detail').hide();
            }
        }).done(function (response) {
            var data = response.Data;
            $('.wrap-box-detail-table-body').html('');
            $.each(data, function (index, item) {
                $(".row-detail-clone span").each(function () {
                    let fieldName = $(this).attr("fieldName");
                    let fieldData = $(this).attr("fieldData");
                    if (fieldData === "Number") {
                        total += item[fieldName];
                        $(this).text(datatable.formatNumber(item[fieldName]));
                    }
                    else {
                        $(this).text(item[fieldName]);
                    }
                });
                $(".wrap-box-detail-table-body").append($(".row-detail-clone").html());
                $('.detail-column-total-money div').text(datatable.formatNumber(total));
            });
            if ($('.box-detail-table-body').hasScrollBar()) {
                $('.detail-column-body.detail-column-body-explain').css({
                    'width': 'calc(100% - 400px)'
                });
            } else {
                $('.detail-column-body.detail-column-body-explain').css({
                    'width': 'calc(100% - 417px)'
                });
            }
        }).fail(function (response) {

        });
    }

    //Hàm lấy dữ liệu cho bảng nhân viên khi ấn vào tìm kiếm nhân viên
    //Người tạo NVMANH 20/6/2019
    loadDataTableSearchEmployee() {
        $.ajax({
            method: 'GET',
            url: '/employee',
            success: function (res) {
                $.each(res.Data, function (index, item) {
                    $('.employee .row-clone-search-employee span').each(function () {
                        let fieldName = $(this).attr("fieldName");
                        $(this).text(item[fieldName]);
                    });
                    $('.employee .wrap-body-object-pay').append($('.employee .row-clone-search-employee').html());
                    $('.employee .wrap-body-object-pay .row-body-object-pay:last-child').data('EmployeeID', item["EmployeeID"]);
                });
                $('.employee .wrap-body-object-pay .row-body-object-pay:first-child').trigger('click');
            },
            error: function () {

            }
        });
    }
    //Hàm lấy dữ liệu cho bảng nhà cung cấp khi ấn vào tìm kiếm nhà cung cấp
    //Người tạo NVMANH 20/6/2019
    loadDataTableSearchSupplier() {
        $.ajax({
            method: 'GET',
            url: '/supplier',
            success: function (res) {
                $.each(res.Data, function (index, item) {
                    $('.object .row-clone-search-supplier span').each(function () {
                        let fieldName = $(this).attr("fieldName");
                        $(this).text(item[fieldName]);
                    });
                    //$('.object .row-clone-search-supplier').children().attr('key', item["supplierID"]);
                    $('.object .wrap-body-object-pay').append($('.object .row-clone-search-supplier').html());
                    $('.object .wrap-body-object-pay .row-body-object-pay:last-child').data('SupplierID', item["SupplierID"]);
                });
                $('.object .wrap-body-object-pay .row-body-object-pay:first-child').trigger('click');
            },
            error: function () {

            }
        });
    }
    //Lấy loại nhà cung cấp vào combo box
    //Người tạo NVMANH 8/7/2019
    loadDataSupplierType() {
        $.ajax({
            method: "GET",
            url: '/suppliertype',
            success: function (res) {
                $.each(res.Data, function (index, item) {
                    $('.clone-object-item a').text(item['SupplierTypeName']);
                    $('.wrap-select-object-pay .combobox-object-item').append($('.clone-object-item').html());
                    $('.wrap-select-object-pay .combobox-object-item a:last-child').data('SupplierTypeID', item["SupplierTypeID"]);
                });
            }
        });
    }
    //Load nhà cung cấp tương ứng với loại được chọn
    //Người tạo NVMANH 8/7/2019
    loadSupplierByType() {
        $('body').on('click', '.wrap-select-object-pay .combobox-object-item a', function () {
            $('.wrap-select-object-pay').find('input').val($(this).text());
            $('.object .wrap-body-object-pay').html('');
            $.ajax({
                method: 'GET',
                url: '/supplier/type/' + $(this).data('SupplierTypeID'),
                success: function (res) {
                    $.each(res.Data, function (index, item) {
                        $('.object .row-clone-search-supplier span').each(function () {
                            let fieldName = $(this).attr("fieldName");
                            $(this).text(item[fieldName]);
                        });
                        //$('.object .row-clone-search-supplier').children().attr('key', item["supplierID"]);
                        $('.object .wrap-body-object-pay').append($('.object .row-clone-search-supplier').html());
                        $('.object .wrap-body-object-pay .row-body-object-pay:last-child').data('SupplierID', item["SupplierID"]);
                    });
                    
                    $('.object .wrap-body-object-pay .row-body-object-pay:first-child').trigger('click');
                },
                error: function () {

                }
            });
        });
    }
    //Căn chỉnh lại cột khi có thanh cuộn
    //Người tạo NVMANH 9/7/2019
    resizeColhasScroll() {
        $(document).mouseover(function () {
            if ($('.wrap-body-object-pay').hasScrollBar()) {
                $('.js-width').css({
                    'width': 'calc(100% - 613px)'
                });
            } else {
                $('.js-width').css({
                    'width': 'calc(100% - 596px)'
                });
            }
        });
    }
    //Hàm lấy dữ liệu cho bảng khách hàng
    //Người tạo NVMANH 20/6/2019
    loadDataTableCustomer() {
        $.ajax({
            method: "GET",
            url: "/supplier",
            success: function (res) {
                $.each(res.Data, function (index, item) {
                    $('.row-clone-table-customer span').each(function () {
                        let fieldName = $(this).attr("fieldName");
                        $(this).text(item[fieldName]);
                    });
                    //$('.row-clone-table-customer').children().attr('key', item["CustomerID"]);
                    $('.wrap-table-customer-body').append($('.row-clone-table-customer').html());
                    $('.wrap-table-customer-body .row-table-customer:last-child').data('CustomerID', item["SupplierID"]);
                });
            },
            error: function () {

            }
        });
    }
    //Hàm lấy dữ liệu cho bảng nhà cung cấp
    //Người tạo NVMANH 25/6/2019
    loadDataTableSupplierDialog() {
        $.ajax({
            method: "GET",
            url: "/supplier",
            success: function (res) {
                debugger
                $.each(res.Data, function (index, item) {
                    $('.row-clone-table-supplier span').each(function () {
                        let fieldName = $(this).attr("fieldName");
                        $(this).text(item[fieldName]);
                    });
                    $('.wrap-table-supplier-body').append($('.row-clone-table-supplier').html());
                    $('.wrap-table-supplier-body .row-table-supplier:last-child').data('SupplierID', item["SupplierID"]);
                });
            },
            error: function () {

            }
        });
    }
    //Load tên nhà cung cấp khi nhấn vào bảng nhà cung cấp
    //Người tạo NVMANH 21/6/2019
    loadFillSupplier() {
        $('body').on('click', '.row-select-object', function () {
            $('#object-input-left').val($(this).find('.col-select-body-id span').text());
            $('#object-input-right').val($(this).find('.col-select-body-name span').text());
            $('#dialog-info-submitter-input').val($(this).find('.col-select-body-name span').text());
            $('#dialog-info-address-input').focus();
            $('#object-input-left').parent().css({
                'border':'1px solid #d0d0d0'
            });
        });
    }
    //Load tên nhà cung cấp khi nhấn vào bảng nhà cung cấp
    //Người tạo NVMANH 21/6/2019
    loadFillEmployee() {
        $('body').on('click', '.row-employee-object', function () {
            if ($('#radio1').is(":checked")) {
                $('.dialog-body-different [fieldname="EmployeeCode"]').val($(this).find('[fieldname="EmployeeCode"]').text());
                $('.dialog-body-different [fieldname="EmployeeName"]').val($(this).find('[fieldname="EmployeeName"]').text());
                datatable.employeeIDDifferent = $(this).data('EmployeeID');
            }
            if ($('#radio2').is(":checked")) {
                $('.dialog-body-debt [fieldname="EmployeeCode"]').val($(this).find('[fieldname="EmployeeCode"]').text());
                $('.dialog-body-debt [fieldname="EmployeeName"]').val($(this).find('[fieldname="EmployeeName"]').text());
                datatable.employeeIDDebt = $(this).data('EmployeeID');
                console.log(datatable.employeeIDDebt);
            }
            $(".table-detail-body .input-detail-1:first").focus();
            $('#employee-input-left').parent().css({
                'border': '1px solid #d0d0d0'
            });
        });
    }
    //Tải dữ liệu hóa đơn của khách hàng trong dialog chọn hóa đơn thu nợ
    //Người tạo NVMANH 22/6/2019 
    loadBillCollect(cus) {
        
        $.ajax({
            method: "GET",
            url: '/billcollect/' + cus,
            beforeSend: function () {
                $('.icon-loading-employee').show();
            },
            complete: function (data) {
                $('.icon-loading-employee').hide();
            }
        }).done(function (response) {
            var data = response.Data;
            $('.select-bill-collect .wrap-collect-table-body').html("");
            if (data.length === 0) {
                $('.select-bill-collect .wrap-collect-table-body').html("");
                $('.select-bill-collect .wrap-collect-table-body').html("<div class='water-mark'>Không có dữ liệu</div>");
                $('.col-table-footer-collected .wrap-text-footer-table').text("0");
                $('.col-table-footer-collect .wrap-text-footer-table').text("0");
            } else {
                var totalbillCollected = 0;
                var totalbillCollect = 0;
                $('.select-bill-pay .wrap-collect-table-body').html("");
                $.each(data, function (index, item) {
                    totalbillCollected += item['BillDebt'];
                    totalbillCollect += item['BillCollected'];
                    $(".select-bill-collect .row-clone-bill-collect span").each(function () {
                        let fieldName = $(this).attr("fieldName");
                        let fieldData = $(this).attr("fieldData");
                        if (fieldData === "Number") {
                            $(this).text(datatable.formatNumber(item[fieldName]));
                        } else if (fieldData === "Time") {
                            $(this).text(new Date(item[fieldName]).toLocaleDateString('en-GB'));
                        } else {
                            $(this).text(item[fieldName]);
                        }
                    });
                    $('.select-bill-collect .wrap-collect-table-body').append($('.row-clone-bill-collect').html());
                    $('.select-bill-collect .wrap-collect-table-body .row-collect-table-body:last-child').data('BillID', item["BillID"]);
                    //console.log($('.select-bill-collect .wrap-collect-table-body .row-collect-table-body:last-child').data('billID'));
                });
                //datatable.autoFillVoucher();
                $('.col-table-footer-collected .wrap-text-footer-table').text(datatable.formatNumber(totalbillCollected));
                $('.col-table-footer-collect .wrap-text-footer-table').text(datatable.formatNumber(totalbillCollect));
            }
        }).fail(function (response) {

        });
    }
    //Tải dữ liệu hóa đơn của nahf cung cấp trong dialog chọn hóa đơn trả nợ
    //Người tạo NVMANH 22/6/2019 
    loadBillPay(pay) {

        $.ajax({
            method: "GET",
            url: '/billpay/' + pay,
            beforeSend: function () {
                $('.icon-loading-employee').show();
            },
            complete: function (data) {
                $('.icon-loading-employee').hide();
            }
        }).done(function (response) {
            var data = response.Data;
            if (data.length === 0) {
                $('.select-bill-pay .wrap-collect-table-body').html("");
                $('.select-bill-pay .wrap-collect-table-body').html("<div class='water-mark'>Không có dữ liệu</div>");
                $('.col-table-footer-collected .wrap-text-footer-table').text("0");
                $('.col-table-footer-collect .wrap-text-footer-table').text("0");
            } else {
                $('.select-bill-pay .wrap-collect-table-body').html("");
                var totalbillCollected = 0;
                var totalbillCollect = 0;
                $.each(data, function (index, item) {
                    totalbillCollected += item['BillPayPaid'];
                    totalbillCollect += item['BillPayUnpaid'];
                    $(".select-bill-pay .row-clone-bill-pay span").each(function () {
                        let fieldName = $(this).attr("fieldName");
                        let fieldData = $(this).attr("fieldData");
                        if (fieldData === "Number") {
                            $(this).text(datatable.formatNumber(item[fieldName]));
                        } else if (fieldData === "Time") {
                            $(this).text(new Date(item[fieldName]).toLocaleDateString('en-GB'));
                        } else {
                            $(this).text(item[fieldName]);
                        }
                    });
                    $('.select-bill-pay .wrap-collect-table-body').append($('.row-clone-bill-pay').html());
                    $('.select-bill-pay .wrap-collect-table-body .row-pay-table-body:last-child').data('BillPayID', item["BillPayID"]);
                });
                $('.col-table-footer-collected .wrap-text-footer-table').text(datatable.formatNumber(totalbillCollected));
                $('.col-table-footer-collect .wrap-text-footer-table').text(datatable.formatNumber(totalbillCollect));
            }
        }).fail(function (response) {

        });
    }
    //Hàm xóa dữ liệu hàng trên bảng chính
    //Người tạo NVMANH 20/6/2019
    deleteFund() {
        var rowCurrent = $('.content-table-body .row-content-active');
        var listID = [];
        $.each(rowCurrent, function (index, item) {
            listID.push($(item).data('FundID'));
        });
        $.ajax({
            method: "DELETE",
            url: "/fund",
            data: JSON.stringify(listID),
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (response) {
                debugger
            },
            error: function () {
                alert("fail");
            }
        });
    }
    //Hàm tính tổng cho bang dữ liệu chính
    //Người tạo NVMANH 12/6/2019
    getTotal() {
        var total = 0;
        $.ajax({
            method: 'GET',
            url: '/fund'
        }).done(function (response) {
            $.each(response.Data, function (index, item) {
                total += item["FundMoney"];
            });
            $('#cell-total-money').text(datatable.formatNumber(total));
        }).fail(function (response) {

        });
    }

    //Hàm định dạng tiền tệ
    //Người tạo NVMANH 14/6/2019
    formatNumber(number) {
        return number.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1.');
    }
    //Hàm tự động điền input trong dialog
    //Người tạo NVMANH 20/6/2019
    autoFillDialog() {
        var currentVal;
        $('.wrap-dialog-body-info input').focus(function () {
            currentVal = $(this).val();
            $(this).focusout(function () {
                if ($(this).val() === "") {
                    $(this).val(currentVal);
                }
            });
        });
    }
    //Điền tên khách hàng khi click vào dòng
    //Người tạo NVMANH 20/6/2019
    autoFillNameCustomer() {
        $('body').on('click', '.wrap-table-customer-body .row-table-customer', function () {
            $('#collect-input-1').val($(this).find('.col-body-customer-name span').text());
            form.checkInputNameCustomer();
            datatable.supplierID = $(this).data('CustomerID');
        });
        $('body').on('click', '.select-bill-collect .wrap-dialog-get-data',function () {
            $('.wrap-collect-table-body').html("");
            $('#collect-input-3').val("0");
            $('.select-bill-collect .checked').removeClass('checked');
            datatable.loadBillCollect(datatable.supplierID);
        });
    }  
    //Điền tên nhà cung cấp khi click vào dòng
    //Người tạo NVMANH 20/6/2019
    autoFillNameSupplier() {
        var supplierID;
        $('body').on('click', '.wrap-table-supplier-body .row-table-supplier', function () {
            $('#collect-input-1').val($(this).find('.col-body-supplier-name span').text());
            form.checkInputNameCustomer();
            supplierID = $(this).data('SupplierID');
        });
        $('body').on('click', '.select-bill-pay .wrap-dialog-get-data',function () {
            $('.wrap-collect-table-body').html("");
            $('#collect-input-3').val("0");
            $('.select-bill-pay .checked').removeClass('checked');
            datatable.loadBillPay(supplierID);
        });
    } 
    //Hiện hông tin chứng từ khi nhấn vào trả nợ
    //Người tạo NVMANH 4/7/2019
    autoFillVoucher() {
        var voucherID = [];
        $('body').on('click', '.select-bill-collect .wrap-dialog-get-data', function () {
            //voucherID = $(this).data('billID');
            var rowVoucher = $('.select-bill-collect .row-collect-table-body .col-table-body-check.checked');
            $.each(rowVoucher, function (index, item) {
                voucherID.push($(item).parent().data('BillID'));
            });
            console.log(voucherID);
        });

    }
    //Thêm data cho dòng dữ liệu
    //Người tạo NVMANH 1/7/2019
    addData() {
        $('body').on('click', '.wrap-select-object-content .row-select-object', function () {
            datatable.supplierID = $(this).data('SupplierID');
        });
        //$('body').on('click', '.wrap-select-employee-content .row-employee-object', function () {
        //    datatable.employeeID = $(this).data('employeeID');
        //});
    }
    //Chuyển từ ngày js sang ngày c#
    //Người tạo NVMANH 1/7/2019
    convertStringJSToStringCsharp(datePicker) {
        let dateObject = $(datePicker).datepicker("getDate");
        let dateString = $.datepicker.formatDate("yy-mm-dd", dateObject);
        let dateCurrent = new Date();
        let fullDateString = dateString + dateCurrent.getFullTimeCurrent();
        return fullDateString;
    }
    //Chuyển từ chuối sang số
    //Người tạo NVMANh 1/7/2019
    convertStringJSToNumber(strNumber) {
        var removeDot = parseInt(strNumber.replace(/\./g, ''), 10);
        return removeDot;
    }
    //Kiểm tra ngày hợp lệ
    //Người tạo NVMANH 10/7/2019
    checkDate(input) {
        var d = new Date($(input).val());
        return d.isValid();
    }
}
//Khởi tạo đối tượng cho bảng dữ liệu   
//Người tạo NVMANH 12/9/2019
var datatable = new DataTableMain();