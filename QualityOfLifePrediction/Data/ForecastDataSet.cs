//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QualityOfLifePrediction.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ForecastDataSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ForecastDataSet()
        {
            this.ForecastDatas = new HashSet<ForecastData>();
        }
    
        public long ForecastDataSet_ID { get; set; }
        public long DataSet_ID { get; set; }
        public long ForecastingMethod_ID { get; set; }
    
        public virtual DataSet DataSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForecastData> ForecastDatas { get; set; }
        public virtual ForecastingMethod ForecastingMethod { get; set; }
    }
}
