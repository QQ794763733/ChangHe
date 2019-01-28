﻿using AutoMapper;
using ChangHeWebSite.Areas.Admin.Models;
using ChangHeWebSite.Areas.Admin.Models.Dto;
using ChangHeWebSite.Models.Dto;

namespace ChangHeWebSite.Areas.Admin.Base
{
    public class AutoMapperConfiguration
    {
        //映射调用方法
        public static void InitializeMapper()
        {
            //初始化
            Mapper.Initialize(mapper =>
            {
                /*前端公司信息传输对象映射*/
                mapper.CreateMap<CompanyInfo, FrontCompanyInfoDto>();



                /*后台新闻表传输对象映射*/
                mapper.CreateMap<News, NewsTableDto>()
                    .ForMember(dest => dest.NewsClassificationName,
                        opt => opt.MapFrom(src => src.NewsClassification.NewsClassificationName));
            });
        }
    }
}