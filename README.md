# food-ordering-app
## Giới thiệu
"Hôm nay ăn gì?" là một ứng dụng quản lý được xây dựng trên nền tảng Windows Forms bằng ngôn ngữ C# và .NET Framework 4.7.2. Ứng dụng hỗ trợ quản lý các chức năng như khách hàng, phòng, hợp đồng, hóa đơn, và đăng nhập. Đây là một công cụ hữu ích cho các nhà quản lý trong việc theo dõi và xử lý thông tin một cách hiệu quả.

## Tính năng chính
1. **Đăng nhập và quản lý tài khoản**:
   - Người dùng có thể đăng nhập bằng tài khoản và mật khẩu.
   - Hỗ trợ quản lý tài khoản (tạo, sửa, xóa tài khoản) dành cho admin.

2. **Quản lý khách hàng**:
   - Thêm, sửa, xóa thông tin khách hàng.
   - Tìm kiếm khách hàng theo mã, tên, số điện thoại, số CMND hoặc địa chỉ.

3. **Quản lý phòng**:
   - Thêm, sửa, xóa thông tin phòng.
   - Hiển thị danh sách phòng trống hoặc đã có khách.
   - Cập nhật trạng thái phòng tự động dựa trên hợp đồng.

4. **Quản lý hợp đồng**:
   - Tạo hợp đồng mới với thông tin khách hàng, phòng, ngày bắt đầu và ngày kết thúc.
   - Sửa thông tin hợp đồng (mã khách, mã phòng, ngày bắt đầu, ngày kết thúc).
   - Xóa hợp đồng.
   - Gia hạn hợp đồng theo số tháng.

5. **Quản lý hóa đơn**:
   - Tạo hóa đơn mới dựa trên chỉ số điện, nước.
   - Sửa hóa đơn (chỉ số điện, nước).
   - Xóa hóa đơn.
   - Thanh toán hóa đơn và cập nhật ngày nộp.

## Cấu trúc dự án
Dự án được tổ chức với cấu trúc như sau:

Workspace
(rerun without)
Collecting workspace information

Dưới đây là nội dung chi tiết cho file README.md của ứng dụng "Hôm nay ăn gì?":


Workspace
(rerun without)
Collecting workspace information

Dưới đây là nội dung chi tiết cho file README.md của ứng dụng "Hôm nay ăn gì?":
```bash
Hôm nay ăn gì?/ 
├── README.md 
├── Code visual/ 
│ ├── TTCS.sln 
│ ├── TTCS/ 
│ │ ├── Ac.cs 
│ │ ├── HoaDon.cs 
│ │ ├── HopDong.cs 
│ │ ├── KHang.cs 
│ │ ├── Phong.cs 
│ │ ├── Login.cs 
│ │ ├── KetNoiSQL.cs 
│ │ ├── Program.cs 
│ │ ├── Properties/ 
│ │ ├── bin/ 
│ │ └── obj/ 
├── Data SQL/ 
│ ├── TTCS.mdf 
│ └── TTCS_log.ldf
```

### Các tệp quan trọng
- **[Ac.cs](Code visual/TTCS/Ac.cs)**: Quản lý tài khoản (tạo, sửa, xóa).
- **[HoaDon.cs](Code visual/TTCS/HoaDon.cs)**: Quản lý hóa đơn (tạo, sửa, xóa, thanh toán).
- **[HopDong.cs](Code visual/TTCS/HopDong.cs)**: Quản lý hợp đồng (tạo, sửa, xóa, gia hạn).
- **[KHang.cs](Code visual/TTCS/KHang.cs)**: Quản lý khách hàng (thêm, sửa, xóa, tìm kiếm).
- **[Phong.cs](Code visual/TTCS/Phong.cs)**: Quản lý phòng (thêm, sửa, xóa, hiển thị trạng thái).
- **[Login.cs](Code visual/TTCS/Login.cs)**: Xử lý đăng nhập.
- **[KetNoiSQL.cs](Code visual/TTCS/KetNoiSQL.cs)**: Kết nối cơ sở dữ liệu SQL Server.

## Yêu cầu hệ thống
- **Hệ điều hành**: Windows 7 trở lên.
- **.NET Framework**: Phiên bản 4.7.2.
- **Cơ sở dữ liệu**: SQL Server.

## Hướng dẫn cài đặt
1. **Clone dự án về máy:**
   ```bash
   git clone <repository-url>
   Mở tệp TTCS.sln bằng Visual Studio 2019 hoặc phiên bản mới hơn.
   ```
   
2.**Đảm bảo rằng cơ sở dữ liệu TTCS.mdf được gắn kết trong SQL Server.**

3.**Xây dựng và chạy ứng dụng:**

4.**Chọn cấu hình**
    Debug hoặc Release.
    Nhấn F5 để chạy ứng dụng.
    
## Cơ sở dữ liệu
Cơ sở dữ liệu TTCS.mdf chứa các bảng chính:
    KhachHang: Lưu thông tin khách hàng.
    Phong: Lưu thông tin phòng.
    HopDong: Lưu thông tin hợp đồng.
    HoaDon: Lưu thông tin hóa đơn.
    TaiKhoan: Lưu thông tin tài khoản người dùng.
