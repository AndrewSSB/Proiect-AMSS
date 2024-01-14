using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proiect1.DAL.Entities;
using Proiect1.Infrastructure.Entities;

namespace Proiect1.DAL;

public class AppDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }

    public DbSet<Trade> Trades { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Agenda> Agendas { get; set; }
    public DbSet<UserMeeting> UserMeetings { get; set; }
    public DbSet<UserTrade> UserTrades { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Meeting>()
            .HasOne(m => m.Agenda)
            .WithOne(a => a.Meeting)
            .HasForeignKey<Agenda>(a => a.MeetingId);

        modelBuilder.Entity<Trade>()
            .HasOne(t => t.Meeting)
            .WithOne(m => m.Trade)
            .HasForeignKey<Meeting>(t => t.MeetingId);

        modelBuilder.Entity<UserTrade>()
            .HasKey(ut => new { ut.UserId, ut.TradeId });

        modelBuilder.Entity<UserTrade>()
            .HasOne(ut => ut.User)
            .WithMany(u => u.UserTrades)
            .HasForeignKey(ut => ut.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<UserTrade>()
            .HasOne(ut => ut.Trade)
            .WithMany(t => t.UserTrades)
            .HasForeignKey(ut => ut.TradeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<UserMeeting>()
            .HasKey(um => new { um.UserId, um.MeetingId });

        modelBuilder.Entity<UserMeeting>()
            .HasOne(ut => ut.User)
            .WithMany(u => u.UserMeetings)
            .HasForeignKey(ut => ut.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<UserMeeting>()
            .HasOne(ut => ut.Meeting)
            .WithMany(t => t.UserMeetings)
            .HasForeignKey(ut => ut.MeetingId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
