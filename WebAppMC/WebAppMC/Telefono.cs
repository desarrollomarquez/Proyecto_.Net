//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppMC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefono
    {
        public System.Guid Codigo_Id { get; set; }
        public Nullable<System.Guid> Entidad_Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public Nullable<System.DateTime> Updated_At { get; set; }
    
        public virtual Entidad Entidad { get; set; }
    }
}
