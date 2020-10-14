using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace MabyJewelrry.Model.ViewModels
{
    public class ProductVM
    {
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public Product Product { get; set; }
    }
}
