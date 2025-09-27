using System;
using System.Text;
using System.Web;
using DLL;

namespace WEB
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Đặt content type cho response là JSON
            Response.ContentType = "application/json; charset=utf-8";

            try
            {
                // Lấy tham số mode và input từ POST hoặc GET
                string mode = Request.Form["mode"] ?? Request.QueryString["mode"];
                string input = Request.Form["input"] ?? Request.QueryString["input"];

                // Kiểm tra tham số đầu vào
                if (string.IsNullOrEmpty(mode) || string.IsNullOrEmpty(input))
                {
                    WriteJson("{\"error\":\"Thiếu tham số mode hoặc input\",\"signature\":\"Phạm Hòa - Matrix Twist\"}");
                    return;
                }

                // Tạo instance của Class1 từ DLL
                Class1 calc = new Class1();
                string report = "";

                // Xử lý theo mode
                if (mode.ToLower() == "encrypt")
                {
                    calc.PlainText = input;
                    calc.Encrypt();
                    report = calc.CipherText;
                }
                else if (mode.ToLower() == "decrypt")
                {
                    calc.CipherText = input;
                    calc.Decrypt();
                    report = calc.DecryptedText;
                }
                else
                {
                    WriteJson("{\"error\":\"Mode không hợp lệ (chỉ encrypt/decrypt)\",\"signature\":\"Phạm Hòa - Matrix Twist\"}");
                    return;
                }

                // Trả về JSON với kết quả
                string json = "{\"report\":\"" + EscapeJson(report) + "\",\"signature\":\"Phạm Hòa - Matrix Twist\"}";
                WriteJson(json);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi từ DLL hoặc server
                string json = "{\"error\":\"" + EscapeJson(ex.Message) + "\",\"signature\":\"Phạm Hòa - Matrix Twist\"}";
                WriteJson(json);
            }
        }


        private void WriteJson(string json)
        {
            Response.Clear();
            Response.Write(json);
            Response.Flush();
            HttpContext.Current.ApplicationInstance.CompleteRequest(); 
        }

        private string EscapeJson(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                switch (c)
                {
                    case '"': sb.Append("\\\""); break;
                    case '\\': sb.Append("\\\\"); break;
                    case '\b': sb.Append("\\b"); break;
                    case '\f': sb.Append("\\f"); break;
                    case '\n': sb.Append("\\n"); break;
                    case '\r': sb.Append("\\r"); break;
                    case '\t': sb.Append("\\t"); break;
                    default: sb.Append(c); break;
                }
            }
            return sb.ToString();
        }
    }
}
