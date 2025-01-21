# 🌐 Excersie2: Web Service và Ứng dụng WinForms

## 📝 Mô tả dự án

Dự án này bao gồm hai phần chính:

1. **CalculatorWS**: Một dịch vụ web cung cấp thông tin về quốc gia và thành phố.
2. **WinformWorld**: Một ứng dụng Windows Forms tiêu thụ dịch vụ web trên để hiển thị thông tin quốc gia và thành phố.

## 📂 Cấu trúc dự án

### CalculatorWS:
- **Data**: Chứa dữ liệu cần thiết để xử lý thông tin quốc gia và thành phố.
- **DataAccess**: Xử lý truy vấn và truy cập dữ liệu.
- **Logic**: Chứa các logic nghiệp vụ chính để xử lý yêu cầu từ dịch vụ web.

### WinformWorld:
- Chứa các thành phần giao diện người dùng để hiển thị và tương tác với dữ liệu từ CalculatorWS.

- **CalculatorWS**: Chứa mã nguồn của dịch vụ web SOAP với các phương thức để lấy thông tin quốc gia và thành phố.
- **WinformWorld**: Chứa mã nguồn của ứng dụng WinForms với giao diện người dùng cho phép nhập và hiển thị thông tin từ dịch vụ web.

## 🚀 Hướng dẫn cài đặt và chạy

1. **Clone repository**:

   ```bash
   git clone https://github.com/soa-ueh-thanhlam/Excersie2.git
   ```

2. **Mở giải pháp trong Visual Studio**:

   - Mở tệp `Excersie2.sln` trong Visual Studio.

3. **Xây dựng và chạy dịch vụ web**:

   - Đặt `CalculatorWS` làm dự án khởi động.
   - Nhấn `F5` để xây dựng và chạy dịch vụ.

4. **Cấu hình và chạy ứng dụng WinForms**:

   - Đặt `WinformWorld` làm dự án khởi động.
   - Mở tệp `Form1.cs` để kiểm tra hoặc tùy chỉnh giao diện người dùng.
   - Nhấn `F5` để chạy ứng dụng.

## ⚙️ Chức năng chính

### 🌍 Dịch vụ web (CalculatorWS):

- Cung cấp các phương thức SOAP để lấy thông tin:
  - **GetCityByName**: Nhận tên thành phố và trả về thông tin chi tiết của thành phố.
  - **GetCitiesByCountry**: Nhận mã quốc gia và trả về danh sách các thành phố thuộc quốc gia đó.
  - **GetAllCountries**: Trả về danh sách tất cả các quốc gia.
  - **GetCountryByCode**: Nhận mã quốc gia và trả về thông tin chi tiết của quốc gia đó.

### 💻 Ứng dụng WinForms (WinformWorld):

- Giao diện thân thiện cho phép người dùng:
  - Chọn một quốc gia từ danh sách.
  - Hiển thị danh sách các thành phố thuộc quốc gia đã chọn.
- Gửi yêu cầu tới dịch vụ web và hiển thị kết quả trên giao diện.

## 🛠️ Mô hình hoạt động

1. Người dùng chọn quốc gia trên giao diện WinForms.
2. Ứng dụng WinForms gửi yêu cầu tới dịch vụ web SOAP để lấy danh sách thành phố.
3. Dịch vụ web trả về danh sách các thành phố tương ứng.
4. Ứng dụng hiển thị danh sách các thành phố cho người dùng.

## 💾 Yêu cầu hệ thống

- **Phần mềm**:
  - Visual Studio 2022 hoặc mới hơn.
  - .NET Framework hỗ trợ ứng dụng WinForms.

- **Phần cứng**:
  - Bộ vi xử lý: 1.6 GHz hoặc cao hơn.
  - RAM: Tối thiểu 2GB.
  - Dung lượng trống ổ đĩa: Tối thiểu 1GB.

## 📊 Ví dụ minh họa

- **Yêu cầu lấy danh sách quốc gia:**
  - Giao diện hiển thị danh sách các quốc gia: `Việt Nam`, `Hoa Kỳ`, `Nhật Bản`.

- **Yêu cầu lấy danh sách thành phố:**
  - Quốc gia được chọn: `Việt Nam`.
  - Giao diện hiển thị danh sách các thành phố: `Hà Nội`, `Hồ Chí Minh`, `Đà Nẵng`.

## 📚 Tài liệu tham khảo

- [Microsoft Docs: Tạo dịch vụ SOAP với ASP.NET](https://learn.microsoft.com/en-us/dotnet/framework/wcf/feature-details/creating-a-basic-soap-service)
- [Hướng dẫn tạo ứng dụng WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-6.0)
