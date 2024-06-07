using Castle.Components.DictionaryAdapter;
using Core;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Repo.Enum;
using Repo.ViewModel;
using Repo.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Repo
{
    public class CartRepo : GenRepo<Cart>, ICart
    {
        ProContext cntx;
        public CartRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }
        public CartVM AddToCart(long gfid, long userid, long storeid)
         
        {
            CartVM res = new CartVM();

            var v = (from t in this.cntx.GiftItems
                     join t1 in this.cntx.Products
                     on t.ProductId equals t1.ProductId
                     join t2 in this.cntx.Carts
                     on t1.ProductId equals t2.ProductId
                     where t2.UserId == userid && t.GiftItemId == gfid
                     select new CartVM
                     {
                         CartId = t2.CartId,

                         CartDate = t2.CartDate,
                         Price = t2.Price,
                         Qty = t2.Qty,
                         UserId = t2.UserId,
                         StoreId = t2.StoreId,
                         ProductId = t2.ProductId,
                         PhotoPath = t.PhotoPath,
                         GiftItemTitle = t.GiftItemTitle,

                     }).SingleOrDefault();
            if (v != null)
            {
                int q = v.Qty;
                q++;

                Cart c = this.cntx.Carts.Find(v.CartId);
                c.CartDate = v.CartDate;
                c.Price = v.Price;
                c.Qty = q;
                c.UserId = v.UserId;
                c.StoreId = v.StoreId;
                c.ProductId = v.ProductId;

                this.cntx.SaveChanges();
            }
            else
            {
                //Order od = new Order();
                //od.OrderDate = DateTime.Now;
                //od.StoreId = storeid;
                //od.UserId = userid;


                var gift = this.cntx.GiftItems.Find(gfid);
                Cart newcart = new Cart();
                newcart.CartDate = DateTime.Now;
                newcart.Price = gift.Product.Price;
                newcart.Qty = 1;
                newcart.UserId = userid;
                newcart.StoreId = storeid;
                //newcart.OfferId = offerid;
                newcart.ProductId = gift.ProductId;

                this.cntx.Carts.Add(newcart);
                //this.cntx.Orders.Add(od);

                //var cart = this.cntx.Carts.Where(p => p.UserId == userid).Select(p => p.StoreId).Distinct().ToList();
                //foreach (var sid in cart)
                //{
                //var c = this.cntx.Carts.Where(p => p.UserId == userid && p.StoreId == storeid);


                //}

                this.cntx.SaveChanges();
            }

            return res;
        }

        public CartVM AddToGreetingCart(long gcid, long userid, long storeid)
        {
            CartVM res = new CartVM();

            var v = (from t in this.cntx.GreetingCards
                     join t1 in this.cntx.Products
                     on t.ProductId equals t1.ProductId
                     join t2 in this.cntx.Carts
                     on t1.ProductId equals t2.ProductId
                     where t2.UserId == userid && t.GreetingCardId == gcid
                     select new CartVM
                     {
                         CartId = t2.CartId,

                         CartDate = t2.CartDate,
                         Price = t2.Price,
                         Qty = t2.Qty,
                         UserId = t2.UserId,
                         StoreId = t2.StoreId,
                         ProductId = t2.ProductId,
                         PhotoPath = t.PhotoPath,
                         CardTitle=t.CardTitle,

                     }).SingleOrDefault();
            if (v != null)
            {
                int q = v.Qty;
                q++;

                Cart c = this.cntx.Carts.Find(v.CartId);
                c.CartDate = v.CartDate;
                c.Price = v.Price;
                c.Qty = q;
                c.UserId = v.UserId;
                c.StoreId = v.StoreId;
                c.ProductId = v.ProductId;

                this.cntx.SaveChanges();
            }
            else
            {
                var greeting = this.cntx.GreetingCards.Find(gcid);
                Cart newcart = new Cart();
                newcart.CartDate = DateTime.Now;
                newcart.Price = greeting.Product.Price;
                newcart.Qty = 1;
                newcart.UserId = userid;
                newcart.StoreId = storeid;
                //newcart.OfferId = offerid;
                newcart.ProductId = greeting.ProductId;

                this.cntx.Carts.Add(newcart);
                //Order ord = new Order();
                //ord.OrderDate = DateTime.Now;
                //ord.StoreId = storeid;
                //ord.UserId = userid;
                //this.cntx.Add(ord);
                var cart=this.cntx.Carts.Where(p=>p.UserId== userid ).Select(p=>p.StoreId).Distinct().ToList();
                foreach(var sid in cart)
                {
                    var c = this.cntx.Carts.Where(p => p.UserId == userid && p.StoreId == storeid);
                    Order rec=new Order();
                    rec.OrderDate=DateTime.Now;
                    rec.StoreId = storeid;
                    rec.UserId = userid;
                    this.cntx.Add(rec);
                }

                this.cntx.SaveChanges();
            }
            
        
            return res;
        }

        public List<CartVM> GetAllByUserId(long userid)
        {
            var res = from t in this.cntx.GiftItems
                    join t1 in this.cntx.Products
                    on t.ProductId equals t1.ProductId
                    join t2 in this.cntx.Carts
                    on t1.ProductId equals t2.ProductId
                    where t2.UserId == userid
                    select new CartVM
                    {
                     CartId=t2.CartId,
                     CartDate = DateTime.Now,
                        Price = t2.Price,
                        Qty = t2.Qty,
                        UserId = t2.UserId,
                        StoreId = t2.StoreId,
                        ProductId = t2.ProductId,
                        PhotoPath = t.PhotoPath,
                        GiftItemTitle = t.GiftItemTitle,

                    };
                return res.ToList();
             
        }
        public List<CartVM> GetGreetingByUserId(long userid)
        {
            var res = from t in this.cntx.GreetingCards
                      join t1 in this.cntx.Products
                      on t.ProductId equals t1.ProductId
                      join t2 in this.cntx.Carts
                      on t1.ProductId equals t2.ProductId
                      where t2.UserId == userid
                      select new CartVM
                      {
                          CartId = t2.CartId,
                          CartDate = DateTime.Now,
                          Price = t2.Price,
                          Qty = t2.Qty,
                          UserId = t2.UserId,
                          StoreId = t2.StoreId,
                          ProductId = t2.ProductId,
                          PhotoPath = t.PhotoPath,
                          CardTitle = t.CardTitle,

                      };
            return res.ToList();

        }

        public int GetCartCount(long userid)
        {
            return this.cntx.Carts.Where(p => p.UserId == userid).Count();
        }

       
        public ProfileResultVM PlaceOrder(long userid, int pmode,OrderDeliveryVM drec)
        {
            ProfileResultVM res = new ProfileResultVM();
            try
            {
                
                var ord = this.cntx.Carts.Where(p => p.UserId == userid).Select(p => p.StoreId).Distinct().ToList();
                foreach (var storeid in ord)
                {
                     
                    var c = this.cntx.Carts.Where(p => p.UserId == userid && p.StoreId == storeid);

                    Order rec = new Order();
                    rec.OrderDate = DateTime.Now;
                    rec.StoreId = storeid;
                    if (pmode == (int)PaymentModeEnum.CashOnDelivery)
                    rec.IsPaid = false;
                else
                    rec.IsPaid = true;
                rec.UserId = userid;

                foreach (var temp in c)
                {
                    OrderDetails ordet = new OrderDetails();
                    ordet.ProductId = temp.ProductId;
                        //ordet.OrderId = orderId1;
                    ordet.Qty = temp.Qty;
                    ordet.Price = temp.Price;
                    rec.OrderDetails.Add(ordet);
 
                }
                
                        OrderDelivery od=new OrderDelivery();
                        od.DeliverToPersonName = drec.DeliverToPersonName ;
                        od.DeliveryAddress =drec.DeliveryAddress;
                        od.PinCode = drec.PinCode;
                        od.ContactNo = drec.ContactNo;
                        od.CityId = drec.CityId;
                         
                        rec.DeliveryOrders.Add(od);
                   

                if (pmode != (int)PaymentModeEnum.CashOnDelivery)
                {
                    Payment ordp = new Payment();
                    ordp.PaymentDate = DateTime.Now;
                    ordp.Amount = c.Sum(p => p.Price * p.Qty);
                    //ordp.OrderId= orderId1;
                    ordp.PaymentMode = pmode;
                    rec.Payment.Add(ordp);
                }

                this.cntx.Orders.Add(rec);
                this.cntx.SaveChanges();
            }
                //empty cart
                var oldcar = this.cntx.Carts.Where(p => p.UserId == userid);
                foreach (var temp in oldcar)
                {
                    this.cntx.Carts.Remove(temp);
                }
                this.cntx.SaveChanges();
                res.IsSuccess = true;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res; 
        }
    }
    }
