using System;
using System.Collections.Generic;

namespace AssetsAPI_Natalie.Models
{
    public partial class Activo
    {
        public int Codigo { get; set; }
        public string NombreActivo { get; set; } = null!;
        public string? Area { get; set; }
        public decimal CostoActivo { get; set; }
    }
}
