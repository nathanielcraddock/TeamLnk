//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamLnk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemGame
    {
        public int SystemGameId { get; set; }
        public int GameID { get; set; }
        public int SystemID { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual System System { get; set; }
    }
}
