using System;

class MainClass {

  static string[] tones = {"A", "A#", "B", "C", "C#", "D", "D#", "E", "F",
     "F#","G", "G#"}; //array

  public static void Main (string[] args) {
    Console.WriteLine ("Please choose a note by typing a number 1 - 12 and then press Enter. 1 = A, 2 = A#, 3 = B, etc."); //this is the main function - starting with numbers because computers love numbers
    string choice; //choice is the variable & prepares memory to save the user's choice
    choice = Console.ReadLine(); //reads in the user's choice and save it in the memory
    Console.WriteLine ("You chose " + choice + " which is the tone " + 
    tones[Convert.ToInt32(choice)-1]); 
    Console.WriteLine ("2 + 2 is " + (2 + 2));
  }
}
 