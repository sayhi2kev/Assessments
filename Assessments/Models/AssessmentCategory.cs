//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assessments.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssessmentCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentCategory()
        {
            this.AssessmentQuestions = new HashSet<AssessmentQuestion>();
            this.UserAssessmentCategories = new HashSet<UserAssessmentCategory>();
        }
    
        public int ID { get; set; }
        public int TranslationID { get; set; }
        public int AssessmentCollectionID { get; set; }
    
        public virtual AssessmentCollection AssessmentCollection { get; set; }
        public virtual Translation Translation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAssessmentCategory> UserAssessmentCategories { get; set; }
    }
}
