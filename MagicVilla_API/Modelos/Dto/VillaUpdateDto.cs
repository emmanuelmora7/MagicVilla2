﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.Dto
{
    public class VillaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        [Required]
        public int ocupantes { get; set; }
        [Required]
        public int metrosCuadrados { get; set; }
        public string Detalle { get; set; }
        [Required]
        public double Tarifa { get; set; }
        public string ImagenUrl { get; set; }
        public string Amenidad { get; set; }
    }
}
