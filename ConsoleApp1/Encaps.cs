namespace CharacterCreation
{

    public struct GameStruc
    {
        public string playerName { get; set; }
        public string playerAge { get; set; }
        public string playerGender { get; set; }

        public GameStruc(string playerName, string playerAge, string playerGender)
        {
            this.playerName = playerName;
            this.playerAge = playerAge;
            this.playerGender = playerGender;
        } 
    }
    public class UserFeatures
    {
         
        public string PlayerName { get; set; }
        public string PlayerAge { get; set; }
        public string PlayerGender { get; set; }
        public string TeamType { get; set; }
        public string HunterSkill { get; set; }
        public string SurvivorSkill { get; set; }
        public string Weapon { get; set; }
        public string Ability { get; set; }
        public string HairStyle { get; set; }
        public string Scar { get; set; }
        public string FaceShape { get; set; }
        public string FaceExpression { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string PlayerTop { get; set; }
        public string PlayerPants { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Buff { get; set; }
        public static string Hat { get; set; }
        public static string Glasses { get; set; }
        public static string Necklace { get; set; }
        public static string Bracelet { get; set; }
        public static string Anklet { get; set; }
        public string Armor { get; set; }
        public string Attitude { get; set; }
        public int Stats { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Speed { get; set; }
        public int Energy { get; set; }
        public bool accessories { get; set; }


        public UserFeatures(string name, string gender, string age, int stats, string armor,
            string anklet, string team, string hunter, string survivor, string weapon, string ability, bool accessories,
            int health, int speed, int energy, int stamina, string attitude, string lace,
            string bracelet, string top, string glasses, int strength,
            string scar, string style, string shape, string expression, string hat, string color, string skin,
            string eyes, string height, string weight)
        {
            this.PlayerName = name;
            this.PlayerAge = age;
            this.PlayerGender = gender;
            this.TeamType = team;
            this.SurvivorSkill = survivor;
            this.HunterSkill = hunter;
            this.Weapon = weapon;
            this.Ability = ability;
            this.HairStyle = style;
            this.HairColor = color;
            this.Scar = scar;
            this.FaceShape = shape;
            this.FaceExpression = expression;
            this.SkinColor = skin;
            this.EyeColor = eyes;
            this.PlayerTop = top;
            this.Height = height;
            this.Weight = weight;
            UserFeatures.Hat = hat;
            UserFeatures.Glasses = glasses;
            UserFeatures.Necklace = lace;
            UserFeatures.Bracelet = bracelet;
            UserFeatures.Anklet = anklet;
            this.Armor = armor;
            this.Attitude = attitude;
            this.Stats = stats;
            this.Health = health;
            this.Strength = strength;
            this.Stamina = stamina;
            this.Speed = speed;
            this.Energy = energy;
            this.accessories = accessories;

           
        }

        public UserFeatures()
        {
        }
    }
}
        
    



 