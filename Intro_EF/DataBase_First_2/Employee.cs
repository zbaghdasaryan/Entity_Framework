//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase_First_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Employees1 = new HashSet<Employee>();
            this.Orders = new HashSet<Order>();
        }
    
        public int EmployeeID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public decimal Salary { get; set; }
        public decimal PriorSalary { get; set; }
        public System.DateTime HireDate { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public Nullable<int> ManagerEmpID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees1 { get; set; }
        public virtual Employee Employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
