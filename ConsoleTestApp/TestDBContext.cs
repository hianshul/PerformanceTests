namespace ConsoleTestApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestDBContext : DbContext
    {
        public TestDBContext()
            : base("name=TestDBContext")
        {
            GenerateSessionID();
        }
        private void GenerateSessionID()
        {            
            
        }
        public virtual DbSet<Trace001> Trace001 { get; set; }
        public virtual DbSet<Trace002> Trace002 { get; set; }
        public virtual DbSet<TraceData> TraceDatas { get; set; }
        public virtual DbSet<TraceData1> TraceData1 { get; set; }
        public virtual DbSet<UserHobby> UserHobbies { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<UserPhone> UserPhones { get; set; }
        public virtual DbSet<UserInfo_History> UserInfo_History { get; set; }
        public virtual DbSet<UserPhones_history> UserPhones_history { get; set; }

        public override int SaveChanges()
        {
            if (this.Database.Connection.State == System.Data.ConnectionState.Closed)
            {
                this.Database.Connection.Open();
                this.Database.ExecuteSqlCommand("exec Generate_Session_ID");
            }

            return base.SaveChanges();

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
