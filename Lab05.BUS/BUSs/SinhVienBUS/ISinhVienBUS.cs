using System.Collections.Generic;
using Lab05.BUS.ViewModels;

namespace Lab05.BUS.BUSs.SinhVienBUS
{
    public interface ISinhVienBUS
    {
        List<SinhVienViewModel> GetSinhViens();
        List<SinhVienViewModel> GetSinhViensChuaDangKyChuyenNganh();
        List<SinhVienViewModel> GetSinhViensDaDangKyChuyenNganh();
        string GetImageByMSSV(string mssv);
    }
}
