using PermisoSystem.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PermisoSystem.BL.DTOS
{
    public class PermisoDTO : IEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreEmpleado { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidosEmpleado { get; set; }

        [Required]
        public int TipoPermisoId { get; set; }

        [Required]
        public DateTime FechaPermiso { get; set; }
    }
}
