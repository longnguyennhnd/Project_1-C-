using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyBanDoTheThao
{
    public class HoaDonNhap
    {
        string MaHDN, TenNCC, DiaChiNCC, SoDT, MaNVNhap,TGNhap, MaSP, MANCC,Email;
        int SoLuong;
        public List<SanPham> dssp = new List<SanPham>();
        public HoaDonNhap() { }
        public HoaDonNhap(string mahdn, string manvnhap,string mancc, string tenncc,string email, string diachincc, string sodt,string tgnhap, int soluong, string masp)
        {
            MaHDN1 = mahdn;
            TenNCC1 = tenncc;
            DiaChi1 = diachincc;
            SoDT1 = sodt;
            MaNVNhap1 = manvnhap;
            SoLuong1 = soluong;
            TGNhap = tgnhap;
            this.MaSP1 = masp;
            this.MANCC = mancc;
            Email1 = email;
        }

        public string DiaChi1
        {
            get
            {
                return DiaChiNCC;
            }

            set
            {
                DiaChiNCC = value;
            }
        }

        public string MaHDN1
        {
            get
            {
                return MaHDN;
            }

            set
            {
                MaHDN = value;
            }
        }

        public string MaNVNhap1
        {
            get
            {
                return MaNVNhap;
            }

            set
            {
                MaNVNhap = value;
            }
        }

        public string SoDT1
        {
            get
            {
                return SoDT;
            }

            set
            {
                SoDT = value;
            }
        }

        public int SoLuong1
        {
            get
            {
                return SoLuong;
            }

            set
            {
                SoLuong = value;
            }
        }

        public string TenNCC1
        {
            get
            {
                return TenNCC;
            }

            set
            {
                TenNCC = value;
            }
        }

        public string TGNhap1
        {
            get
            {
                return TGNhap;
            }

            set
            {
                TGNhap = value;
            }
        }

        public string MaSP1 { get => MaSP; set => MaSP = value; }
        public string MANCC1 { get => MANCC; set => MANCC = value; }
        public string Email1 { get => Email; set => Email = value; }

        //public string Tostring(int n)
        //{
        //    string chuoi1 = this.MaHDN + "#" + this.MaNVNhap + "#" + TenNCC + "#" + DiaChiNCC + "#" + SoDT + "#" + TGNhap + "#";
        //    string chuoi2 = "";
        //    for(int i=0;i<n;i++)
        //    {
        //        if (i < n - 1)
        //            chuoi2 = chuoi2 + this.MaSP + "@" + this.SoLuong + "$";
        //        else if(i==n-1)
        //        {
        //            chuoi2 = chuoi2 + this.MaSP + "@" + this.SoLuong;
        //        }
        //    }
        //    return chuoi1 + chuoi2;
        //}
        //public void GhiThem(int n)
        //{
        //    string filedata = "HoaDonNhap.txt";
        //    try
        //    {
        //        StreamWriter sw = File.AppendText(filedata);
        //        sw.WriteLine(Tostring(n));
        //        sw.Close();
        //    }catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        List<string> a = new List<string>();//TẠO 1 LIST ĐỂ CHỨA MÃ
        List<int> sl = new List<int>();
        public void Nhap()
        {
            int n;
            do
            {
                Console.Write("\tNhập mã nhân viên nhập hàng: ");
                MaNVNhap = Console.ReadLine();
                if (MaNVNhap.Length == 0)
                {
                    Console.WriteLine("Mời nhập lại!");
                }
            } while (MaNVNhap.Length == 0);
            do
            {
                Console.Write("\tNhập mã nhà cung cấp: ");
                MANCC1 = Console.ReadLine();
                if (MANCC1.Length == 0)
                {
                    Console.WriteLine("Mời nhập lại!");
                }
            } while (MANCC1.Length == 0);
            TGNhap = DateTime.Now.ToString("yyyy/MM/dd");
            do
            {
                Console.Write("Nhập số loại sản phẩm: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Nhập lại!");

                }
            } while (n <= 0);
            
            
            for (int i=0; i<n;i++)
            {
                do
                {
                    Console.Write("\tNhập mã sản phẩm: ");
                    MaSP = Console.ReadLine();
                    if (MaSP.Length == 0)
                    {
                        Console.WriteLine("\tNhập lại!");
                    }
                        else
                    a.Add(MaSP);
                } while (MaSP.Length == 0);
                
                do
                {
                    Console.Write("\tNhập số lượng: ");
                    SoLuong =int.Parse( Console.ReadLine());
                    if (SoLuong < 0)
                    {
                        Console.WriteLine("\tNhập lại!");
                    }
                    else
                        sl.Add(SoLuong);
                } while (SoLuong<0);
                
            }
            string chuoi1 = this.MaHDN + "#" + this.MaNVNhap + "#" + MANCC1  + "#" + TGNhap + "#";
            string chuoi2 = "";
            for(int i=0;i<n;i++)
            {
                string tmp = sl[i].ToString();
                if(i<n-1)
                {
                    chuoi2=chuoi2+ a[i] + "@" + tmp + "$";
                }
                else if(i==n-1)
                {
                    chuoi2 = chuoi2 + a[i] + "@" + tmp;
                }
            }
            string filedata = "HoaDonNhap.txt";
            try
            {
                StreamWriter sw = File.AppendText(filedata);//ghi vào dòng tiếp theo của tệp hóa đơn nhập
                sw.WriteLine(chuoi1 + chuoi2);
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Show()
        {
            int TongTien = 0;
            for (int i = 0; i < dssp.Count; i++)
            {
                TongTien = TongTien + dssp[i].ThanhTien1;
            }
            Console.WriteLine("             ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║                                          ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌                                             ║ ");
            Console.WriteLine("             ║                                          ▐     HÓA ĐƠN NHẬP    ▌                                             ║");
            Console.WriteLine("             ║                                          ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                             ║");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║   Mã hóa đơn nhập: {0,-5}                                                                                     ║", MaHDN);
            Console.WriteLine("             ║   Mã nhân viên nhập hàng: {0,-5}                                                                              ║", MaNVNhap);
            Console.WriteLine("             ║   Mã NCC: {0,-5}                                                                                              ║", MANCC);
            Console.WriteLine("             ║   Tên nhà cung cấp: {0,-15}                                                                          ║", TenNCC);
            Console.WriteLine("             ║   Địa chỉ: {0,-10}                                                                                        ║", DiaChiNCC);
            Console.WriteLine("             ║   Số điện thoại: {0,-11}                                                                                 ║", SoDT);
            Console.WriteLine("             ║   Email: {0,-20}                                                                                ║", SoDT);
            Console.WriteLine("             ║   Ngày nhập: {0,-10}                                                                                      ║", TGNhap1);
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║     ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗      ║");
            Console.WriteLine("             ║     ║  Mã SP  |   Tên SP      | Size  |  Đơn Giá  | Màu Sắc | Kiểu Dáng|  Loại |Số Lượng| Thành Tiền  ║      ║");
            Console.WriteLine("             ║     ║-------------------------------------------------------------------------------------------------║      ║");
            for (int i = 0; i < dssp.Count; i++)
            {

                dssp[i].Show();

            }
            Console.WriteLine("             ║     ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝      ║");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║                                                                                Tổng tiền: {0,-9}          ║",TongTien);
            Console.WriteLine("             ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            
            
        }
    }
    public class DSHoaDonNhap
    {
        List<HoaDonNhap> ds = new List<HoaDonNhap>();
        DSSanPham dssp = new DSSanPham();
        public void Readfile()
        {
            DSNhaCungCap dsncc = new DSNhaCungCap();
            dsncc.Readfile();
            dssp.Readfile();
            string filepath = "HoaDonNhap.txt";
            ds = new List<HoaDonNhap>();
            DSSanPham sp = new DSSanPham();
            try
            {
                StreamReader sr = File.OpenText(filepath);
                string a;
                while ((a = sr.ReadLine()) != null)//duyệt từng dòng đến khi khác rỗng
                {
                    HoaDonNhap b = new HoaDonNhap();
                    string[] c = a.Split('#');
                    b.MaHDN1 = c[0];
                    b.MaNVNhap1 = c[1];
                    b.MANCC1 = c[2];
                    b.TGNhap1 = c[3];
                    for(int i=0;i<dsncc.dsnhacc.Count;i++)
                    {
                        if (dsncc.dsnhacc[i].MaNCC1.Equals(b.MANCC1))
                        {
                            b.TenNCC1 = dsncc.dsnhacc[i].TenNCC1;
                            b.DiaChi1 = dsncc.dsnhacc[i].Diachi1;
                            b.SoDT1 = dsncc.dsnhacc[i].SoDT1;
                            b.Email1 = dsncc.dsnhacc[i].Email1;                            
                        }
                    }
                    if (c[4].Contains('$')) //nếu nhập 2 LOẠI sản phẩm trở lên
                    {
                        string[] h = c[4].Split('$');//Các thông tin của từng xe ngăn cách nhau bởi dấu '$'
                        foreach (string tmp in h)
                        {
                            string[] e = tmp.Split('@');//Các thông tin của 1 xe sẽ ngăn cách nhau bằng dấu '@'
                            SanPham s = new SanPham();
                            s.MaSP1 = e[0];
                            for (int i = 0; i < dssp.dssanpham.Count; i++)
                            {
                                if (dssp.dssanpham[i].MaSP1.Equals(e[0]))//Nếu mã sản phẩm giống với mã sản phẩm trong tệp txt thì truy xuất đến thông tin của sản phẩm đó danh sách sp
                                {
                                    s.TenSP1 = dssp.dssanpham[i].TenSP1;
                                    s.DonGia1 = dssp.dssanpham[i].DonGia1;
                                    s.MauSac1 = dssp.dssanpham[i].MauSac1;
                                    s.Kieudang1 = dssp.dssanpham[i].Kieudang1;
                                    s.Loai1 = dssp.dssanpham[i].Loai1;
                                    s.Size1 = dssp.dssanpham[i].Size1;
                                    break;
                                }
                            }
                            s.SoLuong1 = int.Parse(e[1]);
                            s.ThanhTien1 = Convert.ToInt32(s.SoLuong1 * s.DonGia1);
                            dssp.Updatetxt2(s.MaSP1, s.SoLuong1);
                            b.dssp.Add(s);
                            dssp.dssanpham.Add(s);
                        }
                    }
                    else// Nếu chỉ Nhập 1 loại sản phẩm
                    {
                        string[] e = c[4].Split('@');
                        SanPham s = new SanPham();
                        s.MaSP1 = e[0];
                        for (int i = 0; i < dssp.dssanpham.Count; i++)
                        {
                            if (dssp.dssanpham[i].MaSP1.Equals(e[0]))
                            {
                                s.TenSP1 = dssp.dssanpham[i].TenSP1;
                                s.DonGia1 = dssp.dssanpham[i].DonGia1;
                                s.MauSac1 = dssp.dssanpham[i].MauSac1;
                                s.Kieudang1 = dssp.dssanpham[i].Kieudang1;
                                s.Loai1 = dssp.dssanpham[i].Loai1;
                                s.Size1 = dssp.dssanpham[i].Size1;
                                break;
                            }
                        }
                        s.SoLuong1 = int.Parse(e[1]);
                        dssp.Updatetxt2(s.MaSP1, s.SoLuong1);
                        s.ThanhTien1 = Convert.ToInt32(s.SoLuong1 * s.DonGia1);
                        b.dssp.Add(s);
                        dssp.dssanpham.Add(s);
                    }
                    ds.Add(b);
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
            }
        }
        public void Show()
        {

            foreach(HoaDonNhap a in ds)
            {
                
                a.Show();
                Console.WriteLine("    -------------------------------------------------------------------------------------------------------------------");
            }
        }
        public bool KTMa(string mahdn)
        {
            bool validate = false;
            foreach (HoaDonNhap n in ds)
            {
                if (mahdn == n.MaHDN1)
                    validate = true;
            }
            return validate;
        }
        public void AddHDN()
        {
            HoaDonNhap t = new HoaDonNhap();
            DSHoaDonNhap n = new DSHoaDonNhap();
            do
            {
                Console.Write("Nhập mã hóa đơn nhập cần thêm: ");
                t.MaHDN1 = Console.ReadLine();
                t.MaHDN1 = t.MaHDN1.ToUpper();
                if (t.MaHDN1.Length == 0)
                    Console.WriteLine("Mời nhập lại !");
            } while (t.MaHDN1.Length == 0);
            if (n.KTMa(t.MaHDN1))
            {
                Console.WriteLine("Mã hóa đơn đã bị trùng !");
                
            }
            else
            {
                t.Nhap();
                ds.Add(t);
                Console.WriteLine();
                Console.WriteLine("Thêm Thành Công !");
            }
        }
    }
}
