namespace ConsoleTestApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserPhone
    {
        public int UserPhoneId { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int UserId { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
