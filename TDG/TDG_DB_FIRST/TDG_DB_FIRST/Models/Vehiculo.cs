//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDG_DB_FIRST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        public System.Guid Codigo_Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string CodigoInterno { get; set; }
        public System.Guid TipoVehiculo_id { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public Nullable<System.DateTime> Updated_At { get; set; }
    
        public virtual TipoVehiculo TipoVehiculo { get; set; }
    }
}
