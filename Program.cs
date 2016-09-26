using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] MovieCatalog = new Movie[100];
            MovieCatalog[0] = new Movie("Citizen Kane", "drama");
            MovieCatalog[1] = new Movie("Casablanca", "drama");
            MovieCatalog[2] = new Movie("The Godfather", "drama");
            MovieCatalog[3] = new Movie("Gone With The Wind", "drama");
            MovieCatalog[4] = new Movie("Lawrence Of Arabia", "drama");
            MovieCatalog[5] = new Movie("The Wizard Of Oz", "musical");
            MovieCatalog[6] = new Movie("The Graduate", "drama");
            MovieCatalog[7] = new Movie("On The Waterfront", "drama");
            MovieCatalog[8] = new Movie("Schindler's List", "drama");
            MovieCatalog[9] = new Movie("Singin' In The Rain", "musical");
            MovieCatalog[10] = new Movie("It's A Wonderful Life", "drama");
            MovieCatalog[11] = new Movie("Sunset Boulevard", "drama");
            MovieCatalog[12] = new Movie("The Bridge On The River Kwai", "drama");
            MovieCatalog[13] = new Movie("Some Like It Hot", "drama");
            MovieCatalog[14] = new Movie("Star Wars", "scifi");
            MovieCatalog[15] = new Movie("All About Eve", "drama");
            MovieCatalog[16] = new Movie("The African Queen", "drama");
            MovieCatalog[17] = new Movie("Psycho", "horror");
            MovieCatalog[18] = new Movie("Chinatown", "drama");
            MovieCatalog[19] = new Movie("One Flew Over The Cuckoo's Nest", "drama");
            MovieCatalog[20] = new Movie("The Grapes Of Wrath", "drama");
            MovieCatalog[21] = new Movie("2001: A Space Odyssey", "scifi");
            MovieCatalog[22] = new Movie("The Maltese Falcon", "drama");
            MovieCatalog[23] = new Movie("Raging Bull", "drama");
            MovieCatalog[24] = new Movie("E.T. The extra-terrestrial", "scifi");
            MovieCatalog[25] = new Movie("Dr. Strangelove", "drama");
            MovieCatalog[26] = new Movie("Bonnie And Clyde", "drama");
            MovieCatalog[27] = new Movie("Apocalypse Now", "drama");
            MovieCatalog[28] = new Movie("Mr. Smith Goes to Washington", "drama");
            MovieCatalog[29] = new Movie("The Treasure Of The Sierra Madre", "drama");
            MovieCatalog[30] = new Movie("Annie Hall", "comedy");
            MovieCatalog[31] = new Movie("The Godfather Part II", "drama");
            MovieCatalog[32] = new Movie("High Noon", "drama");
            MovieCatalog[33] = new Movie("To Kill A Mockingbird", "drama");
            MovieCatalog[34] = new Movie("It Happened One Night", "drama");
            MovieCatalog[35] = new Movie("Midnight Cowboy", "drama");
            MovieCatalog[36] = new Movie("The Best Years Of Our Lives", "drama");
            MovieCatalog[37] = new Movie("Double Indemnity", "drama");
            MovieCatalog[38] = new Movie("Doctor Zhivago", "drama");
            MovieCatalog[39] = new Movie("North By Northwest", "drama");
            MovieCatalog[40] = new Movie("West Side Story", "musical");
            MovieCatalog[41] = new Movie("Rear Window", "drama");
            MovieCatalog[42] = new Movie("King Kong", "horror");
            MovieCatalog[43] = new Movie("The Birth Of A Nation", "drama");
            MovieCatalog[44] = new Movie("A Streetcar Named Desire", "drama");
            MovieCatalog[45] = new Movie("A Clockwork Orange", "scifi");
            MovieCatalog[46] = new Movie("Taxi Driver", "drama");
            MovieCatalog[47] = new Movie("Jaws", "horror");
            MovieCatalog[48] = new Movie("Snow White And The Seven Dwarfs", "animated");
            MovieCatalog[49] = new Movie("Butch Cassidy And The Sundance Kid", "drama");
            MovieCatalog[50] = new Movie("The Philadelphia Story", "drama");
            MovieCatalog[51] = new Movie("From Here To Eternity", "drama");
            MovieCatalog[52] = new Movie("Amadeus", "drama");
            MovieCatalog[53] = new Movie("All Quiet On The Western Front", "drama");
            MovieCatalog[54] = new Movie("The Sound Of Music", "musical");
            MovieCatalog[55] = new Movie("M*A*S*H", "comedy");
            MovieCatalog[56] = new Movie("The Third Man", "drama");
            MovieCatalog[57] = new Movie("Fantasia", "animated");
            MovieCatalog[58] = new Movie("Rebel Without A Cause", "drama");
            MovieCatalog[59] = new Movie("Raiders Of The Lost Ark", "drama");
            MovieCatalog[60] = new Movie("Vertigo", "drama");
            MovieCatalog[61] = new Movie("Tootsie", "comedy");
            MovieCatalog[62] = new Movie("Stagecoach", "drama");
            MovieCatalog[63] = new Movie("Close Encounters Of The Third Kind", "scifi");
            MovieCatalog[64] = new Movie("The Silence Of The Lambs", "horror");
            MovieCatalog[65] = new Movie("Network", "drama");
            MovieCatalog[66] = new Movie("The Manchurian Candidate", "drama");
            MovieCatalog[67] = new Movie("An American In Paris", "drama");
            MovieCatalog[68] = new Movie("Shane", "drama");
            MovieCatalog[69] = new Movie("The French Connection", "drama");
            MovieCatalog[70] = new Movie("Forrest Gump", "drama");
            MovieCatalog[71] = new Movie("Ben-Hur", "drama");
            MovieCatalog[72] = new Movie("Wuthering Heights", "drama");
            MovieCatalog[73] = new Movie("The Gold Rush", "drama");
            MovieCatalog[74] = new Movie("Dances With Wolves", "drama");
            MovieCatalog[75] = new Movie("City Lights", "drama");
            MovieCatalog[76] = new Movie("American Graffiti", "drama");
            MovieCatalog[77] = new Movie("Rocky", "drama");
            MovieCatalog[78] = new Movie("The Deer Hunter", "drama");
            MovieCatalog[79] = new Movie("The Wild Bunch", "drama");
            MovieCatalog[80] = new Movie("Modern Times", "drama");
            MovieCatalog[81] = new Movie("Giant", "drama");
            MovieCatalog[82] = new Movie("Platoon", "drama");
            MovieCatalog[83] = new Movie("Fargo", "drama");
            MovieCatalog[84] = new Movie("Duck Soup", "comedy");
            MovieCatalog[85] = new Movie("Mutiny On The Bounty", "drama");
            MovieCatalog[86] = new Movie("Frankenstein", "horror");
            MovieCatalog[87] = new Movie("Easy Rider", "drama");
            MovieCatalog[88] = new Movie("Patton", "drama");
            MovieCatalog[89] = new Movie("The Jazz Singer", "drama");
            MovieCatalog[90] = new Movie("My Fair Lady", "musical");
            MovieCatalog[91] = new Movie("A Place In The Sun", "drama");
            MovieCatalog[92] = new Movie("The Apartment", "drama");
            MovieCatalog[93] = new Movie("Goodfellas", "drama");
            MovieCatalog[94] = new Movie("Pulp Fiction", "drama");
            MovieCatalog[95] = new Movie("The Searchers", "drama");
            MovieCatalog[96] = new Movie("Bringing Up Baby", "drama");
            MovieCatalog[97] = new Movie("Unforgiven", "drama");
            MovieCatalog[98] = new Movie("Guess Who's Coming To Dinner", "drama");
            MovieCatalog[99] = new Movie("Yankee Doodle Dandy", "musical");

            
            

                Console.WriteLine("Welcome to the Movie List Application!\n");
                Console.WriteLine("There are 100 movies in this list.\n");
                Console.WriteLine("What category are you interested in?\n");
                string movieCategory = Console.ReadLine();
            Console.WriteLine();

                for (int i = 0; i < MovieCatalog.Length; i++)
                {
                    Movie movie = MovieCatalog[i];
                    if (movie.Category == movieCategory)
                    {
                        Console.WriteLine(movie.Title);
                        
                }
                }
            Console.WriteLine();
            Console.WriteLine("Continue?");
                string continueAnswer = Console.ReadLine();
            
            } 
        }
    }

