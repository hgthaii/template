//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace template
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.CHITIETDONTHANGs = new HashSet<CHITIETDONTHANG>();
        }
    
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<decimal> GiaBan { get; set; }
        public string MoTa { get; set; }
        public string AnhBia { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> SoTuongTon { get; set; }
        public Nullable<int> MaCD { get; set; }
        public Nullable<int> MaNCC { get; set; }
        public Nullable<bool> DaXoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONTHANG> CHITIETDONTHANGs { get; set; }
        public virtual CHUDE CHUDE { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}