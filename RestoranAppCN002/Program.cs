

using RestoranAppCN002.Abstarct;
using RestoranAppCN002.Cocrete;


List<Category> categories = new List<Category>();


Product product1 = new() { Id=1, CategoryId=2, ProductName="Tike kabab", Description="quzu kababi",Price=12.50};
Product product2 = new() { Id = 3, CategoryId = 1, ProductName = "sprite", Description = "icmeli sirin su", Price = 1.20 };

UserCheckRoleManager userCheckRoleManager = new UserCheckRoleManager();


Category category1 = new() { Id = 1, CategoryName = "Su" };
Category category2 = new() { Id = 2, CategoryName = "Kabab" };
Category category3 = new() { Id = 3, CategoryName = "Terevez" };

User user1 = new() { Id = 1, FullName = "Murad Musali", PhoneNumber = "+994556777777", Role = "ADMIN" };
User user2 = new() { Id = 1, FullName = "Gulshan Azimli", PhoneNumber = "+994556777777", Role = "CASHIER" };

categories.Add(category1);
categories.Add(category2);

ProductManager productManager = new ProductManager(userCheckRoleManager, user1);
CategoryManager categoryManager = new CategoryManager(userCheckRoleManager, user2);
productManager.Add(product1);
categoryManager.Add(category1);
categoryManager.Add(category2);
categoryManager.Add(category3);
productManager.Delete(product1);

