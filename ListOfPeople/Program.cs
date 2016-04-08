using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPeople
{
    class Program
    {
        static void Main(string[] args)
        { //creat a dictionary containing the names of all the people, last name first

            Dictionary<string, string> members = new Dictionary<string, string>();
            members.Add("Carlin", "    Patrick");
            members.Add("Lee", "       Ruby");
            members.Add("Michaels", "  Johanna");
            members.Add("Remey", "     Xavier");
            members.Add("Rem", "       Paula");
            members.Add("Remedio", "   Rui");
            members.Add("Rimi", "      Antonio");
            members.Add("Petro", "     Shelby");
            members.Add("Petric", "    Bill");
            members.Add("Petrio", "    Fran");
            members.Add("Schultz", "   Kim");
            members.Add("Tovar", "     Sam");

            List<string> list = new List<string>(members.Keys);

            foreach(string orgMemb in list)
            {
                Console.WriteLine("{0}, {1}", orgMemb, members[orgMemb]); 
            }

            //*****************************LIST OF TEAMS *****************************************************
            static void Main(string[] args)
        {
                string[] teamName = { "Europe", "North America", "South America", "Middle East" };
                teamName = int.Parse(teamName[0]);

                for (int counter = 0; counter <= 3; counter++)
                {
                    Console.WriteLine(teamName[counter]); //want to print the name of the Team
                                                          // underneath that on the first line member name 1, next line member name 2, next line member name 3
                                                          //   need a way to get back to the menu for Teams (loop)
                                                          // user chooses another team, info displayed as above for 2nd  team, loop back to menu for Teams
                                                          //user chooses 3rd team, info name, name displyed under the name of the team, each name appearing on it's own line
                                                          //user chooses 4th team, info displayed as above, loops back to Team menu
                                                          //Team menu loops back to Menu for Name menu
                                                          //Name menu allow user to choose either one member by alpha search, last name if user wants disply one membr at a time, or
                                                          //Name menu allows user to choose to display all members at once
                                                          //Name menu also allows user to display team member name and teams they are associated with
                                                          //


 //********************************** menuUserInput ************************************************

                    {   // kinda proud of this below...
                        Console.WriteLine("Magic Meeting Minutes");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("World Peace Initiative");
                        Console.WriteLine("223 Reed Ave. Ste. 405");
                        Console.WriteLine("Washington, D.C. 11123");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");


                        //could try to loop each question response to Console.WriteLine to pare down the repetitiveness
                        Console.WriteLine("Name of Minutes Recorder: ");
                        //chg string to int
                        Console.ReadLine();

                        Console.WriteLine("Name of Meeting Leader: ");
                        //chg string to int
                        Console.ReadLine();

                        Console.WriteLine("Date of meeting in this format: MMDDYY");
                        //chg string to int
                        Console.ReadLine();

                        Console.WriteLine("Choose type of meeting from list below");
                        //change string to int
                        Console.ReadLine();


                        /* the list of meeting types is not printing out, need to debug, index it and create a list the user can see and choose which type from the number
                        there will be Conditionals, ex: if (user chooses 1(Graphics Meeting), else print to console all names belonging to Graphic Meeting
                        ex: if(user chooses 2(Media Meeting), else print to console all names belonging Media Mtg type
                        etc.

                        List<string> list = new List<string>();
                        list.Add("Graphics Meeting");
                        list.Add("Media Meeting");
                        list.Add("Finance Meeting");
                        list.Add("Brainstorm Meeting");
                        list.Add("Project Meeting");

                        Console.WriteLine(list);
                       //index the list so the user can input a number while choosing a meeting type
                      /*  {
                         //skip a few lines  
                        if (int meeting = 0; meeting <= 4; list++)
                            {
                                Console.WriteLine()
                            }*/

                    }
                }

        }
    }
}
//I can see 3 blocks of code, 1 each for the Menu, the User Input section and 1 for team members and team names
// Each block of code will have to be in a loop or switch statement, and I will need to include StreamWriter/Reader to send information to a text file.

