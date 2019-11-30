namespace ConsoleTestApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserPhones_history
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPhoneId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Action { get; set; }

        public Guid? TransactionToken { get; set; }
    }
}
