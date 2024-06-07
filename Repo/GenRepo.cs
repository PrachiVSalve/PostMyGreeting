using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class GenRepo<T> : IGeneric<T> where T : class
    {
        DbContext dbc;
        public GenRepo(DbContext dbc)
        {
            this.dbc=dbc;
        }

        public void Add(T rec)
        {
             this.dbc.Set<T>().Add(rec);
            this.dbc.SaveChanges();

        }

        public void Delete(long id)
        {
            var rec =this.dbc.Set<T>().Find(id);
            this.dbc.Set<T>().Remove(rec);  
            this.dbc.SaveChanges();
        }

        public void Edit(T rec)
        {
             this.dbc.Entry(rec).State= EntityState.Modified;
            this.dbc.SaveChanges();
        }

        public List<T> GetAll()
        {
             return this.dbc.Set<T>().ToList(); 
        }

        public T GetById(long id)
        {
            return this.dbc.Set<T>().Find(id);
        }
    }
}
