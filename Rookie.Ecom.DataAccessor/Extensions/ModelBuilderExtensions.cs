using Microsoft.EntityFrameworkCore;
using Rookie.Ecom.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedProduct(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                   CategoryName = "Bút thiên long",
                   Description = " Dành cho học sinh , sinh viên "

               }) ;
            modelBuilder.Entity<Product>().HasData(
                //1
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Bút đỏ thiên long",
                    Description = "Bút gạng gel nước cho nét chữ đẹp, Vỏ bằng nhựa chắc chắn, nhỏ gọn dễ cầm",
                    CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                    ImageUrl = "but-do.jpg",
                    Price = 4000,
                    IsFeatured = false
                },
                //2
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Bút xóa thiên long",
                    Description = "Bút xóa Thiên Long CP-02 có kiểu dáng thân dẹp, vừa tầm tay, thuận tiện khi sử dụng",
                    CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                    ImageUrl = "but-xoa.jpg",
                    Price = 16000,
                    IsFeatured = false
                },
                //3
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Bút xanh thiên long",
                    Description = "Được làm từ chất liệu mực an toàn, tiện lợi khi sử dụng Màu mực tươi sáng, mau khô, không đóng cặn Đầu bi nhỏ cho nét chữ thanh mảnh",
                    CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                    ImageUrl = "but-xanh.jpg",
                    Price = 4000,
                    IsFeatured = false
                },
                //4
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Cục tẩy bút chì",
                    Description = "Tính chất dẻo dai, sạch và tác dụng xóa nhanh. Gôm trắng, có bọc ngoài dễ sử dụng, tránh bị dơ khi chưa dùng hết",
                    CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                    ImageUrl = "gom.jpg",
                    Price = 5000,
                    IsFeatured = false
                },
                //5
                new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Bút đen thiên long",
                    Description = "Bút được thiết kế thon, gọn có Grip giúp, cầm thoải mái và không bị mỏi tay khi sử dụng lâu",
                    CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                    ImageUrl = "but-den.jpg",
                    Price = 4000,
                    IsFeatured = false
                },
                 //6
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Bút tím thiên long",
                     Description = "Kiểu dáng đơn giản, thân tròn và nhỏ, dễ cầm nắm, rất thích hợp cho học sinh. Thân và nắp bút bằng nhựa trong.",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "but-tim.jpg",
                     Price = 5000,
                     IsFeatured = false
                 },
                 //7
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Tập Campus",
                     Description = "Bề mặt giấy trơn láng, viết đẹp, mượt mà Khổ giấy B5 thích hợp cho học sinh, sinh viên Gáy vở đóng chắc chắn, không bong tróc",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "sach.jpg",
                     Price = 13500,
                     IsFeatured = false
                 },
                 //8
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Compa Thiên Long",
                     Description = "Compa được làm bằng nhựa, vít kim loại và mũi nhọn làm bằng thép không gỉ",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "compa.jpg",
                     Price = 7000,
                     IsFeatured = false
                 },
                 //9
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Máy tính Casio",
                     Description = "Máy Tính Học Sinh Casio FX 570VN PLUS được thiết kế nút On cải tiến, lún sâu hơn trước. Việc thay đổi giúp Nút On không bị cấn khi đậy nắp, gây hao pin.",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "may-tinh.jpg",
                     Price = 540000,
                     IsFeatured = false
                 },
                 //10
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Tập ABC",
                     Description = "Mặt giấy láng mịn, viết êm tay Bìa tập in hình ảnh những cành hoa đầy màu sắc",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "sach-abc.jpg",
                     Price = 8000,
                     IsFeatured = false
                 },
                 //11
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Thước kẻ thiên long",
                     Description = "Trên thước thẳng SR-03 có vạch chia kích thước cho các bạn học sinh điều khiển và kẻ những đường thẳng chính xác nhất",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "thuoc.jpg",
                     Price = 5000,
                     IsFeatured = false
                 },
                 //12
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Kéo thiên long",
                     Description = "Được làm từ vật liệu thép không gỉ, mũi kéo tròn để bảo vệ an toàn cho người sử dụng.",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "keo.jpg",
                     Price = 10000,
                     IsFeatured = false
                 },
                 //13
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Note ghi chú",
                     Description = "Giấy ghi chú là những mẫu giấy nhỏ có thể dán lên bất cứ đâu để nhắc chúng ta làm việc gì đó.",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "note.jpg",
                     Price = 5000,
                     IsFeatured = false
                 },
                 //14
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Bút Highlight",
                     Description = "Chức năng đặc biệt của chiếc bút highline này sẽ giúp cho công việc diễn ra thuận tiện hơn",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "highlight.jpg",
                     Price = 5000,
                     IsFeatured = false
                 },
                 //15
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Đèn Học",
                     Description = "Đèn Điện Quang thiết kế màu sắc nổi bật, kiểu dáng hiện đại, tạo điểm nhấn cho không gian sử dụng",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "den.jpg",
                     Price = 20000,
                     IsFeatured = false
                 },
                 //16
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Phấn viết bảng",
                     Description = "Loại phấn trắng không bụi, chất lượng uy tín đảm bảo nét viết rõ đẹp, ít bị bể vỡ.",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "phan.jpg",
                     Price = 5000,
                     IsFeatured = false
                 },
                 //17
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Bao tập",
                     Description = "Bao tập, bìa thư theo cách dán nilon mềm, băng dính to bản sẽ cố định tốt và chắc chắn toàn bộ phần vỏ bên ngoài bìa",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "bao-tap.jpg",
                     Price = 8000,
                     IsFeatured = false
                 },
                 //18
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Nhãn vở",
                     Description = "Những mẫu nhãn vở trong bộ sưu tập của chúng tôi có rất nhiều kiểu dáng khác nhau",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "nhan-vo-dep.jpg",
                     Price = 5000,
                     IsFeatured = false
                 },
                 //19
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Bìa sơ mi",
                     Description = "Bìa sơ mi - kẹp file A4 có 5 túi có thể mở rộng đẻ đựng hồ sơ",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "biasomi.jpg",
                     Price = 20000,
                     IsFeatured = false
                 },
                 //20
                 new Product
                 {
                     ProductId = Guid.NewGuid(),
                     Name = "Bút lông",
                     Description = "Là bút lông bảng lớn, 1 đầu có nét viết có màu ổn định trong suốt quá trình sử dụng, lưu trữ, bảo quản",
                     CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                     ImageUrl = "but-long.jpg",
                     Price = 5000,
                     IsFeatured = false
                 }

                );
                
           
        }
    }
}
