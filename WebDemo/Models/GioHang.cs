//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GioHang
    {
        public int magh { get; set; }
        public string name { get; set; }
        public int masp { get; set; }
        public Nullable<int> soluong { get; set; }

        public GioHang(int magh, string name, int masp, int? soluong)
        {
            this.magh = magh;
            this.name = name;
            this.masp = masp;
            this.soluong = soluong;
        }

        public GioHang(string name, int masp, int? soluong)
        {
            this.name = name;
            this.masp = masp;
            this.soluong = soluong;
        }

        public GioHang()
        {
        }

        public GioHang(string name, int masp)
        {
            this.name = name;
            this.masp = masp;
        }

        public GioHang(int magh, string name, int masp)
        {
            this.magh = magh;
            this.name = name;
            this.masp = masp;
        }
    }
}
