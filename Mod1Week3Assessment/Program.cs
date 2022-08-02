/* 
 * In the program below, there are 6 exercises to be completed.
 * Some of the exercises will have some portion to uncomment as you work through them.  Read each 
 * exercse's instructions for specific lines to be uncommented.
 * 
 * When you have finished, commit your work and push up to GitHub - instructors
 * will followup with some video feedback :)
 */

namespace Mod1Week3Assessment
{
    class Program
    {
        static void Main()
        {

            //Exercise 1 (2 points available)
            //In the space below, correct the implementation of list and dictionary assignment.  To check if your syntax is correct, remove the multiline comments.

            /*TO CHECK SYNTAX, REMOVE THIS LINE...
            podcasts = new List() { "Up First", "Consider This", "Stuff You Should Know" };

            podcastEpisodeCount = new Dictionary
                { "Up First", 800}
                { "Consider This", 360 }
                { "Stuff You should Know", 1460 }
            ... AND REMOVE THIS LINE*/


            //Exercise 2 (2 points available)
            //Replace the blanks in the code below to print some information about the given list.  When completed, remove the multiline comments.

            /*TO CHECK SYNTAX, REMOVE THIS LINE...
            IList<string> tvShows = new List<string>();
            tvShows._____("Saturday Night Live"); // This line should add a tv show to our list
            tvShows._____("The Tonight Show"); // This line should add a tv show to our list
            tvShows._____("Late Night"); // This line should add a tv show to our list

            Console.WriteLine($"The second show in this list is: {_______}"); // use the tvShows index to include "The Tonight Show" in the output.

            Console.WriteLine("A list of NBC shows:");
            foreach(________)
            {
                Console.WriteLine(_______);
            }
            ... AND REMOVE THIS LINE*/

            //Exercise 3 (2 points available)
            //The two method definitions below have syntax errors - update the definitions so that the methods will run. When completed, remove the multiline comments indicated.

            /*TO CHECK SYNTAX, REMOVE THIS LINE...
            static Hello()
            {
                return "Hello, World!";
            }

            Hello();

            static SaySomething()
            {
                Console.WriteLine(Hello());
            }

            SaySomething();
            ... AND REMOVE THIS LINE*/

            //Exercise 4 (2 points available)
            //For the two methods in exercise 3 above, write 3-5 sentences describing the differences between the two methods.
            //If you were able to get the methods to run, describe how you fixed the syntax errors.
            //If you got stuck on exercise 3, describe what you tried.

            /*
             <YOUR ANSWER HERE>
            */

            //Exercise 5 (2 points available)
            // In the space below, describe what a Class is.  Imagine you are explaining this concept to someone who has no programming experience.
            /*
             <YOUR ANSWER HERE>
            */

            //Exercise 6 (10 points available)
            /*
            Uncomment each of the lines below, in order (one by one), and implement the code needed for each line to compile and run.  You will need to write code in *this* file, and in the book.cs file!
            These lines will prompt you to create a Book class that has a constructor that takes three arguments: `(string title, string description, string publicationYear)`.
            A book will have 4 properities: string Title, string Description, string PublicationYear, and List<string> Authors.
            A book will have a method .AddAuthor(string author), that will add an author the the list of Authors.
            A book will have a method .Summary() that returns a string that includes the book's Title, Authors, Publication Year and Description.  It might look like:
                Good Omens
                By: Neil Gaiman, Terry Pratchett

                According to The Nice and Accurate Prophecies of Agnes Nutter, Witch 
                (the world's only completely accurate book of prophecies, ....

                Published in 1990
             */

            //var goodOmensDescription = "According to The Nice and Accurate Prophecies of Agnes Nutter, Witch (the world's only completely accurate book of prophecies, written in 1655, before she exploded), the world will end on a Saturday.  Next Saturday, in fact.  Just before dinner";
            //________ book = ___ ________("Good Omens", goodOmensDescription, "1990");

            //Console.WriteLine(book.Title);

            //Console.WriteLine(book.Description);

            //Console.WriteLine(book.PublicationYear);

            //Console.WriteLine(book.Authors);

            //book.AddAuthor("Neil Gaiman");
            //book.AddAuthor("Terry Pratchett");

            //Console.WriteLine(book.Summary());

        }
    }
}



