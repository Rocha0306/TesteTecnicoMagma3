﻿using AutoMapper;
using BackEnd.DTOs;
using BackEnd.Entities;

namespace BackEnd.Infrastructure
{
    public class AutoMapperConfig : Profile
    {

        public AutoMapperConfig() {
            CreateMap<UsersDTO, UsersEntity>();
            CreateMap<ClientesDTO, ClientesEntity>();
            CreateMap<ProdutoDTO, ProdutoEntity>(); 
     
        
        }
    }
}
