﻿using ChangHeWebSite.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace ChangHeWebSite.Areas.Admin.Base.Database
{
    /// <summary>
    /// 数据库环境
    /// </summary>
    public class EFContext : DbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public EFContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// 管理人员表
        /// </summary>
        public DbSet<Manager> Manager { get; set; }
        /// <summary>
        /// 系统信息表
        /// </summary>
        public DbSet<SystemInfo> System { get; set; }
        /// <summary>
        /// 公司信息表
        /// </summary>
        public DbSet<CompanyInfo> Company { get; set; }
        /// <summary>
        /// 新闻分类表
        /// </summary>
        public DbSet<NewsClassification> NewsClassifications { get; set; }
        /// <summary>
        /// 新闻表
        /// </summary>
        public DbSet<News> Newses { get; set; }
        /// <summary>
        /// 图片表
        /// </summary>
        public DbSet<Image> Images { get; set; }

        /// <summary>
        /// 表配置信息
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*管理人员表*/
            modelBuilder.Entity<Manager>(m =>
            {
                m.HasKey(x => x.Id);
                m.HasData(new Manager()
                {
                    Id = 1,
                    ManagerName = "admin",
                    ManagerPassword = "21232F297A57A5A743894A0E4A801FC3"
                });
                m.ToTable("Manager");
            });
            /*系统信息表*/
            modelBuilder.Entity<SystemInfo>(s =>
            {
                s.HasKey(x => x.Id);
                s.ToTable("SystemInfo");
            });
            /*公司信息表*/
            modelBuilder.Entity<CompanyInfo>(c =>
            {
                c.HasKey(x => x.Id);
                c.HasData(new CompanyInfo()
                {
                    Id = 1,
                    CompanyName = "公司名称",
                    CompanyCopyright = "公司版权",
                    CompanyEmail = "公司邮箱",
                    CompanyDescription = "公司描述",
                    CompanyLogo = "/MyPicture.png",
                    CompanyQQ = "公司QQ",
                    CompanyWeChat = "公司微信",
                    CompanyContactPerson = "公司联系人",
                    CompanyKeyWord = "公司关键字",
                    CompanyLocation = "公司位置",
                    CompanyPhone = "公司电话",
                    Lat = 26.585302,
                    Lng = 107.985099,
                    CompanyQRcode = "111"
                });
                c.ToTable("CompanyInfo");
            });
            /*新闻分类表*/
            modelBuilder.Entity<NewsClassification>(n =>
            {
                n.HasKey(x => x.Id);
                /*与新闻的一对多关系映射*/
                n.HasMany(x => x.Newses).WithOne(x=>x.NewsClassification).HasForeignKey(x => x.NewsClassificationId);
                n.ToTable("NewsClassification");
            });
            /*图片表*/
            modelBuilder.Entity<Image>(i =>
            {
                i.HasKey(x => x.Id);
                i.HasData(new Image()
                {
                    Id = 1,
                    ImageUrl = "/images/slide1.jpg",
                    ImageType = ImageType.Cover
                }, new Image()
                {
                    Id = 2,
                    ImageUrl = "/images/slide2.jpg",
                    ImageType = ImageType.Cover
                }, new Image()
                {
                    Id = 3,
                    ImageUrl = "/images/slide3.jpg",
                    ImageType = ImageType.Cover
                }, new Image()
                {
                    Id = 4,
                    ImageUrl = "/images/slide4.jpg",
                    ImageType = ImageType.Cover
                }, new Image()
                {
                    Id = 5,
                    ImageUrl = "/images/fuw.png",
                    ImageType = ImageType.Project
                }, new Image()
                {
                    Id = 6,
                    ImageUrl = "/images/fuw2.png",
                    ImageType = ImageType.Project
                }, new Image()
                {
                    Id = 7,
                    ImageUrl = "/images/fu3.png",
                    ImageType = ImageType.Project
                }, new Image()
                {
                    Id = 8,
                    ImageUrl = "/images/fuw4.png",
                    ImageType = ImageType.Project
                }, new Image()
                {
                    Id = 9,
                    ImageUrl = "/images/ab.png",
                    ImageType = ImageType.Description
                }, new Image()
                {
                    Id = 10,
                    ImageUrl = "/images/7htc.jpg",
                    ImageType = ImageType.Background
                });
                i.ToTable("Images");
            });
            /*新闻表*/
            modelBuilder.Entity<News>(n =>
            {
                n.HasKey(x => x.Id);
                n.ToTable("News");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}