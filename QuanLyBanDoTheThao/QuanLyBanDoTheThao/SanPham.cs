using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyBanDoTheThao
{
    public class SanPham
    {
        string MaSP, TenSP, Size, MauSac, Kieudang, Loai;
        int SoLuong;

        int DonGia;
        int ThanhTien;
        public SanPham()
        {

        }
        public string MaSP1
        {
            get
            {
                return MaSP;
            }

            set
            {
                MaSP = value;
            }
        }

        public string TenSP1
        {
            get
            {
                return TenSP;
            }

            set
            {
                TenSP = value;
            }
        }

        public string Size1
        {
            get
            {
                return Size;
            }

            set
            {
                Size = value;
            }
        }

        public string MauSac1
        {
            get
            {
                return MauSac;
            }

            set
            {
                MauSac = value;
            }
        }

        public string Kieudang1
        {
            get
            {
                return Kieudang;
            }

            set
            {
                Kieudang = value;
            }
        }

        public int DonGia1
        {
            get
            {
                return DonGia;
            }

            set
            {
                DonGia = value;
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

        public string Loai1
        {
            get
            {
                return Loai;
            }

            set
            {
                Loai = value;
            }
        }

        public int ThanhTien1
        {
            get
            {
                return ThanhTien;
            }

            set
            {
                ThanhTien = value;
            }
        }

        public SanPham(string masp, string tensp, string size, int dongia, string mausac, string kieudang, string loai, int soluong, int thanhtien)
        {
            this.MaSP1 = masp;
            this.TenSP1 = tensp;
            this.Size1 = size;
            this.DonGia1 = dongia;
            this.MauSac1 = mausac;
            this.Kieudang1 = kieudang;
            this.Loai1 = loai;
            this.SoLuong = soluong;
            this.ThanhTien = thanhtien;
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap ma san pham: ");
                MaSP = Console.ReadLine().Trim();
            } while (MaSP.Trim().Length == 0 || MaSP.Trim().Length > 10);
            do
            {
                Console.Write("Nhap ten san pham: ");
                TenSP = Console.ReadLine();
            } while (TenSP.Trim().Length == 0 || TenSP.Trim().Length > 30);

            do
            {
                Console.Write("Nhap size: ");
                Size = Console.ReadLine();
            } while (Size.Trim().Length == 0 || Size.Trim().Length > 5);
            do
            {
                Console.Write("Nhap mau sac san pham: ");
                MauSac = Console.ReadLine();
            } while (MauSac.Trim().Length == 0 || MauSac.Trim().Length > 10);
            do
            {
                Console.Write("Nhap kieu dang: ");
                Kieudang = Console.ReadLine();
            } while (Kieudang.Trim().Length == 0 || Kieudang.Trim().Length > 15);
            do
            {
                Console.Write("Nhap loai san pham: ");
                Loai1 = Console.ReadLine();
            } while (Loai1.Trim().Length == 0 || Loai1.Trim().Length > 50);
            do
            {
                Console.Write("Nhap so luong:");
                SoLuong = int.Parse(Console.ReadLine());
            } while (SoLuong < 1);
            do
            {
                Console.Write("Nhap don gia cua san pham: ");
                DonGia = int.Parse(Console.ReadLine());
            } while (DonGia < 0);
        }
        public void NhapThem()
        {
            do
            {
                Console.Write("\tNhập tên sản phẩm: ");
                TenSP = Console.ReadLine();
            } while (TenSP.Trim().Length == 0 || TenSP.Trim().Length > 20);

            do
            {
                Console.Write("\tNhập size: ");
                Size = Console.ReadLine();
            } while (Size.Trim().Length == 0 || Size.Trim().Length > 5);
            do
            {
                Console.Write("\tNhập đơn giá của sản phẩm: ");
                DonGia = int.Parse(Console.ReadLine());
            } while (DonGia < 0);
            do
            {
                Console.Write("\tMàu sắc: ");
                MauSac = Console.ReadLine();
            } while (MauSac.Trim().Length == 0 || MauSac.Trim().Length > 10);
            do
            {
                Console.Write("\tKiểu dáng: ");
                Kieudang = Console.ReadLine();
            } while (Kieudang.Trim().Length == 0 || Kieudang.Trim().Length > 15);
            do
            {
                Console.Write("\tLoại: ");
                Loai1 = Console.ReadLine();
            } while (Loai1.Trim().Length == 0 || Loai1.Trim().Length > 50);
            do
            {
                Console.Write("\tSố lượng:");
                SoLuong = int.Parse(Console.ReadLine());
            } while (SoLuong < 1);
            
    }
        public int thanhtien()
        { 
            return ThanhTien1 = Convert.ToInt32( Math.Round(SoLuong1 * DonGia1*0.5));
        }
        public void Show()
        {
            Console.WriteLine("             ║     ║   {0,-6}| {1,-14}|  {2,-5}|  {3,-9}|  {4,-7}|   {5,-7}| {6,-6}| {7,3}    |  {8,-11}║      ║", MaSP, TenSP, Size, DonGia, MauSac, Kieudang, Loai1, SoLuong, ThanhTien1);
        }
        public void Show2()
        {
            Console.WriteLine("\t\t   ║   {0,-6} | {1,-14} |  {2,-5}|  {3,-9} |  {4,-7} |   {5,-7} | {6,-6}|   {7,5}   ║", MaSP, TenSP, Size, DonGia, MauSac, Kieudang, Loai1, SoLuong);
        }
        public void Show3(SanPham s)
        {
            Console.WriteLine("\t\t\t\t  Mã SP  |     Tên SP            |  Số lượng");
            Console.WriteLine("\t\t\t\t  {0,-5}  | {1,-11}           |     {2}", s.MaSP, s.TenSP1, s.SoLuong1);
            //Console.Write("{0} san pham", s.SoLuong1);
            Console.WriteLine();
        }
        public override string ToString()
        {
            return this.MaSP
                + "#" + this.TenSP
                + "#" + this.Size
                + "#" + this.DonGia
                + "#" + this.MauSac
                + "#" + this.Kieudang
                + "#" + this.Loai
                + "#" + this.SoLuong;

        }
    }
    public class DSSanPham
    {
        private static String FILE_NAME = "SanPham.txt"; //File text lưu thông tin các sản phẩm
        public List<SanPham> dssanpham = new List<SanPham>();
        public List<SanPham> dssptxt;
        public int Compare(SanPham s1, SanPham s2)
        {
            return string.Compare(s1.MaSP1, s2.MaSP1, true);
        }
        public void SapXepMa()
        {
            dssanpham.Sort(Compare);
        }
        public void Readfile()
        {

            string filepath = "SanPham.txt";
            dssanpham = new List<SanPham>();
            try
            {
                StreamReader sr = File.OpenText(filepath);
                string a;
                while ((a = sr.ReadLine())!= null)
                {
                    SanPham b = new SanPham();
                    string[] c = a.Split('#');
                    b.MaSP1 = c[0];
                    b.TenSP1 = c[1];
                    b.Size1 = c[2];
                    b.DonGia1 = int.Parse(c[3]);
                    b.MauSac1 = c[4];
                    b.Kieudang1 = c[5];
                    b.Loai1 = c[6];
                    b.SoLuong1 = int.Parse(c[7]);
                    dssanpham.Add(b);
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Updatetxt(string Masp,int soluong)
        {
            string filepath = "SanPham.txt";
            dssptxt = new List<SanPham>();
            try
            {
                StreamReader sr = File.OpenText(filepath);
                string a;
                while ((a = sr.ReadLine()) != null)//đọc từng dòng đến khi khác rỗng
                {
                    SanPham b = new SanPham();
                    string[] c = a.Split('#');
                    b.MaSP1 = c[0];
                    b.TenSP1 = c[1];
                    b.Size1 = c[2];
                    b.DonGia1 = int.Parse(c[3]);
                    b.MauSac1 = c[4];
                    b.Kieudang1 = c[5];
                    b.Loai1 = c[6];
                    if (b.MaSP1.Equals(Masp))// nếu mã sản phẩm bằng mã sản phẩm trong hóa đơn xuất
                    {
                        b.SoLuong1 = int.Parse(c[7]) - soluong;// thì số lượng trong danh sách sản phẩm sẽ trừ đi số lượng đã xuất đi
                        if (b.SoLuong1 < 0)
                            b.SoLuong1 = 0;
                    }
                    else
                        b.SoLuong1 = int.Parse(c[7]);// nếu mã sản phẩm không giống thì ghi số lượng như cũ
                    dssptxt.Add(b);
                }
                sr.Close();
                StreamWriter sw = File.CreateText(filepath);
                foreach (SanPham sp in dssptxt)
                    sw.WriteLine(sp.ToString());
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Updatetxt2(string Masp, int soluong)
        {
            string filepath = "SanPham.txt";
            dssptxt = new List<SanPham>();
            try
            {
                StreamReader sr = File.OpenText(filepath);
                string a;
                while ((a = sr.ReadLine()) != null)//đọc từng dòng đến khi khác rỗng
                {
                    SanPham b = new SanPham();
                    string[] c = a.Split('#');
                    b.MaSP1 = c[0];
                    b.TenSP1 = c[1];
                    b.Size1 = c[2];
                    b.DonGia1 = int.Parse(c[3]);
                    b.MauSac1 = c[4];
                    b.Kieudang1 = c[5];
                    b.Loai1 = c[6];
                    if (b.MaSP1.Equals(Masp))// nếu mã sản phẩm bằng mã sản phẩm trong hóa đơn xuất
                    {
                        b.SoLuong1 = int.Parse(c[7]) + soluong;// thì số lượng trong danh sách sản phẩm sẽ CỘNG đi số lượng đã NHẬP vào
                        if (b.SoLuong1 < 0)
                            b.SoLuong1 = 0;
                    }
                    else
                        b.SoLuong1 = int.Parse(c[7]);// nếu mã sản phẩm không giống thì ghi số lượng như cũ
                    dssptxt.Add(b);
                }
                sr.Close();
                StreamWriter sw = File.CreateText(filepath);
                foreach (SanPham sp in dssptxt)
                    sw.WriteLine(sp.ToString());
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Show()
        {
            Readfile();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t    ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌");
            Console.WriteLine("\t\t\t\t\t\t    ▐   THÔNG TIN SẢN PHẨM   ▌");
            Console.WriteLine("\t\t\t\t\t\t    ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t   ╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t   ║  Mã SP   |   Tên SP       | Size  |  Đơn Giá   |  Màu sắc |  Kiểu Dáng|  Loại | Số Lượng  ║");
            Console.WriteLine("\t\t   ║═══════════════════════════════════════════════════════════════════════════════════════════║");
            foreach (SanPham a in dssanpham)
            {
                a.Show2();
                Console.WriteLine("\t\t   ║-------------------------------------------------------------------------------------------║");
            }
            Console.WriteLine("\t\t   ╚═══════════════════════════════════════════════════════════════════════════════════════════╝");
        }

        //------------------------------------------------//

        public void TimKiemMa()
        {
            string ma1;
            int f = 0;
            Readfile();
            Show();
            do
            {
                Console.Write("\t\tNhập mã sản phẩm cần tìm: ");
                ma1 = Console.ReadLine();
                if (ma1 == "")
                    Console.WriteLine("Nhập lại");
            } while (ma1 == "");
            for (int i = 0; i < dssanpham.Count; i++)
            {
                if (dssanpham[i].MaSP1.CompareTo(ma1) == 0)
                {
                    Console.WriteLine("\t\tThông tin mặt hàng có mã bạn muốn tìm: \n");
                    Console.WriteLine();
                    Console.WriteLine("\t\t   ╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t   ║  Mã SP   |   Tên SP       | Size  |  Đơn Giá   |  Màu sắc |  Kiểu Dáng|  Loại | Số Lượng  ║");
                    Console.WriteLine("\t\t   ║═══════════════════════════════════════════════════════════════════════════════════════════║");
                    dssanpham[i].Show2();
                    Console.WriteLine("\t\t   ╚═══════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine();
                    f = 1;
                }

            }
            if (f == 0)
            {
                Console.Write("\t\tKhông có sản phẩm nào theo mã bạn tìm!!");
            }
        }
        public void TimKiemTen()
        {
            DSSanPham a = new DSSanPham();
            a.Show();
            string ten1;
            do
            {
                Console.Write("\t\tNhập tên sản phẩm bạn muốn tìm kiếm: ");
                ten1 = Console.ReadLine();
                if (ten1 == "")
                    Console.WriteLine("Nhập lại");
            } while (ten1 == "");
            int f = 0;
            Console.WriteLine("\t\tThông tin danh sách sản phẩm có tên đúng hoặc gần đúng với tên bạn đã tìm!! ");
            for (int i = 0; i < dssanpham.Count; i++)
            {
                if (dssanpham[i].TenSP1.IndexOf(ten1) >= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\t   ╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t   ║  Mã SP   |   Tên SP       | Size  |  Đơn Giá   |  Màu sắc |  Kiểu Dáng|  Loại | Số Lượng  ║");
                    Console.WriteLine("\t\t   ║═══════════════════════════════════════════════════════════════════════════════════════════║");
                    dssanpham[i].Show2();
                    Console.WriteLine("\t\t   ╚═══════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine();
                    f = 1;
                }
            }
            if (f == 0)
            {
                Console.Write("Không có sản phẩm nào theo tên bạn tìm!!");
            }
        }
        public void TimKiemtheoKhoangGia()
        {
            bool ok = false;
            int giatoithieu;
            int giatoida;
            do
            {
                Console.Write("\n\n\t\tNhập giá tối thiểu của sản phẩm bạn muốn mua: ");
                giatoithieu = int.Parse(Console.ReadLine());
                if (giatoithieu < 1000)
                    Console.WriteLine("\t\tMời nhập lại!!!");
            } while (giatoithieu < 1000);
            do
            {
                Console.Write("\n\n\t\tNhập giá tối đa của sản phẩm bạn muốn mua: ");
                giatoida = int.Parse(Console.ReadLine());
                if (!(giatoida > giatoithieu && giatoida <= 4000000))
                    Console.WriteLine("\t\tMời nhập lại!!!");
            } while (!(giatoida > giatoithieu && giatoida <= 4000000));
            Console.WriteLine("\n\t\tDanh sách sản phẩm theo khoảng giá bạn tìm là");
            foreach (SanPham d in dssanpham)
                if (d.DonGia1 >= giatoithieu && (d.DonGia1  <= giatoida))
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\t   ╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t   ║  Mã SP   |   Tên SP       | Size  |  Đơn Giá   |  Màu sắc |  Kiểu Dáng|  Loại | Số Lượng  ║");
                    Console.WriteLine("\t\t   ║═══════════════════════════════════════════════════════════════════════════════════════════║");
                    d.Show2();
                    Console.WriteLine("\t\t   ╚═══════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();
                    ok = true;
                }
            if (ok == false)
                Console.WriteLine("\t\tKhông tìm thấy sản phẩm nào theo khoảng giá bạn tìm!!!");
        }

        public void GhiTep()
        {
            StreamWriter sw = File.CreateText("SanPham.txt");
            foreach (SanPham x in dssanpham)
            {
                sw.WriteLine(x.ToString());
            }
            sw.Close();
        }

        public bool ktMa(string masp)
        {
            bool validate = false;
            foreach (SanPham nv in dssanpham)
            {
                if (masp == nv.MaSP1)
                    validate = true;
            }
            return validate;
        }
        public SanPham TimSanPham(string maSp)
        {
            foreach (SanPham nv in dssanpham)
            {
                if (nv.MaSP1.Equals(maSp))
                {
                    return nv;
                }
            }
            return null;
        }
        public void ktADD(String MaSP, String TenSP, String Size, int DonGia, String MauSac, String KieuDang, String Loai, int SoLuong)
        {
            if (!File.Exists(FILE_NAME))
            {
                File.Create(FILE_NAME);
            }
            else
            {
                StreamWriter sw = File.AppendText(FILE_NAME);
                sw.WriteLine(MaSP + "#" + TenSP + "#" + Size + "#" + DonGia + "#" + MauSac + "#" + KieuDang + "#" + Loai + "#" + SoLuong);
                sw.Close();
            }
        }
        public void Add()
        {
            SanPham t = new SanPham();
            DSSanPham n = new DSSanPham();
            n.Show();
            do
            {
                do
                {
                    Console.WriteLine("\n");
                    Console.Write("\tNhập mã sản phẩm cần thêm: ");
                    t.MaSP1 = Console.ReadLine();
                    t.MaSP1 = t.MaSP1.ToUpper();
                    if (t.MaSP1.Length == 0)
                    {
                        Console.WriteLine("Nhập lại!! ");
                    }
                } while (t.MaSP1.Length == 0);
                if (n.ktMa(t.MaSP1))
                {
                    Console.WriteLine("\tMã sản phẩm đã tồn lại! Mời nhập lại!!");
                }
                else
                {
                    t.NhapThem();
                    n.ktADD(t.MaSP1, t.TenSP1, t.Size1, t.DonGia1, t.MauSac1, t.Kieudang1, t.Loai1, t.SoLuong1);
                    Console.WriteLine("\nAdd successfully !!!");
                }
            } while (n.ktMa(t.MaSP1));
         }
        //Sua thong tin san pham
        public void Update()
        {
            SanPham t = new SanPham();
            DSSanPham n = new DSSanPham();
            n.Show();
            string maSp;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\tNhập mã sản phẩm cần sửa: ");
                maSp = Console.ReadLine();
                maSp = maSp.ToUpper();
                if (maSp.Length == 0)
                {
                    Console.WriteLine("Nhập lại!!!");
                }
            } while (maSp.Length == 0);
            if (TimSanPham(maSp) != null)// nếu hàm tìm sp có giá trị
            {
                TimSanPham(maSp).NhapThem();
                GhiTep();
                Console.WriteLine("\tUpdate successfully !!!");
                Console.WriteLine();
                Console.WriteLine("\tSản phẩm sau khi update xong: ");
                Console.WriteLine();
                Console.WriteLine("\t\t   ╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t   ║  Mã SP   |   Tên SP       | Size  |  Đơn Giá   |  Màu sắc |  Kiểu Dáng|  Loại | Số Lượng  ║");
                Console.WriteLine("\t\t   ║═══════════════════════════════════════════════════════════════════════════════════════════║");
                TimSanPham(maSp).Show2();
                Console.WriteLine("\t\t   ╚═══════════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
                Console.WriteLine("Không tìm thấy sản phẩm cần sửa !!!");
        }
        public void deleteTXT(string maSp)
        {
            StreamWriter sw = File.CreateText(FILE_NAME);
            foreach (SanPham s in dssanpham)
                if (!s.MaSP1.Equals(maSp))//NẾU khác phần tử có mã muốn xóa thì ghi vào tệp
                    sw.WriteLine(s.ToString());
            sw.Close();
        }
        public void Delete()
        {
            DSSanPham n = new DSSanPham();
            n.Show();
            string maSp;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\tNhập mã sản phẩm muốn xóa: ");
                maSp = Console.ReadLine();
                maSp = maSp.ToUpper();
                if (maSp.Length == 0)
                    Console.WriteLine("Mời nhập lại !");
            } while (maSp.Length == 0);
            if (TimSanPham(maSp) != null)// nếu hàm tìm sản phẩm có giá trị
            {
                dssanpham.Remove(TimSanPham(maSp));
                deleteTXT(maSp);
                Console.WriteLine();
                Console.WriteLine("Xóa Thành Công !");
            }
            else
                Console.WriteLine("Không tìm thấy sản phẩm cần xóa !");
        }
        public void ThongKeSPSapHet()
        {
            int f = 0;
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("\t\t   ╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t   ║  MaSP    |    TenSP       | Size  |   DonGia   |  MauSac  |  KieuDang |  Loai | SoLuong   ║");
            Console.WriteLine("\t\t   ║-------------------------------------------------------------------------------------------║");
            for (int i=0;i<dssanpham.Count;i++)
            {
                if(dssanpham[i].SoLuong1<=20)
                {
                    f = 1;
                    dssanpham[i].Show2();
                }
            }
            Console.WriteLine("\t\t   ╚═══════════════════════════════════════════════════════════════════════════════════════════╝");
            if (f == 1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     ♠♠♠♠   Sản phẩm này sắp hết!! Vui lòng nhập thêm! ♠♠♠♠\n");
            }
            if (f==0)
            {
                Console.WriteLine("     ♠♠♠♠ Hàng vẫn còn nhiều! ♠♠♠♠");
            }
        }
    }
}

