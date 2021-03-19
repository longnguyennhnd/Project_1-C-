using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyBanDoTheThao
{
    public class NhaCungCap
    {
        string MaNCC, TenNCC, Diachi, SoDT, Email;
        public NhaCungCap() { }
        public NhaCungCap(string mancc, string tenncc, string diachi, string sodt,string email)
        {
            this.MaNCC1 = mancc;
            this.TenNCC1 = tenncc;
            this.Diachi1 = diachi;
            this.SoDT1 = sodt;
            this.Email1 = email;
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

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string MaNCC1
        {
            get
            {
                return MaNCC;
            }

            set
            {
                MaNCC = value;
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

        public void Nhap()
        {
            do
            {
                Console.Write("Nhập mã nhà cung cấp: ");
                MaNCC = Console.ReadLine().Trim();
            } while (MaNCC.Trim().Length == 0 || MaNCC.Trim().Length > 10);
            do
            {
                Console.Write("Nhập tên nhà cung cấp: ");
                TenNCC = Console.ReadLine();
            } while (TenNCC.Trim().Length == 0 || TenNCC.Trim().Length > 20);

            do
            {
                Console.Write("Nhập địa chỉ: ");
                Diachi = Console.ReadLine();
            } while (Diachi.Trim().Length == 0 || Diachi.Trim().Length > 10);
            do
            {
                Console.Write("Nhập Email: ");
                Email = Console.ReadLine();
            } while (Email.Trim().Length == 0 || Email.Trim().Length > 15);
   
            do
            {
                Console.Write("Nhập số điện thoại: ");
                SoDT = Console.ReadLine();
            } while (SoDT.Trim().Length == 0 || SoDT.Trim().Length > 11);
        }
        public void NhapThem()
        {
            do
            {
                Console.Write("\t\tNhập tên nhà cung cấp: ");
                TenNCC = Console.ReadLine();
            } while (TenNCC.Trim().Length == 0 || TenNCC.Trim().Length > 20);

            do
            {
                Console.Write("\t\tNhập địa chỉ: ");
                Diachi = Console.ReadLine();
            } while (Diachi.Trim().Length == 0 || Diachi.Trim().Length > 10);
            do
            {
                Console.Write("\t\tNhập Email: ");
                Email = Console.ReadLine();
            } while (Email.Trim().Length == 0 || Email.Trim().Length > 25);

            do
            {
                Console.Write("\t\tNhập số điện thoại: ");
                SoDT = Console.ReadLine();
            } while (SoDT.Trim().Length == 0 || SoDT.Trim().Length > 11);
        }
        public void Show()
        {
            Console.WriteLine("\t\t║  {0,-6} | {1,-16} | {2,-10}  |       {3,-24} |  {4,-11}   ║", MaNCC1, TenNCC1, Diachi1, Email1, SoDT1);
        }

        public override string ToString()
        {
            return this.MaNCC1
                + "#" + this.TenNCC1
                + "#" + this.Diachi
                + "#" + this.Email
                + "#" + this.SoDT;
        }
    }
    public class DSNhaCungCap
    {
        private static String FILE_NAME = "NhaCungCap.txt"; //File text lưu thông tin các nhân viên
       public List<NhaCungCap> dsnhacc;
        public void Readfile()
        {
            string filepath = "NhaCungCap.txt";
            dsnhacc = new List<NhaCungCap>();
            try
            {
                StreamReader sr = File.OpenText(filepath);
                string a;
                while ((a = sr.ReadLine()) != null)
                {
                    NhaCungCap b = new NhaCungCap();
                    string[] c = a.Split('#');
                    b.MaNCC1 = c[0];
                    b.TenNCC1 = c[1];
                    b.Diachi1 = c[2];
                    b.Email1 = c[3];
                    b.SoDT1 = c[4];
                    dsnhacc.Add(b);
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
            Console.WriteLine("\n\n\n\t\t\t\t\t          ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌");
            Console.WriteLine("\t\t\t\t\t          ▐  THôNG TIN NHà CUNG Cấp  ▌");
            Console.WriteLine("\t\t\t\t\t          ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌");
            Console.WriteLine();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║  IdNCC  |     Name         |   Address   |              Email             |  PhoneNume     ║");
            Console.WriteLine("\t\t║════════════════════════════════════════════════════════════════════════════════════════════║");
            foreach (NhaCungCap a in dsnhacc)
            {
                a.Show();
                Console.WriteLine("\t\t║--------------------------------------------------------------------------------------------║");
            }
            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void TimKiemMaNCC()
        {

            string ma1;
            int f = 0;
            Readfile();
            Show();
            do
            {
                Console.Write("\t\tNhập mã nhà cung cấp cần tìm: ");
                ma1 = Console.ReadLine();
                if (ma1 == "")
                    Console.WriteLine("\t\tNhập lại");
            } while (ma1 == "");
            for (int i = 0; i < dsnhacc.Count; i++)
            {
                if (dsnhacc[i].MaNCC1.CompareTo(ma1) == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\tThông tin nhà cung cấp đã tìm: \n");
                    Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║  IdNCC  |     Name         |   Address   |              Email             |  PhoneNume     ║");
                    Console.WriteLine("\t\t║════════════════════════════════════════════════════════════════════════════════════════════║");
                    dsnhacc[i].Show();
                    Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();
                    f = 1;
                }

            }
            if (f == 0)
            {
                Console.WriteLine("\t\tKhông có nhà cung cấp nào theo mã bạn đã tìm!!");
            }
        }
        public void TimKiemTen()
        {
            Show();
            string ten1;
            do
            {
                Console.Write("\t\tNhập tên nhà cung cấp bạn muốn tìm: ");
                ten1 = Console.ReadLine();
                if(ten1=="")
                    Console.WriteLine("Nhập lại");
            } while (ten1 == "");
            int f = 0;
            Console.WriteLine("\t\tThông tin danh sách nhà cung cấp có tên đúng hoặc gần đúng với tên bạn đã tìm!! ");
            for (int i = 0; i < dsnhacc.Count; i++)
            {
                if (dsnhacc[i].TenNCC1.IndexOf(ten1) >= 0)
                {
                    f = 1;
                    Console.WriteLine();
                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║  IdNCC  |     Name         |   Address   |              Email             |  PhoneNume     ║");
                    Console.WriteLine("\t\t║════════════════════════════════════════════════════════════════════════════════════════════║");
                    dsnhacc[i].Show();
                    Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();
                }
            }
            if (f == 0)
            {
                Console.Write("\t\tKhông có nhà cung cấp nào co tên bạn đã tìm!!");
            }
        }
        public void GhiTep()
        {
            StreamWriter sw = File.CreateText("NhaCungCap.txt");
            foreach (NhaCungCap x in dsnhacc)
            {
                sw.WriteLine(x.ToString());
            }
            sw.Close();
        }

        public bool KTMa(string mancc)
        {
            bool validate = false;
            foreach (NhaCungCap nv in dsnhacc)
            {
                if (mancc == nv.MaNCC1)
                    validate = true;
            }
            return validate;
        }
        public NhaCungCap TimNhaCungCap(string maNcc)
        {
            foreach (NhaCungCap ncc in dsnhacc)
            {
                if (ncc.MaNCC1.Equals(maNcc))
                {
                    return ncc;
                }
            }
            return null;
        }
        // Thêm Nhân viên
        public void ktADD(String mancc, String tenncc, String diachi, String email, String sodt)
        {
            if (!File.Exists(FILE_NAME))
            {
                File.Create(FILE_NAME);
            }
            else
            {
                StreamWriter sw = File.AppendText(FILE_NAME);
                sw.WriteLine(mancc + "#" + tenncc + "#" + diachi + "#" + email + "#" + sodt);
                sw.Close();
            }
        }
        public void Add()
        {
            NhaCungCap t = new NhaCungCap();
            DSNhaCungCap n = new DSNhaCungCap();
            n.Readfile();
            n.Show();
            do
            {
                Console.Write("\n\t\tNhập mã nhân viên cần thêm: ");
                t.MaNCC1 = Console.ReadLine();
                t.MaNCC1 = t.MaNCC1.ToUpper();
                if (t.MaNCC1.Length == 0)
                {
                    Console.WriteLine("Nhập lại: ");
                }
            } while (t.MaNCC1.Length == 0);
            if (n.KTMa(t.MaNCC1))
            {
                Console.WriteLine("Mã nhân viên đã tồn tại! Nhập lại");
            }
            else
            {
                t.NhapThem();
                n.ktADD(t.MaNCC1, t.TenNCC1, t.Diachi1, t.Email1, t.SoDT1);
                Console.WriteLine("Add Successfully !!!");
            }
        }
        public void Update()
        {

            DSNhaCungCap n = new DSNhaCungCap();
            n.Show();
            string mancc;
            do
            {
                Console.Write("\n\t\tNhập mã nhà cung cấp cần sửa: ");
                mancc = Console.ReadLine();
                mancc = mancc.ToUpper();
                if (mancc.Length == 0)
                {
                    Console.WriteLine("Nhập lại!!!");
                }
            } while (mancc.Length == 0);
            if (TimNhaCungCap(mancc) != null)
            {
                TimNhaCungCap(mancc).NhapThem();
                GhiTep();
                Console.WriteLine("Update successfully !!!");
                Console.WriteLine();
                Console.WriteLine("Nhân viên sau khi update xong: ");
                Console.WriteLine();
                TimNhaCungCap(mancc).Show();
            }
            else
                Console.WriteLine("Không tìm thấy nhà cung cấp cần sửa !!!");
        }
        public void deleteTXT(string maNcc)
        {
            /* ta duyệt qua toàn bộ nhân viên trong file
             * nếu gặp nhân viên có mã như vậy ta sẽ bỏ qua
             * và ghi lại toàn bộ file
             */
            StreamWriter sw = File.CreateText(FILE_NAME);
            foreach (NhaCungCap nv in dsnhacc)
                if (!nv.MaNCC1.Equals(maNcc))
                    sw.WriteLine(nv.ToString());
            sw.Close();
        }
        public void Delete()
        {
            DSNhaCungCap n = new DSNhaCungCap();
            n.Show();
            string maNcc;
            do
            {
                Console.Write("\n\t\tNhập mã nhà cung cấp muốn xóa: ");
                maNcc = Console.ReadLine();
                maNcc = maNcc.ToUpper();
                if (maNcc.Length == 0)
                    Console.WriteLine("Mời nhập lại !");
            } while (maNcc.Length == 0);
            if (TimNhaCungCap(maNcc) != null)
            {
                dsnhacc.Remove(TimNhaCungCap(maNcc));
                deleteTXT(maNcc);
                Console.WriteLine();
                Console.WriteLine("Xóa Thành Công !");
            }
            else
                Console.WriteLine("Không tìm thấy nhà cung cấp cần xóa !");
        }
    }
}
