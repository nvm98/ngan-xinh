using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{

    //Lớp dữ liệu giả của trường
    public class Data
    {
        /// <summary>
        /// Dữ liệu nhân viên
        /// Người tạo NVMANH 12/6/2019
        /// </summary>
        public static List<Employee> ListEmployees = new List<Employee>
        {
            new Employee{employeeID=new Guid("c5ba309a-43ed-4b86-a829-e2c608d2421c"),employeeId="NV0001",employeeName="Đỗ Xuân Quang", SupplierTypeID= new Guid("fb386a41-caea-4c1f-b805-dc86d6c03e3f"), employeeAddress="Sóc Trăng",employeePhone="0976736328"},
            new Employee{employeeID=new Guid("c289d354-63a6-4c22-ba28-78dd3764aa40"),employeeId="NV0002",employeeName="Nguyễn Tiến Xuân",SupplierTypeID= new Guid("0add4b17-4327-4d69-8ad3-9c5f76ab912e"), employeeAddress="Thanh Hóa",employeePhone="0984298866"},
            new Employee{employeeID=new Guid("bd41a20f-580e-4c35-9061-7a1781fbb03c"),employeeId="NV0003",employeeName="Đào Văn Hùng",SupplierTypeID= new Guid("2bbedd0b-dbd8-4013-bc8e-ad0ac10071dc"), employeeAddress="Đà Nẵng",employeePhone="0912446579"},
            new Employee{employeeID=new Guid("8b8790b0-bc14-49c1-921d-9e4fdb9c6108"),employeeId="NV0004",employeeName="Nguyễn Bình Dương",SupplierTypeID= new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e"), employeeAddress="Cần Thơ",employeePhone="0396411888"},
            new Employee{employeeID=new Guid("082164b2-f728-41cc-a838-a9f37ffc4309"),employeeId="NV0005",employeeName="Nguyễn Văn Mạnh",SupplierTypeID= new Guid("0add4b17-4327-4d69-8ad3-9c5f76ab912e"), employeeAddress="Bắc Giang",employeePhone="0985021978"},
            new Employee{employeeID=new Guid("f6e457cc-f132-4aad-850d-0296ab3ee193"),employeeId="NV0006",employeeName="Nguyễn Văn Tùng",SupplierTypeID= new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e"), employeeAddress="Hải Dương",employeePhone="0979490666"},
            new Employee{employeeID=new Guid("3a89ea1d-80e8-4562-b561-fd9606c6d450"),employeeId="NV0007",employeeName="Nguyễn Thị Thu Ngân",SupplierTypeID= new Guid("fb386a41-caea-4c1f-b805-dc86d6c03e3f"), employeeAddress="Hòa Bình",employeePhone="0985299118"},
            new Employee{employeeID=new Guid("b284a0b7-24d9-4da0-82ab-495cfbfc0d60"),employeeId="NV0008",employeeName="Nghiêm Anh Tú",SupplierTypeID= new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e"), employeeAddress="Lâm Đồng",employeePhone="0975141782"},
            new Employee{employeeID=new Guid("9173d5c9-a4bc-41ff-a192-76fb3ed9db14"),employeeId="NV0009",employeeName="Đỗ Đức Dũng",SupplierTypeID= new Guid("2bbedd0b-dbd8-4013-bc8e-ad0ac10071dc"), employeeAddress="Ninh Bình",employeePhone="0777090484"},
            new Employee{employeeID=new Guid("55566ae7-058a-4ff2-bfe1-1cd233974034"),employeeId="NV0010",employeeName="Nguyễn Văn Hưng",SupplierTypeID= new Guid("2bbedd0b-dbd8-4013-bc8e-ad0ac10071dc"), employeeAddress="Bình Phước",employeePhone="0987315434"},
            new Employee{employeeID=new Guid("14832d5a-7500-4fcf-a547-0edca67d3a7c"),employeeId="NV0011",employeeName="Vũ Tiến Hùng",SupplierTypeID= new Guid("fb386a41-caea-4c1f-b805-dc86d6c03e3f"), employeeAddress="Phú Thọ",employeePhone="0777481619"},
            new Employee{employeeID=new Guid("8bf2e55b-6e83-4789-8ff8-5a5635858d94"),employeeId="NV0012",employeeName="Phạm Văn Ngọc",SupplierTypeID= new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e"), employeeAddress="Trà Vinh",employeePhone="0905123390"},
            new Employee{employeeID=new Guid("41d99cb9-9e0b-4f52-ad38-0b19cbdca4e4"),employeeId="NV0013",employeeName="Đinh Hà Phương",SupplierTypeID= new Guid("0add4b17-4327-4d69-8ad3-9c5f76ab912e"), employeeAddress="Vĩnh Phúc",employeePhone="0969926961"}
        };
        /// <summary>
        /// Dữ liệu về loại nhà cung cấp
        /// Người tạo NVMANH 25/6/2019
        /// </summary>
        public static List<SupplierType> ListSupplierType = new List<SupplierType>
        {
            new SupplierType{supplierTypeID=new Guid("fb386a41-caea-4c1f-b805-dc86d6c03e3f"), supplierTypeName="Nhà cung cấp"},
            new SupplierType{supplierTypeID=new Guid("0add4b17-4327-4d69-8ad3-9c5f76ab912e"), supplierTypeName="Khách hàng"},
            new SupplierType{supplierTypeID=new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e"), supplierTypeName="Đối tác giao hàng"},
            new SupplierType{supplierTypeID=new Guid("2bbedd0b-dbd8-4013-bc8e-ad0ac10071dc"), supplierTypeName="Nhân viên"}
        };
        /// <summary>
        /// Dữ liệu về chứng từ
        /// Người tạo NVMANH 12/6/2019
        /// </summary>
        public static List<Fund> ListFund = new List<Fund>()
        {
            new Fund{fundID = new Guid("7048972d-5308-4524-ba2d-64b19dd2ee2f"),fundDate = new DateTime(2019, 6, 6), fundNumberVoucher="PT0001", fundTypeVoucher="Phiếu trả lại hàng mua", fundMoney=17000, fundObject="Nhà máy hải phòng", fundReason="Trả lại hàng", employeeID=new Guid("082164b2-f728-41cc-a838-a9f37ffc4309"), supplierID=new Guid("e33eb276-7ee8-41cb-ab57-f1c02a6af3f9"), typeCheck = "1"},
            new Fund{fundID = new Guid("f52bf2c3-baeb-48f5-a5ff-f199e2babbf0"),fundDate = new DateTime(2019, 6, 24), fundNumberVoucher="PC0001", fundTypeVoucher="Phiếu thu tiền mặt", fundMoney=171000, fundObject="Nhà máy Thái Bình", fundReason="Thu nợ", employeeID=new Guid("55566ae7-058a-4ff2-bfe1-1cd233974034"), supplierID=new Guid("1912e8aa-1587-4285-97c5-6d31103e7c4b"), typeCheck = "2"},
            new Fund{fundID = new Guid("7ee76e2a-8079-48e2-8c0c-b1e62e710312"),fundDate = new DateTime(2019, 5, 12), fundNumberVoucher="PC0002", fundTypeVoucher="Phiếu thu nợ - tiền mặt", fundMoney=164000, fundObject="Nhà máy Thanh Thủy", fundReason="Thu nợ", employeeID=new Guid("8b8790b0-bc14-49c1-921d-9e4fdb9c6108"), supplierID=new Guid("2ee4396b-11e8-4e4a-9d07-5ed57b2d0156"), typeCheck = "2"},
            new Fund{fundID = new Guid("adae8cfa-34bf-4475-9897-a517d903586b"),fundDate = new DateTime(2019, 6, 26), fundNumberVoucher="PT0019", fundTypeVoucher="Phiếu nhập hàng - tiền mặt", fundMoney=44000, fundObject="Nhà máy Quảng Ngãi", fundReason="Thu nợ tiền hàng", employeeID=new Guid("8bf2e55b-6e83-4789-8ff8-5a5635858d94"), supplierID=new Guid("6296a0a1-46d6-4ad4-a7d8-b8facdd09552"), typeCheck = "1"},
            new Fund{fundID = new Guid("af73c9e8-7eed-4aed-a4ff-1138d0f5f55c"),fundDate = new DateTime(2019, 4, 12), fundNumberVoucher="PT0020", fundTypeVoucher="Phiếu thu tiền mặt", fundMoney=159000, fundObject="Nhà máy Quảng Ninh", fundReason="Thu tiền mặt", employeeID=new Guid("55566ae7-058a-4ff2-bfe1-1cd233974034"), supplierID=new Guid("afec236f-a5f6-49f7-953c-df5fc5b4b418"), typeCheck = "1"},
            new Fund{fundID = new Guid("5f11afc1-c880-4f9a-8567-8991defe3274"),fundDate = new DateTime(2019, 6, 26), fundNumberVoucher="PC0003", fundTypeVoucher="Phiếu trả lại hàng mua", fundMoney=111000, fundObject="Nhà máy Huế", fundReason="Trả lại tiền hàng", employeeID=new Guid("c5ba309a-43ed-4b86-a829-e2c608d2421c"), supplierID=new Guid("e33eb276-7ee8-41cb-ab57-f1c02a6af3f9"), typeCheck = "2"},
            new Fund{fundID = new Guid("e1d8df6d-8075-4c09-8166-d5c344f0125b"),fundDate = new DateTime(2019, 3, 14), fundNumberVoucher="PT0022", fundTypeVoucher="Phiếu trả nợ - tiền mặt", fundMoney=38000, fundObject="Nhà máy Hà Tĩnh", fundReason="Trả tiền mặt", employeeID=new Guid("082164b2-f728-41cc-a838-a9f37ffc4309"), supplierID=new Guid("f4c118d6-5aec-4133-9c6e-6b2ba05b5d74"), typeCheck = "1"},
            new Fund{fundID = new Guid("ab37c69f-b8ba-4245-b081-e5d6d776830c"),fundDate = new DateTime(2019, 6, 18), fundNumberVoucher="PC0004", fundTypeVoucher="Phiếu nhập hàng - tiền mặt", fundMoney=20000, fundObject="Nhà máy Thanh Hóa", fundReason="Trả nợ nhập hàng", employeeID=new Guid("c5ba309a-43ed-4b86-a829-e2c608d2421c"), supplierID=new Guid("1912e8aa-1587-4285-97c5-6d31103e7c4b"), typeCheck = "2"},
            new Fund{fundID = new Guid("c48b46a8-c4a0-4888-9336-ac0d3177fba6"),fundDate = new DateTime(2019, 2, 14), fundNumberVoucher="PT0004", fundTypeVoucher="Phiếu chi tiền mặt", fundMoney=209000, fundObject="Nhà máy Nam Định", fundReason="Chi tiền", employeeID=new Guid("c5ba309a-43ed-4b86-a829-e2c608d2421c"), supplierID=new Guid("6296a0a1-46d6-4ad4-a7d8-b8facdd09552"), typeCheck = "1"},
            new Fund{fundID = new Guid("2dd8178c-8e81-4bdb-b624-17fb0091fe2e"),fundDate = new DateTime(2019, 6, 12), fundNumberVoucher="PC0005", fundTypeVoucher="Phiếu trả lại hàng mua", fundMoney=178000, fundObject="Nhà máy Hưng Yên", fundReason="Trả lại hàng", employeeID=new Guid("082164b2-f728-41cc-a838-a9f37ffc4309"), supplierID=new Guid("f4c118d6-5aec-4133-9c6e-6b2ba05b5d74"), typeCheck = "2"},
            new Fund{fundID = new Guid("337e22d1-68be-48fe-908c-71599be58dd2"),fundDate = new DateTime(2019, 6, 12), fundNumberVoucher="PT0006", fundTypeVoucher="Phiếu nhập hàng - tiền mặt", fundMoney=85000, fundObject="Nhà máy Hà Nội", fundReason="Trả tiền hàng", employeeID=new Guid("3a89ea1d-80e8-4562-b561-fd9606c6d450"), supplierID=new Guid("e33eb276-7ee8-41cb-ab57-f1c02a6af3f9"), typeCheck = "1"},
            new Fund{fundID = new Guid("8121fa58-d1ad-4578-aa04-01bdc753ad57"),fundDate = new DateTime(2019, 6, 7), fundNumberVoucher="PC0006", fundTypeVoucher="Phiếu chi tiền mặt", fundMoney=180000, fundObject="Nhà máy Hồ Chí Minh", fundReason="Trả nợ", employeeID=new Guid("c5ba309a-43ed-4b86-a829-e2c608d2421c"), supplierID=new Guid("e33eb276-7ee8-41cb-ab57-f1c02a6af3f9"), typeCheck = "2"},
            new Fund{fundID = new Guid("6404275f-49f4-4888-a772-705b5fc287ba"),fundDate = new DateTime(2019, 6, 12), fundNumberVoucher="PT0008", fundTypeVoucher="Phiếu nhập hàng - tiền mặt", fundMoney=130000, fundObject="Nhà máy Đà Nẵng", fundReason="Nhập hàng", employeeID=new Guid("082164b2-f728-41cc-a838-a9f37ffc4309"), supplierID=new Guid("6296a0a1-46d6-4ad4-a7d8-b8facdd09552"), typeCheck = "1"},
            new Fund{fundID = new Guid("b71a83fc-22f7-44d2-90a8-a6f51529737d"),fundDate = new DateTime(2019, 6, 5), fundNumberVoucher="PC0007", fundTypeVoucher="Phiếu thu tiền mặt", fundMoney=179000, fundObject="Nhà máy Sơn La", fundReason="Thu tiền nợ", employeeID=new Guid("55566ae7-058a-4ff2-bfe1-1cd233974034"), supplierID=new Guid("1912e8aa-1587-4285-97c5-6d31103e7c4b"), typeCheck = "2"},
            new Fund{fundID = new Guid("e2ef4bf3-c0a5-4ff1-b234-da1d62b3c1e5"),fundDate = new DateTime(2019, 6, 12), fundNumberVoucher="PC0008", fundTypeVoucher="Phiếu thu nợ - tiền mặt", fundMoney=110000, fundObject="Nhà máy Hải Dương", fundReason="Thu nợ", employeeID=new Guid("8bf2e55b-6e83-4789-8ff8-5a5635858d94"), supplierID=new Guid("2ee4396b-11e8-4e4a-9d07-5ed57b2d0156"), typeCheck = "2"},
            new Fund{fundID = new Guid("e70029a5-4d63-4eae-b7cf-9abed19aa47e"),fundDate = new DateTime(2019, 3, 12), fundNumberVoucher="PT0011", fundTypeVoucher="Phiếu chi tiền mặt", fundMoney=90000, fundObject="Nhà máy Hà Nam", fundReason="Chi tiền", employeeID=new Guid("3a89ea1d-80e8-4562-b561-fd9606c6d450"), supplierID=new Guid("f4c118d6-5aec-4133-9c6e-6b2ba05b5d74"), typeCheck = "1"},
            new Fund{fundID = new Guid("2ce5df2d-461b-4ddc-9f00-7954c96abf64"),fundDate = new DateTime(2019, 6, 25), fundNumberVoucher="PT0012", fundTypeVoucher="Phiếu nhập hàng - tiền mặt", fundMoney=78000, fundObject="Nhà máy Nghệ An", fundReason="Trả nợ tiền hàng", employeeID=new Guid("c5ba309a-43ed-4b86-a829-e2c608d2421c"), supplierID=new Guid("21b0d044-36e5-4827-9d95-13346a08836b"), typeCheck = "1"},
            new Fund{fundID = new Guid("525406d5-41e5-49ec-b826-d6c886ae5f18"),fundDate = new DateTime(2019, 2, 12), fundNumberVoucher="PC0008", fundTypeVoucher="Phiếu trả nợ - tiền mặt", fundMoney=223000, fundObject="Nhà máy Cà Mau", fundReason="Chi trả nợ", employeeID=new Guid("c5ba309a-43ed-4b86-a829-e2c608d2421c"), supplierID=new Guid("afec236f-a5f6-49f7-953c-df5fc5b4b418"), typeCheck = "2"},
            new Fund{fundID = new Guid("c3b1b8bc-9d2a-4ace-9115-73e5b69977d5"),fundDate = new DateTime(2019, 6, 13), fundNumberVoucher="PT0014", fundTypeVoucher="Phiếu thu nợ - tiền mặt", fundMoney=75000, fundObject="Nhà máy Lào Cai", fundReason="Thu nợ", employeeID=new Guid("8b8790b0-bc14-49c1-921d-9e4fdb9c6108"), supplierID=new Guid("21b0d044-36e5-4827-9d95-13346a08836b"), typeCheck = "1"},
            new Fund{fundID = new Guid("002f194c-9541-4f56-b832-9332f0ed339c"),fundDate = new DateTime(2019, 6, 6), fundNumberVoucher="PT0024", fundTypeVoucher="Phiếu trả lại hàng mua", fundMoney=78000, fundObject="Nhà máy hải phòng", fundReason="Trả lại hàng", employeeID=new Guid("082164b2-f728-41cc-a838-a9f37ffc4309"), supplierID=new Guid("e33eb276-7ee8-41cb-ab57-f1c02a6af3f9"), typeCheck = "1"},
            new Fund{fundID = new Guid("c202cb43-cbb5-47fc-b68b-aaa50e213b36"),fundDate = new DateTime(2019, 1, 15), fundNumberVoucher="PT0015", fundTypeVoucher="Phiếu thu tiền mặt", fundMoney=147000, fundObject="Nhà máy Sài Gòn", fundReason="Thu tiền mặt", employeeID=new Guid("082164b2-f728-41cc-a838-a9f37ffc4309"), supplierID=new Guid("2ee4396b-11e8-4e4a-9d07-5ed57b2d0156"), typeCheck = "1"},
            new Fund{fundID = new Guid("ce8128f1-69e2-4ba3-ac74-343f29a78110"),fundDate = new DateTime(2019, 6, 14), fundNumberVoucher="PC0009", fundTypeVoucher="Phiếu thu tiền mặt", fundMoney=93000, fundObject="Nhà máy Nhà Trang", fundReason="Thu nợ", employeeID=new Guid("3a89ea1d-80e8-4562-b561-fd9606c6d450"), supplierID=new Guid("afec236f-a5f6-49f7-953c-df5fc5b4b418"), typeCheck = "2"},
            new Fund{fundID = new Guid("06fd951a-34b5-4ff0-9f50-defdcc101f4d"),fundDate = new DateTime(2019, 6, 27), fundNumberVoucher="PT0017", fundTypeVoucher="Phiếu trả nợ - tiền mặt", fundMoney=94000, fundObject="Nhà máy Mộc Châu", fundReason="Trả nợ hàng", employeeID=new Guid("8b8790b0-bc14-49c1-921d-9e4fdb9c6108"), supplierID=new Guid("21b0d044-36e5-4827-9d95-13346a08836b"), typeCheck = "1"},
            new Fund{fundID = new Guid("ad53303d-38a0-4f67-b3ed-b17e02ed1383"),fundDate = new DateTime(2019, 5, 12), fundNumberVoucher="PC0010", fundTypeVoucher="Phiếu thu nợ - tiền mặt", fundMoney=98000, fundObject="Nhà máy Bắn Ninh", fundReason="Trả lại hàng", employeeID=new Guid("8bf2e55b-6e83-4789-8ff8-5a5635858d94"), supplierID=new Guid("2ee4396b-11e8-4e4a-9d07-5ed57b2d0156"), typeCheck = "2"},
        };
        /// <summary>
        /// Dữ liệu về Nhà cung cấp
        /// Người tạo NVMANH 12/6/2019
        /// </summary>
        public static List<Supplier> ListSuppliers = new List<Supplier>
        {
            new Supplier{supplierID=new Guid("b1dd1ccd-bc98-4e1e-ba2c-e6eae99f1e1d"),supplierId="NCC0001",supplierName="Nguyễn Thúy An",supplierAddress="Hà Nội", supplierTypeID=new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e")},
            new Supplier{supplierID=new Guid("c1ba81ac-1869-416c-8e7a-e0982b74ddef"),supplierId="NCC0002",supplierName="Nguyễn Diệp Chi",supplierAddress="TP Hồ Chí Minh", supplierTypeID=new Guid("2bbedd0b-dbd8-4013-bc8e-ad0ac10071dc")},
            new Supplier{supplierID=new Guid("f205e5ee-8f58-44ce-a68c-c69b19b66d90"),supplierId="NCC0003",supplierName="Nguyễn Trúc Quỳnh",supplierAddress="Thái Bình", supplierTypeID=new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e")},
            new Supplier{supplierID=new Guid("e33eb276-7ee8-41cb-ab57-f1c02a6af3f9"),supplierId="NCC0004",supplierName="Nguyễn Bình Dương",supplierAddress="Hà Nam", supplierTypeID=new Guid("fb386a41-caea-4c1f-b805-dc86d6c03e3f")},
            new Supplier{supplierID=new Guid("1912e8aa-1587-4285-97c5-6d31103e7c4b"),supplierId="NCC0005",supplierName="Nguyễn Văn Mạnh",supplierAddress="Hưng Yên", supplierTypeID=new Guid("0add4b17-4327-4d69-8ad3-9c5f76ab912e")},
            new Supplier{supplierID=new Guid("f4c118d6-5aec-4133-9c6e-6b2ba05b5d74"),supplierId="NCC0006",supplierName="Nguyễn Văn Tùng",supplierAddress="Hà Nội", supplierTypeID=new Guid("fb386a41-caea-4c1f-b805-dc86d6c03e3f")},
            new Supplier{supplierID=new Guid("6296a0a1-46d6-4ad4-a7d8-b8facdd09552"),supplierId="NCC0007",supplierName="Nguyễn Thị Thu Ngân",supplierAddress="Cao Bằng", supplierTypeID=new Guid("0add4b17-4327-4d69-8ad3-9c5f76ab912e")},
            new Supplier{supplierID=new Guid("afec236f-a5f6-49f7-953c-df5fc5b4b418"),supplierId="NCC0008",supplierName="Nghiêm Anh Tú",supplierAddress="Hải Phòng", supplierTypeID=new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e")},
            new Supplier{supplierID=new Guid("5e1880d2-d114-4e45-8b46-7c59c02c6ebd"),supplierId="NCC0009",supplierName="Đỗ Đức Dũng",supplierAddress="Nghệ An", supplierTypeID=new Guid("2bbedd0b-dbd8-4013-bc8e-ad0ac10071dc")},
            new Supplier{supplierID=new Guid("41530dfd-0fe0-4b1e-b0b2-a6302f427fdf"),supplierId="NCC0010",supplierName="Nguyễn Kim Ngân",supplierAddress="Cà Mau", supplierTypeID=new Guid("0add4b17-4327-4d69-8ad3-9c5f76ab912e")},
            new Supplier{supplierID=new Guid("21b0d044-36e5-4827-9d95-13346a08836b"),supplierId="NCC0011",supplierName="Nguyễn Ngọc Thanh",supplierAddress="Lào Cai", supplierTypeID=new Guid("fb386a41-caea-4c1f-b805-dc86d6c03e3f")},
            new Supplier{supplierID=new Guid("2ee4396b-11e8-4e4a-9d07-5ed57b2d0156"),supplierId="NCC0012",supplierName="Nguyễn Minh Khôi",supplierAddress="Sơn La", supplierTypeID=new Guid("ab1f1f03-4cfc-4c46-8c79-8636ef21cd8e")},
            new Supplier{supplierID=new Guid("0b9781f1-ce92-4088-b991-b2ab714f781a"),supplierId="NCC0013",supplierName="Nguyễn Minh Khang",supplierAddress="Mộc Châu", supplierTypeID=new Guid("2bbedd0b-dbd8-4013-bc8e-ad0ac10071dc")}
        };
        /// <summary>
        /// Dữ liệu về khách hàng
        /// Người tạo NVMANH 25/6/2019
        /// </summary>
        //public static List<Customer> ListCustomers = new List<Customer>
        //{
        //    new Customer{ CustomerID = new Guid("b9b0a76d-a86a-4a5c-9620-e3b9b52f1b57"),CustomerId="KH0001",CustomerName="Bùi Kim Quyên", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("e962688c-e348-45eb-954b-bd885562582e"),CustomerId="KH0002",CustomerName="Võ An Phước Thiện", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("cbebbd89-fa92-4680-b471-4abc3377b598"),CustomerId="KH0003",CustomerName="Phan Vinh Bính", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("c86d57b3-5500-4fb2-bfb9-2060e04d64e4"),CustomerId="KH0004",CustomerName="Nguyễn Vân Anh", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("530d389d-66d9-4309-a08b-d8d456160325"),CustomerId="KH0005",CustomerName="Lê Minh Vương", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("f3b78431-abbe-41b8-9b21-575954215e65"),CustomerId="KH0006",CustomerName="Trương Gia Mẫn", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("56e02745-4e09-45d3-836f-20b7f299f22b"),CustomerId="KH0007",CustomerName="Châu Thị Kim Anh", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("dd57697e-685f-416b-ae5d-3efcc308d984"),CustomerId="KH0008",CustomerName="Đỗ Đức Dũng", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("dac3b2a9-b7d4-4d03-a267-e04d303e49ae"),CustomerId="KH0009",CustomerName="Trần Viết Phúc", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("70435dcb-9a05-49e2-b984-6e7c84b0dc6d"),CustomerId="KH0010",CustomerName="Trần Thu Thùy", CustomerType="Khách hàng"},
        //    new Customer{ CustomerID = new Guid("cb04d154-d61c-4d2b-8464-1bf5b418d679"),CustomerId="KH0011",CustomerName="Nguyễn Thị Dung", CustomerType="Khách hàng"},
        //};
        /// <summary>
        /// Dữ liệu về hóa đơn thu nợ
        /// Người tạo NVMANH 25/6/2019
        /// </summary>
        public static List<BillCollect> ListBillCollects = new List<BillCollect>
        {
            new BillCollect{ billID = new Guid("fd9ece37-056e-44d3-ab0f-11551a2f3b3f"), billDate= new DateTime(2019, 2, 14), billNumber="HD0001", billDebt=100000, billCollected=50000, supplierID = new Guid("b1dd1ccd-bc98-4e1e-ba2c-e6eae99f1e1d")},
            new BillCollect{ billID = new Guid("a2ab26f4-809f-4741-840f-7991d22a0e04"), billDate= new DateTime(2019, 3, 23), billNumber="HD0002", billDebt=104005, billCollected=45000, supplierID = new Guid("c1ba81ac-1869-416c-8e7a-e0982b74ddef")},
            new BillCollect{ billID = new Guid("4d3eae31-427f-4287-a47a-23c11f434f20"), billDate= new DateTime(2019, 5, 27), billNumber="HD0003", billDebt=300000, billCollected=67000, supplierID = new Guid("6296a0a1-46d6-4ad4-a7d8-b8facdd09552")},
            new BillCollect{ billID = new Guid("d3ae4e58-63f7-4198-a39b-249369709248"), billDate= new DateTime(2019, 1, 24), billNumber="HD0004", billDebt=106700, billCollected=24000, supplierID = new Guid("c1ba81ac-1869-416c-8e7a-e0982b74ddef")},
            new BillCollect{ billID = new Guid("660298fe-0822-4896-8504-835f2e1c0743"), billDate= new DateTime(2019, 3, 4), billNumber="HD0005", billDebt=102300, billCollected=55300, supplierID = new Guid("2ee4396b-11e8-4e4a-9d07-5ed57b2d0156")},
            new BillCollect{ billID = new Guid("b4a63308-c1fa-43bf-8681-a465ec8618b6"), billDate= new DateTime(2019, 4, 6), billNumber="HD0006", billDebt=230000, billCollected=88000, supplierID = new Guid("2ee4396b-11e8-4e4a-9d07-5ed57b2d0156")},
            new BillCollect{ billID = new Guid("2af6a24b-4a05-4fb4-b3f9-868b31b55982"), billDate= new DateTime(2019, 2, 9), billNumber="HD0007", billDebt=670000, billCollected=44000, supplierID = new Guid("1912e8aa-1587-4285-97c5-6d31103e7c4b")},
            new BillCollect{ billID = new Guid("660798e9-6ca8-4586-8770-5f146384d52b"), billDate= new DateTime(2019, 6, 15), billNumber="HD0008", billDebt=740000, billCollected=23000, supplierID = new Guid("41530dfd-0fe0-4b1e-b0b2-a6302f427fdf")},
            new BillCollect{ billID = new Guid("aa3ac443-88c4-48e4-9108-8a03103cea07"), billDate= new DateTime(2019, 2, 19), billNumber="HD0009", billDebt=900000, billCollected=42000, supplierID = new Guid("f205e5ee-8f58-44ce-a68c-c69b19b66d90")},
            new BillCollect{ billID = new Guid("b81c4571-fa5f-4c81-8f6a-8599016e8574"), billDate= new DateTime(2019, 3, 23), billNumber="HD0011", billDebt=250000, billCollected=85000, supplierID = new Guid("2ee4396b-11e8-4e4a-9d07-5ed57b2d0156")},
            new BillCollect{ billID = new Guid("66c6fdae-4d10-4182-9bab-c6e3bc245949"), billDate= new DateTime(2019, 3, 11), billNumber="HD0012", billDebt=540000, billCollected=53200, supplierID = new Guid("6296a0a1-46d6-4ad4-a7d8-b8facdd09552")},
            new BillCollect{ billID = new Guid("57074860-f4c8-43f2-b5e6-394c824ec768"), billDate= new DateTime(2019, 4, 10), billNumber="HD0013", billDebt=510000, billCollected=32000, supplierID = new Guid("41530dfd-0fe0-4b1e-b0b2-a6302f427fdf")},
            new BillCollect{ billID = new Guid("1fe97b0b-3e55-4bf1-924b-9ff5b704c9e8"), billDate= new DateTime(2019, 1, 25), billNumber="HD0014", billDebt=143000, billCollected=65000, supplierID = new Guid("5e1880d2-d114-4e45-8b46-7c59c02c6ebd")},
            new BillCollect{ billID = new Guid("ebe8711a-fad8-4b26-9ca0-82a45272d4d8"), billDate= new DateTime(2019, 6, 12), billNumber="HD0015", billDebt=189000, billCollected=34000, supplierID = new Guid("41530dfd-0fe0-4b1e-b0b2-a6302f427fdf")},
            new BillCollect{ billID = new Guid("4bdd3f96-4579-4bba-824a-d1cb50f9666b"), billDate= new DateTime(2019, 5, 17), billNumber="HD0016", billDebt=420000, billCollected=12000, supplierID = new Guid("c1ba81ac-1869-416c-8e7a-e0982b74ddef")},
            new BillCollect{ billID = new Guid("ba7121b6-cd51-4fc7-a992-748bc9ea2b5e"), billDate= new DateTime(2019, 5, 19), billNumber="HD0017", billDebt=980000, billCollected=67000, supplierID = new Guid("0b9781f1-ce92-4088-b991-b2ab714f781a")},
            new BillCollect{ billID = new Guid("5019c9d2-6585-4979-ba84-054361e28788"), billDate= new DateTime(2019, 1, 22), billNumber="HD0018", billDebt=820000, billCollected=98000, supplierID = new Guid("41530dfd-0fe0-4b1e-b0b2-a6302f427fdf")},
            new BillCollect{ billID = new Guid("538b4acb-d242-4f5f-8867-cf4087b29cf3"), billDate= new DateTime(2019, 2, 21), billNumber="HD0019", billDebt=680000, billCollected=32000, supplierID = new Guid("1912e8aa-1587-4285-97c5-6d31103e7c4b")},
            new BillCollect{ billID = new Guid("a5d80a48-74f9-4f3b-82f7-0e8a1a2aa0b4"), billDate= new DateTime(2019, 1, 23), billNumber="HD0020", billDebt=550000, billCollected=96000, supplierID = new Guid("41530dfd-0fe0-4b1e-b0b2-a6302f427fdf")},
            new BillCollect{ billID = new Guid("0d8dfaec-d5a6-4837-a5f8-46e64a25f8cc"), billDate= new DateTime(2019, 4, 11), billNumber="HD0021", billDebt=470000, billCollected=75000, supplierID = new Guid("0b9781f1-ce92-4088-b991-b2ab714f781a")},
            new BillCollect{ billID = new Guid("46c722b4-7e83-4579-97b6-a9552ee77af0"), billDate= new DateTime(2019, 3, 13), billNumber="HD0022", billDebt=420000, billCollected=24000, supplierID = new Guid("c1ba81ac-1869-416c-8e7a-e0982b74ddef")},
            new BillCollect{ billID = new Guid("b6c79a04-1344-48b9-9726-0dbc6d03f1b1"), billDate= new DateTime(2019, 4, 23), billNumber="HD0023", billDebt=730000, billCollected=54000, supplierID = new Guid("5e1880d2-d114-4e45-8b46-7c59c02c6ebd")},
            new BillCollect{ billID = new Guid("da0a5777-83a2-4564-bf61-7ab26b6ef2a3"), billDate= new DateTime(2019, 5, 30), billNumber="HD0024", billDebt=270000, billCollected=96000, supplierID = new Guid("6296a0a1-46d6-4ad4-a7d8-b8facdd09552")},
            new BillCollect{ billID = new Guid("2cae2bca-ff4c-4d5b-8324-6c9475eca2f3"), billDate= new DateTime(2019, 5, 26), billNumber="HD0025", billDebt=370000, billCollected=84000, supplierID = new Guid("41530dfd-0fe0-4b1e-b0b2-a6302f427fdf")},
            new BillCollect{ billID = new Guid("5b839008-a1a3-4943-88b6-50eef2f3aaba"), billDate= new DateTime(2019, 6, 16), billNumber="HD0026", billDebt=850000, billCollected=42000, supplierID = new Guid("1912e8aa-1587-4285-97c5-6d31103e7c4b")},
            new BillCollect{ billID = new Guid("df2db1fc-878e-4e5e-8116-55ba4abc7e45"), billDate= new DateTime(2019, 1, 7), billNumber="HD0027", billDebt=580000, billCollected=76000, supplierID = new Guid("f205e5ee-8f58-44ce-a68c-c69b19b66d90")},
        };
        /// <summary>
        /// dữ liệu về hóa đơn trả nợ
        /// Người tạo NVMANH 25/6/2019
        /// </summary>
        public static List<BillPay> ListBillPays = new List<BillPay>
        {
            new BillPay{ billPayID = new Guid("acc8a8fb-e27f-45b3-8d39-fd25ae7bc1dd"), billPayDate = new DateTime(2019, 2, 22), billPayNumber="PA0001", billPayPaid = 100000, billPayUnpaid = 23000, supplierID = new Guid("b1dd1ccd-bc98-4e1e-ba2c-e6eae99f1e1d")},
            new BillPay{ billPayID = new Guid("7ffa52a8-5268-4e2c-9bdd-68da32f8851c"), billPayDate = new DateTime(2019, 4, 25), billPayNumber="PA0002", billPayPaid = 230000, billPayUnpaid = 53000, supplierID = new Guid("0b9781f1-ce92-4088-b991-b2ab714f781a")},
            new BillPay{ billPayID = new Guid("34a1b07c-9abf-4be0-814b-52a4c528048c"), billPayDate = new DateTime(2019, 6, 12), billPayNumber="PA0003", billPayPaid = 560000, billPayUnpaid = 86000, supplierID = new Guid("21b0d044-36e5-4827-9d95-13346a08836b")},
            new BillPay{ billPayID = new Guid("7755ba2d-0c42-429b-9d9b-f29d456a3187"), billPayDate = new DateTime(2019, 2, 14), billPayNumber="PA0004", billPayPaid = 980000, billPayUnpaid = 43000, supplierID = new Guid("c86d57b3-5500-4fb2-bfb9-2060e04d64e4")},
            new BillPay{ billPayID = new Guid("869f25fa-ddde-48d9-8f0c-e4b8465c7330"), billPayDate = new DateTime(2019, 1, 16), billPayNumber="PA0005", billPayPaid = 340000, billPayUnpaid = 84000, supplierID = new Guid("c86d57b3-5500-4fb2-bfb9-2060e04d64e4")},
            new BillPay{ billPayID = new Guid("450a5af7-d1b9-43ea-8ad7-593c64255718"), billPayDate = new DateTime(2019, 1, 27), billPayNumber="PA0006", billPayPaid = 120000, billPayUnpaid = 83000, supplierID = new Guid("21b0d044-36e5-4827-9d95-13346a08836b")},
            new BillPay{ billPayID = new Guid("f5b9d3f5-5704-4eb9-b400-43df8d669f1a"), billPayDate = new DateTime(2019, 3, 2), billPayNumber="PA0007", billPayPaid = 630000, billPayUnpaid = 55000, supplierID = new Guid("0b9781f1-ce92-4088-b991-b2ab714f781a")},
            new BillPay{ billPayID = new Guid("e20c8570-f7d2-4c4d-a337-9a2dedf0e19e"), billPayDate = new DateTime(2019, 4, 6), billPayNumber="PA0008", billPayPaid = 840000, billPayUnpaid = 22000, supplierID = new Guid("c86d57b3-5500-4fb2-bfb9-2060e04d64e4")},
            new BillPay{ billPayID = new Guid("7bc0ad74-4978-4baa-bf68-3fe6eb2134f3"), billPayDate = new DateTime(2019, 5, 9), billPayNumber="PA0009", billPayPaid = 750000, billPayUnpaid = 56000, supplierID = new Guid("21b0d044-36e5-4827-9d95-13346a08836b")},
            new BillPay{ billPayID = new Guid("b6b8f2af-04d8-422b-9557-27e8e52cdba7"), billPayDate = new DateTime(2019, 2, 24), billPayNumber="PA0010", billPayPaid = 330000, billPayUnpaid = 32000, supplierID = new Guid("530d389d-66d9-4309-a08b-d8d456160325")},
            new BillPay{ billPayID = new Guid("cd13991d-0173-43e2-8865-b50b9cd339e5"), billPayDate = new DateTime(2019, 1, 16), billPayNumber="PA0011", billPayPaid = 870000, billPayUnpaid = 86000, supplierID = new Guid("b1dd1ccd-bc98-4e1e-ba2c-e6eae99f1e1d")},
            new BillPay{ billPayID = new Guid("7fdaba68-aec0-4ca9-999a-5b3d20022107"), billPayDate = new DateTime(2019, 4, 17), billPayNumber="PA0012", billPayPaid = 990000, billPayUnpaid = 36000, supplierID = new Guid("0b9781f1-ce92-4088-b991-b2ab714f781a")},
            new BillPay{ billPayID = new Guid("6b00c56d-d866-43f2-be07-73e1a0c5b687"), billPayDate = new DateTime(2019, 3, 15), billPayNumber="PA0013", billPayPaid = 360000, billPayUnpaid = 74000, supplierID = new Guid("c1ba81ac-1869-416c-8e7a-e0982b74ddef")},
            new BillPay{ billPayID = new Guid("e72bccbe-a0b7-4b39-bacc-907f76f71ed2"), billPayDate = new DateTime(2019, 5, 14), billPayNumber="PA0014", billPayPaid = 760000, billPayUnpaid = 86000, supplierID = new Guid("21b0d044-36e5-4827-9d95-13346a08836b")},
            new BillPay{ billPayID = new Guid("94837ad4-f5cc-45fe-bade-f653ec06ba74"), billPayDate = new DateTime(2019, 1, 23), billPayNumber="PA0015", billPayPaid = 250000, billPayUnpaid = 36000, supplierID = new Guid("c1ba81ac-1869-416c-8e7a-e0982b74ddef")},
            new BillPay{ billPayID = new Guid("cef6a33a-a715-422a-88fc-33009f639eaf"), billPayDate = new DateTime(2019, 6, 28), billPayNumber="PA0016", billPayPaid = 470000, billPayUnpaid = 84000, supplierID = new Guid("530d389d-66d9-4309-a08b-d8d456160325")},
            new BillPay{ billPayID = new Guid("4c3a00b7-6d6e-4e6a-b1b8-3698661b07e9"), billPayDate = new DateTime(2019, 1, 17), billPayNumber="PA0017", billPayPaid = 270000, billPayUnpaid = 89000, supplierID = new Guid("21b0d044-36e5-4827-9d95-13346a08836b")},
            new BillPay{ billPayID = new Guid("ecf98bad-c0d0-498d-8110-beda48915e9c"), billPayDate = new DateTime(2019, 2, 16), billPayNumber="PA0018", billPayPaid = 850000, billPayUnpaid = 37000, supplierID = new Guid("0b9781f1-ce92-4088-b991-b2ab714f781a")},
            new BillPay{ billPayID = new Guid("66ad6717-b861-49ca-9d5f-4818435fdebd"), billPayDate = new DateTime(2019, 4, 29), billPayNumber="PA0019", billPayPaid = 350000, billPayUnpaid = 88000, supplierID = new Guid("c1ba81ac-1869-416c-8e7a-e0982b74ddef")}
        };
        /// <summary>
        /// Dữ liệu về chi tiết hóa đơn
        /// Người tạo NVMANH 8/7/2019
        /// </summary>
        public static List<FundDetail> ListFundDetails = new List<FundDetail>
        {
            new FundDetail{ fundDetailID = new Guid("36cf6993-5c09-450b-a80d-2681d713479e"), fundReason="Thu nợ hàng", fundMoney=10000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("f52bf2c3-baeb-48f5-a5ff-f199e2babbf0")},
            new FundDetail{ fundDetailID = new Guid("cfc1291f-dd54-428f-81b6-851adec0a97d"), fundReason="Thu chuyển khoản", fundMoney=56000, fundTypeVoucher="Thu khác", fundID = new Guid("b71a83fc-22f7-44d2-90a8-a6f51529737d")},
            new FundDetail{ fundDetailID = new Guid("d7e702f8-c45f-4747-926c-fec13678f1d7"), fundReason="Thu chuyển khoản", fundMoney=78000, fundTypeVoucher="Thu khác", fundID = new Guid("2ce5df2d-461b-4ddc-9f00-7954c96abf64")},
            new FundDetail{ fundDetailID = new Guid("93759392-4c2b-4c3f-9c77-0a45f649e56b"), fundReason="Thu nợ hàng", fundMoney=44000, fundTypeVoucher="Thu thanh lý tài sản", fundID = new Guid("adae8cfa-34bf-4475-9897-a517d903586b")},
            new FundDetail{ fundDetailID = new Guid("1ceba747-c423-4e45-a7a0-99210f0603e1"), fundReason="Thu chuyển khoản", fundMoney=20000, fundTypeVoucher="Thu khác", fundID = new Guid("ab37c69f-b8ba-4245-b081-e5d6d776830c")},
            new FundDetail{ fundDetailID = new Guid("b6e46bd2-c815-44a8-abcd-a40bd771498e"), fundReason="Thu đặ cọc", fundMoney=56000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("002f194c-9541-4f56-b832-9332f0ed339c")},
            new FundDetail{ fundDetailID = new Guid("afc6526e-cbf5-4798-b1c4-c3226cb8a491"), fundReason="Thu tiền mặt", fundMoney=87000, fundTypeVoucher="Thu thanh lý tài sản", fundID = new Guid("c48b46a8-c4a0-4888-9336-ac0d3177fba6")},
            new FundDetail{ fundDetailID = new Guid("19b6e653-01f8-4c20-9e74-103d4ddb58a6"), fundReason="Thu đặ cọc", fundMoney=22000, fundTypeVoucher="Thu khác", fundID = new Guid("002f194c-9541-4f56-b832-9332f0ed339c")},
            new FundDetail{ fundDetailID = new Guid("f9f5173b-7f87-4524-b4f6-6de4582c85e7"), fundReason="Thu tiền mặt", fundMoney=99000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("c48b46a8-c4a0-4888-9336-ac0d3177fba6")},
            new FundDetail{ fundDetailID = new Guid("5b327c93-93d8-4ae7-9676-a1d2c0a8f17f"), fundReason="Thu đặ cọc", fundMoney=74000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("f52bf2c3-baeb-48f5-a5ff-f199e2babbf0")},
            new FundDetail{ fundDetailID = new Guid("fcd4e849-342a-49a5-9bbe-87acfb606482"), fundReason="Thu tiền mặt", fundMoney=86000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("525406d5-41e5-49ec-b826-d6c886ae5f18")},
            new FundDetail{ fundDetailID = new Guid("207ec3f7-afe5-4790-8611-d9359ec6c204"), fundReason="Thu đặ cọc", fundMoney=37000, fundTypeVoucher="Thu khác", fundID = new Guid("e70029a5-4d63-4eae-b7cf-9abed19aa47e")},
            new FundDetail{ fundDetailID = new Guid("8f53ac27-cb8a-43c3-a4df-98fd9212e6b6"), fundReason="Thu nợ hàng", fundMoney=38000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("e1d8df6d-8075-4c09-8166-d5c344f0125b")},
            new FundDetail{ fundDetailID = new Guid("831b048b-abea-4e87-a590-52fb68f3ed0b"), fundReason="Thu đặ cọc", fundMoney=93000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("ce8128f1-69e2-4ba3-ac74-343f29a78110")},
            new FundDetail{ fundDetailID = new Guid("a3543a5f-a5d3-4123-a448-bd8c456702bd"), fundReason="Thu đặ cọc", fundMoney=74000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("7ee76e2a-8079-48e2-8c0c-b1e62e710312")},
            new FundDetail{ fundDetailID = new Guid("84b6cdc5-1208-4fca-bb29-4ddb4e5a07ff"), fundReason="Thu đặ cọc", fundMoney=65000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("8121fa58-d1ad-4578-aa04-01bdc753ad57")},
            new FundDetail{ fundDetailID = new Guid("10ceb785-4554-41e8-8f58-bf0f7b9e2e2d"), fundReason="Thu chuyển khoản", fundMoney=66000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("6404275f-49f4-4888-a772-705b5fc287ba")},
            new FundDetail{ fundDetailID = new Guid("5a5315ab-99d8-47c9-a713-4c5e175651ca"), fundReason="Thu tiền mặt", fundMoney=83000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("c202cb43-cbb5-47fc-b68b-aaa50e213b36")},
            new FundDetail{ fundDetailID = new Guid("0b87cdce-6eb7-49e7-a431-ff781b79d86b"), fundReason="Thu đặ cọc", fundMoney=83000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("525406d5-41e5-49ec-b826-d6c886ae5f18")},
            new FundDetail{ fundDetailID = new Guid("070a5152-afd2-459c-8db4-edd62573e82c"), fundReason="Thu tiền mặt", fundMoney=17000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("7048972d-5308-4524-ba2d-64b19dd2ee2f")},
            new FundDetail{ fundDetailID = new Guid("c5244e40-1498-46e5-bd47-9bfefe1ae764"), fundReason="Thu đặ cọc", fundMoney=28000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("8121fa58-d1ad-4578-aa04-01bdc753ad57")},
            new FundDetail{ fundDetailID = new Guid("d6fe5fa5-3487-4a7c-b5f5-910323a5fcc9"), fundReason="Thu tiền mặt", fundMoney=85000, fundTypeVoucher="Thu khác", fundID = new Guid("337e22d1-68be-48fe-908c-71599be58dd2")},
            new FundDetail{ fundDetailID = new Guid("bfe058c9-d213-4c5b-b4be-aa6d2e9ce983"), fundReason="Thu đặ cọc", fundMoney=55000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("2dd8178c-8e81-4bdb-b624-17fb0091fe2e")},
            new FundDetail{ fundDetailID = new Guid("1a099835-ae91-4ccc-b5cc-c566474036cf"), fundReason="Thu đặ cọc", fundMoney=77000, fundTypeVoucher="Thu thanh lý tài sản", fundID = new Guid("b71a83fc-22f7-44d2-90a8-a6f51529737d")},
            new FundDetail{ fundDetailID = new Guid("ccdad2f6-7f75-4aaa-92d4-9eb3a343502b"), fundReason="Thu nợ hàng", fundMoney=84000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("e2ef4bf3-c0a5-4ff1-b234-da1d62b3c1e5")},
            new FundDetail{ fundDetailID = new Guid("54014365-56cb-4483-bf5d-ad9b5bb10e4c"), fundReason="Thu đặ cọc", fundMoney=73000, fundTypeVoucher="Thu khác", fundID = new Guid("2dd8178c-8e81-4bdb-b624-17fb0091fe2e")},
            new FundDetail{ fundDetailID = new Guid("aa23e2c6-8d35-4f59-b505-caeb7626aae3"), fundReason="Thu đặ cọc", fundMoney=90000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("7ee76e2a-8079-48e2-8c0c-b1e62e710312")},
            new FundDetail{ fundDetailID = new Guid("8f9d1104-d31d-4754-bf9f-6501993a4a24"), fundReason="Thu chuyển khoản", fundMoney=37000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("c202cb43-cbb5-47fc-b68b-aaa50e213b36")},
            new FundDetail{ fundDetailID = new Guid("e5de732b-f09b-4e62-9eb4-695c1ecd214c"), fundReason="Thu nợ hàng", fundMoney=64000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("6404275f-49f4-4888-a772-705b5fc287ba")},
            new FundDetail{ fundDetailID = new Guid("0d57ca9e-45f7-4f5c-8814-6259f49b77b7"), fundReason="Thu chuyển khoản", fundMoney=53000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("e70029a5-4d63-4eae-b7cf-9abed19aa47e")},
            new FundDetail{ fundDetailID = new Guid("4a700ab1-4ff5-42da-a977-c59dfe086b59"), fundReason="Thu tiền mặt", fundMoney=49000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("5f11afc1-c880-4f9a-8567-8991defe3274")},
            new FundDetail{ fundDetailID = new Guid("765fce94-2d07-4fdd-a38d-8299ece42773"), fundReason="Thu đặ cọc", fundMoney=22000, fundTypeVoucher="Thu thanh lý tài sản", fundID = new Guid("2dd8178c-8e81-4bdb-b624-17fb0091fe2e")},
            new FundDetail{ fundDetailID = new Guid("14692545-cb39-4bc4-90e6-134dd71ee91d"), fundReason="Thu tiền mặt", fundMoney=62000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("5f11afc1-c880-4f9a-8567-8991defe3274")},
            new FundDetail{ fundDetailID = new Guid("9b1ffc4d-1380-4182-a4d8-27c5b8f79fa8"), fundReason="Thu đặ cọc", fundMoney=75000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("ad53303d-38a0-4f67-b3ed-b17e02ed1383")},
            new FundDetail{ fundDetailID = new Guid("25d0943f-dcfb-4891-ae04-90c3de7135c0"), fundReason="Thu chuyển khoản", fundMoney=87000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("f52bf2c3-baeb-48f5-a5ff-f199e2babbf0")},
            new FundDetail{ fundDetailID = new Guid("21bf37fa-84ac-4ba0-aea2-fa6263bae0d3"), fundReason="Thu đặ cọc", fundMoney=28000, fundTypeVoucher="Thu khác", fundID = new Guid("2dd8178c-8e81-4bdb-b624-17fb0091fe2e")},
            new FundDetail{ fundDetailID = new Guid("e13178b5-8cf6-4671-a8c3-c5521c2dcad1"), fundReason="Thu đặ cọc", fundMoney=94000, fundTypeVoucher="Thu khác", fundID = new Guid("06fd951a-34b5-4ff0-9f50-defdcc101f4d")},
            new FundDetail{ fundDetailID = new Guid("65001e79-4803-48c5-a7f1-57be193d4738"), fundReason="Thu nợ hàng", fundMoney=87000, fundTypeVoucher="Thu khác", fundID = new Guid("8121fa58-d1ad-4578-aa04-01bdc753ad57")},
            new FundDetail{ fundDetailID = new Guid("82196d4e-ef21-46c2-8d39-bc63f13ff0f9"), fundReason="Thu chuyển khoản", fundMoney=23000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("ad53303d-38a0-4f67-b3ed-b17e02ed1383")},
            new FundDetail{ fundDetailID = new Guid("f6ce6304-7ec7-4ff8-9945-2fed73c5ad4c"), fundReason="Thu chuyển khoản", fundMoney=26000, fundTypeVoucher="Thu từ bán phế liệu", fundID = new Guid("e2ef4bf3-c0a5-4ff1-b234-da1d62b3c1e5")},
            new FundDetail{ fundDetailID = new Guid("73ed6ce4-10be-4316-8d03-6928c11eef7f"), fundReason="Thu chuyển khoản", fundMoney=75000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("c3b1b8bc-9d2a-4ace-9115-73e5b69977d5")},
            new FundDetail{ fundDetailID = new Guid("f814c327-10b7-4c62-a1b1-524f2c29760d"), fundReason="Thu nợ hàng", fundMoney=23000, fundTypeVoucher="Thu thanh lý tài sản", fundID = new Guid("c48b46a8-c4a0-4888-9336-ac0d3177fba6")},
            new FundDetail{ fundDetailID = new Guid("02cfa1d0-89c8-48f0-9f7a-4a9564d785c5"), fundReason="Thu tiền mặt", fundMoney=54000, fundTypeVoucher="Thu khác", fundID = new Guid("525406d5-41e5-49ec-b826-d6c886ae5f18")},
            new FundDetail{ fundDetailID = new Guid("ff4e2f61-0877-4b2e-bbeb-e93791008376"), fundReason="Thu tiền mặt", fundMoney=27000, fundTypeVoucher="Thu hoàn ứng", fundID = new Guid("c202cb43-cbb5-47fc-b68b-aaa50e213b36")},
            new FundDetail{ fundDetailID = new Guid("b45d8890-a964-4617-92ae-60e25da43819"), fundReason="Thu tiền mặt", fundMoney=85000, fundTypeVoucher="Thu khác", fundID = new Guid("af73c9e8-7eed-4aed-a4ff-1138d0f5f55c")},
            new FundDetail{ fundDetailID = new Guid("7e7284fd-0c57-4d5c-9571-aa199228f7db"), fundReason="Thu nợ hàng", fundMoney=46000, fundTypeVoucher="Thu thanh lý tài sản", fundID = new Guid("b71a83fc-22f7-44d2-90a8-a6f51529737d")},
            new FundDetail{ fundDetailID = new Guid("359423d3-cb1e-4e1f-a11e-3ad1f8a8d72b"), fundReason="Thu nợ hàng", fundMoney=74000, fundTypeVoucher="Thu từ bán hàng", fundID = new Guid("af73c9e8-7eed-4aed-a4ff-1138d0f5f55c")}
        };
    }
}