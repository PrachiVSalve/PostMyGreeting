using Entities;
using Microsoft.EntityFrameworkCore;
using Repo;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(
      opt =>
      {
          opt.Cookie.HttpOnly = true;
          opt.IdleTimeout = TimeSpan.FromMinutes(20);
          opt.Cookie.IsEssential = true;
      }
     );

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProContext>(
   opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon"))
   );
builder.Services.AddScoped<IAdmin,AdminRepo>();

builder.Services.AddScoped<ICountry,CountryRepo >();
builder.Services.AddScoped<IState, StateRepo>();
builder.Services.AddScoped<ICity, CityRepo>();
 builder.Services.AddScoped<IStore, StoreRepo>();
builder.Services.AddScoped<ITax,TaxRepo>();
builder.Services.AddScoped<ICategory, CategoryRepo >();
builder.Services.AddScoped<ISubCategory, SubCategoryRepo >();
builder.Services.AddScoped<IOffer,OfferRepo>(); 
builder.Services.AddScoped<IGiftItem, GiftItemRepo >();
builder.Services.AddScoped<IGreetingCard, GreetingCardRepo >();
builder.Services.AddScoped<IUser, UserRepo >();
builder.Services.AddScoped<ICart, CartRepo>();
builder.Services.AddScoped<IOrder, OrderRepo >();
builder.Services.AddScoped<IOrderDelivey,OrderdeliveryRepo >();
builder.Services.AddScoped<IdispatchAgency,DispatchAgencyRepo>();
builder.Services.AddScoped<IDispatch, DispatchRepo>();
builder.Services.AddScoped<IReturn, ReturnRepo >();
builder.Services.AddScoped<IRefund, RefundRepo >();
builder.Services.AddScoped<IReview,StoreReviewRepo >();

var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

app.MapDefaultControllerRoute();
app.UseStaticFiles();
app.Run();
