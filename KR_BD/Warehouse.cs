//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KR_BD
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            this.DutyPart = new ObservableCollection<DutyPart>();
        }
    
        public long IdWarehouse { get; set; }
        public string Document { get; set; }
        public string Weapon { get; set; }
        public string SpecialMeans { get; set; }
        public string MeansOfCommunication { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<DutyPart> DutyPart { get; set; }
    }
}
