
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LibraryProjectWinForm
{

using System;
    using System.Collections.Generic;
    
public partial class KaynakTurler
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public KaynakTurler()
    {

        this.Kaynaklar = new HashSet<Kaynaklar>();

    }


    public int tur_id { get; set; }

    public string tur { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Kaynaklar> Kaynaklar { get; set; }

}

}