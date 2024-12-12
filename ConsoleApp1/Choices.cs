using System;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using CharacterCreation;


namespace CharacterCreation
{
    public class Choices
    {
        public void NewGame()
        {

            Menu menu = new Menu();
            CharacSheets character = new CharacSheets();
            CharacterClass horrorCharac = new CharacterClass();

            bool placeholder = false;

            while (!placeholder)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("You have reached death! WELCOME to 'Reaching Death'!");
                    Console.WriteLine("(1) Create New Character");
                    Console.WriteLine("(2) Return");

                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        character.PlayerName(horrorCharac);
                        placeholder = true;
                    }
                    //     if (choice == 2) { Menu.MainMenu(horrorCharac); }

                    else { throw new ArgumentException("Invalid input. Try again!"); }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Press any key to continue. ");
                    Console.ReadKey();
                }

            }
        }
        public void CurrentGame()
        {
            bool ph = false;

            while (!ph)
            {
                string filePath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zam\Documents\Finals\MainFile\ConsoleApp1\Database1.mdf;Integrated Security=True";

                string query = "SELECT * FROM HorrorGame";

                SqlConnection connection = new SqlConnection(filePath);
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int characList = reader.GetInt32(0);
                            string playerName = reader.GetString(1);

                            Console.WriteLine($"Player ID: {characList} {"", -5} {"|", -5} {playerName}");
                         //   Console.WriteLine("Player Name: " + playerName);

                        }
                    }
                    else
                    {
                        Console.WriteLine("No entries found.");
                    }
                    CharacterClass horrorCharacter = new CharacterClass();

                    connection.Close();

                    Console.WriteLine("[1] Go back to main menu");
                    Console.WriteLine("[2] Delete Character ");

                    connection.Open(); 
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Menu.MainMenu(horrorCharacter);
                            break;
                        case "2":
                            DeletePlayer(horrorCharacter);
                            break;
                    }
                }
            }
        }

        public void CampaignMode()
        {
            bool ph = false;


            while (!ph)
            {
                foreach (string paragraph in UserFeatures.gameStory)
                {

                    char[] charParagraph = paragraph.ToCharArray();
                    foreach (char characters in charParagraph)
                    {
                        Console.Write(characters);
                        Thread.Sleep(10);
                    }
                    Console.WriteLine("\n");
                }
                try
                {
                    CharacterClass horrorCharacter = new CharacterClass();

                    Console.WriteLine();
                    Console.WriteLine("\nDo you wish to continue?");
                    Console.WriteLine("Press Y to continue.");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "Y":
                            Menu.MainMenu(horrorCharacter);
                            ph = true;
                            break;
                        case "y":
                            Menu.MainMenu(horrorCharacter);
                            ph = true;
                            break;
                        default:
                            throw new ArgumentException("Invalid input. Please try again!");
                    }
                }
                catch (ArgumentException ex) { Console.WriteLine("Error: " + ex.Message); }
            }
        }

        public void Credits()
        {
            Console.WriteLine("Zam Ortega: Leader, programmer, pabuhat");
            Console.WriteLine("Jomar Cruz: Documentation");
            Console.WriteLine("Ethan Raphael Concepcion: Documentation");
            Console.WriteLine("Luis Rivera: Pancit Canton");
            Console.WriteLine("Reyn Penus: Certified Pancit Canton");
            Console.WriteLine("Raven Villanueva");
            Console.WriteLine("Emmanuel Caraig");
            Console.WriteLine("\nGo back to main menu?");
            Console.WriteLine("(1) YES");
            Console.WriteLine("(2) NO");

            string choice = Console.ReadLine();
        }
        public static void DeletePlayer(CharacterClass horrorCharacter)
        {
            string filePath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zam\Documents\Finals\MainFile\ConsoleApp1\Database1.mdf;Integrated Security=True";

            // First, let the user choose the PlayerID
            Console.WriteLine("Enter the Player ID to delete:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int playerId))
            {
                string selectQuery = "SELECT PlayerID, PlayerName FROM HorrorGame WHERE PlayerID = @PlayerID";

                using (SqlConnection connection = new SqlConnection(filePath))
                {
                    connection.Open();

                    // Use a separate SqlCommand for the SELECT operation
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@PlayerID", playerId);

                    // Execute the SELECT command and check if the player exists
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                        
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                Console.WriteLine($"Player to delete: {name} (ID: {id})");

                               
                                Console.WriteLine("Do you want to delete this player? (Y/N)");
                                string confirmation = Console.ReadLine();

                                if (confirmation.ToUpper() == "Y")
                                {
                                  
                                    string deleteQuery = "DELETE FROM HorrorGame WHERE PlayerID = @PlayerID";
                                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                                    deleteCommand.Parameters.AddWithValue("@PlayerID", playerId);

                                
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        Console.WriteLine($"Successfully deleted player with ID '{playerId}'.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"No player found with ID '{playerId}'.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Player deletion cancelled.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No player found with that ID.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric Player ID.");
            }
        }


    }
}
