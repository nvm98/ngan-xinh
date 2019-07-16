using MISA.MShopkeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MISA.MShopkeeper.Controllers
{
    [RoutePrefix("fund")]
    public class FundController : ApiController
    {
        [Route("")]
        //Lấy tất cả danh sách hóa đơn
        //Người tạo NVMANH 18/6/2019
        public async Task<IEnumerable<FundDto>> Get()
        {
            try
            {
                await Task.Delay(500);
                var listFund = new List<FundDto>();
                foreach (var item in Data.ListFund)
                {
                    var fundDto = new FundDto(item);
                    listFund.Add(fundDto);
                }
                return listFund.OrderByDescending(e => e.fundDate);
            }
            catch (Exception)
            {
                return null;
            }
           
        }
        [HttpGet]
        [Route("{id}")]
        //Lấy hóa đơn theo mã
        //Người tạo NVMANH 18//6/2019
        public async Task<IEnumerable<FundDto>> GetAsync(Guid id)
        {
            await Task.Delay(100);
            var listFund = new List<FundDto>();
            foreach (var item in Data.ListFund)
            {
                var fundDto = new FundDto(item);
                listFund.Add(fundDto);
            }
            var fund = listFund.Where(e => e.fundID == id);
            return fund;
        }
        [HttpGet]
        [Route("detail/{id}")]
        //Lấy chi tiết hóa đơn theo mã
        //Người tạo NVMANH 8/7/2019
        public async Task<IEnumerable<FundDetail>> GetDetailFund(Guid id)
        {
            await Task.Delay(100);
            var fund = Data.ListFundDetails.Where(e => e.fundID == id);
            return fund;
        }
        //Lưu bản ghi hóa đơn
        //Người tạo NVMANH 20/6/2019
        [HttpPost]
        [Route("save")]
        public bool saveFund(Fund fund)
        {
            Data.ListFund.Add(fund);
            return true;
        }
        //Lưu chi tiết hóa đơn
        //Người tạo NVMANH 9/7/2019
        [HttpPost]
        [Route("savedetail")]
        public bool saveFundDetail(List<FundDetail> fundDetail)
        {
            foreach(var item in fundDetail)
            {
                Data.ListFundDetails.Add(item);
            }
            return true;
        }
        [HttpGet]
        [Route("view/{id}")]
        //Lấy hóa đơn để hiển thị lên form view
        //người tạo 22/6/2019
        public async Task<FundDto> GetViewAsync(Guid id)
        {
            await Task.Delay(500);
            var listFund = new List<FundDto>();
            foreach (var item in Data.ListFund)
            {
                var fundDto = new FundDto(item);
                listFund.Add(fundDto);
            }
            var fund = listFund.Where(e => e.fundID == id).FirstOrDefault();
            return fund;
        }

        [HttpGet]
        [Route("getcollect")]
        //Lấy phiếu thu có mã lớn nhất
        //Người tạo NVMANH 24/6/2019
        public Fund GetIDCollect()
        {
            var fund = Data.ListFund.Where(e => e.typeCheck =="1").OrderByDescending(x => x.fundNumberVoucher).FirstOrDefault();
            return fund;
        }
        [HttpGet]
        [Route("getid/{code}")]
        //Lấy phiếu thu có mã code tương ứng
        //Người tạo NVMANH 24/6/2019
        public Fund GetIdByCode(string code)
        {
            var fund = Data.ListFund.Where(e => e.fundNumberVoucher == code).FirstOrDefault();
            return fund;
        }
        [HttpGet]
        [Route("getpay")]
        //Lấy phiếu chi có mã lớn nhất
        //Người tạo NVMANH 24/6/2019
        public Fund GetIDPay()
        {
            var fund = Data.ListFund.Where(e => e.typeCheck == "2").OrderByDescending(x => x.fundNumberVoucher).FirstOrDefault();
            return fund;
        }
        //Xóa dữ liệu trong bản hóa đơn
        //Người tạo NVMANH 25/6/2019
        [HttpDelete]
        [Route("delete")]
        public bool Delete([FromBody]List<Guid> listID)
        {
            foreach(var id in listID)
            {
                var data = Data.ListFund.Where(e => e.fundID == id).FirstOrDefault();
                Data.ListFund.Remove(data);
            }
            return true;
        }
        //Sửa dữ liệu trong bản hóa đơn
        //Người tạo NVMANH 25/6/2019
        [HttpPut]
        [Route("edit")]
        public IHttpActionResult PutFund([FromBody] Fund newFund)
        {
            try
            {
                var existFund = Data.ListFund.FirstOrDefault(x => x.fundID==newFund.fundID);
                existFund.fundID = newFund.fundID;
                existFund.fundMoney = newFund.fundMoney;
                existFund.employeeID = newFund.employeeID;
                existFund.fundDate = newFund.fundDate;
                existFund.fundNumberVoucher = newFund.fundNumberVoucher;
                existFund.fundReason = newFund.fundReason;
                existFund.fundTypeVoucher = newFund.fundTypeVoucher;
                existFund.supplierID = newFund.supplierID;
                existFund.typeCheck = newFund.typeCheck;
                existFund.fundObject = newFund.fundObject;
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        //Sửa dữ liệu trong bảng chi tiết hóa đơn
        //Người tạo NVMANH 25/6/2019
        [HttpPut]
        [Route("editDeatil")]
        public IHttpActionResult PutFundDetail([FromBody] List<FundDetail> newFundDetail)
        {
            try
            {
                foreach (var item in newFundDetail)
                {
                    var existFundDetail = Data.ListFundDetails.FirstOrDefault(x => x.fundDetailID == item.fundDetailID);
                    existFundDetail.fundID = item.fundID;
                    existFundDetail.fundMoney = item.fundMoney;
                    existFundDetail.fundReason = item.fundReason;
                    existFundDetail.fundTypeVoucher = item.fundTypeVoucher;
                }
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
            
        }
    }

    [RoutePrefix("billcollect")]
    public class BillCollectController : ApiController
    {
        [Route("")]
        //Lấy tất cả danh sách hóa đơn thu nợ
        //Người tạo NVMANH 23/6/2019
        public IEnumerable<BillCollect> Get()
        {
            return Data.ListBillCollects;
        }
        [Route("{id}")]
        //Lấy hóa đơn thu nợ theo mã nhân viên
        //Người tạo NVMANH 23/6/2019
        public async Task<IEnumerable<BillCollect>> Get(Guid id)
        {
            await Task.Delay(500);
            return Data.ListBillCollects.Where(x => x.supplierID == id).OrderBy(x => x.billDate);
        }
    }

    [RoutePrefix("billpay")]
    public class BillPayController : ApiController
    {
        [Route("")]
        //Lấy tất cả danh sách hóa đơn thu nợ
        //Người tạo NVMANH 23/6/2019
        public IEnumerable<BillPay> Get()
        {
            return Data.ListBillPays;
        }
        [Route("{id}")]
        //Lấy hóa đơn thu nợ theo mã nhân viên
        //Người tạo NVMANH 23/6/2019
        public async Task<IEnumerable<BillPay>> Get(Guid id)
        {
            await Task.Delay(500);
            return Data.ListBillPays.Where(x => x.supplierID == id);
        }
    }

    [RoutePrefix("suppliertype")]
    public class SupplierTypeController : ApiController
    {
        [Route("")]
        //Lấy tất cả các loại nhà cung cấp
        //Người tạo NVMANH 8/7/2019
        public IEnumerable<SupplierType> Get()
        {
            return Data.ListSupplierType;
        }
    }

    [RoutePrefix("supplier")]
    public class SupplierController : ApiController
    {
        [Route("")]
        //Lấy tất cả nhà cung cấp
        //Người tạo NVMANH 25/6/2019
        public IEnumerable<SupplierDto> Get()
        {
            var listOb = new List<SupplierDto>();
            foreach (var item in Data.ListSuppliers)
            {
                var obDto = new SupplierDto(item);
                listOb.Add(obDto);
            }
            return listOb;
        }
        [Route("{id}")]
        //Lấy nhà cung cấp theo id
        //người tạo NVMANH 25/6/2019
        public Supplier Get(Guid id)
        {
            var supplier = Data.ListSuppliers.Where(e => e.supplierID == id).FirstOrDefault();
            return supplier;
        }
        [Route("type/{id}")]
        //Lấy nhà cung cấp theo loại nhà cung cấp
        //người tạo NVMANH 25/6/2019
        public IEnumerable<SupplierDto> GetSupplierByType(Guid id)
        {
            var listOb = new List<SupplierDto>();
            foreach (var item in Data.ListSuppliers)
            {
                var obDto = new SupplierDto(item);
                listOb.Add(obDto);
            }
            return listOb.Where(e => e.supplierTypeID == id);
        }
    }

    //[RoutePrefix("customer")]
    //public class CustomerController : ApiController
    //{
    //    [Route("")]
    //    //Lấy tất cả danh sách khách hàng
    //    //người tạo NVMANH 20/6/2019
    //    public IEnumerable<Customer> Get()
    //    {
    //        return Data.ListCustomers.OrderByDescending(x => x.CustomerId);
    //    }
    //    [Route("{id}")]
    //    //Lấy nhà cung cấp theo id
    //    //người tạo NVMANH 25/6/2019
    //    public Customer Get(Guid id)
    //    {
    //        var customer = Data.ListCustomers.Where(e => e.CustomerID == id).FirstOrDefault();
    //        return customer;
    //    }
    //}

    [RoutePrefix("employee")]
    public class EmployeeController : ApiController
    {
        [Route("")]
        //Lấy tất cả danh sách nhân viên
        //Người tạo NVMANH 20/6/2019
        public IEnumerable<EmployeeDto> Get()
        {
            var listEm = new List<EmployeeDto>();
            foreach (var item in Data.ListEmployees)
            {
                var emDto = new EmployeeDto(item);
                listEm.Add(emDto);
            }
            return listEm;
        }
        [Route("{id}")]
        //Lấy nhân viên theo khóa
        //Người tạo NVMANH 20/6/2019
        public Employee Get(Guid id)
        {
            var employee = Data.ListEmployees.Where(e => e.employeeID == id).FirstOrDefault();
            return employee;
        }
    }

    [RoutePrefix("object")]
    public class ObjectTypeController : ApiController
    {
        [Route("")]
        //Lấy tất cả loại nhà cung cấp
        //người tạo NVMANH 25/6/2019
        public IEnumerable<SupplierType> Get()
        {
            return Data.ListSupplierType.OrderByDescending(x => x.supplierTypeName);


        }

        [Route("{id}")]
        //Lấy loại nhà cung cấp theo id
        //Người tạo NVMANH 25/6/2019
        public SupplierType Get(Guid id)
        {
            var objectType = Data.ListSupplierType.Where(e => e.supplierTypeID == id).FirstOrDefault();
            return objectType;
        }
    }
}
