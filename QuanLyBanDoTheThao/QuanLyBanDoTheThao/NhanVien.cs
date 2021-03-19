using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyBanDoTheThao
{
    public class Nhanvien
    {
        string Manv, Hoten, Diachi, NamSinh, Gioitinh, Chucvu, Sodt;
        public Nhanvien(){}
        public Nhanvien(string manv, string hoten, string gioitinh, string namsinh, string chucvu, string diachi, string sodt)
        {
            Manv1 = manv;
            Hoten1 = hoten;
            Diachi = diachi;
            Gioitinh1 = gioitinh;
            NamSinh1 = namsinh;
            Chucvu1 = chucvu;
            Sodt1 = sodt;
        }

        public string Chucvu1
        {
            get
            {
                return Chucvu;
            }

            set
            {
                Chucvu = value;
            }
        }



        public string Gioitinh1
        {
            get
            {
                return Gioitinh;
            }

            set
            {
                Gioitinh = value;
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

        public string Manv1
        {
            get
            {
                return Manv;
            }

            set
            {
                Manv = value;
            }
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

        public string Sodt1
        {
            get
            {
                return Sodt;
            }

            set
            {
                Sodt = value;
            }
        }

        public string NamSinh1
        {
            get
            {
                return NamSinh;
            }

            set
            {
                NamSinh = value;
            }
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap ma nhan vien: ");
                Manv1 = Console.ReadLine().Trim();
            } while (Manv1.Trim().Length == 0 || Manv1.Trim().Length > 10);
            do
            {
                Console.Write("Nhap ten nhan vien: ");
                Hoten1 = Console.ReadLine();
            } while (Hoten1.Trim().Length == 0 || Hoten1.Trim().Length > 20);

            do
            {
                Console.Write("Nhap gioi tinh: ");
                Gioitinh1= Console.ReadLine();
            } while (Gioitinh1.Trim().Length == 0 || Gioitinh1.Trim().Length > 5);
            do
            {
                Console.Write("Nhap nam sinh: ");
                NamSinh1 = Console.ReadLine();
            } while (NamSinh1.Trim().Length == 0 || NamSinh1.Trim().Length > 5);
            do
            {
                Console.Write("Nhap chuc vu nhan vien: ");
                Chucvu = Console.ReadLine();
            } while (Chucvu.Trim().Length == 0 || Chucvu.Trim().Length > 10);
            do
            {
                Console.Write("Nhap dia chi: ");
                Diachi = Console.ReadLine().Trim();
            } while (Diachi1.Trim().Length == 0 || Diachi1.Trim().Length > 10);
            do
            {
                Console.Write("Nhap so dien thoai: ");
                Sodt = Console.ReadLine();
            } while (Sodt.Trim().Length == 0 || Sodt.Trim().Length > 11);
        }
        public void NhapThem()
        {
            do
            {
                Console.Write("\tNhập tên nhân viên: ");
                Hoten1 = Console.ReadLine();
            } while (Hoten1.Trim().Length == 0 || Hoten1.Trim().Length > 20);

            do
            {
                Console.Write("\tGiới tính: ");
                Gioitinh1 = Console.ReadLine();
            } while (Gioitinh1.Trim().Length == 0 || Gioitinh1.Trim().Length > 10);
            do
            {
                Console.Write("\tNăm sinh: ");
                NamSinh1 = Console.ReadLine();
            } while (NamSinh1.Trim().Length == 0 || NamSinh1.Trim().Length > 5);
            do
            {
                Console.Write("\tChức vụ: ");
                Chucvu = Console.ReadLine();
            } while (Chucvu.Trim().Length == 0 || Chucvu.Trim().Length > 10);
            do
            {
                Console.Write("\tĐịa chỉ: ");
                Diachi = Console.ReadLine().Trim();
            } while (Diachi.Trim().Length == 0 || Diachi.Trim().Length > 10);
            do
            {
                Console.Write("\tSố điện thoại: ");
                Sodt = Console.ReadLine();
            } while (Sodt.Trim().Length == 0 || Sodt.Trim().Length > 11);
        }
        public void Show()
        {
            Console.WriteLine("\t\t  ║   {0,-4} | {1,-15} |  {2,-7} | {3,-7} |  {4,-9}|  {5,-9}| {6,-11}   ║", Manv1, Hoten1, Gioitinh1, NamSinh1, Chucvu1, Diachi1, Sodt);
        }

        public override string ToString()
        {
            return this.Manv
                + "#" + this.Hoten
                + "#" + this.NamSinh
                + "#" + this.Gioitinh
                + "#" + this.Chucvu
                + "#" + this.Sodt
                + "#" + this.Diachi;
        }
    }
    public class DSNhanvien
    {
        private static String FILE_NAME = "NhanVien.txt"; //File text lưu thông tin các nhân viên
        List<Nhanvien> dsnhanvien;
        public void Readfile()
        {
            string filepath = "NhanVien.txt";
            dsnhanvien = new List<Nhanvien>();
            try
            {
                StreamReader sr = File.OpenText(filepath);
                string a;
                while ((a = sr.ReadLine()) != null)
                {
                    Nhanvien b = new Nhanvien();
                    string[] c = a.Split('#');
                    b.Manv1 = c[0];
                    b.Hoten1 = c[1];
                    b.Gioitinh1 = c[2];
                    b.NamSinh1 = c[3];
                    b.Chucvu1 = c[4];
                    b.Diachi1 = c[5];
                    b.Sodt1 = c[6];
                    dsnhanvien.Add(b);
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void Show()
        {
            Readfile();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n\n\n\t\t\t\t\t          ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌");
            Console.WriteLine("\t\t\t\t\t          ▐  THÔNG TIN NHÂN VIÊN  ▌");
            Console.WriteLine("\t\t\t\t\t          ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌");
            Console.WriteLine("\t\t  ╔═══════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t  ║  idNV  |       Name      |    Sex   |  YofB   |  Position |  Address  |   PhoneNumes  ║");
            Console.WriteLine("\t\t  ║═══════════════════════════════════════════════════════════════════════════════════════║");
            foreach (Nhanvien a in dsnhanvien)
            {
                a.Show();
                Console.WriteLine("\t\t  ║---------------------------------------------------------------------------------------║");
            }
            Console.WriteLine("\t\t  ╚═══════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void TimKiemMaNV()
        {
            
            string ma1;
            int f = 0;
            Readfile();
            Show();
            do
            {
                Console.Write("\t\tNhập mã nhân viên bạn cần tìm: ");
                ma1 = Console.ReadLine();
                if (ma1 == "")
                    Console.WriteLine("Nhập lại");
            } while (ma1 == "");
            for (int i = 0; i < dsnhanvien.Count; i++)
            {
                if (dsnhanvien[i].Manv1.CompareTo(ma1) == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\tThông tin nhân viên có mã bạn cần tìm: \n");
                    Console.WriteLine("\t\t  ╔═══════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t  ║  idNV  |       Name      |    Sex   |  YofB   |  Position |  Address  |   PhoneNumes  ║");
                    Console.WriteLine("\t\t  ║═══════════════════════════════════════════════════════════════════════════════════════║");
                    dsnhanvien[i].Show();
                    Console.WriteLine("\t\t  ╚═══════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();
                    f = 1;
                }

            }
            if (f == 0)
            {
                Console.WriteLine("\t\tKhông có nhân viên nào có mã bạn đã tìm!!");
            }
        }
        public void TimKiemTen()
        {
            Show();
            string ten1;
            do
            {
                Console.Write("\t\tNhập tên nhân viên bạn cần tìm: ");
                ten1 = Console.ReadLine();
                if (ten1 == "")
                    Console.WriteLine("\t\tNhập lại");
            } while (ten1 == "");
            int f = 0;
            Console.WriteLine("\t\tThông tin danh sách nhân viên có tên gần đúng với tên bạn tìm!! ");
            Console.WriteLine();
            Console.WriteLine();
            
            for (int i = 0; i < dsnhanvien.Count; i++)
            {
                if (dsnhanvien[i].Hoten1.IndexOf(ten1) >= 0)
                {
                    f = 1;
                    Console.WriteLine("\t\t  ╔═══════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t  ║  idNV  |       Name      |    Sex   |  YofB   |  Position |  Address  |   PhoneNumes  ║");
                    Console.WriteLine("\t\t  ║═══════════════════════════════════════════════════════════════════════════════════════║");
                    dsnhanvien[i].Show();
                    Console.WriteLine("\t\t  ╚═══════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();
                }
            }
            
            if (f == 0)
            {
                Console.Write("\t\tKhông có nhân viên nào có tên như bạn đã tìm kiếm!!");
            }
        }
        public void TimKiemChucVu()
        {
            Show();
            string chucvu;
            do
            {
                Console.Write("\t\tNhập chức vụ nhân viên bạn muốn tìm: ");
                chucvu = Console.ReadLine();
                if(chucvu=="")
                    Console.WriteLine("\t\tNhập lại");
            } while (chucvu == "");
            int f = 0;
            for (int i = 0; i < dsnhanvien.Count; i++)
            {
                if (dsnhanvien[i].Chucvu1.IndexOf(chucvu) >= 0)
                {
                    f = 1;
                    Console.WriteLine();
                    Console.WriteLine("\t\tThông tin nhân viên có chức vụ bạn cần tìm là!! ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t  ╔═══════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t  ║  idNV  |       Name      |    Sex   |  YofB   |  Position |  Address  |   PhoneNumes  ║");
                    Console.WriteLine("\t\t  ║═══════════════════════════════════════════════════════════════════════════════════════║");
                    //Console.WriteLine();
                    dsnhanvien[i].Show();
                    Console.WriteLine("\t\t  ╚═══════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();
                }
            }
            if (f == 0)
            {
                Console.Write("Không có nhân viên nào theo chức vụ bạn cần tìm!!");
            }
        }
        public void GhiTep()
        {
            StreamWriter sw = File.CreateText("NhanVien.txt");
            foreach (Nhanvien x in dsnhanvien)
            {
                sw.WriteLine(x.ToString());
            }
            sw.Close();
        }

        public bool KTMa(string manv)
        {
            bool validate = false;
            foreach (Nhanvien nv in dsnhanvien)
            {
                if (manv == nv.Manv1)
                    validate = true;
            }
            return validate;
        }
        public Nhanvien TimNhanVien(string maNv)
        {
            foreach (Nhanvien nv in dsnhanvien)
            {
                if (nv.Manv1.Equals( maNv))
                {
                    return nv;
                }
            }
            return null;
        }
        // Thêm Nhân viên
        public void ktADD(String MaNV, String hoten, String gioitinh, String namsinh, String chucvu, String diachi, String sodt)
        {
            if (!File.Exists(FILE_NAME))
            {
                File.Create(FILE_NAME);
            }
            else
            {
                StreamWriter sw = File.AppendText(FILE_NAME);
                sw.WriteLine(MaNV + "#" + hoten + "#" + gioitinh + "#" + namsinh + "#" + chucvu + "#" + diachi + "#" + sodt);
                sw.Close();
            }
        }
        public void Add()
        {
            Nhanvien t = new Nhanvien();
            DSNhanvien n = new DSNhanvien();
            n.Readfile();
            n.Show();
            do
            {
                Console.Write("\n\n\t\tNhập mã nhân viên muốn thêm: ");
                t.Manv1 = Console.ReadLine();
                t.Manv1 = t.Manv1.ToUpper();
                if (t.Manv1.Length == 0)
                {
                    Console.WriteLine("Mời nhập lại: ");
                }
            } while (t.Manv1.Length == 0);
            if (n.KTMa(t.Manv1))
            {
                Console.WriteLine("Mã nhân viên đã tồn tại! Mời nhập lại!");
            }
            else
            {
                t.NhapThem();
                n.ktADD(t.Manv1, t.Hoten1, t.Gioitinh1, t.NamSinh1, t.Chucvu1, t.Diachi1, t.Sodt1);
                Console.WriteLine("Add Successfully !!!");
            }
        }
        public void Update()
        {

            DSNhanvien n = new DSNhanvien();
            n.Show();
            string maNv;
            do
            {
                Console.Write("\n\n\t\tNhập mã nhân viên cần sửa: ");
                maNv = Console.ReadLine();
                maNv = maNv.ToUpper();
                if (maNv.Length == 0)
                {
                    Console.WriteLine("Nhập lại!!!");
                }
            } while (maNv.Length == 0);
            if (TimNhanVien(maNv) != null)
            {
                TimNhanVien(maNv).NhapThem();
                GhiTep();
                Console.WriteLine("Update successfully !!!");
                Console.WriteLine();
                Console.WriteLine("Nhân viên sau khi update xong: ");
                Console.WriteLine();
                Console.WriteLine("\t\t  ╔═══════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t  ║  idNV  |       Name      |    Sex   |  YofB   |  Position |  Address  |   PhoneNumes  ║");
                Console.WriteLine("\t\t  ║═══════════════════════════════════════════════════════════════════════════════════════║");
                TimNhanVien(maNv).Show();
                Console.WriteLine("\t\t  ╚═══════════════════════════════════════════════════════════════════════════════════════╝");
            }
            else
                Console.WriteLine("Không tìm thấy nhân viên cần sửa !!!");
        }
        public void deleteTXT(string maNv)
        {
                /* ta duyệt qua toàn bộ nhân viên trong file
                 * nếu gặp nhân viên có mã như vậy ta sẽ bỏ qua
                 * và ghi lại toàn bộ file
                 */
                StreamWriter sw = File.CreateText(FILE_NAME);
                foreach (Nhanvien nv in dsnhanvien)
                    if (!nv.Manv1.Equals(maNv))
                        sw.WriteLine(nv.ToString());
                sw.Close();
            }
        public void Delete()
        {
            DSNhanvien n = new DSNhanvien();
            n.Show();
            string maNv;
            do
            {
                Console.Write("\n\n\t\tNhập mã nhân viên muốn xóa: ");
                maNv = Console.ReadLine();
                maNv = maNv.ToUpper();
                if (maNv.Length == 0)
                    Console.WriteLine("Mời nhập lại !");
            } while (maNv.Length == 0);
            if (TimNhanVien(maNv) != null)
            {
                dsnhanvien.Remove(TimNhanVien(maNv));
                deleteTXT(maNv);
                Console.WriteLine();
                Console.WriteLine("Xóa Thành Công !");
            }
            else
                Console.WriteLine("Không tìm thấy nhân viên cần xóa !");
        }
    }
}
