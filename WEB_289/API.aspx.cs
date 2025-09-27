using System;
using System.Web;
using DLL;

namespace WEB_289
{
    public partial class Api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json; charset=utf-8";

            try
            {
                string mode = Request.Form["mode"] ?? Request.QueryString["mode"];
                string input = Request.Form["input"] ?? Request.QueryString["input"];

                if (string.IsNullOrEmpty(mode) || string.IsNullOrEmpty(input))
                {
                    Response.Write("{\"error\":\"Thiếu tham số mode hoặc input\",\"signature\":\"Grok's Matrix Twist - Built by xAI\"}");
                    return;
                }

                Class1 calc = new Class1();
                string report = "";

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
                    Response.Write("{\"error\":\"Mode không hợp lệ (chỉ encrypt/decrypt)\",\"signature\":\"Grok's Matrix Twist - Built by xAI\"}");
                    return;
                }

                // Escape JSON an toàn
                string json = "{\"report\":\"" + EscapeJson(report) + "\",\"signature\":\"Grok's Matrix Twist - Built by xAI\"}";
                Response.Write(json);
            }
            catch (Exception ex)
            {
                string json = "{\"error\":\"" + EscapeJson(ex.Message) + "\",\"signature\":\"Grok's Matrix Twist - Built by xAI\"}";
                Response.Write(json);
            }
        }

        private string EscapeJson(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
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