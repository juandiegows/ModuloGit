//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsuarioBloqueados
    {
        public int ID { get; set; }
        public int adminitradorID { get; set; }
        public int UsuarioID { get; set; }
        public System.DateTime fechaYHora { get; set; }
    
        public virtual Users Admin { get; set; }
        public virtual Users User { get; set; }
    }
}
