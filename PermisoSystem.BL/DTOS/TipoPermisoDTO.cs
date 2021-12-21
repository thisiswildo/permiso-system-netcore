using PermisoSystem.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PermisoSystem.BL.DTOS
{
    public class TipoPermisoDTO : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
