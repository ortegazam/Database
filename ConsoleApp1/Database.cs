using System;
using System.Collections.Generic;
using CharacterCreation;
using System.Data.SqlClient;

namespace CharacterCreation
{
    public class SampleDatabase
    {
        
    }
}
    /*
    public class SQLConnection
    {
        private static MySqlConnection connMaster;

        private static string server = "localhost";
        private static string database = "charactercreationdb";
        private static string Uid = "root";
        private static string password = "password";
        public SQLConnection()
        {
            string connectionString = $"server={server};database={database};User Id={Uid};Password={password};";
            connMaster = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connMaster ?? throw new Exception("Connection cannot be established!");
        }

        public void ConnOpen()
        {
            if (connMaster.State == System.Data.ConnectionState.Closed)
            {
                connMaster.Open();
            }
        }

        public void ConnClose()
        {
            if (connMaster.State == System.Data.ConnectionState.Open)
            {
                connMaster.Close();
            }
        }

        static SQLConnection con = new SQLConnection();
       
       
        // Add character to SQL Database
        public static void AddToSQLDatabase(object[] informationArray)
        {
            try
            {


                string PlayerName = Convert.ToString(informationArray[0]);
                string PlayerAge = Convert.ToString(informationArray[0]);
                string PlayerGender = Convert.ToString(informationArray[0]);
                string TeamType = Convert.ToString(informationArray[0]);
                string HunterSkill = Convert.ToString(informationArray[0]);
                string SurvivorSkill = Convert.ToString(informationArray[0]);
                string Weapon = Convert.ToString(informationArray[0]);
                string Ability = Convert.ToString(informationArray[0]);
                string HairStyle = Convert.ToString(informationArray[0]);
                string Scar = Convert.ToString(informationArray[0]);
                string FaceShape = Convert.ToString(informationArray[0]);
                string FaceExpression = Convert.ToString(informationArray[0]);
                string HairColor = Convert.ToString(informationArray[0]);
                string SkinColor = Convert.ToString(informationArray[0]);
                string EyeColor = Convert.ToString(informationArray[0]);
                string PlayerTop = Convert.ToString(informationArray[0]);
                string PlayerPants = Convert.ToString(informationArray[0]);
                string Height = Convert.ToString(informationArray[0]);
                string Weight = Convert.ToString(informationArray[0]);
                string Buff = Convert.ToString(informationArray[0]);
                string Hat = Convert.ToString(informationArray[0]);

                con.ConnOpen();
                string sql = "INSERT INTO characterInformation VALUES (@characterName, @moonCycle, @form, @pirateCode, @mainWeapon, @secondarySkill, @natureSkill, @additionalSkill, @physicalTrademark, @skinTone, @hairStyle, @facialHair, @baseClothing, @accessory, @pirateOrigin, @shipType, @shipSize, @pet, @crew, @trigger, @debuff)";

                using (MySqlCommand cmd = new MySqlCommand(sql, con.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@characterName", characterName);
                    cmd.Parameters.AddWithValue("@moonCycle", moonCycle);
                    cmd.Parameters.AddWithValue("@form", form);
                    cmd.Parameters.AddWithValue("@pirateCode", pirateCode);
                    cmd.Parameters.AddWithValue("@mainWeapon", mainWeapon);
                    cmd.Parameters.AddWithValue("@secondarySkill", secondarySkill);
                    cmd.Parameters.AddWithValue("@natureSkill", natureSkill);
                    cmd.Parameters.AddWithValue("@additionalSkill", additionalSkill);
                    cmd.Parameters.AddWithValue("@physicalTrademark", physicalTrademark);
                    cmd.Parameters.AddWithValue("@skinTone", skinTone);
                    cmd.Parameters.AddWithValue("@hairStyle", hairStyle);
                    cmd.Parameters.AddWithValue("@facialHair", facialHair);
                    cmd.Parameters.AddWithValue("@baseClothing", baseClothing);
                    cmd.Parameters.AddWithValue("@accessory", accessory);
                    cmd.Parameters.AddWithValue("@pirateOrigin", pirateOrigin);
                    cmd.Parameters.AddWithValue("@shipType", shipType);
                    cmd.Parameters.AddWithValue("@shipSize", shipSize);
                    cmd.Parameters.AddWithValue("@pet", pet);
                    cmd.Parameters.AddWithValue("@crew", crew);
                    cmd.Parameters.AddWithValue("@trigger", trigger);
                    cmd.Parameters.AddWithValue("@debuff", debuff);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                con.ConnClose();
            }
            finally
            {
                con.ConnClose();
            }
        }
        // Remove character from SQL
        public static void RemoveFromSQLDatabase(CharacterClass horrorCharacter)
        {
            try
            {
                string characterName = horrorCharacter.gs.playerName;

                con.ConnOpen();
                string sql = "DELETE FROM characterInformation WHERE characterName = @characterName";

                using (MySqlCommand cmd = new MySqlCommand(sql, con.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@characterName", characterName);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                con.ConnClose();
            }
            finally
            {
                con.ConnClose();
            }
        }
    }
}
*/