﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ERP_Domians.Models;
using GP_ERP_SYSTEM_v1._0.DTOs;

namespace GP_ERP_SYSTEM_v1._0.Helpers.AutomapperProfile
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {

            //SCM DTOs
            CreateMap<TbProduct, AddProductDTO>().ReverseMap();

            CreateMap<TbProduct, ProductDTO>()
                .ForMember(d => d.CategoryName, opt => opt.MapFrom(s => s.Category.CategoryName)).ReverseMap();

            CreateMap<TbCategory, CategoryDTO>().ReverseMap();
            CreateMap<TbCategory, AddCategoryDTO>().ReverseMap();

            CreateMap<TbRawMaterial, AddRawMaterialDTO>().ReverseMap();
            CreateMap<TbRawMaterial, RawMaterialDTO>().ReverseMap();


            CreateMap<TbSupplier, AddSupplierDTO>().ReverseMap();
            CreateMap<TbSupplier, SupplierDTO>().ReverseMap();



            CreateMap<TbFinishedProductsInventory, AddProductInventoryDTO>().ReverseMap();
          
            CreateMap<TbFinishedProductsInventory, ProductInventoryDTO>()
            .ForMember(d => d.ProductName, opt => opt.MapFrom(s => s.Product.ProductName))
            .ForMember(d=>d.CategoryId, opt=>opt.MapFrom(s=>s.Product.Category.CategoryId))
            .ForMember(d=>d.CategoryName, opt=>opt.MapFrom(s=>s.Product.Category.CategoryName)).ReverseMap();


            CreateMap<TbRawMaterialsInventory, AddRawMaterialInventoryDTO>().ReverseMap();

            CreateMap<TbRawMaterialsInventory, RawMaterialInventoryDTO>()
            .ForMember(d => d.MaterialName, opt => opt.MapFrom(s => s.Material.MaterialName))
            .ForMember(d => d.MaterialDescription, opt => opt.MapFrom(s => s.Material.MaterialDescription));



            CreateMap<TbSupplyingMaterialDetail, SupplyingMaterialDetailDTO>().ReverseMap();

            CreateMap<TbDistributor, DistributorDTO>().ReverseMap();
            CreateMap<TbDistributor, AddDistributorDTO>().ReverseMap();

            //FMS DTOs
        
            CreateMap<TbFmsAccount, AddFmsAccountDTO>().ReverseMap();
            CreateMap<TbFmsAccount, FmsAccountDTO>().ReverseMap();

            CreateMap<TbFmsAccCat, AddFmsAccCatDTO>().ReverseMap();
            CreateMap<TbFmsAccCat, FmsAccCatDTO>().ReverseMap();

            CreateMap<TbFmsStatementAccount, AddFmsStatementAccountDTO>().ReverseMap();
            CreateMap<TbFmsStatementAccount, FmsStatementAccountDTO>().ReverseMap();

            CreateMap<TbFmsStatementTemplate, AddFmsStatementTemplateDTO>().ReverseMap();
            CreateMap<TbFmsStatementTemplate, FmsStatementTemplateDTO>().ReverseMap();

            CreateMap<TbFmsStatement, AddFmsStatementDTO>().ReverseMap();
            CreateMap<TbFmsStatement, FmsStatementDTO>().ReverseMap();

            CreateMap<TbFmsTemplateAccount, AddFmsTemplateAccountDTO>().ReverseMap();
            CreateMap<TbFmsTemplateAccount, FmsTemplateAccountDTO>().ReverseMap();

            CreateMap<TbFmsJournalEntry, AddFmsJeDTO>().ReverseMap();
            CreateMap<TbFmsJournalEntry, FmsJeDTO>().ReverseMap();

            CreateMap<TbFmsCategory, AddFmsCategoryDTO>().ReverseMap();
            CreateMap<TbFmsCategory, FmsCategoryDTO>().ReverseMap();



        }
    }
}
