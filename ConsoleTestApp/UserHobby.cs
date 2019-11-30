namespace ConsoleTestApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserHobby
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserHobbyId { get; set; }

        [Required]
        [StringLength(50)]
        public string HobbyName { get; set; }

        public int UserId { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
