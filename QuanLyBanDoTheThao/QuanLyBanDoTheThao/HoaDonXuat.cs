using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyBanDoTheThao
{
    public class HoaDonXuat
    {
        string MaHDX, TenKh, DiaChi, SoDT, ThoiGianMua,SoCMT, MaNVX, makhachhang, MaSP;
        int SoLuong, Solanghetham;
        public List<SanPham> dssp = new List<SanPham>();
        public List<KhachHang> dskh = new List<KhachHang>();
        public HoaDonXuat() { }
        public HoaDonXuat(string mahdx, string tenkh, string diachi, string sodt,string soCmt, string thoigianmua, string maNVX, int soluong,string makh, string masp)
        {
            MaHDX1 = mahdx;
            TenKh1 = tenkh;
            DiaChi1 = diachi;
            SoDT1 = sodt;
            SoCMT = soCmt;
            ThoiGianMua1 = thoigianmua;
            MaNVX1 = maNVX;
            SoLuong1 = soluong;
            makhachhang = makh;
        }

        public string DiaChi1
        {
            get
            {
                return DiaChi;
            }

            set
            {
                DiaChi = value;
            }
        }

        public string MaHDX1
        {
            get
            {
                return MaHDX;
            }

            set
            {
                MaHDX = value;
            }
        }

        public string MaNVX1
        {
            get
            {
                return MaNVX;
            }

            set
            {
                MaNVX = value;
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

        public string TenKh1
        {
            get
            {
                return TenKh;
            }

            set
            {
                TenKh = value;
            }
        }

        public string ThoiGianMua1
        {
            get
            {
                return ThoiGianMua;
            }

            set
            {
                ThoiGianMua = value;
            }
        }

        public int Solanghetham1
        {
            get
            {
                return Solanghetham;
            }

            set
            {
                Solanghetham = value;
            }
        }

        public string Makhachhang
        {
            get
            {
                return makhachhang;
            }

            set
            {
                makhachhang = value;
            }
        }

        public string SoCMT1
        {
            get
            {
                return SoCMT;
            }

            set
            {
                SoCMT = value;
            }
        }

        public string MaSP1 { get => MaSP; set => MaSP = value; }

        //public string Tostring(int n)
        //{
        //    string chuoi1 = this.MaHDX + "#" + this.MaNVX + "#" + makhachhang + "#" + this.ThoiGianMua + "#";
        //    string chuoi2 = "";
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (i < n - 1)
        //            chuoi2 = chuoi2 + this.MaSP + "@" + this.SoLuong + "$";
        //        else if (i == n - 1)
        //        {
        //            chuoi2 = chuoi2 + this.MaSP1 + "@" + this.SoLuong;
        //        }
        //    }
        //    return chuoi1 + chuoi2;
        //}
        //public void GhiThem(int n)
        //{
        //    string filedata = "HoaDonXuat.txt";
        //    try
        //    {
        //        StreamWriter sw = File.AppendText(filedata);
        //        sw.WriteLine(Tostring(n));
        //        sw.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        List<string> ma = new List<string>();
        List<int> s = new List<int>();
        public void Nhap()
        {
            int n;
            do
            {
                Console.Write("\tNhập mã nhân viên xuất hàng: ");
                MaNVX = Console.ReadLine();
                if (MaNVX.Length == 0)
                {
                    Console.WriteLine("Mời nhập lại!");
                }
            } while (MaHDX.Length == 0);
            do
            {
                Console.Write("\tNhập mã khách hàng: ");
                makhachhang = Console.ReadLine();
                if (makhachhang.Length == 0)
                {
                    Console.WriteLine("Mời nhập lại!");
                }
            } while (makhachhang.Length == 0);
            ThoiGianMua = DateTime.Now.ToString("yyyy/MM/dd");  
            do
            {
                Console.Write("Nhập số loại sản phẩm: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Nhập lại!");
                }
            } while (n <= 0);

            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("\tNhập mã sản phẩm: ");
                    MaSP = Console.ReadLine();
                    if (MaSP.Length == 0)
                    {
                        Console.WriteLine("\tNhập lại!");
                    }
                    else ma.Add(MaSP);
                } while (MaSP.Length == 0);
                do
                {
                    Console.Write("\tNhập số lượng: ");
                    SoLuong = int.Parse(Console.ReadLine());
                    if (SoLuong < 0)
                    {
                        Console.WriteLine("\tNhập lại!");
                    }
                    else
                        s.Add(SoLuong);
                } while (SoLuong < 0);
            }
            string chuoi1 = this.MaHDX + "#" + this.MaNVX + "#" + makhachhang + "#" + this.ThoiGianMua + "#";
            string chuoi2 = "";
            for(int i=0;i<n;i++)
            {
                string tmp = s[i].ToString();//Chuyển số lượng thành kiểu string
                if (i < n - 1)
                {
                    chuoi2 = chuoi2 + ma[i] + "@" + tmp + "$";
                }
                else if (i == n - 1)
                {
                    chuoi2 = chuoi2 + ma[i] + "@" + tmp;
                }
            }
            string filedata = "HoaDonXuat.txt";
            try
            {
                StreamWriter sw = File.AppendText(filedata);
                sw.WriteLine(chuoi1 + chuoi2);
                sw.Close();
            }
            catch (Exception e)
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
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("             ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║                                      ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌                                                 ║ ");
            Console.WriteLine("             ║                                      ▐     HÓA ĐƠN XUẤT    ▌                                                 ║");
            Console.WriteLine("             ║                                      ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                 ║");
            Console.WriteLine("             ║                                                                                                              ║");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("             ║       Mã hóa đơn xuất: {0,-5}                                                                                 ║", MaHDX);
            Console.WriteLine("             ║       Mã Nhân viên xuất: {0,-5}                                                                               ║", MaNVX);
            Console.WriteLine("             ║       Mã Khách hàng: {0,-5}                                                                                   ║", makhachhang);
            Console.WriteLine("             ║       Tên Khách hàng: {0,-16}                                                                       ║", TenKh);
            Console.WriteLine("             ║       Địa chỉ: {0,-10}                                                                                    ║", DiaChi);
            Console.WriteLine("             ║       Số DT: {0,-11}                                                                                     ║", SoDT);
            Console.WriteLine("             ║       Số CMT: {0,-13}                                                                                  ║", SoCMT1);
            Console.WriteLine("             ║       Số lần ghé thăm cửa hàng: {0,3}                                                                          ║", Solanghetham1);
            Console.WriteLine("             ║       Thời gian mua: {0,-10}                                                                              ║", ThoiGianMua1);   
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
            Console.WriteLine("             ║                                                                            Tổng tiền: {0,-9}              ║",TongTien);
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
        }
    }
    //public void ToString(int n)
    //{
    //    Console.Write("Nhập số loại sản phẩm khách hàng đã mua: ");
    //    n = int.Parse(Console.ReadLine());
    //    string xau1;
    //    string xau2;
    //    for (int i = 0; i < n; i++)
    //    {
    //        xau1 = this + "#"
    //    }
    //}
    public class DSHoaDonXuat
    {
        List<HoaDonXuat> dshdx = new List<HoaDonXuat>();//List chứa danh sách các hóa đơn xuất.
        DSSanPham dssp = new DSSanPham();
        public List<SanPham> danhsachsanpham = new List<SanPham>();//List chứa toàn bộ những sản phẩm bán ra (chưa gộp các xe trùng)
        public List<SanPham> danhsachsanphamdagop = new List<SanPham>();//List chứa toàn bộ các sản phẩm bán ra (đã gộp các xe trùng)
        public List<SanPham> dssanphamtheothang = new List<SanPham>();//List chứa những sản phẩm bán ra theo tháng (chưa gộp)
        public List<SanPham> dssanphamtheothangdagop = new List<SanPham>();//List chứa những sản phẩm bán ra theo tháng (đã gộp)
        public void Readfile()
        {
            //hhu = new SanPham();
            DSKhachHang dskh = new DSKhachHang();
            //KhachHang kh = new KhachHang();
            dssp.Readfile();
            dskh.Readfile();
            string filepath = "HoaDonXuat.txt";
            dshdx = new List<HoaDonXuat>();
            try
            {
                StreamReader sr = File.OpenText(filepath);
                string a;
                while ((a = sr.ReadLine()) != null)
                {
                    HoaDonXuat b = new HoaDonXuat();
                    
                    string[] c = a.Split('#');
                    b.MaHDX1 = c[0];
                    b.MaNVX1 = c[1];
                    b.Makhachhang = c[2];
                    b.ThoiGianMua1 = c[3];
                    int visits = 0;
                    for(int i=0;i<dskh.dskhachhang.Count;i++)
                    {
                        if(dskh.dskhachhang[i].Makh1.Equals(b.Makhachhang))
                        {
                            b.TenKh1 = dskh.dskhachhang[i].Hoten1;
                            b.DiaChi1 = dskh.dskhachhang[i].Diachi1;
                            b.SoDT1 = dskh.dskhachhang[i].SoDt1;
                            b.SoCMT1 = dskh.dskhachhang[i].SoCMT;
                            //b.ThoiGianMua1 = dskh.dskhachhang[i].TGmua1;
                            b.Solanghetham1 = dskh.dskhachhang[i].SoLanGheTham1;
                            visits = dskh.dskhachhang[i].SoLanGheTham1;
                        }
                    }
                    if (c[4].Contains('$'))
                    {
                        string[] d = c[4].Split('$');// các loại sản phẩm thì ngăn cách nhau bởi dấu '$'
                        foreach (string tmp in d)
                        {
                            string[] e = tmp.Split('@');// các thông tin của 1 loại sản phẩm thì ngăn cách nhau bởi dấu '@'
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
                            s.SoLuong1 = int.Parse(e[1]);//
                            
                                if (visits >= 3)//Nếu khách hàng thân thiết sẽ được giảm giá 10%
                                {
                                    s.ThanhTien1 = Convert.ToInt32(Math.Round(s.SoLuong1 * s.DonGia1 * 0.9));
                                    //b.dssp.Add(s);
                                }
                                if (visits >= 1 && visits<3)// khách hàng thông thường sẽ tính tiền bình thường
                                    s.ThanhTien1 = Convert.ToInt32((s.SoLuong1 * s.DonGia1));
                            dssp.Updatetxt(s.MaSP1, s.SoLuong1);
                            b.dssp.Add(s);
                            dssp.dssanpham.Add(s);
                            danhsachsanpham.Add(s);
                        }
                    }
                    else//Khách hàng mua 1 loai sản phẩm thì sẽ k có dấu '$'
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
                        s.SoLuong1 = int.Parse(e[1]);//
                        dssp.Updatetxt(s.MaSP1, s.SoLuong1);
                        if (visits >= 3)
                        {
                            s.ThanhTien1 = Convert.ToInt32(Math.Round(s.SoLuong1 * s.DonGia1 * 0.9));
                            //b.dssp.Add(s);
                        }
                        if (visits >= 1 && visits < 3)
                            s.ThanhTien1 = Convert.ToInt32((s.SoLuong1 * s.DonGia1));
                        b.dssp.Add(s);
                        dssp.dssanpham.Add(s);
                        danhsachsanpham.Add(s);
                    }
                    
                    dshdx.Add(b);
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
            }
        }
        public bool KTMa(HoaDonXuat hdx)
        {
            bool validate = false;
            foreach (HoaDonXuat n in dshdx)
            {
                if (n.MaHDX1.Equals(hdx.MaHDX1))
                {
                    validate = true;
                    break;
                }
            }
            if (validate == true)
                return false;
            return true;
            
        }
        public void AddHDX()
        {
            Console.WriteLine("\n\n");
            HoaDonXuat t = new HoaDonXuat();
            do
            {
                Console.Write("Nhập mã hóa đơn xuất cần thêm: ");
                t.MaHDX1 = Console.ReadLine();
                t.MaHDX1 = t.MaHDX1.ToUpper();
                if (t.MaHDX1.Length == 0)
                    Console.WriteLine("Mời nhập lại !");
            } while (t.MaHDX1.Length == 0);
            if (KTMa(t))
            {
                t.Nhap();
                dshdx.Add(t);
                Console.WriteLine("Thêm Thành Công !");
            }
            else
            {
                Console.WriteLine("Mã Hóa Đơn Đã Bị Trùng !");
            }
        }
        public void Show()
        {
            HoaDonXuat g = new HoaDonXuat();
            SanPham p = new SanPham();
            foreach (HoaDonXuat a in dshdx)
            {
                a.Show();
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                //Console.WriteLine();
            }
        }
        //public void ThongKeSPBan()
        //{
        //    dssp.SapXepMa();
        //    List<SanPham> dsspp = new List<SanPham>();

        //    List<SanPham> dsspdagop = dsspp.Distinct().ToList();
        //    List<string> ma = dsspdagop.Distinct().
        //    for (int i = 0; i < dshdx.Count; i++)
        //    {
        //        int d = 0;
        //        string tmp = dssp.dssanpham[i].MaSP1;
        //        foreach (SanPham a in dsspdagop)
        //        {

        //        }
        //        dssp.dssanpham[i].SoLuong1 = dssp.dssanpham[i].SoLuong1 + d;
        //    }
        //    Console.WriteLine("\n\n\t\t\tDanh sách những sản phẩm đã bán: ");
        //    Console.WriteLine();
        //    dssp.HienThi();
        //    //Console.WriteLine();
        //    //Console.WriteLine("Số lượng sản phẩm đã bán là: " + d);
        //}
        public int Compare(SanPham s1, SanPham s2)
        {
            return string.Compare(s1.MaSP1, s2.MaSP1, true);
        }
        public void SapXepMa()
        {
            danhsachsanpham.Sort(Compare);
        }
        public void SapXepMaThang()
        {
            dssanphamtheothang.Sort(Compare);
        }
        public void Gop()
        {
            List<string> masp = new List<string>();
            SapXepMa();
            for(int i=0;i<danhsachsanpham.Count;i++)
            {
                masp.Add(danhsachsanpham[i].MaSP1);
            }
            List<string> masp2 = masp.Distinct().ToList();
            foreach(string s in masp2)
            {
                int S = 0;
                foreach(SanPham sp in danhsachsanpham)
                {
                    if(sp.MaSP1.Equals(s))
                    {
                        S = S + sp.SoLuong1;                       
                    }  
                }
                if(s.IndexOf("SP")>=0)
                {
                    SanPham a = new SanPham();
                    a.MaSP1 = s;
                    a.SoLuong1 = S;
                    danhsachsanphamdagop.Add(a);
                }
            }
        }
        public void GopThang()
        {
            List<string> masp = new List<string>();
            SapXepMaThang();
            for(int i=0;i<dssanphamtheothang.Count;i++)
            {
                masp.Add(dssanphamtheothang[i].MaSP1);
            }
            List<string> masp2 = masp.Distinct().ToList();
            foreach (string s in masp2)
            {
                int sum = 0;
                foreach (SanPham x in dssanphamtheothang)
                {
                    if (x.MaSP1.Equals(s))
                    {
                        sum = sum + x.SoLuong1;
                        //dssanphamtheothangdagop.Add(x);
                    }
                }
                if (s.IndexOf("SP") >= 0)
                {
                    SanPham a = new SanPham();
                    a.MaSP1 = s;
                    a.SoLuong1 = sum;
                    dssanphamtheothangdagop.Add(a);
                }
            }
        }
        public void ThongKeSPBan()
        {
            Gop();
            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\t\t\t\tThống Kê Toàn Bộ Những Sản Phẩm Bán Ra Của Cửa Hàng");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t {0,-15}{1}", "Mã Sản Phẩm", "Số Lượng");
            Console.WriteLine();
            for (int i = 0; i < danhsachsanphamdagop.Count; i++)
            {
                Console.Write("\t\t\t\t {0,-5}\t    ", danhsachsanphamdagop[i].MaSP1);
                for (int j = 0; j < danhsachsanphamdagop[i].SoLuong1; j++)
                {
                    Console.Write("♠");
                }
                Console.Write(" {0} Sản Phẩm", danhsachsanphamdagop[i].SoLuong1);
                Console.WriteLine("\n");
            }
        }


        //--------------------------------------------------------------//

        public void ThongKeDoanhThu()
        {
            int tien = 0;
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("\n\n\t\t\tDanh sách những sản phẩm đã bán: ");
            Console.WriteLine("             ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║     ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗      ║");
            Console.WriteLine("             ║     ║  Mã SP  |   Tên SP      | Size  |  Đơn Giá  | Màu Sắc | Kiểu Dáng|  Loại |Số Lượng| Thành Tiền  ║      ║");
            Console.WriteLine("             ║     ║-------------------------------------------------------------------------------------------------║      ║");
            for (int i = 0; i < dshdx.Count; i++)
            {
                int mon = 0;
                for (int j = 0; j < dshdx[i].dssp.Count; j++)
                {
                    dshdx[i].dssp[j].Show();
                    mon = mon + dshdx[i].dssp[j].ThanhTien1;
                }
                tien = tien + mon;
            }
            Console.WriteLine("             ║     ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝      ║");
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ║                                                                            Doanh thu tiền: {0,-9}         ║", tien);
            Console.WriteLine("             ║                                                                                                              ║");
            Console.WriteLine("             ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();

            Console.WriteLine("Doanh thu cửa hàng là: {0}", tien);
        }

        //-------------------------------------------------------------------------------------//

        public void ThongKeDoanhThuTheoNam()
        {
            int nam = DateTime.Now.Year;
            Console.WriteLine("Năm hiện tại là: " +nam);
            int year;
            do
            {
                Console.Write("\n\n\n\n\t\t\tNhập năm cần thống kê: ");
                year = int.Parse(Console.ReadLine());
                if (!(year >= 2010 && year <= nam))
                {
                    Console.WriteLine("\t\t\tNhập lại!");
                }
            } while (!(year >= 2010 && year <= nam));
            int mon = 0;
            foreach (HoaDonXuat hdx in dshdx)
            {
                int tien = 0;
                string[] tmp = hdx.ThoiGianMua1.Split('/');
                if (Convert.ToInt32(tmp[0]) == year)
                    foreach (SanPham x in hdx.dssp)
                    {
                        tien = tien + x.ThanhTien1;
                    }
                mon = mon + tien;
            }
            Console.WriteLine("\n\n\t\t\tDoanh thu của cửa hàng trong năm {0} la: {1}đ", year, mon);
        }

        // --------------------------------------------------------------------------------------------------//

        public void ThongKeDoanhThuTheoThang()
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            Console.WriteLine("Tháng {0} năm {1}",thang, nam);
            int month, year;
            do
            {
                Console.Write("\n\n\n\t\t\tNhập năm cần thống kê: ");
                year = int.Parse(Console.ReadLine());
                if (!(year >= 2010 && year <= nam))
                {
                    Console.WriteLine("\t\t\tNhập lại!");
                }
            } while (!(year >= 2000 && year <= nam));
            do
            {
                Console.Write("\n\n\t\t\tNhập tháng cần thống kê: ");
                month = int.Parse(Console.ReadLine());
                if (!(month >= 1 && month <= thang))
                {
                    Console.WriteLine("\t\t\tNhập lại!");
                }
            } while (!(month >= 1 && month <= thang));
            
            int mon = 0;
            for (int i = 0; i < dshdx.Count; i++)
            {
                int tien = 0;
                string[] tmp = dshdx[i].ThoiGianMua1.Split('/');
                if(Convert.ToInt32(tmp[1])== month && Convert.ToInt32(tmp[0])==year)
                    for (int j = 0; j < dshdx[i].dssp.Count; j++)
                    {
                        //dshdx[i].dssp[j].Show();
                        tien = tien + dshdx[i].dssp[j].ThanhTien1;
                    }
                mon = mon + tien;
            }
            Console.WriteLine("\n\t\t\tDoanh thu của cửa hàng trong tháng {0} năm {1} la: {2}đ", month, year, mon);
        }

        //------------------------------------------------------------------------------------------------//

        public void ThongKeSanPhamBanChay()
        {
            //GopThang();
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            int month, year;
            do
            {
                Console.Write("\n\n\t\t\tNhập tháng cần thống kê: ");
                month = int.Parse(Console.ReadLine());
                if (!(month >= 1 && month <= 12))
                {
                    Console.WriteLine("Nhập lại!");
                }
            } while (!(month >= 1 && month <= 12));
            do
            {
                Console.Write("\n\n\t\t\tNhập năm cần thống kê: ");
                year = int.Parse(Console.ReadLine());
                if (!(year >= 2010 && year <= nam))
                {
                    Console.WriteLine("Nhập lại!");
                }
            } while (!(year >= 2000 && year <= nam));
            Console.WriteLine("\n\n\t\tThống kê những sản phẩm bán chạy của cửa hàng trong tháng {0} năm {1}(bán được >15 sản phẩm)", month, year);
            foreach (HoaDonXuat hdx in dshdx)
            {
                string[] tmp = hdx.ThoiGianMua1.Split('/');
                if (Convert.ToInt32(tmp[1]) == month && Convert.ToInt32(tmp[0]) == year)
                {
                    foreach (SanPham x in hdx.dssp)
                    {
                        dssanphamtheothang.Add(x);
                    }
                    
                }
            }
            GopThang();
            Console.WriteLine("\n\n\n");
            //Console.WriteLine("Thống Kê Những Xe Bán Ra Tháng {0} Năm {1} ", thang, nam);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t {0,-15}{1}", "Mã Xe", "Số Lượng");
            Console.WriteLine();
            for (int i = 0; i < dssanphamtheothangdagop.Count; i++)
            {
                if (dssanphamtheothangdagop[i].SoLuong1 > 15)
                {
                    Console.Write("\t\t\t\t {0,-5}\t    ", dssanphamtheothangdagop[i].MaSP1);
                    for (int j = 0; j < dssanphamtheothangdagop[i].SoLuong1; j++)
                    {
                        Console.Write("♠");
                    }
                    Console.Write(" {0} Sản Phẩm", dssanphamtheothangdagop[i].SoLuong1);
                    Console.WriteLine("\n");
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------//

        public void ThongKeSanPhamTonKho()
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            int month,month2, year;
            do
            {
                Console.Write("\n\n\t\t\tNhập tháng đầu cần thống kê: ");
                month = int.Parse(Console.ReadLine());
                if (!(month >= 1 && month <= thang))
                {
                    Console.WriteLine("\t\t\t=> Nhập lại!");
                }
            } while (!(month >= 1 && month <= thang));
            do
            {
                Console.Write("\n\n\t\t\tNhập tháng cuối cần thống kê (nên nhập lớn hơn hoặc bằng 3 tháng kể từ tháng đầu tiên): ");
                month2 = int.Parse(Console.ReadLine());
                if (!(month2 >= 1 && month2 <= thang))
                {
                    Console.WriteLine("\t\t\t=> Nhập lại!");
                }
            } while (!(month2 >= 1 && month2 <= thang));
            do
            {
                Console.Write("\n\n\t\t\tNhập năm cần thống kê: ");
                year = int.Parse(Console.ReadLine());
                if (!(year >= 2010 && year <= nam))
                {
                    Console.WriteLine("\t\t=> Nhập lại!");
                }
            } while (!(year >= 2000 && year <= nam));
            int a = month2 - month;
            Console.WriteLine("\n\tNhững SP tồn kho của cửa hàng từ tháng {0} đến tháng {1} năm {2}", month, month2, year);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t(bán được <10 sản phẩm trong {3} tháng, và số lượng còn lại > 100 sản phẩm)", month,month2, year, a);
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (HoaDonXuat hdx in dshdx)
            {
                string[] tmp = hdx.ThoiGianMua1.Split('/');
                if (Convert.ToInt32(tmp[1]) > month && Convert.ToInt32(tmp[1]) < month2 && Convert.ToInt32(tmp[0]) == year)
                {
                    foreach (SanPham x in hdx.dssp)
                    {
                        dssanphamtheothang.Add(x);
                    }

                }
            }
            GopThang();
            Console.WriteLine("\n\n\n");
            //Console.WriteLine("Thống Kê Những Xe Bán Ra Tháng {0} Năm {1} ", thang, nam);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t {0,-15}{1}", "Mã Xe", "Số Lượng");
            Console.WriteLine();
            Random rd = new Random();
            for (int i = 0; i < dssanphamtheothangdagop.Count; i++)
            {
                switch (rd.Next(1, 8))
                {
                    case 1: Console.ForegroundColor = ConsoleColor.Green; break;
                    case 2: Console.ForegroundColor = ConsoleColor.Red; break;
                    case 3: Console.ForegroundColor = ConsoleColor.Cyan; break;
                    case 4: Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case 5: Console.ForegroundColor = ConsoleColor.Blue; break;
                    case 6: Console.ForegroundColor = ConsoleColor.Gray; break;
                    case 7: Console.ForegroundColor = ConsoleColor.Magenta; break;
                }
                if (dssanphamtheothangdagop[i].SoLuong1 < 10 && dssp.dssanpham[i].SoLuong1 > 100)
                {
                    Console.Write("\t\t\t\t {0,-5}\t    ", dssanphamtheothangdagop[i].MaSP1);
                    for (int j = 0; j < dssanphamtheothangdagop[i].SoLuong1; j++)
                    {
                        Console.Write("♠");
                    }
                    Console.Write(" {0} Sản Phẩm", dssanphamtheothangdagop[i].SoLuong1);
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
