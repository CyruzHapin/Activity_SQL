using Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataLayer
{
    public class DataServices
    {
        public List<Menu> rmenu = new List<Menu>();

        public DataServices()
        {
            Menu rmeal1 = new Menu
            {
                Description = "Cy Restaurant's Special Carbonara, is a filipino dish made with spaghetti pasta, chopped bacon, onion, garlic, eggs, evaporated milk, all-purpose cream, cheese, salt and pepper, and chopped parsley for garnish(optional). Combined with the freshly made lemon juice to contrast the richness of the carbonara.",
                Meal = "Meal 1",
                Price = "149 Pesos",
                Drinks = "Lemon juice"
            };


            Menu rmeal2 = new Menu
            {
                Description = "Cy Restaurant's Grilled meats, paired with java rice and the best selling Special Halo-Halo made with shaved ice, sweeted fruits, leche flan, ube, evaporated milk, and ube flavored ice cream.",
                Meal = "Meal 2",
                Price = "179 Pesos",
                Drinks = "Coke"
            };

            Menu rmeal3 = new Menu
            {
                Description = "Cy Restaurant's Adobo, is a savory and tangy dish made with chicken marinated in vinegar, soy sauce, garlic, spices, then simmered tander. It has rich and flavourful sauce that pairs well with rice.Combined with freshly squeezed calamansi served over ice, a zesty companion to the robust flavors of our adobo.",
                Meal = "Meal 3",
                Price = "169 Pesos",
                Drinks = "Calamansi juice"
            };

            Menu rmeal4 = new Menu
            {
                Description = "Cy Restaurant's Sisig. Savor the sizzle of our sizzling sisig, featuring diced pork, seasoned to perfection with calamansi, chill peppers, and onions, served on a hot plate. A spicy and flavorful delight paired with regular rice and fresh lime juice.",
                Meal = "Meal 4",
                Price = "169 Pesos",
                Drinks = "Lime juice"
            };

            Menu rmeal5 = new Menu
            {
                Description = "Cy Restaurant's Crispy Pata. Delight in our crispy pata, featuring tender pork trotters or knuckles, deep-fried until golden and served with a savory soy-vinegar dipping sauce. A crunchy and satisfying treat combine dwith coconut breeze refresher. A chilled coconut water served over ice, a light and hydrating beverage to complement the hearty flavors of our crispy pata.",
                Meal = "Meal 5",
                Price = "199 Pesos",
                Drinks = "Coconut breeze referesher"
            };

            rmenu.Add(rmeal1);
            rmenu.Add(rmeal2);
            rmenu.Add(rmeal3);
            rmenu.Add(rmeal4);
            rmenu.Add(rmeal5);

        }
    }
}

