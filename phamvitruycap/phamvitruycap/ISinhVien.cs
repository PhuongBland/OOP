namespace phamvitruycap
{
    interface ISinhVien
    {
        double DiemLy { get; set; }
        double DiemToan { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string getMaSV();
        void InThongTinDiemTB();
        void setDiemToan(int diemToan);
        string ToString();
    }
}