using Microsoft.AspNetCore.Mvc;
using Thuchanh2.Models;

namespace Thuchanh2.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> menuItems = new List<MenuItem>();

        public RenderViewComponent()
        {
            menuItems = new List<MenuItem>() { 
                new MenuItem() {Id = 1, Name = "Branches", Link="Branches/List"},
                new MenuItem() {Id = 2, Name = "Students", Link="Students/List"},
                new MenuItem() {Id = 3, Name = "Subjects", Link="Subjects/List"},
                new MenuItem() {Id = 4, Name = "Courses", Link="Courses/List"},
            };
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", menuItems);
        }
    }
}
