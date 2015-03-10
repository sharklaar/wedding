using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Guest
/// </summary>
public class Guest
{
	public Guest()
	{
		//
		// TODO: Add constructor logic here
		//
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
}