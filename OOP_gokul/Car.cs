using System;

public class Car
{
	public string colour = "black";
	int maxSpeed = 200;
	public int year;
	public string model;
	string registration
	{ get; set; }
public void fullThrottle()   
	{
		Console.WriteLine("The car is going as fast as it can!");
	}
	public Car()
	{
		this.model = "Toyota";
	}
	public Car(string model)
	{
		this.model = model;
	}
	public Car(string model, string colour, int year)
	{
		this.model = model;
		this.colour = colour;
		this.year = year;
	}

}
