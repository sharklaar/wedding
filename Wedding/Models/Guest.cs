using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wedding.Models
{
    public class Guest
    {
        public Guest()
        {
            StarterOptions = new SelectList(
                new[]{
                    new  { Text = "Melons", Value = "Melons" }, 
                    new  { Text = "Soup", Value = "Soup" }
                },
                "Value",
                "Text");

            MainOptions = new SelectList(
                new[]{
                    new  { Text = "Chicken", Value = "Chicken" }, 
                    new  { Text = "Beef", Value = "Beef" }
                },
                "Value",
                "Text");

            DessertOptions = new SelectList(
                new[]{
                    new  { Text = "Chocolate", Value = "Chocolate" }, 
                    new  { Text = "Ice cream", Value = "IceCream" }
                },
                "Value",
                "Text");
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public bool AttendingCeremony { get; set; }
        public bool AttendingMeal { get; set; }
        public bool AttendingReception { get; set; }
        public string Starter { get; set; }
        public string Main { get; set; }
        public string Dessert { get; set; }
        public bool CeremonyPermitted { get; set; }
        public bool MealPermitted { get; set; }
        public bool ReceptionPermitted { get; set; }

        public SelectList StarterOptions { get; set; }
        public SelectList MainOptions { get; set; }
        public SelectList DessertOptions { get; set; }
    }
}