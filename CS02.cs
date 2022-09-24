// Biến, hằng số, kiểu dữ liệu và nhập xuất dữ liệu terminal console

using System;

namespace CS02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kieu_du_lieu Ten_bien;
            string studentName = "abc"; //Kiểu chuỗi

            int studentAge; //Kiểu số nguyên

            char a; //Ký tự

            bool b; //True or False

            double q = 3.14;

            float c; //Số thực
            c = 16.6f;
            // c = float(16.6);

            object d; //Đối tượng
            d = studentName; //Chú ý phải gán giá trị cho studentName = "abc";

            // Ex1:
            string studentName2 = "ThieuTranCuong"; //Gán thẳng
            int studentAge2 = 20;


            // Ex2;
            Console.WriteLine("Hello Kitty");

            // Console.Clear(); // Xoá sạch dữ liệu

            // Ex3:
            Console.WriteLine("Nhập a: ");
            Console.ReadKey();

            // Ex4:
            Console.Write("Vui lòng nhập họ và tên: ");
            string hoVaTen = Console.ReadLine();
            Console.WriteLine("Xin chào {0}", hoVaTen);


            // Ex5:
            float num1, num2;
            string sInput;

            Console.WriteLine("Input Num1: ");
            sInput = Console.ReadLine();
            num1 = float.Parse(sInput); //Chuyển chuỗi sInput thành số thực sInput (ép kiểu)
            // num1 = Convert.ToSingle(sInput);  //Cách 2


            Console.WriteLine("Input Num2: ");
            sInput = Console.ReadLine();
            num2 = float.Parse(sInput); //Chuyển chuỗi sInput thành số thực sInput (ép kiểu)
            // num2 = Convert.ToSingle(sInput); //Cách 2

            Console.WriteLine("So num1 = {0}, num2 = {1}", num1, num2);


            // Ex6:
            // Khai báo biến ngầm định
            var k = 1;
            // Nếu gán k = 1 là kiểu số nguyên thì sẽ là số nguyên
            // Tương tự như string, float, double, bool,...

            // Ex7:
            // Hằng số
            const double SO_PI = 3.14;
            const string NAME = "CuongThieu";


        }
    }
}

//Note!
// Console.WriteLine() dữ liệu xuất ra thì xuống dòng (Chủ yếu hay dùng)
// Console.Write() dữ liệu xuất ra không xuống dòng
// ReadKey(): Trương trình sẽ dừng lại và chờ người dùng bấm vào phím bất kì để chạy tiếp 
// ReadLine(): Truòng trình sẽ dừng lại và chờ người dùng nhập vào 1 dòng bất kì và nhấn Enter

// https://freetuts.net/chuyen-doi-kieu-du-lieu-trong-c-sharp-1064.html
