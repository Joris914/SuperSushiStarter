using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSushi.Data
{
        public class GerechtRepositorySql : IGerechtRepository
    {
        public Gerecht Create(Gerecht gerecht)
        {
            using (var ctx = new SuperSushiContext())
            {
                ctx.Gerechten.Add(gerecht);
                ctx.SaveChanges();
                return gerecht;
            }
        }

        public bool Delete(int id)
        {
            using (var ctx = new SuperSushiContext())
            {
                var toRemove = ctx.Gerechten.Find(id);
                if (toRemove != null)
                {
                    ctx.Gerechten.Remove(toRemove);
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public List<Gerecht> GetAll()
        {
            using (var ctx = new SuperSushiContext())
            {
                return ctx.Gerechten.ToList();
            }
        }

        public Gerecht GetOne(int Id)
        {
            using (var ctx = new SuperSushiContext())
            {
                return ctx.Gerechten.FirstOrDefault(m => m.Id == Id);
            }
        }

        public Gerecht Update(Gerecht gerecht)
        {
            using (var ctx = new SuperSushiContext())
            {
                ctx.Attach(gerecht);
                ctx.Gerechten.Update(gerecht);
                ctx.SaveChanges();
                return gerecht;
            }
        }
    }
}
