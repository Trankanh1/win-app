using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;
using System.Data.SQLite;


namespace QuanLyBanHang.Class
{
    class functions

    {

        public static SQLiteConnection conn;
        public static string connstring;

        public static void connect()
        {
            connstring = @"Data Source=quanlybanhang.db;";
            conn = new SQLiteConnection(connstring, true );
            conn.ConnectionString = connstring;
            conn.Open();
        }

        public static void disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        public static DataTable GetDataTable(string sql)
        {
          

            DataTable table = new DataTable();
            SQLiteDataAdapter Mydata = new SQLiteDataAdapter();   // Khai báo
                                                            //Tạo đối tượng Command thực hiện câu lệnh SELECT        
            Mydata.SelectCommand = new SQLiteCommand();
            Mydata.SelectCommand.Connection = functions.conn; 	// Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql; // Gán câu lệnh SELECT
                                                    // Khai báo DataTable nhận dữ liệu trả về
            Mydata.Fill(table); 	//Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
            return table;

        }
        public static bool checkkey(string sql)
        {
            SQLiteDataAdapter mydata = new SQLiteDataAdapter(sql, functions.conn);
            DataTable table = new DataTable();

            mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;

            else
                return false;

        }
        public static void runsql(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = functions.conn;
            cmd.CommandText = sql;
         
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;

        }
        public static string getfieldvalues(string sql)
        {
          
            string ma = "";
            SQLiteCommand cmd = new SQLiteCommand(sql, Class.functions.conn);
            SQLiteDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static void fillcombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SQLiteDataAdapter Mydata = new SQLiteDataAdapter(sql, Class.functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;    // Truong gia tri
            cbo.DisplayMember = ten;    // Truong hien thi
        }



        public static string chuyensosangchu(string sNumber)
        {
            //int mlen, mdigit;
            //string mtemp = "";
            //string[] mnumtext;
            //snummber = snummber.Replace(",", "");
            //mnumtext = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            //mlen = snummber.Length - 1;
            //for (int i = 0; i <= mlen; i++)
            //{
            //    mdigit = Convert.ToInt32(snummber.Substring(i, 1));
            //    mtemp = mtemp + " " + mnumtext[mdigit];
            //    if (mlen == 1)
            //        break;
            //    switch ((mlen - 1) % 9)
            //    {
            //        case 0:
            //            mtemp = mtemp + "tỷ";
            //            if (snummber.Substring(i + 1, 3) == "000")
            //                i = i + 3;
            //            if (snummber.Substring(i + 1, 3) == "000")
            //                i = i + 3;
            //            if (snummber.Substring(i + 1, 3) == "000")
            //                i = i + 3;
            //            break;
            //        case 6:
            //            mtemp = mtemp + "triệu";
            //            if (snummber.Substring(i + 1, 3) == "000")
            //                i = i + 3;
            //            if (snummber.Substring(i + 1, 3) == "000")
            //                i = i + 3;

            //            break;
            //        case 3:
            //            mtemp = mtemp + "nghìn";
            //            if (snummber.Substring(i + 1, 3) == "000")
            //                i = i + 3;
            //            break;
            //        default:
            //            switch ((mlen - 1) % 3)
            //            {
            //                case 2:
            //                    mtemp = mtemp + "trăm";
            //                    break;
            //                case 1:
            //                    mtemp = mtemp + "mươi";
            //                    break;

            //            }
            //            break;
            //    }
            //}
            //mtemp = mtemp.Replace("không mươi không ", "");
            //mtemp = mtemp.Replace("không mươi không ", "");
            //mtemp = mtemp.Replace("không mươi ", "linh");
            //mtemp = mtemp.Replace("mươi không", "mươi");
            //mtemp = mtemp.Replace("một mươi", "mười");
            //mtemp = mtemp.Replace("mươi bốn", "mươi tư");
            //mtemp = mtemp.Replace("linh bốn", "linh tư");
            //mtemp = mtemp.Replace("mươi năm", "mươi lăm");
            //mtemp = mtemp.Replace("mươi một", "mươi mốt");
            //mtemp = mtemp.Replace("mười năm", "mười lăm");
            //mtemp = mtemp.Trim();


            //mtemp = mtemp.Substring(0, 1).ToUpper() + mtemp.Substring(1) + "đồng";
            //return mtemp;
            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            //Xóa các dấu "," nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // trừ 1 vì thứ tự đi từ 0
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if (mLen == i) // Chữ số cuối cùng không cần xét tiếp
                    break;
                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỷ";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mươi";
                                break;
                        }
                        break;
                }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", "");
            //Loại bỏ trường hợp 00x
            mTemp = mTemp.Replace("không mươi ", "linh ");
            //Loại bỏ trường hợp x0, x>=2
            mTemp = mTemp.Replace("mươi không", "mươi");
            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mươi", "mười");
            //Fix trường hợp x4, x>=2
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            //Fix trường hợp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            //Fix trường hợp x5, x>=2
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            //Fix trường hợp x1, x>=2
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            //Fix trường hợp x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            //Bỏ ký tự space
            mTemp = mTemp.Trim();
            //Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;

        }
        public static string ConvertdateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

        public static string createkey(string tiento)
        {
            string key = tiento;
            string[] parstday;
            parstday = DateTime.Now.ToShortDateString().Split('/');
            string d = String.Format("{0}{1}{2}", parstday[0], parstday[1], parstday[2]);
            key = key + d;
            string[] partstime;
            partstime = DateTime.Now.ToLongTimeString().Split(':');
            if (partstime[2].Substring(3, 2) == "PM")
                partstime[0] = Converttimeto24(partstime[0]);
            if (partstime[2].Substring(3, 2) == "AM")
                if (partstime[0].Length == 1)
                    partstime[0] = "0" + partstime[0];
            partstime[2] = partstime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partstime[0], partstime[1], partstime[2]);
            key = key + t;
            return key;
        }
        public static string Converttimeto24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;

            }
            return h;
        }
        public static byte[] ConvertImageToByte(string filePath)
        {
            try
            {
                FileStream objStream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
                BinaryReader objReader = new BinaryReader(objStream);
                byte[] byImages = objReader.ReadBytes((int)objStream.Length);

                objReader.Close();
                objStream.Close();

                return byImages;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }
        public static Image ConvertByteToImage(byte[] byImages)
        {
            MemoryStream objMStream;
            try
            {
                objMStream = new MemoryStream(byImages);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return Image.FromStream(objMStream);
        }

    }
}
