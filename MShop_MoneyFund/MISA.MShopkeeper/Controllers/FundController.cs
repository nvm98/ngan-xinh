using MISA.BL.Dictionary;
using MISA.Commons;
using MISA.MShopkeeper.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MISA.Entites.Dictionary;
using MISA.Entites.ViewModels;
using MISA.Entites.Common;

namespace MISA.MShopkeeper.Controllers
{
    [RoutePrefix("fund")]
    public class FundController : ApiController
    {
        /// <summary>
        /// Lấy danh sách phiếu thu chi
        /// </summary>
        /// <returns>danh sách phiếu thu chi</returns>
        /// Created by NVMANH 18/6/2019
        [HttpGet]
        [Route("")]
        public async Task<AjaxResult> Get()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                await Task.Delay(500);
                using (FundBL fundBL = new FundBL())
                {
                    ajaxresult.Data = fundBL.GetAllFund();
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetListFund;
            }
           return ajaxresult;
        }
        /// <summary>
        /// Lấy phiếu thu chi theo id
        /// </summary>
        /// <param name="id">ID phiếu thu chi</param>
        /// <returns>Phiếu thu chi với ID tương ứng</returns>
        /// Created by NVMANH 8/7/2019
        [HttpGet]
        [Route("{id}")]
        public async Task<AjaxResult> GetAsync(Guid id)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                await Task.Delay(100);
                using (FundBL fundBL = new FundBL())
                {
                    ajaxresult.Data = fundBL.GetFundByIDBL(id);
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetFund;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy chi tiết hóa đơn theo ID phiếu thu chi
        /// </summary>
        /// <param name="id">ID phiếu thu chi</param>
        /// <returns>Danh sách chi tiết hóa đơn có ID tương ứng</returns>
        /// Created by NVMANH 8/7/2019
        [HttpGet]
        [Route("detail/{id}")]
        public async Task<AjaxResult> GetDetailFund(Guid id)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                await Task.Delay(100);
                using (FundDetailBL fundDetailBL = new FundDetailBL())
                {
                    ajaxresult.Data = fundDetailBL.GetAllFundDetailByFundID(id);
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetFundDetail;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Thêm mới phiếu thu chi
        /// </summary>
        /// <param name="fund">Đối tượng phiếu thu chi</param>
        /// <returns></returns>
        /// Created by NVMANH 20/6/2019
        [HttpPost]
        [Route("")]
        public AjaxResult saveFund(Fund fund)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundBL fundBL = new FundBL())
                {
                    fundBL.CreateFundBL(fund);
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorSaveFund;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Thêm mới chi tiết hóa đơn
        /// </summary>
        /// <param name="fundDetail">Đối tượng chi tiết hóa đơn</param>
        /// <returns></returns>
        /// Created by NVMANH 9/7/2019
        [HttpPost]
        [Route("detail")]
        public AjaxResult saveFundDetail(List<FundDetail> fundDetail)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundDetailBL fundDetailBL = new FundDetailBL())
                {
                    foreach(var item in fundDetail)
                    {
                        fundDetailBL.CreateFundDetailBL(item);
                    }
                }
                ajaxresult.Success = true;
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy một phiếu để hiển thị lên form
        /// </summary>
        /// <param name="id">ID phiếu</param>
        /// <returns>một đối tượng fund viewmodel</returns>
        /// Created by NVMANH 22/6/2019
        [HttpGet]
        [Route("view/{id}")]
        public async Task<AjaxResult> GetViewAsync(Guid id)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                await Task.Delay(500);
                using (FundBL fundBL = new FundBL())
                {
                    ajaxresult.Data = fundBL.GetFundViewModel(id);
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy phiếu thu có mã lớn nhất
        /// </summary>
        /// <returns>Mã phiếu thu hợp lệ</returns>
        /// Created by NVMANH 24/6/2019
        [HttpGet]
        [Route("collectid")]
        public AjaxResult GetIDCollect()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundBL fundBL = new FundBL())
                {
                    ajaxresult.Data = fundBL.GetCollectCodeAutoBL();
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy phiếu thu có mã code tương ứng
        /// </summary>
        /// <param name="code">Mã phiếu thu</param>
        /// <returns>Đối tượng phiếu tương ứng</returns>
        /// Created by NVMANH 24/6/2019
        [HttpGet]
        [Route("id/{code}")]
        public AjaxResult GetIdByCode(string code)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundBL fundBL = new FundBL())
                {
                    ajaxresult.Data = fundBL.GetFundByFundCodeBL(code);
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy phiếu chi có mã code tương ứng
        /// </summary>
        /// <param name="code">Mã phiếu chi</param>
        /// <returns>Đối tượng phiếu tương ứng</returns>
        /// Created by NVMANH 24/6/2019
        [HttpGet]
        [Route("payid")]
        public AjaxResult GetIDPay()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundBL fundBL = new FundBL())
                {
                    ajaxresult.Data = fundBL.GetPayCodeAutoBL();
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Xóa dữ liệu phiếu thu chi
        /// </summary>
        /// <param name="listID">danh sách ID phiếu thu chi</param>
        /// <returns></returns>
        /// Created by NVMANH 25/6/2019
        [HttpDelete]
        [Route("")]
        public AjaxResult Delete([FromBody]List<Guid> listID)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundBL fundBL = new FundBL())
                {
                    foreach(var id in listID)
                    {
                        fundBL.DeleteFundBL(id);
                    }
                    ajaxresult.Data = fundBL.GetAllFund();
                }
                
                ajaxresult.Success = true;
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorDeleteFund;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Sửa phiếu thu chi
        /// </summary>
        /// <param name="newFund">Đối tượng phiếu thu chi mới</param>
        /// <returns></returns>
        /// Created by NVMANH 25/6/2019
        [HttpPut]
        [Route("")]
        public AjaxResult PutFund([FromBody] Fund newFund)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundBL fundBL = new FundBL())
                {
                    fundBL.EditFundBL(newFund);
                }
            }
            catch(Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorEditFund;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Sửa chi tiết phiếu thu chi
        /// </summary>
        /// <param name="newFundDetail"></param>
        /// <returns></returns>
        /// Created by NVMANH 25/6/2019
        [HttpPut]
        [Route("detail")]
        public AjaxResult PutFundDetail([FromBody] List<FundDetail> newFundDetail)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundDetailBL fundDetailBL = new FundDetailBL())
                {
                    foreach (var item in newFundDetail)
                    {
                        fundDetailBL.EditFundDetailBL(item);
                    }
                }
                ajaxresult.Success = true;
            }
            catch(Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Xóa chi tiết phiếu thu chi
        /// </summary>
        /// <param name="listID">Danh sách id chi tiết phiếu</param>
        /// <returns></returns>
        /// Created by NVMANH 17/7/2019
        [HttpDelete]
        [Route("detail")]
        public AjaxResult DeleteDetail([FromBody]List<Guid> listID)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (FundDetailBL fundDetailBL = new FundDetailBL())
                {
                    foreach (var id in listID)
                    {
                        fundDetailBL.DeleteFundDetailBL(id);
                    }
                }
                ajaxresult.Success = true;
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorDeleteFund;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Hàm lọc dữ liệu bảng Fund
        /// </summary>
        /// <param name="pageNumber">Số trang</param>
        /// <param name="pageSize">Kích thước trang</param>
        /// <param name="filters">danh sách điều kiện lọc</param>
        /// <returns>danh ssch phiếu sau khi được lọc</returns>
        /// Created by NVMANH 29/7/2019
        [HttpPost]
        [Route("filter/{pageNumber}/{PageSize}")]
        public async Task<AjaxResult> FilterFund(int pageNumber, int pageSize, [FromBody]List<Filter> filters)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                await Task.Delay(100);
                string where = string.Empty;
                if (filters != null && filters.Count > 0)
                {
                    where = Filter.buidWhereFilterCondition(filters);
                }
                using (FundBL fundBL = new FundBL())
                {
                    List<Fund> fund = fundBL.PagingFundBL(where, pageNumber, pageSize);
                    ajaxresult.Data = fund;
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorSaveFund;
            }
            return ajaxresult;
        }
    }

    [RoutePrefix("billcollect")]
    public class BillCollectController : ApiController
    {
        /// <summary>
        /// lấy danh sách hóa đơn
        /// </summary>
        /// <returns>danh sách hóa đơn</returns>
        /// Created by NVMANH 23/6/2019
        [HttpGet]
        [Route("")]
        public AjaxResult Get()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (BillBL billBL = new BillBL())
                {
                    ajaxresult.Data = billBL.GetAllBillBL();
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetBill;
            }
            return ajaxresult;
        }
        /// <summary>
        /// lấy hóa đơn theo mã nhân viên
        /// </summary>
        /// <param name="id">Mã nhân viên</param>
        /// <returns>danh sách hóa đơn</returns>
        /// Created by NVMANH 23/6/2019
        [HttpGet]
        [Route("{id}")]
        public async Task<AjaxResult> Get(Guid id)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (BillBL billBL = new BillBL())
                {
                    ajaxresult.Data = billBL.GetBillBL(id);
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetBill;
            }
            return ajaxresult;
        }
    }

    [RoutePrefix("billpay")]
    public class BillPayController : ApiController
    {
        /// <summary>
        /// Lấy danh sách hóa đơn thu nợ
        /// </summary>
        /// <returns>danh sách hóa đơn thu nợ</returns>
        /// Created by NVMANH 23/6/2019
        [HttpGet]
        [Route("")]
        public AjaxResult Get()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                //ajaxresult.Data = Data.ListBillPays;
                //ajaxresult.Success = true;
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetBill;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy danh sách hóa đơn thu nợ theo mã nhân viên
        /// </summary>
        /// <param name="id">mã nhân viên</param>
        /// <returns>danh sách phiếu chi</returns>
        /// Created by NVMANH 23/6/2019
        [HttpGet]
        [Route("{id}")]
        public async Task<AjaxResult> Get(Guid id)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                //await Task.Delay(500);
                //ajaxresult.Data = Data.ListBillPays.Where(x => x.SupplierID == id);
                //ajaxresult.Success = true;
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetBill;
            }
            return ajaxresult;
        }
    }

    [RoutePrefix("suppliertype")]
    public class SupplierTypeController : ApiController
    {
        /// <summary>
        /// Lấy tất cả loại nhà cung cấp
        /// </summary>
        /// <returns>loại nhà cung cấp</returns>
        /// Created by NVMANH 8/7/2019
        [HttpGet]
        [Route("")]
        public AjaxResult Get()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                //ajaxresult.Data = Data.ListSupplierType;
                //ajaxresult.Success = true;
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
    }

    [RoutePrefix("supplier")]
    public class SupplierController : ApiController
    {
        /// <summary>
        /// Lấy tất cả nhà cung cấp
        /// </summary>
        /// <returns>danh sách nhà cung cấp</returns>
        /// Created by NVMANH 25/6/2019
        [HttpGet]
        [Route("")]
        public AjaxResult Get()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (SupplierBL supplierBL = new SupplierBL()) {
                    ajaxresult.Data = supplierBL.GetAllSupplier();
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetSupplier;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy nhà cung cấp theo id
        /// </summary>
        /// <param name="id">ID nhà cung cấp</param>
        /// <returns>Đối tượng nhà cung cấp</returns>
        /// Created by NVMANH 25/6/2019
        [HttpGet]
        [Route("{id}")]
        public AjaxResult Get(Guid id)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (SupplierBL supplierBL = new SupplierBL())
                {
                    ajaxresult.Data = supplierBL.GetSupplierByIDBL(id);
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetSupplier;
            }
            return ajaxresult;
        }
        //[HttpGet]
        //[Route("type/{id}")]
        //Lấy nhà cung cấp theo loại nhà cung cấp
        //người tạo NVMANH 25/6/2019
        //public AjaxResult GetSupplierByType(Guid id)
        //{
        //    var ajaxresult = new AjaxResult();
        //    try
        //    {
        //        var listOb = new List<SupplierDto>();
        //        foreach (var item in Data.ListSuppliers)
        //        {
        //            var obDto = new SupplierDto(item);
        //            listOb.Add(obDto);
        //        }
        //        ajaxresult.Data = listOb.Where(e => e.SupplierTypeID == id);
        //        ajaxresult.Success = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        ajaxresult.Success = false;
        //        ajaxresult.Data = ex;
        //        ajaxresult.Message = Resources.ErrorGetSupplier;
        //    }
        //    return ajaxresult;
        //}
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
        /// <summary>
        /// Lấy tất cả danh sách nhân viên
        /// </summary>
        /// <returns>danh sách nhân viên</returns>
        /// Created by NVMANH 20/6/2019
        [HttpGet]
        [Route("")]
        public AjaxResult Get()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (EmployeeBL employeeBL = new EmployeeBL())
                {
                    ajaxresult.Data = employeeBL.GetAllEmployee();
                    ajaxresult.Success = true;
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorGetEmployee;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy nhân viên theo ID
        /// </summary>
        /// <param name="id">ID nhân viên</param>
        /// <returns>Nhân viên tương ứng</returns>
        /// Created by NVMANH 20/6/2019
        [HttpGet]
        [Route("{id}")]
        public AjaxResult Get(Guid id)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                using (EmployeeBL employeeBL = new EmployeeBL())
                {
                    ajaxresult.Data = employeeBL.GetEmployeeByIDBL(id);
                }
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
    }

    [RoutePrefix("object")]
    public class ObjectTypeController : ApiController
    {
        /// <summary>
        /// Lấy tất cả loại nhà cung cấp
        /// </summary>
        /// <returns>danh sách nhà cung cấp</returns>
        /// Created by NVMANH 25/6/2019
        [HttpGet]
        [Route("")]
        public AjaxResult Get()
        {
            var ajaxresult = new AjaxResult();
            try
            {
                //ajaxresult.Data = Data.ListSupplierType.OrderByDescending(x => x.SupplierTypeName);
                //ajaxresult.Success = true;
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
        /// <summary>
        /// Lấy loại nhà cung cấp theo id
        /// </summary>
        /// <param name="id">ID nhà cung cấp</param>
        /// <returns>Nhà cung cấp tương ứng</returns>
        /// Created by NVMANH 25/6/2019
        [HttpGet]
        [Route("{id}")]
        public AjaxResult Get(Guid id)
        {
            var ajaxresult = new AjaxResult();
            try
            {
                //var objectType = Data.ListSupplierType.Where(e => e.SupplierTypeID == id).FirstOrDefault();
                //ajaxresult.Data = objectType;
                //ajaxresult.Success = true;
            }
            catch (Exception ex)
            {
                ajaxresult.Success = false;
                ajaxresult.Data = ex;
                ajaxresult.Message = Resources.ErrorNotify;
            }
            return ajaxresult;
        }
    }
}
