//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoserviceDoeduSam.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.ClientService = new HashSet<ClientService>();
            this.ServicePhoto = new HashSet<ServicePhoto>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int DurationInSeconds { get; set; }
        public string Description { get; set; }
        public Nullable<double> Discount { get; set; }
        public string MainImagePath { get; set; }

        public int DurationInMinutes
        {
            get
            {
                return DurationInSeconds / 60;
            }
        }
        public Nullable<double> DiscountDec
        {
            get
            {
                return Discount * 100;
            }
        }

        public string CostDis
        {
            get
            {
                if (Convert.ToDouble(Discount) != 0)
                {
                    return Convert.ToString(Convert.ToDouble(Cost) - Convert.ToDouble(Discount) * Convert.ToDouble(Cost));
                }
                else return "";
            }
        }
        public bool IsDiscount
        {
            get
            {
                if (Convert.ToDouble(Discount) != 0) return true;
                else return false;
            }
        }
        public string CostTextDecoration
        {
            get
            {
                return IsDiscount ? "Strikethrough" : "None";
            }
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientService> ClientService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicePhoto> ServicePhoto { get; set; }
    }
}
