// class defines an Object
class Board {

    // Property: Unique to each object. Type (string) Spaces (name) New (assigns new value)
    // Below is an Object. Each object can have multiple attributes 
    List<string> spaces = new List<string>();

    // public allows for function Board to be used outside of the Board.cs file
    // Board is a Meathod that can be used outside of Board.cs file
    public Board() {
        for (int i = 1; i <= 9; i++)
        {
            spaces.Add(i.ToString());
        }
    }

    // Method is a Fucntion contained in a class
    //Print is the name of the Function we are using to create the board
    public void print() {
        Console.WriteLine($"{spaces[0]}|{spaces[1]}|{spaces[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{spaces[3]}|{spaces[4]}|{spaces[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{spaces[6]}|{spaces[7]}|{spaces[8]}");
    }

}