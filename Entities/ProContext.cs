  using Core;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ProContext:DbContext
    {
        public ProContext (DbContextOptions <ProContext>opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            foreach (var relationship in mb.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            mb.Entity<Admin>().HasData(
                new Admin() { AdminId = 1, FirstName = "Prachi", LastName = "Salve", EmailId = "prachi@gmail.com", MobileNo = "4356378965", Password = "123", Address = "Pune" }
                );
             
        }


        public DbSet <Admin> Admins { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; } 
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }   
        public DbSet<Product> Products { get; set; }
        public DbSet <GreetingCard> GreetingCards { get; set; }
        public DbSet<GiftItem> GiftItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet <Payment> Payment { get; set; }    
        public DbSet<StoreReview> StoreReviews { get; set; }
        public DbSet <Dispatch> Dispatch { get; set; }  
        public DbSet <DispatchAgency> DispatchAgency { get; set; }  
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Solution> Solutions { get; set; }  
        public DbSet<OrderDelivery> OrderDelivery { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }   
        public DbSet<Tax> Taxs { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<Refund> Refunds { get; set; }


















    }
}
