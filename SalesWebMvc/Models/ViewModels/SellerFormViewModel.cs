﻿using System.Collections.Generic;
using System.Globalization;

namespace SalesWebMvc.Models.ViewModels
{
	public class SellerFormViewModel
	{
		public Seller Seller { get; set; }
		public ICollection<Department> Departments { get; set; }
	}
}
