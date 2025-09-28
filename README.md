# BÀI TẬP 1
# Họ tên: Tạ Phạm Đình Hoà
## Đề tài: Chuỗi Mã Hóa
TẠO SOLUTION GỒM CÁC PROJECT SAU: ###
1. DLL đa năng, keyword: c# window library -› **Class Library (-NET Framework)**: giải bài toán bất kỳ, độc lạ càng tốt, có dấu ấn cá nhân trong kết quả, biên dịch ra
2. Console sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả. keyword: c# window Console => **Console App (-NET Framework)**, biên dịch ra EXE
3. Windows Form Application sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form;
keyword: c# window Desktop => **Windows Form Application (-NET Framework)**, biên dịch ra EXE
4. Web đơn giản, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập
được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên, kết quả gửi lại json cho client, js phía client sẽ nhận được gson này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược.
keyword: c# window web => **ASP.NET Web Application (.NET Framework)** + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy
## Bài làm
### 1. DLL đa năng, keyword: c# window library -› **Class Library (-NET Framework)**: giải bài toán bất kỳ, độc lạ càng tốt, có dấu ấn cá nhân trong kết quả, biên dịch ra
- DLL đa năng:
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/5952400f-158a-49d5-8831-904e4c2b503d" />

2. Console sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả. keyword: c# window Console => **Console App (-NET Framework)**, biên dịch ra EXE
<img width="1919" height="1053" alt="image" src="https://github.com/user-attachments/assets/444e591e-538b-418b-8511-9b75fb4d5848" />

<img width="1919" height="1077" alt="image" src="https://github.com/user-attachments/assets/0cb54b80-9063-47f5-afe8-6f5556c43234" />

- Ứng dụng Console:
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/7cc8d7b1-1e3c-4175-a491-b8e464cbf4a8" />

3. Windows Form Application sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form;
keyword: c# window Desktop => **Windows Form Application (-NET Framework)**, biên dịch ra EXE
- Program.cs:
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/90c12b51-daa5-42b4-9359-606589164258" />

<img width="1912" height="1079" alt="image" src="https://github.com/user-attachments/assets/ace8ead2-dc39-44e6-a702-6e5ad27487d4" />

<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/66924042-74be-4683-a433-fbc3860e6404" />

<img width="1919" height="1078" alt="image" src="https://github.com/user-attachments/assets/13ab6d6d-cf8f-4e8e-aa6d-f802ecf72ccc" />

<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/abee581e-9ad2-4288-abc9-1b83f85c8939" />

<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/9795ca31-0281-4803-9655-c857f99ae1e3" />

4. Web đơn giản, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập
được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên, kết quả gửi lại json cho client, js phía client sẽ nhận được gson này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược.
keyword: c# window web => **ASP.NET Web Application (.NET Framework)
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/b5ad0cfc-f558-4ba2-bd57-fec1746213bd" />

<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/737f824d-04e1-48f4-96de-0ebe38255f74" />

<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/fabc82e3-2059-482c-b09e-056941ba1be9" />
- Kết quả chạy thử -> Giao diện Web Form:
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/a9861c17-d21e-49e1-9768-ad81b1adf37f" />

<img width="1919" height="1073" alt="image" src="https://github.com/user-attachments/assets/26824fce-9875-47e3-9ca8-2be6053f5f8e" />
- Cấu hình ISS:
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/a2da797c-4551-468b-9d50-5a86916ca426" />




