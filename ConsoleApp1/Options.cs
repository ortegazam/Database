
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals
{
    public class Options
    {
        public void age()
        {
            Console.WriteLine($"[1] Child {"",-17} | (7 - 13 years old)");
            Console.WriteLine($"[2] Teenager {"",-14} | (14 - 20 years old)");
            Console.WriteLine($"[3] Adult {"",-17} | (21 - 40 years old)");
            Console.WriteLine($"[4] Middle Age {"",-12} | (41 - 55 years old)");
            Console.WriteLine($"[5] Old {"",-19} | (56 years old above)");
        }
        public void gender()
        {
            Console.WriteLine($"{"[A]",-5}Agender");
            Console.WriteLine($"{"[B]",-5}Cisgender");
            Console.WriteLine($"{"[C]",-5}Nonbinary");
            Console.WriteLine($"{"[D]",-5}Gender Neutral");
            Console.WriteLine($"{"[E]",-5}Pangender");
            Console.WriteLine($"{"[F]",-5}Androgyne");
            Console.WriteLine($"{"[G]",-5}Transgender");
            Console.WriteLine($"{"[H]",-5}Bigender");
            Console.WriteLine($"{"[I]",-5}Others");
        }
        public void hairStyle()
        {
            Console.WriteLine("Clean Cut");
            Console.WriteLine("Buzz Cut");
            Console.WriteLine("Fade Cut");
            Console.WriteLine("Wolf Cut");
            Console.WriteLine("Long Hair");
        }
        public void hairColor()
        {
            Console.WriteLine("Red");
            Console.WriteLine("Black");
            Console.WriteLine("Brown");
            Console.WriteLine("Orange");
            Console.WriteLine("Blonde");
        }
        public void skinColor()
        {
            Console.WriteLine("Brown");
            Console.WriteLine("Black");
            Console.WriteLine("White");
            Console.WriteLine("Yellow");
            Console.WriteLine("Porcelain");
        }
        public void eyeColor()
        {
            Console.WriteLine("Brown");
            Console.WriteLine("Black");
            Console.WriteLine("Red");
            Console.WriteLine("Blue");
            Console.WriteLine("Green");
        }
        public void scar()
        {
            Console.WriteLine("Eye Scar");
            Console.WriteLine("Leg Scar");
            Console.WriteLine("Arm Scar");
            Console.WriteLine("Chest Scar");
            Console.WriteLine("Shoulder Scar");
        }
        public void hunterSkills()
        {
            Console.WriteLine($"\n{"Doppelganger:",-5}You can pretend as one of the survivors whom you killed before within a brief period.");
            Console.WriteLine($"{"Poltergeist:",-5} You can be invisible for a brief period. Your steps will still be heard by the survivors.");
            Console.WriteLine($"{"Trickster:",-5} You can trick the survivors that you are dead.");
            Console.WriteLine($"{"Phantom:",-5} Your steps will not be heard by the survivors in a limited time. ");
            Console.WriteLine($"{"Assassin:",-5} Once you spot a survivor, you can kill them despite out of range. ");
        }
        public void survivorSkills()
        {
            Console.WriteLine($"\nAce In The Hole: You can use any of ‘Blood Pact,’ ‘Circle of Healing,’ Borrowed Time, Critical Thinking.");
            Console.WriteLine($"Blood Pact: You can reduce the Hunter’s health upon casting.");
            Console.WriteLine($"Circle of Healing: You can heal your Health with a random amount");
            Console.WriteLine($"Borrowed Time: You can go back in time, where you are still not eaten by the hunter.");
            Console.WriteLine($"Critical Thinking: You will be given a hint of where to use the clues you currently have.");
        }
        public void weapon()
        {
            Console.WriteLine($"\nRifle: A gun that can slow down the hunter.");
            Console.WriteLine($"Machete: A weapon that can scratch the hunter.");
            Console.WriteLine($"Axe:  A weapon that can scratch the hunter, but it looks like it’s been used before.");
            Console.WriteLine($"Pistol: A gun that can slow down the hunter, but you might run out of ammo soon.");
            Console.WriteLine($"Bow and Arrow: Left by an archer who lost their life inside the mansion.");
            Console.WriteLine($"Grenade Launcher: A weapon that may be able to kill the hunter.");
        }
        public void ability()
        {
            Console.WriteLine($"Healing: This ability allows the player to recover half of their current health.");
            Console.WriteLine($"Sword Wielder: The player will be able to efficiently wield a sword once obtained.");
            Console.WriteLine($"Marksman: The player will have the ability to shoot the enemy once obtained.");
            Console.WriteLine($"Clairvoyance: The player will be notified if the enemy’s nearby.");
            Console.WriteLine($"Silent Steps: The player will be able to escape the enemy’s range of sight unnoticed.");
        }
        public void shape()
        {
            Console.WriteLine("Triangular");
            Console.WriteLine("Oval");
            Console.WriteLine("Circle");
            Console.WriteLine("Square");
            Console.WriteLine("Diamond");
        }
        public void expression()
        {
            Console.WriteLine("Angry");
            Console.WriteLine("Sad");
            Console.WriteLine("Smile");
            Console.WriteLine("Calm");
            Console.WriteLine("Confused");
        }
        public void heights()
        {
            Console.WriteLine("Short");
            Console.WriteLine("Average");
            Console.WriteLine("Tall");
            Console.WriteLine("Dwarf");
            Console.WriteLine("Giant");
        }
        public void weights()
        {
            Console.WriteLine("Skinny");
            Console.WriteLine("Slim");
            Console.WriteLine("Fit");
            Console.WriteLine("Plum");
            Console.WriteLine("Fat");

        }
        public void armors()
        {
            Console.WriteLine($"Sturdy Armor: ‘Left by a knight from an unknown era. Does it mean the mansion’s already up by then?’ The hunter will not be able to eat you the first time. Make sure they do not have a second time. ");
            Console.WriteLine($"Leather Armor: ‘Made from an animal’s skin, the animal’s stench remains.’ The hunter might be able to eat you deliciously once you wear this within their radius. However, they might also think it is one of their emergency foods: the hounds. \r\n");
            Console.WriteLine($"Iron Armor: A heavy armor which came from a civilian who also came across the mansion. But also died. His soul remains inside the armor. Upon wearing this, you might feel hallucinations or perhaps, clues to the mansion’s secrets. ");
            Console.WriteLine($"Chain Armor: Because of the heaviness of the armor, the previous owner died because they lost the ability to run. Upon wearing this, your steps will be heavy. But the hunter will believe it is just one of his allies. ");
            Console.WriteLine($"Cloth Armor: Filled with blood, the previous owner’s wrath against the hunters remained inside the armor. Upon wearing this, you will be able to use blood pact occasionally, but with a health rebound. ");

        }
        public void attitudes()
        {
            Console.WriteLine("\nPlease choose your attitude:\n");
            Console.WriteLine($"\nWistful: Because of the sudden accident, you miss your family and friends. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"Enthusiastic: You consider the accident as fate. An adventure. No debuffs or buffs will commence upon selection.  ");
            Console.WriteLine($"Calm: You know this is a trial you must overcome to survive in a world much harsher than this. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"Scared: You are not a fan of horror, and you hate gore. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"Blank: You do not care. No debuffs or buffs will commence upon selection. ");

        }
    }
}
