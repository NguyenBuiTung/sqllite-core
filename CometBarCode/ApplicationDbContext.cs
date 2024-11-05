using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometBarCode
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CodeEntry> CodeEntries { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Codechecker.db");
            //MessageBox.Show(dbPath);
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Thiết lập mối quan hệ giữa CodeEntry và Setting
        //    modelBuilder.Entity<CodeEntry>()
        //        .HasOne(c => c.Setting)
        //        .WithMany(s => s.CodeEntries)
        //        .HasForeignKey(c => c.SettingId)
        //        .OnDelete(DeleteBehavior.Cascade); // Có thể chọn hành vi khi xóa

        //    base.OnModelCreating(modelBuilder);
        //}

    }
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<CodeEntry> CodeEntries { get; set; }
    }
    public class CodeEntry
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime ScanTime { get; set; }
        public bool IsDuplicate { get; set; }
        public bool IsWrongType { get; set; }
        public string ProductType { get; set; }
    }

    public class Setting
    {
        public int Id { get; set; }
        public string ProductType { get; set; } // Lưu 4 ký tự đầu của mã sản phẩm
        public DateTime LastUpdated { get; set; }

        // Quan hệ ngược lại với CodeEntries
        public virtual ICollection<CodeEntry> CodeEntries { get; set; }
    }


}
