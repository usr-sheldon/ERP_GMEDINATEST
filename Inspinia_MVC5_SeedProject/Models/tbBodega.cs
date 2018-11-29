//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5_SeedProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbBodega
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbBodega()
        {
            this.tbBodegaDetalle = new HashSet<tbBodegaDetalle>();
            this.tbEntrada = new HashSet<tbEntrada>();
            this.tbSalida = new HashSet<tbSalida>();
            this.tbSalida1 = new HashSet<tbSalida>();
            this.tbSalidaDetalle = new HashSet<tbSalidaDetalle>();
        }
    
        public int bod_Id { get; set; }
        public string bod_ResponsableBodega { get; set; }
        public string bod_Direccion { get; set; }
        public string bod_Correo { get; set; }
        public string bod_Telefono { get; set; }
        public int usu_Id { get; set; }
        public string mun_Codigo { get; set; }
        public byte estm_Id { get; set; }
        public int bod_UsuarioCrea { get; set; }
        public System.DateTime bod_FechaCrea { get; set; }
        public Nullable<int> bod_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> bod_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbMunicipio tbMunicipio { get; set; }
        public virtual tbEstadoMovimiento tbEstadoMovimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBodegaDetalle> tbBodegaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalidaDetalle> tbSalidaDetalle { get; set; }
    }
}
