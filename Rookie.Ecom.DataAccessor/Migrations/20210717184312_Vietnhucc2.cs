using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.Ecom.DataAccessor.Migrations
{
    public partial class Vietnhucc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Bút thiên long", " Dành cho học sinh , sinh viên " });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "IsFeatured", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { new Guid("e674d113-c4fc-48d8-8f9b-21218733fa8b"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Bút gạng gel nước cho nét chữ đẹp, Vỏ bằng nhựa chắc chắn, nhỏ gọn dễ cầm", "but-do.jpg", false, "Bút đỏ thiên long", 4000m, 0 },
                    { new Guid("c223a730-860d-4178-8fb6-6776b2e3f068"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Những mẫu nhãn vở trong bộ sưu tập của chúng tôi có rất nhiều kiểu dáng khác nhau", "nhan-vo-dep.jpg", false, "Nhãn vở", 5000m, 0 },
                    { new Guid("d3782628-5836-4aa7-afa4-6442c7ee9eab"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Bao tập, bìa thư theo cách dán nilon mềm, băng dính to bản sẽ cố định tốt và chắc chắn toàn bộ phần vỏ bên ngoài bìa", "bao-tap.jpg", false, "Bao tập", 8000m, 0 },
                    { new Guid("a62e0c1c-3a6e-49e5-bdb1-b01741b99e69"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Loại phấn trắng không bụi, chất lượng uy tín đảm bảo nét viết rõ đẹp, ít bị bể vỡ.", "phan.jpg", false, "Phấn viết bảng", 5000m, 0 },
                    { new Guid("a0fb76b1-844c-4b2f-a649-a0ff6008cc68"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Đèn Điện Quang thiết kế màu sắc nổi bật, kiểu dáng hiện đại, tạo điểm nhấn cho không gian sử dụng", "den.jpg", false, "Đèn Học", 20000m, 0 },
                    { new Guid("650325f4-e3ed-47e2-b95f-c2a3d6a362fb"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Chức năng đặc biệt của chiếc bút highline này sẽ giúp cho công việc diễn ra thuận tiện hơn", "highlight.jpg", false, "Bút Highlight", 5000m, 0 },
                    { new Guid("1cfd9b28-bb2e-46da-8000-7ba48693645c"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Giấy ghi chú là những mẫu giấy nhỏ có thể dán lên bất cứ đâu để nhắc chúng ta làm việc gì đó.", "note.jpg", false, "Note ghi chú", 5000m, 0 },
                    { new Guid("2560dd43-0126-423e-bd2e-739f6f68be41"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Được làm từ vật liệu thép không gỉ, mũi kéo tròn để bảo vệ an toàn cho người sử dụng.", "keo.jpg", false, "Kéo thiên long", 10000m, 0 },
                    { new Guid("af3eb291-c199-4913-a062-91c08f17ff86"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Trên thước thẳng SR-03 có vạch chia kích thước cho các bạn học sinh điều khiển và kẻ những đường thẳng chính xác nhất", "thuoc.jpg", false, "Thước kẻ thiên long", 5000m, 0 },
                    { new Guid("0be5cff9-0193-45b6-b6b3-7a4375524f03"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Mặt giấy láng mịn, viết êm tay Bìa tập in hình ảnh những cành hoa đầy màu sắc", "sach-abc.jpg", false, "Tập ABC", 8000m, 0 },
                    { new Guid("af4edbbd-a670-44db-aebd-ce7ac0de9ca2"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Máy Tính Học Sinh Casio FX 570VN PLUS được thiết kế nút On cải tiến, lún sâu hơn trước. Việc thay đổi giúp Nút On không bị cấn khi đậy nắp, gây hao pin.", "may-tinh.jpg", false, "Máy tính Casio", 540000m, 0 },
                    { new Guid("0787777c-8b71-482f-a04e-cece98b9f5c2"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Compa được làm bằng nhựa, vít kim loại và mũi nhọn làm bằng thép không gỉ", "compa.jpg", false, "Compa Thiên Long", 7000m, 0 },
                    { new Guid("8bc6370a-9342-4103-a063-16a3f13be5dd"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Bề mặt giấy trơn láng, viết đẹp, mượt mà Khổ giấy B5 thích hợp cho học sinh, sinh viên Gáy vở đóng chắc chắn, không bong tróc", "sach.jpg", false, "Tập Campus", 13500m, 0 },
                    { new Guid("74e700ac-f1a9-4f02-8ed6-6b201199296f"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Kiểu dáng đơn giản, thân tròn và nhỏ, dễ cầm nắm, rất thích hợp cho học sinh. Thân và nắp bút bằng nhựa trong.", "but-tim.jpg", false, "Bút tím thiên long", 5000m, 0 },
                    { new Guid("39e37233-3595-4613-ad40-47fb3268b68e"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Bút được thiết kế thon, gọn có Grip giúp, cầm thoải mái và không bị mỏi tay khi sử dụng lâu", "but-den.jpg", false, "Bút đen thiên long", 4000m, 0 },
                    { new Guid("f1a93971-d349-4ced-9cdb-420ce590c3d1"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Tính chất dẻo dai, sạch và tác dụng xóa nhanh. Gôm trắng, có bọc ngoài dễ sử dụng, tránh bị dơ khi chưa dùng hết", "gom.jpg", false, "Cục tẩy bút chì", 5000m, 0 },
                    { new Guid("87361815-59b1-4b41-8a20-c55b95c064f9"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Được làm từ chất liệu mực an toàn, tiện lợi khi sử dụng Màu mực tươi sáng, mau khô, không đóng cặn Đầu bi nhỏ cho nét chữ thanh mảnh", "but-xanh.jpg", false, "Bút xanh thiên long", 4000m, 0 },
                    { new Guid("5b00aed0-2dbf-411a-9864-ca9d719ef93b"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Bút xóa Thiên Long CP-02 có kiểu dáng thân dẹp, vừa tầm tay, thuận tiện khi sử dụng", "but-xoa.jpg", false, "Bút xóa thiên long", 16000m, 0 },
                    { new Guid("5370f7f0-a2ce-4ed8-9f49-06ffce960459"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Bìa sơ mi - kẹp file A4 có 5 túi có thể mở rộng đẻ đựng hồ sơ", "biasomi.jpg", false, "Bìa sơ mi", 20000m, 0 },
                    { new Guid("908d0ea1-2496-42f0-be2a-3c0c2c10d08b"), new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"), "Là bút lông bảng lớn, 1 đầu có nét viết có màu ổn định trong suốt quá trình sử dụng, lưu trữ, bảo quản", "but-long.jpg", false, "Bút lông", 5000m, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("0787777c-8b71-482f-a04e-cece98b9f5c2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("0be5cff9-0193-45b6-b6b3-7a4375524f03"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1cfd9b28-bb2e-46da-8000-7ba48693645c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2560dd43-0126-423e-bd2e-739f6f68be41"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("39e37233-3595-4613-ad40-47fb3268b68e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("5370f7f0-a2ce-4ed8-9f49-06ffce960459"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("5b00aed0-2dbf-411a-9864-ca9d719ef93b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("650325f4-e3ed-47e2-b95f-c2a3d6a362fb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("74e700ac-f1a9-4f02-8ed6-6b201199296f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("87361815-59b1-4b41-8a20-c55b95c064f9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("8bc6370a-9342-4103-a063-16a3f13be5dd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("908d0ea1-2496-42f0-be2a-3c0c2c10d08b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a0fb76b1-844c-4b2f-a649-a0ff6008cc68"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a62e0c1c-3a6e-49e5-bdb1-b01741b99e69"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("af3eb291-c199-4913-a062-91c08f17ff86"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("af4edbbd-a670-44db-aebd-ce7ac0de9ca2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c223a730-860d-4178-8fb6-6776b2e3f068"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d3782628-5836-4aa7-afa4-6442c7ee9eab"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e674d113-c4fc-48d8-8f9b-21218733fa8b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f1a93971-d349-4ced-9cdb-420ce590c3d1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"));
        }
    }
}
