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
    
    public partial class tbRolesUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRolesUsuario()
        {
            this.tbAccesoRol = new HashSet<tbAccesoRol>();
            this.tbUsuario = new HashSet<tbUsuario>();
        }
    
        public int rolusu_Id { get; set; }
        public int rol_Id { get; set; }
        public int usu_Id { get; set; }
        public int rolusu_UsuarioCrea { get; set; }
        public System.DateTime rolusu_FechaCrea { get; set; }
        public Nullable<int> rolusu_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rolusu_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol { get; set; }
        public virtual tbRoles tbRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUsuario> tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}
