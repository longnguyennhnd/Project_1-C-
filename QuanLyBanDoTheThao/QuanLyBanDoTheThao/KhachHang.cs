using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyBanDoTheThao
{
   public class KhachHang
    {
        string Makh, Hoten, Diachi,TGmua, soCMT, SoDt;
        int SoLanGheTham;
        string Cap;
        public KhachHang()
        {

        }
        public KhachHang(string makh, string hoten, string tgmua, string diachi,string socmt, string sodt, int solanghetham,string cap)
        {
            this.Makh1 = makh;
            this.Hoten1 = hoten;
            this.Diachi1 = diachi;
            this.SoDt1 = sodt;
            this.SoCMT = socmt;
            this.TGmua1 = tgmua;
            this.SoLanGheTham1 = solanghetham;
        }

        public string Diachi1
        {
            get
            {
                return Diachi;
            }

            set
            {
                Diachi = value;
            }
        }

        public string Hoten1
        {
            get
            {
                return Hoten;
            }

            set
            {
                Hoten = value;
            }
        }

        public string Makh1
        {
            get
            {
                return Makh;
            }

            set
            {
                Makh = value;
            }
        }

        public string SoCMT
        {
            get
            {
                return soCMT;
            }

            set
            {
                soCMT = value;
            }
        }

        public string SoDt1
        {
            get
            {
                return SoDt;
            }

            set
            {
                SoDt = value;
            }
        }

        public int SoLanGheTham1
        {
            get
            {
                return SoLanGheTham;
            }

            set
            {
                SoLanGheTham = value;
            }
        }

        public string TGmua1
        {
            get
            {
                return TGmua;
            }

            set
            {
                TGmua = value;
            }
        }

        public string Cap1
        {
            get
            {
                return Cap;
            }

            set
            {
                Cap = value;
            }
        }

        public void Nhap()
        {
            do
            {
                Console.Write("Nhap ma khach hang: ");
                Makh = Console.ReadLine().Trim();
            } while (Makh.Trim().Length == 0 || Makh.Trim().Length > 10);
            do
            {
                Console.Write("Nhap ten khach hang: ");
                Hoten1 = Console.ReadLine();
            } while (Hoten1.Trim().Length == 0 || Hoten1.Trim().Length > 20);

            do
            {
                Console.Write("Dia chi: ");
                Diachi = Console.ReadLine();
            } while (Diachi.Trim().Length == 0 || Diachi.Trim().Length > 10);
            do
            {
                Console.Write("Nhap so dien thoai: ");
                SoDt = Console.ReadLine();
            } while (SoDt.Trim().Length == 0 || SoDt.Trim().Length > 11);
            do
            {
                Console.Write("Nhap so CMT/CCCD: ");
                soCMT = Console.ReadLine();
            } while (soCMT.Trim().Length == 0 || soCMT.Trim().Length > 10);
            do
            {
                Console.Write("Nhap thoi gian mua: ");
                TGmua = Console.ReadLine().Trim();
            } while (TGmua.Trim().Length == 0 || TGmua.Trim().Length > 10);
            do
            {
                Console.Write("So lan ghe tham cua hang:");
                SoLanGheTham1 = int.Parse(Console.ReadLine());
            } while (SoLanGheTham1 < 1);
        }
        public void NhapThem()
        {
            do
            {
                Console.Write("\tNhập tên khách hàng: ");
                Hoten1 = Console.ReadLine();
            } while (Hoten1.Trim().Length == 0 || Hoten1.Trim().Length > 20);

            do
            {
                Console.Write("\tĐịa chỉ: ");
                Diachi = Console.ReadLine();
            } while (Diachi.Trim().Length == 0 || Diachi.Trim().Length > 10);
            do
            {
                Console.Write("\tSố điện thoại: ");
                SoDt = Console.ReadLine();
            } while (SoDt.Trim().Length == 0 || SoDt.Trim().Length > 11);
            do
            {
                Console.Write("\tSố CMT/CCCD: ");
                soCMT = Console.ReadLine();
            } while (soCMT.Trim().Length == 0 || soCMT.Trim().Length > 10);
            TGmua = DateTime.Now.ToString("dd/MM/yyyy");
            do
            {
                Console.Write("\tSố lần ghé thăm cửa hàng:");
                SoLanGheTham1 = int.Parse(Console.ReadLine());
            } while (SoLanGheTham1 < 1);
        }
        public string CapDo()
        {
            if(SoLanGheTham1 >= 3)
            {
                Cap1 = "Thân thiết";
            }
            else
            {
                Cap1 = "Thông thường";
            }
            return Cap1;
        }
        public void Show()
        {
            Console.WriteLine("\t\t║  {0,-4} | {1,-16} | {2,-9} | {3,-10} | {4,-9} | {5,-10} |  {6}    | {7,13}    ║", Makh1, Hoten1, Diachi1, SoDt1, SoCMT, TGmua1, SoLanGheTham1, CapDo());
        }
        public override string ToString()
        {
            return this.Makh
                + "#" + this.Hoten
                + "#" + this.Diachi
                + "#" + this.SoDt
                + "#" + this.soCMT
                + "#" + this.TGmua
                + "#" + this.SoLanGheTham1;
        }
    }
    public class DSKhachHang
    {
        private static String FILE_NAME = "KhachHang.txt"; //File text lưu thông tin các nhân viên
        public List<KhachHang> dskhachhang;
        public void Readfile()
        {
            string filepath = "KhachHang.txt";
            dskhachhang = new List<KhachHang>();
            try
            {
                StreamReader sr = File.OpenText(filepath);
                string a;
                while ((a = sr.ReadLine()) != null)
                {
                    KhachHang b = new KhachHang();
                    string[] c = a.Split('#');
                    b.Makh1 = c[0];
                    b.Hoten1 = c[1];
                    b.Diachi1 = c[2];
                    b.SoDt1 = c[3];
                    b.SoCMT = c[4];
                    b.TGmua1 = c[5];
                    b.SoLanGheTham1 =int.Parse( c[6]);
                    dskhachhang.Add(b);
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void HienThiCapDo()
        {
            KhachHang k = new KhachHang();
            for (int i = 0; i < dskhachhang.Count; i++)
            {
                if (dskhachhang[i].SoLanGheTham1 >= 3)
                {
                    k.Cap1 = "Thân Thiết";
                }
                else
                {
                    k.Cap1 = "Thông Thường";
                }
            }
        }
        public void Show()
        {
            Readfile();
            Console.WriteLine();
            Console.WriteLine();
            Readfile();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t          ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌");
            Console.WriteLine("\t\t\t\t\t\t          ▐  THÔNG TIN KHÁCH HÀNG  ▌");
            Console.WriteLine("\t\t\t\t\t\t          ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌");
            Console.WriteLine();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║  idKH  |     Name         |  Address  |  PhoneNum  |  IDNum    |   Date     |Visits |      Level       ║");
            Console.WriteLine("\t\t║════════════════════════════════════════════════════════════════════════════════════════════════════════║");
            foreach (KhachHang a in dskhachhang)
            {
                a.Show();
                Console.WriteLine("\t\t║--------------------------------------------------------------------------------------------------------║");
            }
            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void TimKiemMaKH()
        {
            string ma1;
            int f = 0;
            Readfile();
            Show();
            do
            {
                Console.Write("\t\tNhập mã khách hàng bạn muốn tìm: ");
                ma1 = Console.ReadLine();
                if(ma1=="")
                    Console.WriteLine("Nhập lại");
            } while (ma1 == "");
            for (int i = 0; i < dskhachhang.Count; i++)
            {
                if (dskhachhang[i].Makh1.CompareTo(ma1) == 0)
                {

                    Console.WriteLine("\t\tThông tin khách hàng có mã bạn cần tìm là: \n");
                    Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║  idKH  |     Name         |  Address  |  PhoneNum  |  IDNum    |   Date     |Visits |      Level       ║");
                    Console.WriteLine("\t\t║════════════════════════════════════════════════════════════════════════════════════════════════════════║");
                    dskhachhang[i].Show();
                    Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                    f = 1;
                }

            }
            if (f == 0)
            {
                Console.WriteLine("Không có nhân viên nào theo mã bạn đã tìm!!");
            }
        }
        public void TimKiemTen()
        {
            Show();
            string ten1;
            do
            {
                Console.Write("\t\tNhập tên khách hàng bạn muốn tìm kiếm: ");
                ten1 = Console.ReadLine();
                if (ten1 == "")
                    Console.WriteLine("Nhập lại");
            } while (ten1 == "");
            int f = 0;
            Console.WriteLine("\t\tThông tin khách hàng có tên gần đúng hoặc đúng với tên bạn cần tìm là: \n");
            for (int i = 0; i < dskhachhang.Count; i++)
            {
                if (dskhachhang[i].Hoten1.IndexOf(ten1) >= 0)
                {
                    f = 1;
                    Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║  idKH  |     Name         |  Address  |  PhoneNum  |  IDNum    |   Date     |Visits |      Level       ║");
                    Console.WriteLine("\t\t║════════════════════════════════════════════════════════════════════════════════════════════════════════║");
                    dskhachhang[i].Show();
                    Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                }
            }
            if (f == 0)
            {
                Console.Write("\t\tKhông có khách hàng nào theo tên bạn đã tìm!!");
            }
        }
        public void GhiTep()
        {
            StreamWriter sw = File.CreateText("KhachHang.txt");
            foreach (KhachHang x in dskhachhang)
            {
                sw.WriteLine(x.ToString());
            }
            sw.Close();
        }
        public bool KTMa(string manv)
        {
            bool validate = false;
            foreach (KhachHang nv in dskhachhang)
            {
                if (manv == nv.Makh1)
                    validate = true;
            }
            return validate;
        }
        public KhachHang TimKhachHang(string maKh)
        {
            foreach (KhachHang kh in dskhachhang)
            {
                if (kh.Makh1.Equals(maKh))
                {
                    return kh;
                }
            }
            return null;
        }
        public void ktADD(String makh, String hoten, String diachi, String sodt, String socmt, String tgmua, int solanghetham)
        {
            if (!File.Exists(FILE_NAME))
            {
                File.Create(FILE_NAME);
            }
            else
            {
                StreamWriter sw = File.AppendText(FILE_NAME);
                sw.WriteLine(makh + "#" + hoten + "#" + diachi + "#" + sodt + "#" + socmt + "#" + tgmua + "#" + solanghetham);
                sw.Close();
            }
        }
        public void Add()
        {
            KhachHang t = new KhachHang();
            DSKhachHang n = new DSKhachHang();
            n.Readfile();
            n.Show();
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tNhập mã khách hàng cần thêm: ");
                t.Makh1 = Console.ReadLine();
                t.Makh1 = t.Makh1.ToUpper();
                if (t.Makh1.Length == 0)
                {
                    Console.WriteLine("Nhập lại: ");
                }
            } while (t.Makh1.Length == 0);
            if (n.KTMa(t.Makh1))
            {
                Console.WriteLine("Mã khách hàng đã tồn tại!");
            }
            else
            {
                t.NhapThem();
                n.ktADD(t.Makh1, t.Hoten1, t.Diachi1, t.SoDt1, t.SoCMT, t.TGmua1, t.SoLanGheTham1);
                Console.WriteLine("Add successfully !!!");
            }
        }
        //=====>Sua thong tin khach hang
        public void Update()
        {

            DSKhachHang n = new DSKhachHang();
            n.Show();
            string maKh;
            do
            {
                Console.WriteLine();

                Console.WriteLine();
                Console.Write("\t\tNhập mã khách hàng cần sửa: ");
                maKh = Console.ReadLine();
                maKh = maKh.ToUpper();
                if (maKh.Length == 0)
                {
                    Console.WriteLine("Nhập lại!!!");
                }
            } while (maKh.Length == 0);
            if (TimKhachHang(maKh) != null)
            {
                TimKhachHang(maKh).NhapThem();
                GhiTep();
                Console.WriteLine("Update successfully !!!");
                Console.WriteLine();
                Console.WriteLine("Khách hàng sau khi update xong: ");
                Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║  idKH  |     Name         |  Address  |  PhoneNum  |  IDNum    |   Date     |Visits |      Level       ║");
                Console.WriteLine("\t\t║════════════════════════════════════════════════════════════════════════════════════════════════════════║");
                TimKhachHang(maKh).Show();
                Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
                Console.WriteLine("Không tìm thấy khách hàng cần sửa !!!");
        }
        public void deleteTXT(string maKh)
        {
            /* ta duyệt qua toàn bộ nhân viên trong file
             * nếu gặp nhân viên có mã như vậy ta sẽ bỏ qua
             * và ghi lại toàn bộ file
             */
            StreamWriter sw = File.CreateText(FILE_NAME);
            foreach (KhachHang kh in dskhachhang)
                if (!kh.Makh1.Equals(maKh))
                    sw.WriteLine(kh.ToString());
            sw.Close();
        }
        public void Delete()
        {
            DSKhachHang n = new DSKhachHang();
            n.Show();
            string maKh;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tNhập mã khách hàng muốn xóa: ");
                maKh = Console.ReadLine();
                maKh = maKh.ToUpper();
                if (maKh.Length == 0)
                    Console.WriteLine("Mời nhập lại !");
            } while (maKh.Length == 0);
            if (TimKhachHang(maKh) != null)
            {
                dskhachhang.Remove(TimKhachHang(maKh));
                deleteTXT(maKh);
                Console.WriteLine();
                Console.WriteLine("\t\t\tDelete successfully !");
            }
            else
                Console.WriteLine("\t\t\tKhông tìm thấy khách hàng cần xóa !");
        }
       
    }
}
