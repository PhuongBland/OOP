using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phamvitruycap
{

    class SinhVien
    {
        /*
             Các thuộc tính đều mang lại phạm vi là private. Vì thế chỉ được sử dụng nội bộ trong class.
         */

        private string maSV;
        private string hoTen;
        private double diemToan;
        private double diemVan;
        private double diemLy;


        public double DiemLy
        {
            get { return DiemLy1; }
            set {
                /*
                 Kiểm tra điểm lý có thỏa mãn hay không, Nếu có sẽ thực hiện gán thuộc tính, không thì không làm gì cả
                 */
                if(value<=10 || value >= 10)
                {
                    DiemLy1 = value;
                }
            }
        }

        public double DiemToan
        {
            get { return DiemToan1; }

            set
            {
                if (value <= 10 || value >= 10)
                {
                    DiemToan1 = value;
                }
            }
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double DiemToan1 { get => diemToan; set => diemToan = value; }
        public double DiemVan { get => diemVan; set => diemVan = value; }
        public double DiemLy1 { get => diemLy; set => diemLy = value; }

        /* Đây là phương thức truy vấn giá trị của thuôc tính MaSV 
         * Vì thế phương thức sẽ trả về string (trùng với kiểu dữ liệu)
         */
        public string getMaSV(){
            return MaSV;
            }


        // Đây là pthuc cập nhật giá trị điểm toán

        public void setDiemToan(int diemToan)
        {
            DiemToan = diemToan;
        }
        public void InThongTinDiemTB()
        {
            double DTB = (DiemToan + DiemVan) / 2;
            Console.WriteLine("Sinh Vien " + HoTen + "Co diem tb la: " + DTB);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            sv1.DiemToan = 8;
            sv1.DiemVan = 7;
            sv1.InThongTinDiemTB();

            Console.ReadKey();
        }
    }
}


// Có 5 loại phạm vi truy cập : public, private, protected, static
// tên property viết hoa, private viết thường