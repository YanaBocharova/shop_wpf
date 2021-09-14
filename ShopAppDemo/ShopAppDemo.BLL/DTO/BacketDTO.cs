﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.DTO
{
    public class BacketDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public AccountDTO Account { get; set; }
    }
}
