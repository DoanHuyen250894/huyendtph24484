﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.ConText;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(DUAN1DBContext))]
    partial class DUAN1DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.DomainModels.ChatLieu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ten")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChatLieu_SP", b =>
                {
                    b.Property<Guid>("IDCTSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDCL")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatLieuVai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IDCTSP", "IDCL");

                    b.HasIndex("IDCL");

                    b.ToTable("ChatLieu_SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChiTietSP", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IDChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDDongSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDThuongHieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongTon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("TrangThai")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDDongSP");

                    b.HasIndex("IDMauSac");

                    b.HasIndex("IDSP");

                    b.HasIndex("IDSize");

                    b.HasIndex("IDThuongHieu");

                    b.ToTable("ChiTietSP");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChucVu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.CuaHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ThanhPho")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("CuaHang");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.DongSP", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("DongSP");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HinhThucThanhToan", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HinhThucThanhToan");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("IDHTTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHTTT");

                    b.HasIndex("IDKH");

                    b.HasIndex("IDNV");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDChiTietSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SoLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("IDHD", "IDChiTietSP");

                    b.HasIndex("IDChiTietSP");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDem")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ThanhPho")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.MauSac", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("IDCH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDCV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TenDem")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ThanhPho")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDCH");

                    b.HasIndex("IDCV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Sizez", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ten")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ThuongHieu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ThuongHieu");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChatLieu_SP", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.ChatLieu", "ChatLieu")
                        .WithMany("chatLieu_SPs")
                        .HasForeignKey("IDCL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.ChiTietSP", "chiTietSP")
                        .WithMany("chatLieu_SPs")
                        .HasForeignKey("IDCTSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatLieu");

                    b.Navigation("chiTietSP");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChiTietSP", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.DongSP", "DongSP")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IDDongSP");

                    b.HasOne("_1.DAL.DomainModels.MauSac", "MauSac")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IDMauSac");

                    b.HasOne("_1.DAL.DomainModels.SanPham", "SanPham")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IDSP");

                    b.HasOne("_1.DAL.DomainModels.Sizez", "Size")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IDSize");

                    b.HasOne("_1.DAL.DomainModels.ThuongHieu", "ThuongHieu")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IDThuongHieu");

                    b.Navigation("DongSP");

                    b.Navigation("MauSac");

                    b.Navigation("SanPham");

                    b.Navigation("Size");

                    b.Navigation("ThuongHieu");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.HinhThucThanhToan", "HinhThucThanhToan")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDHTTT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HinhThucThanhToan");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.ChiTietSP", "ChiTietSP")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IDChiTietSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IDHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSP");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.CuaHang", "CuaHang")
                        .WithMany("NhanViens")
                        .HasForeignKey("IDCH");

                    b.HasOne("_1.DAL.DomainModels.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("IDCV");

                    b.Navigation("ChucVu");

                    b.Navigation("CuaHang");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChatLieu", b =>
                {
                    b.Navigation("chatLieu_SPs");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChiTietSP", b =>
                {
                    b.Navigation("chatLieu_SPs");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.CuaHang", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.DongSP", b =>
                {
                    b.Navigation("chiTietSPs");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HinhThucThanhToan", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.MauSac", b =>
                {
                    b.Navigation("chiTietSPs");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SanPham", b =>
                {
                    b.Navigation("chiTietSPs");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Sizez", b =>
                {
                    b.Navigation("chiTietSPs");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ThuongHieu", b =>
                {
                    b.Navigation("chiTietSPs");
                });
#pragma warning restore 612, 618
        }
    }
}
