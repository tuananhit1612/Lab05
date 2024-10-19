using System;
using System.Collections.Generic;
using System.Linq;
using Lab05.BUS.ViewModels;
using Lab05.DAL.DALs.StudentDAL;

namespace Lab05.BUS.BUSs.SinhVienBUS
{
    public class SinhVienBUS : ISinhVienBUS
    {
        StudentDAL _studentDAL;
        public SinhVienBUS()
        {
            _studentDAL = new StudentDAL();
        }

        public string GetImageByMSSV(string mssv)
        {
            
            var students = _studentDAL.GetStudents();
            var student = students.FirstOrDefault(c => c.StudenID == mssv);
            return student?.Avatar ?? "Không có";
        }


        public List<SinhVienViewModel> GetSinhViens()
        {
            var students = _studentDAL.GetStudents();
            return students.Select(c => new SinhVienViewModel()
            {
                MSSV = c.StudenID,
                HoTen = c.FullName,
                DiemTB = c.AverageScore ?? 0,
                Khoa = c.Faculty.FacultyName,
                ChuyenNganh = c.Major?.Name ?? "Chưa đăng ký"
            }).ToList();
        }

        public List<SinhVienViewModel> GetSinhViensChuaDangKyChuyenNganh()
        {
            var students = _studentDAL.GetStudents();
            return students.Where(c => c.MajorID == null).Select(c=>new SinhVienViewModel()
            {
                MSSV = c.StudenID,
                HoTen = c.FullName,
                DiemTB = c.AverageScore ?? 0,
                Khoa = c.Faculty.FacultyName,
                ChuyenNganh = c.Major?.Name ?? "Chưa đăng ký"
            }).ToList();
        }
        
        public List<SinhVienViewModel> GetSinhViensDaDangKyChuyenNganh()
        {
            var students = _studentDAL.GetStudents();
            return students.Where(c => c.MajorID != null).Select(c => new SinhVienViewModel()
            {
                MSSV = c.StudenID,
                HoTen = c.FullName,
                DiemTB = c.AverageScore ?? 0,
                Khoa = c.Faculty.FacultyName,
                ChuyenNganh = c.Major?.Name ?? "Chưa đăng ký"
            }).ToList();
        }
    }
}
