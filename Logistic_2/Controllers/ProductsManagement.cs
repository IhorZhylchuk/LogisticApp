using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Providers.Entities;
using Logistic_2.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Logistic_2.Controllers
{
    
    public class ProductsManagement : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<IdentityUser> userManager;
        public ProductsManagement(ApplicationDbContext db, SignInManager<IdentityUser> signManager, UserManager<IdentityUser> manager)
        {
            dbContext = db;
            signInManager = signManager;
            userManager = manager;
        }
        [HttpGet]
        public IActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel login)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await userManager.FindByEmailAsync(login.Email);
                    var result = await signInManager.PasswordSignInAsync(user.UserName, login.Password, login.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("WorkingArea", "ProductsManagement");
                    }
                     ModelState.AddModelError("", "User was not found. Chek your email or password!");
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
            return RedirectToAction("Login", "ProductsManagement");
            
        }
        public IActionResult WorkingArea()
        {
            ViewBag.Count = dbContext.Products.Select(p => p).Count();
            return View();
        }
        public JsonResult GetData()
        {     
            List<ProductsItems> products = dbContext.Products.ToList();
            return Json(products);
        }
     


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddEditItem(int id)
        {
           if(id == 0)
            {
                return View(new ProductsItems());
            }
            else
            {
                var p = await dbContext.Products.Where(i => i.Id == id).FirstOrDefaultAsync<ProductsItems>();
                return View(p);
            }

        }

        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEditItem(ProductsItems product)
        {
            if (product.Id == 0)
            {
                ProductsItems addedProduct = new ProductsItems();
                addedProduct.Id = product.Id;
                addedProduct.NameOfItem = product.NameOfItem;
                addedProduct.TotalWeight = product.TotalWeight;
                addedProduct.DateOfProduction = product.DateOfProduction;
                addedProduct.BestBefore = product.BestBefore;
                addedProduct.Category = product.Category;
                addedProduct.Container = product.Container;
                addedProduct.Amount = product.Amount;

                int compare = DateTime.Compare(addedProduct.DateOfProduction, addedProduct.BestBefore);
                if (compare > 0 | compare == 0)
                {
                    return new JavaScriptResult("swal({text: 'Make sure that dates are correct!',icon: 'error',}); ");
                }
                else
                {
                    try
                    {
                        dbContext.Products.Add(product);
                        await dbContext.SaveChangesAsync();
                        return Json(new { success = true, message = "Saved successfully" });
                    }
                    catch (Exception ex)
                    {
                        ex.Message.ToString();
                    }
                }
            }

                dbContext.Entry(product).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
                return Json(new { success = true, message = "Saved successfully" });
            
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

                ProductsItems products = await dbContext.Products.Where(i => i.Id == id).FirstOrDefaultAsync();
                dbContext.Products.Remove(products);
                await dbContext.SaveChangesAsync();
                return Json(new { success = true, message = "Deleted successfully" });
        }


        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "ProductsManagement");
        }
    }
}
