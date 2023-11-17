﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.Dto
{
    public class VillaCreateDto
    {
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        public int ocupantes { get; set; }
        public int metrosCuadrados { get; set; }
        public string Detalle { get; set; }
        [Required]
        public double Tarifa { get; set; }
        public string ImagenUrl { get; set; }
        public string Amenidad { get; set; }
    }
}
