using System.Collections.Generic;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class Services
    {
        DataServices dataServices = new DataServices();

        public List<Menu> GetMenus()
        {
            return dataServices.rmenu;
        }

        public List<Menu> GetMenusByMealNum(string mealNum)
        {
            List<Menu> found = new List<Menu>();
            foreach (Menu menu in dataServices.rmenu)
            {
                if (menu.Meal == mealNum)
                {
                    found.Add(menu);
                }
            }
            return found;
        }
    }
        
    
        
    }
