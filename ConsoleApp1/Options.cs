
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public class Options
    {
        public static void age()
        {
            Console.WriteLine($"[1] Child {"",-17} | (7 - 13 years old)");
            Console.WriteLine($"[2] Teenager {"",-14} | (14 - 20 years old)");
            Console.WriteLine($"[3] Adult {"",-17} | (21 - 40 years old)");
            Console.WriteLine($"[4] Middle Age {"",-12} | (41 - 55 years old)");
            Console.WriteLine($"[5] Old {"",-19} | (56 years old above)");
        }
        public static void gender()
        {
            Console.WriteLine($"{"[1]",-5}Female");
            Console.WriteLine($"{"[2]",-5}Male");
            Console.WriteLine($"{"[3]",-5}Nonbinary");
            Console.WriteLine($"{"[4]",-5}Prefer not to say");
            Console.WriteLine($"{"[5]",-5}Others");
        }
        public static void hairStyle()
        {
            Console.WriteLine($"{"[1]",-5}Clean Cut");
            Console.WriteLine($"{"[2]",-5}Buzz Cut");
            Console.WriteLine($"{"[3]",-5}Fade Cut");
            Console.WriteLine($"{"[4]",-5}Wolf Cut");
            Console.WriteLine($"{"[5]",-5}Long Hair");
        }
        public static void hairColor()
        {
            Console.WriteLine($"{"[1]",-5}Red");
            Console.WriteLine($"{"[2]",-5}Black");
            Console.WriteLine($"{"[3]",-5}Brown");
            Console.WriteLine($"{"[4]",-5}Orange");
            Console.WriteLine($"{"[5]",-5}Blonde");
        }
        public static void skinColor()
        {
            Console.WriteLine($"{"[1]",-5}Brown");
            Console.WriteLine($"{"[1]",-5}Black");
            Console.WriteLine($"{"[1]",-5}White");
            Console.WriteLine($"{"[1]",-5}Yellow");
            Console.WriteLine($"{"[1]",-5}Porcelain");
        }
        public static void eyeColor()
        {
            Console.WriteLine($"{"[1]",-5}Brown");
            Console.WriteLine($"{"[2]",-5}Black");
            Console.WriteLine($"{"[3]",-5}Red");
            Console.WriteLine($"{"[4]",-5}Blue");
            Console.WriteLine($"{"[5]",-5}Green");
        }
        public static void scar()
        {
            Console.WriteLine($"{"[1]",-5}Eye Scar");
            Console.WriteLine($"{"[2]",-5}Leg Scar");
            Console.WriteLine($"{"[3]",-5}Arm Scar");
            Console.WriteLine($"{"[4]",-5}Chest Scar");
            Console.WriteLine($"{"[5]",-5}Shoulder Scar");
        }
        public static void hunterSkills()
        {
            Console.WriteLine($"{"[1]",-5}Doppelganger:You can pretend as one of the survivors whom you killed before within a brief period.");
            Console.WriteLine($"{"[2]",-5}Poltergeist: You can be invisible for a brief period. Your steps will still be heard by the survivors.");
            Console.WriteLine($"{"[3]",-5}Trickster: You can trick the survivors that you are dead.");
            Console.WriteLine($"{"[4]",-5}Phantom: Your steps will not be heard by the survivors in a limited time. ");
            Console.WriteLine($"{"[5]",-5}Assassin: Once you spot a survivor, you can kill them despite out of range. ");
        }
        public static void survivorSkills()
        {
            Console.WriteLine($"{"[1]",-5}Ace In The Hole: You can use any of ‘Blood Pact,’ ‘Circle of Healing,’ Borrowed Time, Critical Thinking.");
            Console.WriteLine($"{"[2]",-5}Blood Pact: You can reduce the Hunter’s health upon casting.");
            Console.WriteLine($"{"[3]",-5}Circle of Healing: You can heal your Health with a random amount");
            Console.WriteLine($"{"[4]",-5}Borrowed Time: You can go back in time, where you are still not eaten by the hunter.");
            Console.WriteLine($"{"[5]",-5}Critical Thinking: You will be given a hint of where to use the clues you currently have.");
        }
        public static void weapon()
        {
            Console.WriteLine($"{"[1]",-5}Rifle: A gun that can slow down the hunter.");
            Console.WriteLine($"{"[2]",-5}Machete: A weapon that can scratch the hunter.");
            Console.WriteLine($"{"[3]",-5}Axe:  A weapon that can scratch the hunter, but it looks like it’s been used before.");
            Console.WriteLine($"{"[4]",-5}Pistol: A gun that can slow down the hunter, but you might run out of ammo soon.");
            Console.WriteLine($"{"[5]",-5}Bow and Arrow: Left by an archer who lost their life inside the mansion.");

        }
        public static void ability()
        {
            Console.WriteLine($"{"[1]",-5}Healing: This ability allows the player to recover half of their current health.");
            Console.WriteLine($"{"[2]",-5}Sword Wielder: The player will be able to efficiently wield a sword once obtained.");
            Console.WriteLine($"{"[3]",-5}Marksman: The player will have the ability to shoot the enemy once obtained.");
            Console.WriteLine($"{"[4]",-5}Clairvoyance: The player will be notified if the enemy’s nearby.");
            Console.WriteLine($"{"[5]",-5}Silent Steps: The player will be able to escape the enemy’s range of sight unnoticed.");
        }
        public static void shape()
        {
            Console.WriteLine($"{"[1]",-5}Triangular");
            Console.WriteLine($"{"[2]",-5}Oval");
            Console.WriteLine($"{"[3]",-5}Circle");
            Console.WriteLine($"{"[4]",-5}Square");
            Console.WriteLine($"{"[5]",-5}Diamond");
        }
        public static void expression()
        {
            Console.WriteLine($"{"[1]",-5}Angry");
            Console.WriteLine($"{"[1]",-5}Sad");
            Console.WriteLine($"{"[1]",-5}Smile");
            Console.WriteLine($"{"[1]",-5}Calm");
            Console.WriteLine($"{"[1]",-5}Confused");
        }
        public static void heights()
        {
            Console.WriteLine($"{"[1]",-5}Short");
            Console.WriteLine($"{"[2]",-5}Average");
            Console.WriteLine($"{"[3]",-5}Tall");
            Console.WriteLine($"{"[4]",-5}Dwarf");
            Console.WriteLine($"{"[5]",-5}Giant");
        }
        public static void weights()
        {
            Console.WriteLine($"{"[1]",-5}Skinny");
            Console.WriteLine($"{"[2]",-5}Slim");
            Console.WriteLine($"{"[3]",-5}Fit");
            Console.WriteLine($"{"[4]",-5}Plum");
            Console.WriteLine($"{"[5]",-5}Fat");

        }
        public static void armors()
        {
            Console.WriteLine($"{"[1]",-5}Sturdy Armor: ‘Left by a knight from an unknown era. Does it mean the mansion’s already up by then?’ The hunter will not be able to eat you the first time. Make sure they do not have a second time. ");
            Console.WriteLine($"{"[2]",-5}Leather Armor: ‘Made from an animal’s skin, the animal’s stench remains.’ The hunter might be able to eat you deliciously once you wear this within their radius. However, they might also think it is one of their emergency foods: the hounds. \r\n");
            Console.WriteLine($"{"[3]",-5}Iron Armor: A heavy armor which came from a civilian who also came across the mansion. But also died. His soul remains inside the armor. Upon wearing this, you might feel hallucinations or perhaps, clues to the mansion’s secrets. ");
            Console.WriteLine($"{"[4]",-5}Chain Armor: Because of the heaviness of the armor, the previous owner died because they lost the ability to run. Upon wearing this, your steps will be heavy. But the hunter will believe it is just one of his allies. ");
            Console.WriteLine($"{"[5]",-5}Cloth Armor: Filled with blood, the previous owner’s wrath against the hunters remained inside the armor. Upon wearing this, you will be able to use blood pact occasionally, but with a health rebound. ");

        }
        public static void attitudes()
        {
            Console.WriteLine("\nPlease choose your attitude:\n");
            Console.WriteLine($"{"[1]",-5}Wistful: Because of the sudden accident, you miss your family and friends. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"{"[2]",-5}Enthusiastic: You consider the accident as fate. An adventure. No debuffs or buffs will commence upon selection.  ");
            Console.WriteLine($"{"[3]",-5}Calm: You know this is a trial you must overcome to survive in a world much harsher than this. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"{"[4]",-5}Scared: You are not a fan of horror, and you hate gore. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"{"[5]",-5}Blank: You do not care. No debuffs or buffs will commence upon selection. ");

        }
    }
}
