using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Data
{
  public class MovieContext : DbContext
  {
    public MovieContext(DbContextOptions<MovieContext> opt) : base(opt)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Address>()
      .HasOne(address => address.Cinema)
      .WithOne(cinema => cinema.Address)
      .HasForeignKey<Cinema>(cinema => cinema.AddressId);

      builder.Entity<Cinema>()
      .HasOne(cinema => cinema.Manager)
      .WithMany(manager => manager.Cinemas)
      .HasForeignKey(cinema => cinema.ManagerId)
      .OnDelete(DeleteBehavior.Restrict);

      builder.Entity<Session>()
      .HasOne(session => session.Movie)
      .WithMany(movie => movie.Sessions)
      .HasForeignKey(session => session.MovieId);

      builder.Entity<Session>()
      .HasOne(session => session.Cinema)
      .WithMany(cinema => cinema.Sessions)
      .HasForeignKey(session => session.CinemaId);
    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Session> Sessions { get; set; }

  }
}