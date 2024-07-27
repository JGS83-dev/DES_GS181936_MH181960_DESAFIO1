using AutoMapper;
using GestionInventarioEntities.DTO;
using GestionInventarioEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventarioBL.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile() 
        { 
            CreateMap<Producto, ProductoDto>()
                .ForMember(destination => destination.CodigoProducto, options => options.MapFrom(source => source.Codigo))                
                .ForMember(destination => destination.StockProducto, options => options.MapFrom(source => source.Stock))               
                .ReverseMap();
        }
    }
}
