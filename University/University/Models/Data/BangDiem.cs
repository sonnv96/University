//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class BangDiem
    {
        public string maSinhVien { get; set; }
        public string maMonMoc { get; set; }
        public int namHoc { get; set; }
        public int hocKy { get; set; }
        public string trangThai { get; set; }
        public Nullable<int> thucHanh { get; set; }
        public Nullable<int> giuaKy { get; set; }
        public Nullable<int> cuoiKy { get; set; }
    
        public virtual MonHoc MonHoc { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
