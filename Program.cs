class Car 
{
  //Attributes go here
  string colour;

  //Constructor to make a new object of class Car TODO fix.
  public Car(string aColour){
    colour = "No colour assigned";
  }

  //Main runs automatically when the Program is run
  static void Main(string[] args)
  {
    //Calling the constructor of the Car class to make a new Car object
    Car myObj = new Car("Black");
    Car myObj2 = new Car("Yellow");

    //Printing an attribute
    Console.WriteLine(myObj.colour);
    Console.WriteLine(myObj2.colour);
  }

}
