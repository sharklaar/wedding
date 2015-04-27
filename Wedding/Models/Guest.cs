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
                    new  { Text = "Vegetable Soup", Value = "soup" }, 
                    new  { Text = "Melon Balls", Value = "balls" },
                    new  { Text = "Prawn Cocktail", Value = "cocktail" },
                    new  { Text = "Breaded Garlic Mushrooms", Value = "shrooms" }
                },
                "Value",
                "Text");

            MainOptions = new SelectList(
                new[]{
                    new  { Text = "Roast Beef", Value = "beef" }, 
                    new  { Text = "Roast Pork", Value = "pork" },
                    new  { Text = "Roast Turkey", Value = "turkey" },
                    new  { Text = "Vegetable Wellington", Value = "welly" }
                },
                "Value",
                "Text");

            DessertOptions = new SelectList(
                new[]{
                    new  { Text = "Apple Crumble w/Custard", Value = "crumble" }, 
                    new  { Text = "Raspberry Pavlova", Value = "pavlova" },
                    new  { Text = "Chocolate Fudge Cake", Value = "fudge" },
                    new  { Text = "Ice Cream", Value = "iceCream" }
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