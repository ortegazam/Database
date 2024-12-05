namespace CharacterCreation
{
    public class Features
    {
        public string playerName { get; set; }
        public int playerAge { get; set; }
        public string playerGender { get; set; }
        public string teamType { get; set; }
        public string hunterSkill { get; set; }
        public string survivorSkill { get; set; }
        public string weapon { get; set; }
        public string ability { get; set; }
        public string hairStyle { get; set; }
        public string scar { get; set; }
        public string faceShape { get; set; }
        public string faceExpression { get; set; }
        public string hairColor { get; set; }
        public string skinColor { get; set; }
        public string eyeColor { get; set; }
        public string playerTop { get; set; }
        public string playerPants { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string hat { get; set; }
        public string buff { get; set; }
        public string glasses { get; set; }
        public string necklace { get; set; }
        public string bracelet { get; set; }
        public string anklet { get; set; }
        public string armor { get; set; }
        public string attitude { get; set; }
        public int stats { get; set; }
        public int health { get; set; }
        public int strength { get; set; }
        public int stamina { get; set; }
        public int speed { get; set; }
        public int energy { get; set; }
        public bool boost { get; set; }


        public Features(string name, string gender, int age, int stats, string armor,
            string anklet, string team, string hunter, string survivor, string weapon, string ability, bool boost,
            int health, int speed, int energy, int stamina, string attitude, string lace,
            string bracelet, string pants, string top, string glasses, int strength,
            string scar, string style, string shape, string expression, string hat, string color, string skin,
            string eyes, string height, string weight)
        {
            this.playerName = name;
            this.playerAge = age;
            this.playerGender = gender;
            this.teamType = team;
            this.survivorSkill = survivor;
            this.hunterSkill = hunter;
            this.weapon = weapon;
            this.ability = ability;
            this.hairStyle = style;
            this.hairColor = color;
            this.scar = scar;
            this.faceShape = shape;
            this.faceExpression = expression;
            this.skinColor = skin;
            this.eyeColor = eyes;
            this.playerTop = top;
            this.height = height;
            this.weight = weight;
            this.hat = hat;
            this.glasses = glasses;
            this.necklace = lace;
            this.bracelet = bracelet;
            this.anklet = anklet;
            this.armor = armor;
            this.attitude = attitude;
            this.stats = stats;
            this.health = health;
            this.strength = strength;
            this.stamina = stamina;
            this.speed = speed;
            this.energy = energy;
            this.boost = boost;
        }

        public Features()
        {
        }
    }
}