class Car 
{
  //Attributes go here
  private string colour;

  //Constructor to make a new object of class Car TODO fix.
  public Car(string aColour){
    colour = "No colour assigned";
  }

  //Main runs automatically when the Program is run
  public static void Main(string[] args)
  {
    //Calling the constructor of the Car class to make a new Car object
    Car car1 = new Car("Black");
    Car car2 = new Car("Yellow");

    //Printing an attribute
    Console.WriteLine(car1.colour);
    Console.WriteLine(car2.colour);
  }

}
