//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace concourCanin
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROPRIETAIRE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROPRIETAIRE()
        {
            this.CHIENs = new HashSet<CHIEN>();
        }
    
        public string codeproprietaire { get; set; }
        public string adresseproprietaire { get; set; }
        public string cpproprietaire { get; set; }
        public string nomproprietaire { get; set; }
        public string prenomproprietaire { get; set; }
        public string villeproprietaire { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHIEN> CHIENs { get; set; }
    }
}
