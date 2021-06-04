using Broadway.DesktopApp.DbFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.DesktopApp.Services
{
    public class MenuService
    {
        private BwEntities db = new BwEntities();

        public List<Menu> GetAll()
        {
            return db.Menus.ToList();
        }
        public Menu GetById(int id)
        {
            return db.Menus.Find(id);
        }
        public bool Create(Menu menu)
        {
            try
            {
                db.Menus.Add(menu);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Update(Menu menu)
        {
            try
            {
                var existingMenu = GetById(menu.Id);
                existingMenu.MenuName = menu.MenuName;
                existingMenu.MenuUrl = menu.MenuUrl;
                existingMenu.ParentId = menu.ParentId;


                db.Entry(existingMenu).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                var existingMenu = GetById(id);
                if (existingMenu==null)
                {
                    return false;
                }
                else
                {
                    db.Menus.Remove(existingMenu);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
