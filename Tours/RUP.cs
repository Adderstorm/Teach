//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tours
{
    using System;
    using System.Collections.Generic;
    
    public partial class RUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RUP()
        {
            this.Grade = new HashSet<Grade>();
        }
    
        public int RUPID { get; set; }
        public string RUPName { get; set; }
        public int FacultyHour { get; set; }
        public string AttestationView { get; set; }
        public Nullable<int> TrainerID { get; set; }
        public Nullable<int> Term { get; set; }
        public Nullable<int> FacultyID { get; set; }
        public Nullable<int> CourseID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Faculty Faculty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grade { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
