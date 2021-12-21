using AutoMapper;
using PermisoSystem.BL.DTOS;
using PermisoSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.BL.Profiles
{
    public class ProfileConfig : Profile
    {
        public ProfileConfig()
        {
            CreateMap<Permiso, PermisoDTO>()
                .ReverseMap();

            CreateMap<TipoPermiso, TipoPermisoDTO>()
                .ReverseMap();
        }
    }
}
