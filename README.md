# 🌐 Excersie2: Dự án Web Service và Ứng dụng WinForms

## 📝 Tổng quan dự án

Dự án này được xây dựng với hai thành phần chính:

1. **CalculatorWS**: Một dịch vụ web SOAP cung cấp thông tin về các quốc gia và thành phố.
2. **WinformWorld**: Một ứng dụng Windows Forms sử dụng dữ liệu từ dịch vụ web để hiển thị và tương tác với thông tin quốc gia và thành phố.

## 📂 Cấu trúc chính

### **CalculatorWS**
- **Data**: Chứa dữ liệu liên quan đến quốc gia và thành phố.
- **DataAccess**: Đảm nhiệm việc truy vấn và quản lý dữ liệu.
- **Logic**: Tích hợp các nghiệp vụ chính, xử lý yêu cầu từ dịch vụ web.

### **WinformWorld**
- Tích hợp giao diện người dùng để hiển thị dữ liệu từ dịch vụ web và hỗ trợ tương tác với người dùng.
- **CalculatorWS**: Mã nguồn của dịch vụ web với các phương thức hỗ trợ truy xuất thông tin quốc gia và thành phố.
- **WinformWorld**: Chứa giao diện ứng dụng WinForms, giúp người dùng gửi yêu cầu và nhận kết quả từ dịch vụ web.

## 🚀 Hướng dẫn cài đặt và sử dụng

1. **Clone dự án**:

   ```bash
   git clone https://github.com/soa-ueh-thanhlam/Excersie2.git
