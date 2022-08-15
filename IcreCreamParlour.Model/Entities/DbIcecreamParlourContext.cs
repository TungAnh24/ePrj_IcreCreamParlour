﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class DbIcecreamParlourContext : DbContext
    {
        public DbIcecreamParlourContext()
        {
        }

        public DbIcecreamParlourContext(DbContextOptions<DbIcecreamParlourContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Flavor> Flavors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-VQBEJRR\\SQLEXPRESS; Database = DbIcecreamParlour; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId).HasColumnName("Admin_Id");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("Book_Id");

                entity.Property(e => e.AdminAddId).HasColumnName("AdminAdd_Id");

                entity.Property(e => e.AdminUpdateId).HasColumnName("AdminUpdate_Id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Date");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Image).HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Update_Date");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.FeedbackId).HasColumnName("Feedback_Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FeedbackDetail).HasColumnName("Feedback_Detail");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Feedbacks_Users");
            });

            modelBuilder.Entity<Flavor>(entity =>
            {
                entity.Property(e => e.FlavorId).HasColumnName("Flavor_Id");

                entity.Property(e => e.FlavorName).HasColumnName("Flavor_Name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.CardNo).HasColumnName("Card_No");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Orders_Users");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("Order_Detail");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetail_Id");

                entity.Property(e => e.BookId).HasColumnName("Book_Id");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Detail_Books");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Detail_Orders");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.Property(e => e.RecipeId).HasColumnName("Recipe_Id");

                entity.Property(e => e.AdminCreateId).HasColumnName("AdminCreate_Id");

                entity.Property(e => e.AdminUpdateId).HasColumnName("AdminUpdate_Id");

                entity.Property(e => e.FlavorId).HasColumnName("Flavor_Id");

                entity.Property(e => e.PublistDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Publist_Date");

                entity.Property(e => e.RecipeName).HasColumnName("Recipe_Name");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Update_Date");

                entity.HasOne(d => d.AdminCreate)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.AdminCreateId)
                    .HasConstraintName("FK_Recipes_Admin");

                entity.HasOne(d => d.Flavor)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.FlavorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recipes_Flavors");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.Property(e => e.SubscriptionId).HasColumnName("Subscription_Id");
            });

            modelBuilder.Entity<SubscriptionPayment>(entity =>
            {
                entity.ToTable("Subscription_Payment");

                entity.Property(e => e.SubscriptionPaymentId).HasColumnName("SubscriptionPayment_Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionId).HasColumnName("Subscription_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.SubscriptionPayments)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subscription_Payment_Subscriptions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SubscriptionPayments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subscription_Payment_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(10)
                    .HasColumnName("Card_No")
                    .IsFixedLength(true);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
