﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        //we are going to add two properties as per our domain models
        public Movie Movie { get; set; }
        //and a list of customers
        public List<Customer> Customers { get; set; }
    }
}