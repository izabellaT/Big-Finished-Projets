﻿using System.ComponentModel.DataAnnotations;

namespace SkateAppWeb.Models.Statistic
{
    public class StatisticVM
    {
        [Display(Name = "CountClients")]
        public int CountClients { get; set; }

        [Display(Name = "CountProducts")]
        public int CountProducts { get; set; }

        [Display(Name = "CountOrders")]
        public int CountOrders { get; set; }

        [Display(Name = "CountFavorites")]
        public int CountFavorites { get; set; }

        [Display(Name = "SumOrders")]
        public decimal SumOrders { get; set; }
    }
}
