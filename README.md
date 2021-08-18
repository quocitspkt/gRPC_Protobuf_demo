# gRPC_Protobuf_demo
Chương trình máy tính đơn giản ứng dụng gRPC

Video chương trình demo: https://youtu.be/mGkgrsGuKQE

Tổng quan về gRPC và Protobuf (Protocol buffers)
  - gRPC là một framework RPC mã nguồn mở, hiện đại và hiệu năng cao, có thể chạy trên bất kì môi trường nào.
  - Framework này được google phát triển năm 2015. Được cho là thế hệ tiếp theo của RPC (Remote Procedure Calls) đặc biệt là trong mô hình Microservices
  - Trong gRPC, một ứng dụng khách có thể gọi trực tiếp phương thức trên server
  - Máy chủ gRPC xử lý các request từ máy khách

  - Dữ liệu Protocol buffer được cấu trúc dưới dạng messages. Trong đó, mỗi message là một bản ghi logic nhỏ chứa thông tin các cặp name-value gọi là các trường.
  - HTTP/2 hoạt động rất tốt với binary thay vì test nên google phát minh ra kiểu dữ liệu binary với tên gọi: Protobuf (tên đầy đủ là Protocol Buffers). 
  - Tốc độ encode và decode của Protobuf là nhanh nhất.
  
Vì sao cần dùng gRPC
  - Để tăng tải và thông lượng giữa các services
  - Khi chúng thực hiện dự án có nhiều services và tải đang rất cao.
  - Từ việc làm thế nào để các service giao tiếp với nhau với tốc độ cao nhất, giảm tải encode/ decode data.

gRPC hoạt động ra sao ?
  - Để phục vụ tăng tải cho cả hệ thống nhiều services (hay Microservies), google phát triển 2 thứ:
  + Một giao thức mới để tối ưu các connection, đảm bảo dữ liệu đi trao đổi liên tục với ít băng thông nhất có thể.
  + Một định dạng dữ liệu mới để 2 đầu service(hoặc client và server) có thể hiệu được các message của nhau mà ít phải encode và decode
  - Đầu tiên google phát triển một giao thức thay thế cho HTTP/1.1 với tên gọi là SPDY. Sau này giao thức này được open source thậm chí chuẩn hóa, lấy làm nền móng cho giao thức       HTTP/2. Khi có HTTP/2 rồi thì giao thức SPDY ngừng phát triển. gRPC chính thức hoạt động trên HTTP/2 luôn từ 2015
 Kết luận
  Tóm lại gRPC là một kỹ thuật rất ưu việt để scale tải hệ thống, đặc biệt trong hệ thống phân tán, nhiều services hoặc Microservices.
  
