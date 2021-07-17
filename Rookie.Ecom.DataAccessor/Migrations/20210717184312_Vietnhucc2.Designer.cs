﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rookie.Ecom.DataAccessor.Data;

namespace Rookie.Ecom.DataAccessor.Migrations
{
    [DbContext(typeof(EcommerceDbContext))]
    [Migration("20210717184312_Vietnhucc2")]
    partial class Vietnhucc2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rookie.Ecom.DataAccessor.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            CategoryName = "Bút thiên long",
                            Description = " Dành cho học sinh , sinh viên "
                        });
                });

            modelBuilder.Entity("Rookie.Ecom.DataAccessor.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("e674d113-c4fc-48d8-8f9b-21218733fa8b"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Bút gạng gel nước cho nét chữ đẹp, Vỏ bằng nhựa chắc chắn, nhỏ gọn dễ cầm",
                            ImageUrl = "but-do.jpg",
                            IsFeatured = false,
                            Name = "Bút đỏ thiên long",
                            Price = 4000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("5b00aed0-2dbf-411a-9864-ca9d719ef93b"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Bút xóa Thiên Long CP-02 có kiểu dáng thân dẹp, vừa tầm tay, thuận tiện khi sử dụng",
                            ImageUrl = "but-xoa.jpg",
                            IsFeatured = false,
                            Name = "Bút xóa thiên long",
                            Price = 16000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("87361815-59b1-4b41-8a20-c55b95c064f9"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Được làm từ chất liệu mực an toàn, tiện lợi khi sử dụng Màu mực tươi sáng, mau khô, không đóng cặn Đầu bi nhỏ cho nét chữ thanh mảnh",
                            ImageUrl = "but-xanh.jpg",
                            IsFeatured = false,
                            Name = "Bút xanh thiên long",
                            Price = 4000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("f1a93971-d349-4ced-9cdb-420ce590c3d1"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Tính chất dẻo dai, sạch và tác dụng xóa nhanh. Gôm trắng, có bọc ngoài dễ sử dụng, tránh bị dơ khi chưa dùng hết",
                            ImageUrl = "gom.jpg",
                            IsFeatured = false,
                            Name = "Cục tẩy bút chì",
                            Price = 5000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("39e37233-3595-4613-ad40-47fb3268b68e"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Bút được thiết kế thon, gọn có Grip giúp, cầm thoải mái và không bị mỏi tay khi sử dụng lâu",
                            ImageUrl = "but-den.jpg",
                            IsFeatured = false,
                            Name = "Bút đen thiên long",
                            Price = 4000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("74e700ac-f1a9-4f02-8ed6-6b201199296f"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Kiểu dáng đơn giản, thân tròn và nhỏ, dễ cầm nắm, rất thích hợp cho học sinh. Thân và nắp bút bằng nhựa trong.",
                            ImageUrl = "but-tim.jpg",
                            IsFeatured = false,
                            Name = "Bút tím thiên long",
                            Price = 5000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("8bc6370a-9342-4103-a063-16a3f13be5dd"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Bề mặt giấy trơn láng, viết đẹp, mượt mà Khổ giấy B5 thích hợp cho học sinh, sinh viên Gáy vở đóng chắc chắn, không bong tróc",
                            ImageUrl = "sach.jpg",
                            IsFeatured = false,
                            Name = "Tập Campus",
                            Price = 13500m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("0787777c-8b71-482f-a04e-cece98b9f5c2"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Compa được làm bằng nhựa, vít kim loại và mũi nhọn làm bằng thép không gỉ",
                            ImageUrl = "compa.jpg",
                            IsFeatured = false,
                            Name = "Compa Thiên Long",
                            Price = 7000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("af4edbbd-a670-44db-aebd-ce7ac0de9ca2"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Máy Tính Học Sinh Casio FX 570VN PLUS được thiết kế nút On cải tiến, lún sâu hơn trước. Việc thay đổi giúp Nút On không bị cấn khi đậy nắp, gây hao pin.",
                            ImageUrl = "may-tinh.jpg",
                            IsFeatured = false,
                            Name = "Máy tính Casio",
                            Price = 540000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("0be5cff9-0193-45b6-b6b3-7a4375524f03"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Mặt giấy láng mịn, viết êm tay Bìa tập in hình ảnh những cành hoa đầy màu sắc",
                            ImageUrl = "sach-abc.jpg",
                            IsFeatured = false,
                            Name = "Tập ABC",
                            Price = 8000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("af3eb291-c199-4913-a062-91c08f17ff86"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Trên thước thẳng SR-03 có vạch chia kích thước cho các bạn học sinh điều khiển và kẻ những đường thẳng chính xác nhất",
                            ImageUrl = "thuoc.jpg",
                            IsFeatured = false,
                            Name = "Thước kẻ thiên long",
                            Price = 5000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("2560dd43-0126-423e-bd2e-739f6f68be41"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Được làm từ vật liệu thép không gỉ, mũi kéo tròn để bảo vệ an toàn cho người sử dụng.",
                            ImageUrl = "keo.jpg",
                            IsFeatured = false,
                            Name = "Kéo thiên long",
                            Price = 10000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("1cfd9b28-bb2e-46da-8000-7ba48693645c"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Giấy ghi chú là những mẫu giấy nhỏ có thể dán lên bất cứ đâu để nhắc chúng ta làm việc gì đó.",
                            ImageUrl = "note.jpg",
                            IsFeatured = false,
                            Name = "Note ghi chú",
                            Price = 5000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("650325f4-e3ed-47e2-b95f-c2a3d6a362fb"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Chức năng đặc biệt của chiếc bút highline này sẽ giúp cho công việc diễn ra thuận tiện hơn",
                            ImageUrl = "highlight.jpg",
                            IsFeatured = false,
                            Name = "Bút Highlight",
                            Price = 5000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("a0fb76b1-844c-4b2f-a649-a0ff6008cc68"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Đèn Điện Quang thiết kế màu sắc nổi bật, kiểu dáng hiện đại, tạo điểm nhấn cho không gian sử dụng",
                            ImageUrl = "den.jpg",
                            IsFeatured = false,
                            Name = "Đèn Học",
                            Price = 20000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("a62e0c1c-3a6e-49e5-bdb1-b01741b99e69"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Loại phấn trắng không bụi, chất lượng uy tín đảm bảo nét viết rõ đẹp, ít bị bể vỡ.",
                            ImageUrl = "phan.jpg",
                            IsFeatured = false,
                            Name = "Phấn viết bảng",
                            Price = 5000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("d3782628-5836-4aa7-afa4-6442c7ee9eab"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Bao tập, bìa thư theo cách dán nilon mềm, băng dính to bản sẽ cố định tốt và chắc chắn toàn bộ phần vỏ bên ngoài bìa",
                            ImageUrl = "bao-tap.jpg",
                            IsFeatured = false,
                            Name = "Bao tập",
                            Price = 8000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("c223a730-860d-4178-8fb6-6776b2e3f068"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Những mẫu nhãn vở trong bộ sưu tập của chúng tôi có rất nhiều kiểu dáng khác nhau",
                            ImageUrl = "nhan-vo-dep.jpg",
                            IsFeatured = false,
                            Name = "Nhãn vở",
                            Price = 5000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("5370f7f0-a2ce-4ed8-9f49-06ffce960459"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Bìa sơ mi - kẹp file A4 có 5 túi có thể mở rộng đẻ đựng hồ sơ",
                            ImageUrl = "biasomi.jpg",
                            IsFeatured = false,
                            Name = "Bìa sơ mi",
                            Price = 20000m,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("908d0ea1-2496-42f0-be2a-3c0c2c10d08b"),
                            CategoryId = new Guid("53f717bb-63fe-4f05-b528-6ad8200a6f18"),
                            Description = "Là bút lông bảng lớn, 1 đầu có nét viết có màu ổn định trong suốt quá trình sử dụng, lưu trữ, bảo quản",
                            ImageUrl = "but-long.jpg",
                            IsFeatured = false,
                            Name = "Bút lông",
                            Price = 5000m,
                            Rating = 0
                        });
                });

            modelBuilder.Entity("Rookie.Ecom.DataAccessor.Entities.Product", b =>
                {
                    b.HasOne("Rookie.Ecom.DataAccessor.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Rookie.Ecom.DataAccessor.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}