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
                    new  { Text = "Vegetable Soup", Value = "Vegetable Soup" }, 
                    new  { Text = "Melon Balls", Value = "Melon Balls" },
                    new  { Text = "Prawn Cocktail", Value = "Prawn Cocktail" },
                    new  { Text = "Breaded Garlic Mushrooms", Value = "Garlic Mushrooms" }
                },
                "Value",
                "Text");

            MainOptions = new SelectList(
                new[]{
                    new  { Text = "Roast Beef", Value = "Roast Beef" }, 
                    new  { Text = "Roast Pork", Value = "Roast Pork" },
                    new  { Text = "Roast Turkey", Value = "Roast Turkey" },
                    new  { Text = "Vegetable Wellington", Value = "Vegetable Wellington" }
                },
                "Value",
                "Text");

            DessertOptions = new SelectList(
                new[]{
                    new  { Text = "Apple Crumble w/Custard", Value = "Apple Crumble" }, 
                    new  { Text = "Raspberry Pavlova", Value = "Raspberry Pavlova" },
                    new  { Text = "Chocolate Fudge Cake", Value = "Fudge Cake" },
                    new  { Text = "Ice Cream", Value = "Ice Cream" }
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