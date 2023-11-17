using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto { Id = 1, Nombre="Villa Bonita", ocupantes=4, metrosCuadrados=90 },
            new VillaDto { Id = 2, Nombre="Villa Dana Yolotl", ocupantes=2, metrosCuadrados=70}
        };
    }
}
