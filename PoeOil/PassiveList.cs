using System;
using System.Collections.Generic;
using System.Text;

namespace PoeOil
{
    public class PassiveList
    {


        public static List<Passive> AllPassives = new List<Passive>
        {
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Clear Oil"), Name = "Alacrity", Effect = @"30 to Dexterity" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Sepia Oil"), Name = "Beef", Effect = @"30 to Strength" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Sepia Oil"), Name = "Agility", Effect = @"30 to Dexterity" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Amber Oil"), Name = "Wisdom of the Glade", Effect = @"30 to Intelligence" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Sepia Oil"), Name = "Expertise", Effect = @"30 to Dexterity" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Amber Oil"), Name = "Thief's Craft", Effect = @"30 to Intelligence" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Verdant Oil"), Name = "Prowess", Effect = @"30 to Strength" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Amber Oil"), Name = "Proficiency", Effect = @"30 to Dexterity" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Verdant Oil"), Name = "Ancestral Knowledge", Effect = @"30 to Intelligence" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Amber Oil"), Name = "Might", Effect = @"30 to Strength" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Verdant Oil"), Name = "Fending", Effect = @"25% increased Knockback Distance
12% chance to Knock Enemies Back on hit" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Amber Oil"), Name = "Hard Knocks", Effect = @"30 to Intelligence" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Teal Oil"), Name = "Physique", Effect = @"30 to Strength" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Verdant Oil"), Name = "Arcane Vision", Effect = @"Light Radius is based on Energy Shield instead of Life
+30 to Accuracy Rating" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Teal Oil"), Name = "Diamond Skin", Effect = @"24% increased Armour
3% increased Movement Speed
+12% to all Elemental Resistances" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Verdant Oil"), Name = "Path of the Savant", Effect = @"20 to Intelligence
+20 to maximum Mana
16% increased Spell Damage" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Amber Oil"), Name = "Path of the Warrior", Effect = @"20 to Strength
12% increased Physical Damage
+10 to Armour" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Verdant Oil"), Name = "Path of the Hunter", Effect = @"20 to Dexterity
12% increased Projectile Damage
+20 to Accuracy Rating" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Teal Oil"), Name = "Righteous Decree", Effect = @"22% increased maximum Mana
6% reduced Mana Cost of Skills" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Teal Oil"), Name = "Ironwood", Effect = @"25% increased Totem Damage
Totems gain +16% to all Elemental Resistances
Totems have 10% additional Physical Damage Reduction" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Verdant Oil"), Name = "Fusillade", Effect = @"15% increased Attack Speed with Wands
30% increased Accuracy Rating with Wands" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Verdant Oil"), Name = "Quickstep", Effect = @"6% increased Attack Speed
4% increased Movement Speed" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Teal Oil"), Name = "Weathered Hunter", Effect = @"15% increased Global Accuracy Rating
+20 to Dexterity
+10% to all Elemental Resistances
+100 to Accuracy Rating" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Azure Oil"), Name = "Cloth and Chain", Effect = @"24% increased Evasion Rating and Armour
+12% to all Elemental Resistances" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Teal Oil"), Name = "Solidity", Effect = @"3% Chance to Block Attack Damage while holding a Shield
20% increased Attack Damage while holding a Shield
Attack Skills deal 20% increased Damage with Ailments while holding a Shield
+8% Elemental Resistances while holding a Shield" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Verdant Oil"), Name = "Aspect of the Eagle", Effect = @"20% increased Damage with Bows
4% increased Movement Speed
12% increased Global Accuracy Rating
+10 to maximum Life
20% increased Damage Over Time with Bow Skills" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Azure Oil"), Name = "Dynamo", Effect = @"5% reduced Mana Cost of Skills
16% increased maximum Mana" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Teal Oil"), Name = "Decay Ward", Effect = @"Minions have +10% Chance to Block Attack Damage
Minions have +10% Chance to Block Spell Damage
Minions Recover 2% of their Life when they Block" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Teal Oil"), Name = "Thrill Seeker", Effect = @"15% increased maximum Mana
0.4% of Attack Damage Leeched as Mana
+10 Mana gained on Kill" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Azure Oil"), Name = "Aspect of the Panther", Effect = @"16% increased Weapon Damage while Dual Wielding
6% increased Attack Speed while Dual Wielding
+3% Chance to Block Attack Damage while Dual Wielding
+10 to maximum Life
Attack Skills deal 16% increased Damage with Ailments while Dual Wielding" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Verdant Oil"), Name = "Spirit Void", Effect = @"20% increased total Recovery per second from Mana Leech
0.8% of Attack Damage Leeched as Mana
25% increased Maximum total Recovery per second from Mana Leech" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Azure Oil"), Name = "Poisonous Fangs", Effect = @"20% increased Damage with Claws
10% increased Poison Duration
10% chance to Poison on Hit with Attacks
20% increased Damage with Ailments from Attack Skills while wielding a Claw
+5% to Damage over Time Multiplier for Poison" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Teal Oil"), Name = "Saboteur", Effect = @"30% increased Trap Damage
30% increased Mine Damage
Can have up to 2 additional Trap placed at a time
Can have up to 2 additional Remote Mine placed at a time" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Teal Oil"), Name = "Depth Perception", Effect = @"15% increased Global Accuracy Rating
+20 to Dexterity
25% increased Critical Strike Chance
+100 to Accuracy Rating" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Azure Oil"), Name = "Elemental Focus", Effect = @"16% increased Elemental Damage
10% increased Duration of Elemental Ailments on Enemies
10% chance to Avoid Elemental Ailments
10% increased Effect of non-Damaging Ailments on Enemies" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Teal Oil"), Name = "Deep Wisdom", Effect = @"20 to Intelligence
+20 to maximum Mana
+20 to maximum Energy Shield" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Azure Oil"), Name = "Martial Experience", Effect = @"30% increased Physical Damage with Two Handed Melee Weapons
30% increased Damage with Ailments from Attack Skills while wielding a Two Handed Weapon
50% increased total Recovery per second from Life Leech
0.8% of Physical Attack Damage Leeched as Life" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Teal Oil"), Name = "Fury Bolts", Effect = @"20% increased Projectile Damage
+20 to Strength
10% increased Global Accuracy Rating" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Azure Oil"), Name = "Battle Rouse", Effect = @"8% of Damage taken gained as Mana over 4 seconds when Hit
15% increased maximum Mana
+15 to maximum Mana" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Azure Oil"), Name = "Hasty Reconstruction", Effect = @"20% increased Trap Damage
10% increased Cooldown Recovery Speed for throwing Traps" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Teal Oil"), Name = "Sanctuary", Effect = @"3% Chance to Block Attack Damage while holding a Shield
+3% Chance to Block Spell Damage while holding a Shield
+12% Elemental Resistances while holding a Shield" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Violet Oil"), Name = "Practical Application", Effect = @"25% chance to Avoid interruption from Stuns while Casting
+20 to Strength and Dexterity" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Azure Oil"), Name = "Words of Glory", Effect = @"If you've Warcried Recently, you and nearby allies have 10% increased Attack, Cast and Movement Speed
30% increased Warcry Duration
Warcries cost no Mana" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Azure Oil"), Name = "Executioner", Effect = @"24% increased Physical Damage with Two Handed Melee Weapons
50% increased Damage with Hits against Enemies that are on Low Life
24% increased Damage with Ailments from Attack Skills while wielding a Two Handed Weapon
8% increased Area of Effect if you've Killed Recently" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Teal Oil"), Name = "Mind Drinker", Effect = @"0.4% of Attack Damage Leeched as Mana
16% increased maximum Mana
Recover 2% of Mana on Kill" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Violet Oil"), Name = "Freedom of Movement", Effect = @"30% increased Evasion Rating
10% increased Movement Speed while Phasing
5% chance to Dodge Attack Hits while Phasing
10% chance to gain Phasing for 4 seconds on Kill" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Azure Oil"), Name = "Dreamer", Effect = @"25% increased maximum Mana
15% increased Mana Regeneration Rate" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Violet Oil"), Name = "Aligned Spirits", Effect = @"10% increased maximum Mana
Minions deal 20% increased Damage
15% reduced Mana Cost of Minion Skills" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Azure Oil"), Name = "Arsonist", Effect = @"6% to Fire Damage over Time Multiplier
24% increased Fire Damage
Regenerate 1% of Life per second" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Violet Oil"), Name = "Weapon Artistry", Effect = @"16% increased Attack Damage
+2% Chance to Block Attack Damage while Dual Wielding or holding a Shield
+10 to Strength and Dexterity
4% increased Attack Speed" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Azure Oil"), Name = "Unpredictable Offensive", Effect = @"Channelling Skills have 10% increased Attack Speed
20% chance to Avoid being Stunned while Channelling
5% chance to Dodge Attack Hits while Channelling" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Teal Oil"), Name = "Mystic Bulwark", Effect = @"6% Chance to Block Spell Damage
15% increased maximuim Mana
1% increased Mana Regeneration Rate per 1% Chance to Block Spell Damage" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Violet Oil"), Name = "Shamanistic Fury", Effect = @"30% increased Totem Damage
15% increased Totem Placement speed" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Violet Oil"), Name = "Deep Thoughts", Effect = @"20% increased maximum Mana
20% increased Mana Regeneration Rate
+20 to Intelligence" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Azure Oil"), Name = "Prodigal Perfection", Effect = @"10% increased Spell Damage
15% increased maximum Mana
2% increased Spell Damage per 100 Maximum Mana, up to 40%" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Azure Oil"), Name = "Sentinel", Effect = @"24% increased Evasion Rating and Armour
+10% to all Elemental Resistances" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Violet Oil"), Name = "Heavy Draw", Effect = @"20% increased Physical Damage with Bows
20% increased Damage Over Time with Bow Skills
12% increased Area of Effect
10% reduced Enemy Stun Threshold with Bows
30% increased Stun Duration with Bows on Enemies" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Azure Oil"), Name = "Claws of the Magpie", Effect = @"20% increased Damage with Claws
10% increased Attack Speed with Claws
25% chance to Steal Power, Frenzy, and Endurance Charges on Hit with Claws
20% increased Damage with Ailments from Attack Skills while wielding a Claw" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Violet Oil"), Name = "Harvester of Foes", Effect = @"20% increased Damage with Axes
20% increased Damage with Ailments from Attack Skills while wielding an Axe
12% increased Accuracy Rating with Axes
15% increased Attack Speed while Leeching" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Violet Oil"), Name = "Splitting Strikes", Effect = @"26% increased Physical Damage with Axes
6% increased Attack Speed with Axes
26% increased Damage with Ailments from Attack Skills while wielding an Axe
+1 to Melee range with Axes" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Violet Oil"), Name = "Silent Steps", Effect = @"20% increased Evasion Rating
5% reduced Damage taken from Blinded Enemies
60% chance to Avoid Blind" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Azure Oil"), Name = "Explosive Runes", Effect = @"You can Cast an additional Brand
20% increased Damage with Brand Skills
10% increased Brand Attachment range" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Azure Oil"), Name = "Steelwood Stance", Effect = @"30% increased Damage with Staves
30% increased Damage with Ailments from Attack Skills while wielding a Staff
20% increased Armour
+600 Armour if you've Blocked Recently
+4% Chance to Block Attack Damage while wielding a Staff" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Violet Oil"), Name = "Efficient Explosives", Effect = @"25% increased Mine Damage
25% increased Mine Duration
12% reduced Mana Reservation of Skills that throw Mines" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Violet Oil"), Name = "Totemic Zeal", Effect = @"30% increased Totem Placement speed
Spells Cast by Totems have 6% increased Cast Speed
Attacks used by Totems have 10% increased Attack Speed" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Azure Oil"), Name = "Bone Breaker", Effect = @"30% increased Physical Damage with Maces or Sceptres
12% increased Area of Effect
30% increased Damage with Ailments from Attack Skills while wielding a Mace or Sceptre
+2 to Melee range with Maces and Sceptres" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Violet Oil"), Name = "Gemini", Effect = @"12% increased Accuracy Rating while Dual Wielding
16% increased Weapon Damage while Dual Wielding
+4% Chance to Block Attack Damage while Dual Wielding
Attack Skills deal 16% increased Damage with Ailments while Dual Wielding
6% increased Attack Speed while Dual Wielding" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Violet Oil"), Name = "Expeditious Munitions", Effect = @"8% increased Trap Throwing Speed
30% increased Trap Trigger Area of Effect
20% increased Trap Damage" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Violet Oil"), Name = "Razor's Edge", Effect = @"30% increased Physical Damage with Swords
Attacks have 15% chance to cause Bleeding
30% increased Damage with Ailments from Attack Skills while wielding a Sword
+10% to Damage over Time Multiplier for Bleeding" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Azure Oil"), Name = "Red Storm", Effect = @"Attacks have 15% chance to cause Bleeding
30% increased Physical Damage
+8% to Damage over Time Multiplier for Bleeding" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Violet Oil"), Name = "Honed Edge", Effect = @"24% increased Damage with Swords
24% increased Damage with Ailments from Attack Skills while wielding a Sword
6% increased Attack Speed with Swords
+200 to Accuracy Rating with Swords
20% increased Evasion Rating" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Violet Oil"), Name = "Kinetic Impacts", Effect = @"24% increased Physical Damage with Two Handed Melee Weapons
24% increased Damage with Ailments from Attack Skills while wielding a Two Handed Weapon
4% chance to deal Double Damage
10% chance to double Stun Duration" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Violet Oil"), Name = "Elder Power", Effect = @"10% increased Wand Damage per Power Charge
10% chance to gain a Power Charge on Kill" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Crimson Oil"), Name = "Successive Detonations", Effect = @"20% increased Critical Strike Chance for each Mine Detonated Recently, up to 100%
+8% to Critical Strike Multiplier for each Mine Detonated Recently, up to 40%" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Violet Oil"), Name = "Forceful Skewering", Effect = @"15% chance to Impale Enemies on Hit with Attacks
5% increased Impale Effect
+20 to Strength" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Azure Oil"), Name = "Slaughter", Effect = @"25% increased Physical Damage with Axes
25% increased Damage with Ailments from Attack Skills while wielding an Axe
10% chance to gain Onslaught for 4 seconds on Kill
8% increased Attack Speed with Axes" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Crimson Oil"), Name = "Galvanic Hammer", Effect = @"25% increased Elemental Damage with Maces and Sceptres
10% increased Accuracy Rating with Maces and Sceptres
Damage with Weapons Penetrates 5% Elemental Resistance" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Crimson Oil"), Name = "Magmatic Strikes", Effect = @"24% increased Fire Damage with Attack Skills
Gain 5% of Physical Damage as Extra Fire Damage" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Crimson Oil"), Name = "Toxic Strikes", Effect = @"10% increased Poison Duration
+8% to Damage over Time Multiplier for Poison
10% chance to Poison on Hit
30% increased Chaos Damage with Attack Skills" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Violet Oil"), Name = "Pain Forger", Effect = @"8% chance to gain a Power Charge when you Stun with Melee Damage
60% increased Critical Strike Chance with Maces and Sceptres
5% reduced Enemy Stun Threshold with Maces and Sceptres" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Violet Oil"), Name = "Sacrifice", Effect = @"Minions have +10% to all Elemental Resistances
Minions have 20% increased maximum Life
Minions Regenerate 1% of Life per second
Regenerate 1% of Life per second" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Crimson Oil"), Name = "Entropy", Effect = @"27% increased Damage over Time
5% increased Skill Effect Duration" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Violet Oil"), Name = "Grave Intentions", Effect = @"Minions have +15% to Chaos Resistance
Minions have 25% chance to gain Unholy Might for 4 seconds on Kill
Minions gain 10% of Maximum Life as Extra Maximum Energy Shield" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Crimson Oil"), Name = "Blast Waves", Effect = @"Skills used by Mines deal 30% increased Area Damage if you Detonated a Mine Recently
Skills used by Mines have 10% increased Area of Effect
Skills used by Mines have 10% increased Area of Effect if you Detonated a Mine Recently" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Crimson Oil"), Name = "Master Fletcher", Effect = @"12% increased Damage with Bows
12% increased Attack Speed with Bows
20% increased Arrow Speed
12% increased Damage Over Time with Bow Skills
20% increased Global Accuracy Rating" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Crimson Oil"), Name = "Bladedancer", Effect = @"24% increased Damage with Swords
24% increased Damage with Ailments from Attack Skills while wielding a Sword
+1 to Melee range with Swords
6% increased Attack Speed with Swords" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Violet Oil"), Name = "Claws of the Pride", Effect = @"25% increased Damage with Claws
25% increased Damage with Ailments from Attack Skills while wielding a Claw
15% increased Attack and Cast Speed if you've used a Movement Skill Recently
+1 to Melee range with Claws" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Crimson Oil"), Name = "Ophidian Aim", Effect = @"12% increased Accuracy Rating with Staves
8% increased Attack Speed with Staves
+150 to Accuracy Rating with Staves
30% increased Critical Strike Chance with Staves" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Crimson Oil"), Name = "Primal Manifestation", Effect = @"24% increased Totem Damage
20% increased Totem Life
20% increased Totem Duration
24% increased Damage with Brand Skills
Brand Skills have 20% increased Duration" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Violet Oil"), Name = "Spinecruncher", Effect = @"28% increased Physical Damage with Maces and Sceptres
28% increased Damage with Ailments from Attack Skills while wielding a Mace or Sceptre
50% increased Stun Duration against Enemies that are on Full Life
10% chance to double Stun Duration" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Violet Oil"), Name = "Smashing Strikes", Effect = @"30% increased Damage with Staves
10% chance to gain an Endurance Charge on Melee Critical Strike
30% increased Damage with Ailments from Attack Skills while wielding a Staff
30% increased Critical Strike Chance with Staves
+2 to Melee range with Staves" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Crimson Oil"), Name = "Utmost Swiftness", Effect = @"40 to Dexterity
8% increased Dexterity" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Crimson Oil"), Name = "Farsight", Effect = @"24% increased Damage with Bows
24% increased Damage Over Time with Bow Skills
16% increased Accuracy Rating with Bows
6% increased Attack Speed with Bows" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Crimson Oil"), Name = "Whirling Barrier", Effect = @"6% Chance to Block Attack Damage while wielding a Staff
+6% Chance to Block Spell Damage while wielding a Staff
20% chance to gain a Power Charge when you Block" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Violet Oil"), Name = "Unstable Munitions", Effect = @"24% increased Trap Damage
8% increased Area of Effect
40% increased Trap Trigger Area of Effect" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Crimson Oil"), Name = "From the Shadows", Effect = @"15% increased Damage with Daggers
15% increased Accuracy Rating with Daggers
15% increased Damage with Ailments from Attack Skills while wielding a Dagger
6% increased Attack Speed with Daggers
10% chance to gain Phasing for 4 seconds on Kill" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Crimson Oil"), Name = "Hatchet Master", Effect = @"25% increased Damage with Axes
8% increased Attack Speed with Axes
25% increased Damage with Ailments from Attack Skills while wielding an Axe
40% increased Global Evasion Rating when on Full Life" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Crimson Oil"), Name = "Clever Construction", Effect = @"Traps cannot be Damaged for 5 seconds after being Thrown
Mines cannot be Damaged for 5 seconds after being Thrown
20% increased Trap Damage
20% increased Mine Damage" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Crimson Oil"), Name = "Utmost Might", Effect = @"40 to Strength
8% increased Strength" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Crimson Oil"), Name = "Wandslinger", Effect = @"16% increased Damage with Wands
8% increased Attack Speed with Wands
16% increased Damage with Ailments from Attack Skills while wielding a Wand
10% increased Accuracy Rating with Wands" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Violet Oil"), Name = "Bludgeon Blitz", Effect = @"18% increased Damage with Maces and Sceptres
18% increased Damage with Ailments from Attack Skills while wielding a Mace or Sceptre
8% increased Attack Speed with Maces and Sceptres
+200 to Accuracy Rating with Maces and Sceptres
6% increased Movement Speed if you've Hit an Enemy Recently" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Crimson Oil"), Name = "Flash Freeze", Effect = @"24% increased Cold Damage
20% increased Projectile Speed
10% increased Effect of Chill" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Crimson Oil"), Name = "Flaying", Effect = @"24% increased Damage with Daggers
12% increased Attack Speed with Daggers
24% increased Damage with Ailments from Attack Skills while wielding a Dagger
10% increased Accuracy Rating with Daggers
+1 to Melee range with Daggers" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Crimson Oil"), Name = "Fearsome Force", Effect = @"Minions deal 15% increased Damage
Minions have 10% increased Area of Effect
Minions have 10% increased Area of Effect if you used a Minion Skill Recently
+10 to Intelligence" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Crimson Oil"), Name = "Redemption", Effect = @"Minions have 5% increased Attack Speed
Minions have 5% increased Cast Speed
20% increased Minion Accuracy Rating
12% increased Damage
Minions have 10% increased Movement Speed" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Crimson Oil"), Name = "Utmost Intellect", Effect = @"40 to Intelligence
8% increased Intelligence" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Violet Oil"), Name = "Enigmatic Defence", Effect = @"15% increased Spell Damage while wielding a Staff
+5% Chance to Block Attack Damage while wielding a Staff
+5% Chance to Block Spell Damage while wielding a Staff
10% chance to gain Unholy Might on block for 3 seconds" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Crimson Oil"), Name = "Butchery", Effect = @"25% increased Physical Damage with Two Handed Melee Weapons
+20 to Strength
5% increased Attack Speed with Two Handed Melee Weapons
25% increased Damage with Ailments from Attack Skills while wielding a Two Handed Weapon" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Crimson Oil"), Name = "Holy Dominion", Effect = @"12% increased Elemental Damage
+12% to all Elemental Resistances
5% chance to Freeze, Shock and Ignite
12% increased Physical Damage" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Crimson Oil"), Name = "Static Blows", Effect = @"20% increased Shock Duration on Enemies
30% increased Effect of Shock
30% increased Damage if you have Shocked an Enemy Recently
40% increased Critical Strike Chance against Shocked Enemies" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Crimson Oil"), Name = "Light Eater", Effect = @"0.8% of Spell Damage Leeched as Energy Shield
20% increased Maximum total Recovery per second from Energy Shield Leech
24% increased Damage while on Full Energy Shield" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Crimson Oil"), Name = "Shaper", Effect = @"40% increased Mana Regeneration Rate
Regenerate 1% of Life per second" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Black Oil"), Name = "Annihilation", Effect = @"15% to Critical Strike Multiplier for Spells
50% increased Critical Strike Chance for Spells" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Crimson Oil"), Name = "Ash, Frost and Storm", Effect = @"20% increased Elemental Damage
20% reduced Reflected Elemental Damage taken
+6% to all Elemental Resistances" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Black Oil"), Name = "Testudo", Effect = @"5% Chance to Block Attack Damage while holding a Shield
60% increased Block Recovery
+20 Mana gained when you Block
40% increased Defences from Equipped Shield" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Black Oil"), Name = "Lightning Walker", Effect = @"25% increased Lightning Damage
+15% to Lightning Resistance
5% increased Cast Speed with Lightning Skills" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Crimson Oil"), Name = "Nimbleness", Effect = @"6% increased Cast Speed
4% increased Movement Speed
15% chance to Avoid interruption from Stuns while Casting
+12% to Critical Strike Multiplier for Spells" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Crimson Oil"), Name = "Aspect of the Lynx", Effect = @"16% increased Attack Damage
4% increased Movement Speed
20% increased Critical Strike Chance
+10 to Dexterity and Intelligence" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Black Oil"), Name = "Exceptional Performance", Effect = @"25% increased Skill Effect Duration" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Black Oil"), Name = "Cleaving", Effect = @"20% increased Physical Damage with Axes
20% increased Damage with Ailments from Attack Skills while wielding an Axe
30% increased Damage with Hits and Ailments against Bleeding Enemies
Bleeding you inflict deals Damage 15% faster
+1 to Melee range with Axes" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Crimson Oil"), Name = "Arcane Focus", Effect = @"18% increased maximum Energy Shield
10% increased Energy Shield Recharge Rate" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Black Oil"), Name = "Combat Stamina", Effect = @"Regenerate 1% of Life per second
20% increased Armour
5% increased maximum Life" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Black Oil"), Name = "Will of Blades", Effect = @"25% increased Physical Damage
25% increased Critical Strike Chance" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Black Oil"), Name = "Divine Fury", Effect = @"12% increased Elemental Damage
12% increased Physical Damage
Fire Spells have 15% of Physical Damage Converted to Fire Damage
Gain 5% of Physical Damage as Extra Fire Damage" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Crimson Oil"), Name = "Heartseeker", Effect = @"30% to Critical Strike Multiplier" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Black Oil"), Name = "Arcane Guarding", Effect = @"60% increased Energy Shield from Equipped Shield
20% increased Spell Damage if you've Blocked Recently
15% increased Spell Damage while holding a Shield
+6% Chance to Block Spell Damage while holding a Shield" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Black Oil"), Name = "Reflexes", Effect = @"30% increased Evasion Rating
+150 to Evasion Rating
15% increased Global Accuracy Rating
+150 to Accuracy Rating" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Black Oil"), Name = "Divine Judgement", Effect = @"18% increased Elemental Damage
Damage Penetrates 5% Elemental Resistances
10% increased Effect of non-Damaging Ailments on Enemies
+6% to Fire Damage over Time Multiplier" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Black Oil"), Name = "Trickery", Effect = @"20% increased Critical Strike Chance
20% increased Damage
+10 to Dexterity and Intelligence" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Black Oil"), Name = "Defiance", Effect = @"20% increased Attack Damage while holding a Shield
+3% Chance to Block Attack Damage while holding a Shield
25% increased Defences from Equipped Shield
Attack Skills deal 20% increased Damage with Ailments while holding a Shield" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Crimson Oil"), Name = "Harrier", Effect = @"5% increased Movement Speed
9% increased Attack Speed
5% increased Cast Speed" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Black Oil"), Name = "Twin Terrors", Effect = @"75% increased Weapon Critical Strike Chance while Dual Wielding
12% increased Accuracy Rating while Dual Wielding" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Black Oil"), Name = "Enigmatic Reach", Effect = @"10% increased Area of Effect while wielding a Staff
8% increased Attack Speed with Staves
8% increased Cast Speed while wielding a Staff
3% increased Area of Effect per Power Charge" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Black Oil"), Name = "Snowforged", Effect = @"25% increased Fire Damage
25% increased Cold Damage
30% increased Critical Strike Chance
+10% to Fire and Cold Resistances" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Black Oil"), Name = "Ambidexterity", Effect = @"50% increased Attack Damage with Main Hand
20% increased Attack Speed with Off Hand
Attack Skills deal 50% increased Damage with Ailments while Dual Wielding" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Black Oil"), Name = "Warrior's Blood", Effect = @"Regenerate 1.8% of Life per second
+20 to Strength
20% increased Stun Threshold" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Black Oil"), Name = "Command of the Elements", Effect = @"Damage with Weapons Penetrates 4% Elemental Resistance
40% increased Defences from Equipped Shield
6% increased Attack Speed while holding a Shield
24% increased Elemental Damage with Attack Skills" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Crimson Oil"), Name = "Light of Divinity", Effect = @"15% increased Spell Damage
4% increased Cast Speed
+10 to Strength and Intelligence
10% increased Light Radius
20% increased Critical Strike Chance for Spells" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Black Oil"), Name = "Acuity", Effect = @"15% increased Global Accuracy Rating
+20 to Dexterity
5% increased Attack Speed
+100 to Accuracy Rating" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Black Oil"), Name = "Finesse", Effect = @"20 to Dexterity
8% increased Attack Speed
15% increased Global Accuracy Rating" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Black Oil"), Name = "Mental Rapidity", Effect = @"8% increased Cast Speed
20% increased Mana Regeneration Rate
10% increased Energy Shield Recharge Rate" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Black Oil"), Name = "Revelry", Effect = @"2 Mana gained for each Enemy hit by your Attacks
15% increased maximum Mana
+20 to maximum Mana" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Black Oil"), Name = "Aggressive Bastion", Effect = @"30% increased Physical Attack Damage while holding a Shield
+4% Chance to Block Attack Damage while holding a Shield
Attack Skills deal 30% increased Damage with Ailments while holding a Shield
5% chance to gain an Endurance Charge on Kill while holding a Shield" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Black Oil"), Name = "Sanctity", Effect = @"10 to Strength and Intelligence
20% increased Armour
10% increased maximum Energy Shield
Regenerate 1% of Life per second" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Black Oil"), Name = "Essence Sap", Effect = @"20% increased total Recovery per second from Mana Leech
0.6% of Attack Damage Leeched as Mana
25% increased Maximum total Recovery per second from Mana Leech
+2 Mana gained for each Enemy hit by your Attacks" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Black Oil"), Name = "Adamant", Effect = @"20% increased Armour
10% chance when Hit for double Armour effect
+250 to Armour while affected by a Guard Skill Buff
Regenerat 0.5% of Life per second while affected by a Guard Skill Buff" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Crimson Oil"), Name = "Coldhearted Calculation", Effect = @"20% increased Mana Regeneration Rate
+20 to Intelligence
12% increased Spell Damage
12% increased Attack Damage" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Black Oil"), Name = "Arcanist's Dominion", Effect = @"20 to Intelligence
5% increased Cast Speed
20% increased Spell Damage" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Eagle Eye", Effect = @"15% increased Global Accuracy Rating
30% increased Critical Strike Chance
+100 to Accuracy Rating" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Black Oil"), Name = "Storm Weaver", Effect = @"25% increased Cold Damage
25% increased Lightning Damage
20% increased Mana Regeneration Rate
10% increased Effect of non-Damaging Ailments on Enemies" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Berserking", Effect = @"12% increased Attack Speed" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Potency of Will", Effect = @"25% increased Skill Effect Duration" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Black Oil"), Name = "Coordination", Effect = @"12% increased Attack Speed
6% increased Cast Speed
+10 to Dexterity and Intelligence" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Black Oil"), Name = "Graceful Assault", Effect = @"20% increased Attack Damage
30% increased Evasion Rating during Onslaught
10% chance to gain Onslaught for 4 seconds on Kill
20% increased Onslaught Effect" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Brinkmanship", Effect = @"Melee Skills have 10% increased Area of Effect
10% increased Area of Effect if you have Stunned an Enemy Recently
5% reduced Area Damage taken from Hits
+2 to Melee Weapon and Unarmed Attack range" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Fleetfoot", Effect = @"20% increased Evasion Rating
20% increased Cooldown Recovery Speed of Movement Skills
5% increased Movement Speed
10% increased Attack and Cast Speed if you've used a Movement Skill Recently" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Black Oil"), Name = "Precise Interception", Effect = @"3% Chance to Block Attack Damage while holding a Shield
60% increased Defences from Equipped Shield
15% increased Attack Damage while holding a Shield
Attack Skills deal 15% increased Damage with Ailments while holding a Shield
6% increased Attack Speed while holding a Shield" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Blast Radius", Effect = @"10% increased Area of Effect
20% increased Area Damage" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Destroyer", Effect = @"12% increased Accuracy Rating with Two Handed Melee Weapons
25% increased Physical Damage with Two Handed Melee Weapons
5% increased Attack Speed with Two Handed Melee Weapons
25% increased Damage with Ailments from Attack Skills while wielding a Two Handed Weapon" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Divine Wrath", Effect = @"12% increased Elemental Damage
12% increased Physical Damage
Lightning Spells have 15% of Physical Damage Converted to Lightning Damage
Gain 5% of Physical Damage as Extra Lightning Damage" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Black Oil"), Name = "True Strike", Effect = @"12% to Critical Strike Multiplier
45% increased Critical Strike Chance" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Wrecking Ball", Effect = @"20% increased Damage with Two Handed Weapons
10% increased Attack Speed with Two Handed Melee Weapons
20% increased Damage with Ailments from Attack Skills while wielding a Two Handed Weapon
20% increased Stun Duration with Two Handed Melee Weapons on Enemies" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Titanic Impacts", Effect = @"40% increased Critical Strike Chance with Two Handed Melee Weapons
12% increased Accuracy Rating with Two Handed Melee Weapons
+20% to Critical Strike Multiplier with Two Handed Melee Weapons" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Deflection", Effect = @"4% Chance to Block Attack Damage while holding a Shield
+4% Chance to Block Spell Damage while holding a Shield
40% increased Defences from Equipped Shield
+8% Chance to Block Projectile Attack Damage" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Versatility", Effect = @"10% increased Global Accuracy Rating
20% increased Critical Strike Chance
+20 to Dexterity and Intelligence
5% increased Attack Speed" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Juggernaut", Effect = @"6% increased maximum Life
16% increased Armour
20% increased Life Recovery from Flasks" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Black Oil"), Name = "Dervish", Effect = @"2% Chance to Block Attack Damage while Dual Wielding
24% increased Weapon Damage while Dual Wielding
6% increased Attack Speed while Dual Wielding
Attack Skills deal 24% increased Damage with Ailments while Dual Wielding" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Strong Arm", Effect = @"20 to Strength
25% increased Physical Damage with One Handed Melee Weapons
5% increased Attack Speed with One Handed Melee Weapons
25% increased Damage with Ailments from Attack Skills while wielding a One Handed Weapon" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Sleight of Hand", Effect = @"20% increased Damage with One Handed Weapons
8% increased Attack Speed with One Handed Melee Weapons
30% increased Damage with Ailments from Attack Skills while wielding a One Handed Weapon" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Battle Cry", Effect = @"Using Warcries is Instant
20% increased Warcry Buff Effect
10% increased Warcry Cooldown Recovery Speed" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Amplify", Effect = @"10% increased Area of Effect
20% increased Area Damage" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Dazzling Strikes", Effect = @"10% chance to Blind Enemies on Hit with Attacks
40% increased Critical Strike Chance against Blinded Enemies
15% increased Global Accuracy Rating" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Explosive Impact", Effect = @"25% increased Fire Damage
8% increased Area of Effect" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Black Oil"), Name = "Fire Walker", Effect = @"25% increased Fire Damage
+15% to Fire Resistance
5% increased Cast Speed with Fire Skills" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Blade Barrier", Effect = @"5% Chance to Block Attack Damage while Dual Wielding
24% increased Weapon Damage while Dual Wielding
50% increased Block Recovery
Attack Skills deal 24% increased Damage with Ailments while Dual Wielding" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Dark Arts", Effect = @"5% increased Cast Speed while Dual Wielding
10% increased Attack and Cast Speed if you've used a Movement Skill Recently
30% increased Mana Regeneration if you've used a Movement Skill Recently
+10 to Dexterity and Intelligence" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Melding", Effect = @"6% increased maximum Life
10% increased maximum Energy Shield" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Throatseeker", Effect = @"30% to Critical Strike Multiplier" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Frost Walker", Effect = @"25% increased Cold Damage
+15% to Cold Resistance
5% increased Cast Speed with Cold Skills" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Steadfast", Effect = @"10% increased Effect of Fortify on you
10% increased Effect of Fortify on you while Stationary
30% increased Armour while you have Fortify" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Mysticism", Effect = @"16% increased Spell Damage while Dual Wielding
+4% Chance to Block Attack Damage while Dual Wielding
+4% Chance to Block Spell Damage while Dual Wielding
10% chance to gain a Power Charge when you Block Spell Damage
10% chance to gain a Frenzy Charge when you Block Attack Damage" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Ballistic Mastery", Effect = @"15% increased Projectile Damage
+20 to Dexterity
20% increased Projectile Speed" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Black Oil"), Name = "Essence Extraction", Effect = @"15% increased Mana Regeneration Rate
15% increased Flask Charges gained
Mana Flasks gain 1 Charge every 3 seconds
Remove a random Elemental Ailment when you use a Mana Flask" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Retribution", Effect = @"10 to Strength and Intelligence
14% increased Damage
5% increased Attack and Cast Speed
Minions deal 10% increased Damage" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Lethal Assault", Effect = @"18% increased Damage
10% increased Projectile Speed
10% increased Area of Effect" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Soul Thief", Effect = @"12% increased maximum Energy Shield
18% increased Evasion Rating
0.3% of Spell Damage Leeched as Energy Shield" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Sanctum of Thought", Effect = @"You take 20% reduced Extra Damage from Critical Strikes
30% increased Armour
20% reduced Effect of Curses on you" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Command of Steel", Effect = @"3% Chance to Block Attack Damage while holding a Shield
25% increased Attack Damage while holding a Shield
Attack Skills deal 25% increased Damage with Ailments while holding a Shield
6% increased Attack Speed while holding a Shield" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Precision", Effect = @"20 to Dexterity
10% increased Global Accuracy Rating
4% increased Movement Speed
5% increased Attack and Cast Speed" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Hired Killer", Effect = @"10 Life gained on Kill
6% increased maximum Life" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Retaliation", Effect = @"20% increased Attack Damage while holding a Shield
40% increased Defences from Equipped Shield
8% increased Attack Speed while holding a Shield
Attack Skills deal 20% increased Damage with Ailments while holding a Shield" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Righteous Army", Effect = @"Minions deal 20% increased Damage
Minions have 20% increased maximum Life
Minions Regenerate 1% Life per second
Regenerate 1% of Life per second" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Longshot", Effect = @"20% increased Projectile Attack Damage
Projectiles gain Damage as they travel farther, dealing up
to 40% increased Damage with Hits to targets
20% increased Projectile Speed" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Ribcage Crusher", Effect = @"18% increased Damage with Maces and Sceptres
6% increased Attack Speed with Maces and Sceptres
18% increased Damage with Ailments from Attack Skills while wielding a Mace or Sceptre
15% increased Area of Effect if you have Stunned an Enemy Recently" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Dire Torment", Effect = @"20% to Damage over Time Multiplier for Ailments from Critical Strikes
30% increased Critical Strike Chance" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Gravepact", Effect = @"Minions deal 15% increased Damage
Minions have 8% increased Attack Speed
30% increased Minion Accuracy Rating
Minions have 5% chance to deal Double Damage" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Silver Oil"), Name = "Arcing Blows", Effect = @"30% increased Lightning Damage with Attack Skills
Damage with Weapons Penetrates 8% Lightning Resistance
10% increased Effect of Shock" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Disciple of the Unyielding", Effect = @"1 to Minimum Endurance Charges
5% chance to gain an Endurance Charge on Kill
5% increased Damage per Endurance Charge" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Disintegration", Effect = @"60% increased Critical Strike Chance with Wands
+30% to Critical Strike Multiplier with Wands
+20 to Intelligence" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Silver Oil"), Name = "Blade Master", Effect = @"20% increased Physical Damage with Swords
8% increased Attack Speed with Swords
+200 to Accuracy Rating with Swords
20% increased Damage with Ailments from Attack Skills while wielding a Sword
+1 to Melee range with Swords" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Silver Oil"), Name = "Fangs of Frost", Effect = @"30% increased Cold Damage with Attack Skills
Damage with Weapons Penetrates 8% Cold Resistance
10% increased Effect of Chill" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Silver Oil"), Name = "Counterweight", Effect = @"60% increased Global Critical Strike Chance while wielding a Staff
+30% to Global Critical Strike Multiplier while wielding a Staff" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Silver Oil"), Name = "Destructive Apparatus", Effect = @"20% increased Mine Damage
40% increased Mine Duration
10% increased Mine Throwing Speed
Each Mine applies 2% reduced Damage dealt to Enemies near it, up to 10%" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Silver Oil"), Name = "Hunter's Gambit", Effect = @"24% increased Damage with Bows
24% increased Damage Over Time with Bow Skills
10% increased Skill Effect Duration
Poisons you inflict deal Damage 10% faster
+10% to Chaos Damage over Time Multiplier" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Silver Oil"), Name = "Soul Raker", Effect = @"20% increased Damage with Claws
1.2% of Attack Damage Leeched as Life
0.8% of Attack Damage Leeched as Mana
50% increased total Recovery per second from Life Leech
20% increased Damage with Ailments from Attack Skills while wielding a Claw" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Silver Oil"), Name = "Dirty Techniques", Effect = @"20% increased Poison Duration
20% increased Bleeding Duration
+10% to Damage over Time Multiplier
Poisons you inflict deal Damage 5% faster
Bleeding you inflict deals Damage 5% faster" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Silver Oil"), Name = "Backstabbing", Effect = @"40% increased Critical Strike Chance with Daggers
+30% to Critical Strike Multiplier with Daggers
+40% to Critical Strike Multiplier against Enemies that are on Full Life
30% increased Critical Strike Chance against Enemies on Full Life" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Silver Oil"), Name = "Tempest Blast", Effect = @"Gain 20% of Wand Physical Damage as Extra Lightning Damage" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Silver Oil"), Name = "Winter Spirit", Effect = @"16% increased Cold Damage with Attack Skills
20% of Physical Damage Converted to Cold Damage" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Silver Oil"), Name = "High Explosives", Effect = @"Trap Damage Penetrates 10% Elemental Resistances
Mine Damage Penetrates 10% Elemental Resistances
30% increased Mine Duration
30% increased Trap Trigger Area of Effect" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Silver Oil"), Name = "Holy Fire", Effect = @"12% to Fire Damage over Time Muiltiplier
20% increased Fire Damage
15% chance to Ignite" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Silver Oil"), Name = "Shaman's Dominion", Effect = @"20% to Critical Strike Multiplier with Totem Skills
100% increased Global Critical Strike Chance if you've Summoned a Totem Recently
+20% to Critical Strike Multiplier with Brand Skills
50% increased Critical Strike Chance with Brand Skills" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Silver Oil"), Name = "Method to the Madness", Effect = @"8% to Chaos Resistance
22% increased Chaos Damage
+8% to Chaos Damage over Time Multiplier" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Silver Oil"), Name = "Blade of Cunning", Effect = @"20% increased Physical Damage with Swords
20% increased Damage with Ailments from Attack Skills while wielding a Sword
40% increased Critical Strike Chance with Swords
+15% to Critical Strike Multiplier with Swords" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Silver Oil"), Name = "Searing Heat", Effect = @"20% to Damage over Time Multiplier for Ignite from Critical Strikes
45% increased Critical Strike Chance for Spells
+20% to Critical Strike Multiplier against Burning Enemies" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Silver Oil"), Name = "Devastating Devices", Effect = @"50% increased Critical Strike Chance with Traps
50% increased Critical Strike Chance with Mines
+30% to Critical Strike Multiplier with Traps
+30% to Critical Strike Multiplier with Mines" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Silver Oil"), Name = "Forces of Nature", Effect = @"20% increased Elemental Damage with Attack Skills
Damage with Weapons Penetrates 6% Elemental Resistance" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Singular Focus", Effect = @"Channelling Skills deal 15% increased Damage
4% additional Physical Damage Reduction while Channelling
Channelling Skills have 6% increased Attack and Cast Speed" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Corruption", Effect = @"15% increased Damage over Time
+10% to Chaos Damage over Time Multiplier
15% increased Chaos Damage" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Skull Cracking", Effect = @"30% increased Physical Damage with Maces and Sceptres
10% reduced Enemy Stun Threshold with Maces and Sceptres
Hits that Stun Enemies have Culling Strike
30% increased Damage with Ailments from Attack Skills while wielding a Mace or Sceptre" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Adder's Touch", Effect = @"30% to Critical Strike Multiplier with Daggers
Critical Strikes with Daggers have a 40% chance to Poison the Enemy
20% increased Damage with Poison
+15% to Damage over Time Multiplier for Poison from Critical Strikes" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Silver Oil"), Name = "Fatal Toxins", Effect = @"30% increased Damage with Poison
10% increased Poison Duration
+10% to Chaos Resistance
+10% to Damage over Time Multiplier for Poison" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Silver Oil"), Name = "Gladiator's Perseverance", Effect = @"20% increased Physical Damage with One Handed Melee Weapons
0.6% of Physical Attack Damage Leeched as Life
10% increased Maximum total Recovery per second from Life Leech
20% increased Attack Damage while Leeching
20% increased Damage with Ailments from Attack Skills while wielding a One Handed Weapon" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Silver Oil"), Name = "Lethality", Effect = @"30% to Critical Strike Multiplier with Bows
16% increased Damage with Bows
50% increased Critical Strike Chance with Bows
16% increased Damage Over Time with Bow Skills" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Feller of Foes", Effect = @"30% increased Damage with Axes
+30% to Critical Strike Multiplier with Axes
+200 to Accuracy Rating with Axes
30% increased Damage with Ailments from Attack Skills while wielding an Axe" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Silver Oil"), Name = "Lucidity", Effect = @"Channelling Skills deal 30% increased Damage
Channelling Skills have -3 to Total Mana Cost
40% chance to Avoid being Stunned while Channelling" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Blacksmith's Clout", Effect = @"18% increased Physical Damage with Maces and Sceptres
18% increased Damage with Ailments from Attack Skills while wielding a Mace or Sceptre
40% increased Critical Strike Chance with Maces and Sceptres
+25% to Critical Strike Multiplier with Maces and Sceptres" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Silver Oil"), Name = "King of the Hill", Effect = @"Knocks Back Enemies if you get a Critical Strike with a Bow
80% increased Critical Strike Chance with Bows
16% increased Damage with Bows
16% increased Damage Over Time with Bow Skills" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Silver Oil"), Name = "Bloodletting", Effect = @"25% increased Damage with Bleeding
+8% to Damage over Time Multiplier for Bleeding
40% increased Attack Damage against Bleeding Enemies
Bleeding you inflict deals Damage 10% faster
5% reduced Damage taken from Bleeding Enemies" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Master Sapper", Effect = @"30% increased Trap Damage
Can have up to 2 additional Traps placed at a time
20% increased Trap Trigger Area of Effect
15% chance to gain a Frenzy Charge when your Trap is triggered by an Enemy" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Silver Oil"), Name = "Charging Offensive", Effect = @"Channelling Skills deal 16% increased Attack Damage
Channelling Skills have 6% increased Attack Speed
20% chance to gain an Endurance Charge when Hit while Channelling
20% chance to gain a Frenzy Charge when Hit while Channelling" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Serpent Stance", Effect = @"40% increased Global Critical Strike Chance while wielding a Staff
+35% to Global Critical Strike Multiplier while wielding a Staff" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Silver Oil"), Name = "Primeval Force", Effect = @"20% increased Elemental Damage with Attack Skills
10% reduced Reflected Elemental Damage taken
20% increased Elemental Damage during any Flask Effect
Damage with Weapons Penetrates 5% Elemental Resistance" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Silver Oil"), Name = "Death Attunement", Effect = @"1 to Maximum number of Spectres
Minions have 8% increased Attack Speed
Minions have 8% increased Cast Speed
+1 to Maximum number of Raised Zombies
+1 to Maximum number of Skeletons" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Silver Oil"), Name = "Deadly Draw", Effect = @"20% increased Physical Damage with Bows
30% increased Damage Over Time with Bow Skills
Bow Attacks have 10% chance to cause Bleeding
Bleeding you inflict deals Damage 15% faster" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Claws of the Hawk", Effect = @"40% increased Critical Strike Chance with Claws
+25% to Critical Strike Multiplier with Claws
10% chance to Blind Enemies on Critical Strike" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Silver Oil"), Name = "Blast Cascade", Effect = @"30% to Critical Strike Multiplier with Traps
+30% to Critical Strike Multiplier with Mines
15% chance to gain a Power Charge when your Trap is triggered by an Enemy
15% chance to gain a Power Charge when your Mine is Detonated targeting an Enemy" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Silver Oil"), Name = "Swift Skewering", Effect = @"15% chance to Impale Enemies on Hit with Attacks
15% increased Attack Physical Damage
5% increased Attack Speed" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Silver Oil"), Name = "Lord of the Dead", Effect = @"1 to Maximum number of Skeletons
+1 to Maximum number of Raised Zombies
Minions have 10% increased maximum Life
Minions deal 15% increased Damage
30% increased Minion Accuracy Rating" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Silver Oil"), Name = "Blunt Trauma", Effect = @"Knocks Back Enemies if you get a Critical Strike with a Staff
15% increased Accuracy Rating with Staves
40% increased Critical Strike Chance with Staves
+20% to Critical Strike Multiplier with Staves" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Silver Oil"), Name = "Runesmith", Effect = @"12% increased Brand Activation frequency
You can Cast an additional Brand
Brand Skills deal 30% increased Damage to Enemies they're Attached to
Brand Skills have 10% increased Duration" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Hex Master", Effect = @"Curse Skills have 80% increased Skill Effect Duration
5% increased Effect of your Curses
40% increased Area of Effect of Curse Skills" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Black Oil"), Name = "Disciple of the Forbidden", Effect = @"1 to Minimum Power Charges
5% chance to gain a Power Charge on Kill
5% increased Damage per Power Charge" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Avatar of the Hunt", Effect = @"24% increased Damage with Bows
6% increased Movement Speed
24% increased Damage Over Time with Bow Skills
20% increased Cooldown Recovery Speed of Movement Skills
+200 to Evasion Rating" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Prism Weave", Effect = @"24% increased Elemental Damage with Wands
6% increased Attack Speed with Wands
Damage with Weapons Penetrates 5% Elemental Resistance" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Silver Oil"), Name = "Indomitable Army", Effect = @"Minions have 15% increased maximum Life
Minions have 15% additional Physical Damage Reduction
Minions have +15% to all Elemental Resistances
Moving while Bleeding doesn't cause Minions to take extra Damage" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Fatal Blade", Effect = @"30% to Critical Strike Multiplier with Swords
60% increased Critical Strike Chance with Swords
10% increased Damage with Swords
10% increased Damage with Ailments from Attack Skills while wielding a Sword" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Clear Oil"), C = Oil.Parse("Golden Oil"), Name = "Lava Lash", Effect = @"30% increased Fire Damage with Attack Skills
Damage with Weapons Penetrates 8% Fire Resistance" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Golden Oil"), Name = "Atrophy", Effect = @"10% to Chaos Damage over Time Multiplier
20% increased Chaos Damage
4% increased Cast Speed with Chaos Skills
+8% to Chaos Resistance" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Ravenous Horde", Effect = @"Minions have 20% increased Movement Speed
Minions deal 20% increased Damage
Minions have 5% increased Attack Speed
Minions have 5% increased Cast Speed
Minions have 10% chance to gain Onslaught for 4 seconds on Kill" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Sepia Oil"), C = Oil.Parse("Golden Oil"), Name = "Spiritual Command", Effect = @"Minions have 8% increased Attack Speed
20% increased Minion Accuracy Rating
Increases and Reductions to Minion Attack Speed also affect you
Minions have 8% increased Cast Speed" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Golden Oil"), Name = "Swift Venoms", Effect = @"8% increased Attack Speed
+8% to Damage over Time Multiplier for Poison
Poisons you inflict deal Damage 5% faster
10% chance to Poison on Hit with Attacks
16% increased Damage with Poison" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Golden Oil"), Name = "Stun Mastery", Effect = @"10% reduced Enemy Stun Threshold
30% increased Stun and Block Recovery
10% chance to gain an Endurance Charge when you Stun an Enemy with a Melee Hit
10% chance to double Stun Duration" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "One with the River", Effect = @"30% increased Elemental Damage with Staves
Damage with Weapons Penetrates 5% Elemental Resistance
5% reduced Elemental Damage taken while stationary" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Golden Oil"), Name = "Enduring Bond", Effect = @"15% increased Skill Effect Duration
Minions deal 20% increased Damage
Minions deal 20% increased Damage if you've used a Minion Skill Recently
15% increased Minion Duration" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Golden Oil"), Name = "Brutal Blade", Effect = @"20% increased Damage with Swords
8% increased Attack Speed with Swords
+4% Chance to Block Attack Damage while Dual Wielding or holding a Shield
20% increased Damage with Ailments from Attack Skills while wielding a Sword
10% chance to gain a Frenzy Charge when you Block Attack Damage" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Amber Oil"), C = Oil.Parse("Golden Oil"), Name = "Claws of the Falcon", Effect = @"16% increased Damage with Claws
+30% to Critical Strike Multiplier with Claws
12% increased Accuracy Rating with Claws
16% increased Damage with Ailments from Attack Skills while wielding a Claw" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Golden Oil"), Name = "Growth and Decay", Effect = @"20% increased Damage over Time
Regenerate 1% of Life per second
+10% to Damage over Time Multiplier" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Golden Oil"), Name = "Disciple of the Slaughter", Effect = @"1 to Minimum Frenzy Charges
5% chance to gain a Frenzy Charge on Kill
5% increased Damage per Frenzy Charge" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Golden Oil"), Name = "Nightstalker", Effect = @"20% increased Damage with Daggers
40% increased Critical Strike Chance with Daggers
20% increased Damage with Ailments from Attack Skills while wielding a Dagger
+150 to Accuracy Rating with Daggers
+20% to Critical Strike Multiplier with Daggers" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Volatile Mines", Effect = @"20% increased Mine Damage
Can have up to 2 additional Remote Mines placed at a time
Mines have 20% increased Detonation Speed
Each Mine applies 2% increased Damage taken to Enemies near it, up to 10%" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Verdant Oil"), C = Oil.Parse("Golden Oil"), Name = "Insightfulness", Effect = @"10% increased maximum Energy Shield
10% increased maximum Mana
10% reduced Mana Cost of Skills while on Full Energy Shield
+10 to Intelligence" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Golden Oil"), Name = "Arcane Chemistry", Effect = @"15% increased maximum Mana
25% increased Mana Recovery from Flasks
15% reduced Flask Charges used
Flasks applied to you have 8% increased Effect" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Golden Oil"), Name = "Cleansed Thoughts", Effect = @"Chaos Resistance is doubled" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Golden Oil"), Name = "Influence", Effect = @"14% increased effect of Non-Curse Auras from your Skills" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Golden Oil"), Name = "Heart of Thunder", Effect = @"25% increased Lightning Damage
Damage Penetrates 6% Lightning Resistance
0.2% of Lightning Damage Leeched as Energy Shield" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Silver Oil"), Name = "Devotion", Effect = @"20 to Strength
8% increased maximum Life
3% increased effect of Non-Curse Auras from your Skills" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Purity of Flesh", Effect = @"8% increased maximum Life
+8% to Chaos Resistance
+10 to Strength" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Golden Oil"), Name = "Doom Cast", Effect = @"60% increased Critical Strike Chance for Spells
+15% to Critical Strike Multiplier for Spells" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Teal Oil"), C = Oil.Parse("Golden Oil"), Name = "Quick Recovery", Effect = @"6% increased maximum Life
20% increased Mana Regeneration Rate
Regenerate 0.8% of Life per second" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Crystal Skin", Effect = @"15% chance to Avoid Elemental Ailments
5% reduced Elemental Damage taken
+5% to all Elemental Resistances" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Bravery", Effect = @"24% increased Evasion Rating and Armour
8% increased maximum Life" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Golden Oil"), Name = "Breath of Flames", Effect = @"10% to Fire Damage over Time Multiplier
20% increased Fire Damage
20% increased Ignite Duration on Enemies
20% chance to Ignite" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Fervour", Effect = @"1 to Maximum Frenzy Charges" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Golden Oil"), Name = "Transcendence", Effect = @"-10 Physical Damage taken from Hits
-1 Physical Damage taken from Hits per Level" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Profane Chemistry", Effect = @"6% increased maximum Life
30% increased Life Recovery from Flasks
Flasks applied to you have 8% increased Effect" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Golden Oil"), Name = "Heart of Flame", Effect = @"25% increased Fire Damage
Damage Penetrates 6% Fire Resistance
0.2% of Fire Damage Leeched as Energy Shield" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Golden Oil"), Name = "Written in Blood", Effect = @"8% increased maximum Life
10% increased maximum Energy Shield
+10 to Strength" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Golden Oil"), Name = "Aqueous Accelerant", Effect = @"Flasks applied to you have 10% increased Effect
8% increased Attack and Cast Speed during Effect of any Mana Flask
10% increased Mana Recovery Rate during Efect of any Mana Flask" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Cruel Preparation", Effect = @"10% increased maximum Life
+5% to all Elemental Resistances" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Golden Oil"), Name = "Disemboweling", Effect = @"50% increased Melee Critical Strike Chance
+25% to Melee Critical Strike Multiplier" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Azure Oil"), C = Oil.Parse("Golden Oil"), Name = "Cursed Concoction", Effect = @"15% inceased maximum Mana
10% increased Effect of your Curses if you've spent 200 total Mana Recently
Remove a Curse when you use a Mana Flask" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Golden Oil"), Name = "Soul Siphon", Effect = @"18% increased maximum Mana
+5 Mana gained on Kill
+10 to maximum Mana" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Arcane Potency", Effect = @"30% to Critical Strike Multiplier for Spells
30% increased Critical Strike Chance for Spells" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Golden Oil"), Name = "Breath of Lightning", Effect = @"20% increased Shock Duration on Enemies
10% chance to Shock
20% increased Lightning Damage
15% increased Effect of Shock" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Vigour", Effect = @"1 to Maximum Endurance Charges" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Master of Force", Effect = @"20% increased Physical Damage
20% reduced Reflected Physical Damage taken
4% chance to deal Double Damage
+20 to Strength" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Hematophagy", Effect = @"20% increased total Recovery per second from Life Leech
1% of Physical Attack Damage Leeched as Life
30% increased Damage while Leeching
15% increased Maximum total Recovery per second from Life Leech" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Golden Oil"), Name = "Druidic Rite", Effect = @"15% increased maximum Mana
20% increased Flask Charges gained
20% increased Flask Effect Duration
+15 to maximum Mana" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Golden Oil"), Name = "Heart and Soul", Effect = @"8% increased maximum Life
12% increased maximum Mana" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Golden Oil"), Name = "Bloodless", Effect = @"Enemies Cannot Leech Life From you
8% increased maximum Life" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Violet Oil"), C = Oil.Parse("Golden Oil"), Name = "Born to Fight", Effect = @"20 to Strength
26% increased Melee Physical Damage
4% increased Melee Attack Speed
+20 to Accuracy Rating" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Golden Oil"), Name = "Heart of Oak", Effect = @"20% chance to Avoid being Stunned
8% increased maximum Life
Regenerate 1% of Life per second
20% increased Stun and Block Recovery" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Golden Oil"), Name = "Champion of the Cause", Effect = @"6% increased effect of Non-Curse Auras from your Skills
4% reduced Mana Reserved
12% increased Area of Effect of Aura Skills" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Golden Oil"), Name = "Survivalist", Effect = @"24% increased Evasion Rating
+8% to all Elemental Resistances
+1% to maximum Cold Resistance
+3% chance to Evade Attacks" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Overcharge", Effect = @"1 to Maximum Power Charges" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Overcharged", Effect = @"8% chance to gain a Power, Frenzy or Endurance Charge on Kill" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Master of the Arena", Effect = @"20 to Strength
+2 to Melee Weapon and Unarmed Attack range
8% increased Melee Physical Damage
Regenerate 1% of Life per second" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Mystic Talents", Effect = @"16% increased Spell Damage
+14 to maximum Energy Shield
25% increased Mana Regeneration Rate
+30 to Intelligence" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Golden Oil"), Name = "Fingers of Frost", Effect = @"Enemies Become Chilled as they Unfreeze
10% chance to Freeze Enemies which are Chilled
12% increased Cold Damage
10% increased Effect of Chill
+10% to Cold Damage over Time Multiplier" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Divine Fervour", Effect = @"24% increased Elemental Damage with Attack Skills
+10 to Strength and Intelligence
25% increased Melee Critical Strike Chance
Damage with Weapons Penetrates 3% Elemental Resistance" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Herbalism", Effect = @"20% increased Life Recovery from Flasks
20% increased Flask Recovery rate
10% increased maximum Life" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Blood Siphon", Effect = @"10% increased maximum Life
+20 to Strength
+5 Life gained on Kill" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Crackling Speed", Effect = @"16% increased Lightning Damage
4% increased Cast Speed
+15% to Critical Strike Multiplier
10% increased Effect of Shock" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Leadership", Effect = @"30% increased Area of Effect of Aura Skills
6% increased effect of Non-Curse Auras from your Skills" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Crimson Oil"), C = Oil.Parse("Golden Oil"), Name = "Arcane Expanse", Effect = @"Spell Skills have 10% increased Area of Effect
15% increased Spell Damage
10% increased Area of Effect if you've Killed Recently
+10 to Intelligence" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Endurance", Effect = @"1 to Maximum Endurance Charges" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Faith and Steel", Effect = @"20% increased Armour
10% increased maximum Energy Shield
+8% to all Elemental Resistances
10% increased Energy Shield Recharge Rate" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Way of the Warrior", Effect = @"16% increased Armour
+16 to maximum Life
16% increased Melee Damage
+30 to Strength" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Deadly Inclinations", Effect = @"18% increased Evasion Rating
+12 to maximum Life
16% increased Projectile Damage
+30 to Dexterity" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Hardened Scars", Effect = @"15% increased Life Recovery from Flasks
You have Fortify during Effect of any Life Flask" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Rampart", Effect = @"10% increased Effect of Fortify on you
5% increased Movement Speed while you have Fortify
20% increased Attack Damage while you have Fortify
8% increased Attack Speed while you have Fortify" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Inexorable", Effect = @"20% increased Armour
Regenerate 0.2% of Life per second per Endurance Charge
10% chance to gain an Endurance Charge when you are Hit
30% increased Armour while stationary" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Silver Oil"), Name = "Stamina", Effect = @"1 to Maximum Endurance Charges" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Arcane Capacitor", Effect = @"15% increased maximum Mana
10% increased Effect of Arcane Surge on you per 200 Mana spent Recently, up to 50%
10% chance to gain Arcane Surge when you Kill an Enemy" },
           new Passive{ A = Oil.Parse("Opalescent Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Opalescent Oil"), Name = "Tireless", Effect = @"8% increased maximum Life
6% reduced Mana Cost of Skills" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Arcane Swiftness", Effect = @"5% increased Spell Damage per 5% Chance to Block Attack Damage
+3% Chance to Block Attack Damage while holding a Shield
20% chance to Avoid being Stunned while holding a Shield
20% chance to Avoid Elemental Ailments while holding a Shield
5% increased Cast Speed while holding a Shield" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Stabbing Thirst", Effect = @"24% increased Damage with Daggers
0.5% of Attack Damage Leeched as Life
0.5% of Attack Damage Leeched as Mana
24% increased Damage with Ailments from Attack Skills while wielding a Dagger
6% increased Attack Speed with Daggers" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Savagery", Effect = @"1 to Maximum Frenzy Charges" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Mana Flows", Effect = @"16% increased maximum Mana
40% increased Mana Regeneration Rate
+20 to Intelligence
+10 to maximum Mana" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Primal Spirit", Effect = @"20% increased Mana Regeneration Rate
20% increased Flask Charges gained
+20 to Strength and Intelligence
15% increased maximum Mana" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Art of the Gladiator", Effect = @"12% increased Attack Speed
+20 to Dexterity
Ignore all Movement Penalties from Armour
10% increased Global Accuracy Rating" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Instability", Effect = @"1 to Maximum Power Charges" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Arcane Will", Effect = @"Regenerate 2 Mana per second
20% increased maximum Mana
20% increased Mana Recovery from Flasks
Gain 4% of Maximum Mana as Extra Maximum Energy Shield" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Foresight", Effect = @"20 to maximum Energy Shield
14% increased maximum Energy Shield
10% increased Energy Shield Recharge Rate" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Breath of Rime", Effect = @"20% increased Freeze Duration on Enemies
10% chance to Freeze
20% increased Cold Damage
15% increased Effect of Chill
+10% to Cold Damage over Time Multiplier" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Lust for Carnage", Effect = @"1.2% of Physical Attack Damage Leeched as Life
20% increased total Recovery per second from Life Leech
12% increased Attack Speed" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Frenetic", Effect = @"1 to Maximum Frenzy Charges" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Force Shaper", Effect = @"20% increased Physical Damage
Gain 4% of Physical Damage as Extra Chaos Damage
4% increased Attack and Cast Speed
10% reduced Physical Damage taken over time" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Piercing Shots", Effect = @"Projectiles Pierce 2 additional Targets" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Thick Skin", Effect = @"10% increased maximum Life
8% chance to Avoid Elemental Ailments" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Dismembering", Effect = @"30% increased Melee Critical Strike Chance
+30% to Melee Critical Strike Multiplier
20% chance to Maim Enemies on Critical Strike with Attacks" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Infused", Effect = @"1 to Maximum Power Charges" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Heart of Ice", Effect = @"25% increased Cold Damage
Damage Penetrates 6% Cold Resistance
0.2% of Cold Damage Leeched as Energy Shield" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Black Oil"), C = Oil.Parse("Golden Oil"), Name = "Swagger", Effect = @"20% increased Weapon Damage while Dual Wielding
+5% Chance to Block Attack Damage while Dual Wielding
Attack Skills deal 20% increased Damage with Ailments while Dual Wielding
10% chance to gain a Frenzy Charge when you Block
10% chance to gain an Endurance Charge when you Block" },
           new Passive{ A = Oil.Parse("Opalescent Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Silver Oil"), Name = "Blood Drinker", Effect = @"8% increased maximum Life
0.4% of Attack Damage Leeched as Life" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Vitality Void", Effect = @"20% increased total Recovery per second from Life Leech
0.8% of Attack Damage Leeched as Life
15% increased Maximum total Recovery per second from Life Leech" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Fangs of the Viper", Effect = @"20 to Dexterity
5% increased Movement Speed
20% increased Physical Damage
20% increased Chaos Damage" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Ethereal Feast", Effect = @"0.6% of Spell Damage Leeched as Energy Shield
30% increased Maximum total Recovery per second from Energy Shield Leech
6% increased Attack and Cast Speed while Leeching Energy Shield" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Resourcefulness", Effect = @"5% increased maximum Life
10% increased maximum Energy Shield
15% increased Evasion Rating
Regenerate 0.5% of Life per second" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Essence Surge", Effect = @"30 to maximum Energy Shield
10% increased Energy Shield Recharge Rate
15% faster start of Energy Shield Recharge" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Golem Commander", Effect = @"20% increased Damage when you have a Summoned Golem
30% increased Effect of Buffs granted by your Golems
Golems have 15% increased Maximum Life
+1 to maximum number of Golems" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Discipline and Training", Effect = @"30 to maximum Life
10% increased maximum Life" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Assassination", Effect = @"35% to Critical Strike Multiplier
30% increased Critical Strike Chance" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Heart of the Warrior", Effect = @"10 to Strength
+20 to maximum Life
10% increased maximum Life" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Void Barrier", Effect = @"10% increased maximum Energy Shield
15% increased Evasion Rating
+8% to all Elemental Resistances
10% increased Energy Shield Recharge Rate" },
           new Passive{ A = Oil.Parse("Opalescent Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Skittering Runes", Effect = @"15% increased Effect of your Curses" },
           new Passive{ A = Oil.Parse("Opalescent Oil"), B = Oil.Parse("Opalescent Oil"), C = Oil.Parse("Golden Oil"), Name = "Barbarism", Effect = @"6% increased maximum Life
+1% to maximum Fire Resistance
+8% to Fire Resistance" },
           new Passive{ A = Oil.Parse("Clear Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Crusader", Effect = @"8% increased maximum Mana
Transfiguration of Mind" },
           new Passive{ A = Oil.Parse("Sepia Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Thunderous Salvos", Effect = @"30% increased Critical Strike Chance for Spells
Skills supported by Unleash have +1 to maximum number of Seals" },
           new Passive{ A = Oil.Parse("Amber Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Vengeant Cascade", Effect = @"15% increased Projectile Speed
Attack Projectiles Return to you from final Target
Returning Projectiles Pierce all Targets" },
           new Passive{ A = Oil.Parse("Verdant Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Unnatural Calm", Effect = @"18% increased maximum Energy Shield
+1% to maximum Lightning Resistance
15% increased Energy Shield Recharge Rate" },
           new Passive{ A = Oil.Parse("Teal Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Golem's Blood", Effect = @"Regenerate 1.6% of Life per second
10% increased maximum Life" },
           new Passive{ A = Oil.Parse("Azure Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Tranquility", Effect = @"5% increased maximum Energy Shield
Transfiguration of Soul" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Revenge of the Hunted", Effect = @"18% increased Evasion Rating
8% increased maximum Life
12% increased Physical Damage" },
           new Passive{ A = Oil.Parse("Violet Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Aspect of Stone", Effect = @"20% chance to Avoid Physical Damage from Hits" },
           new Passive{ A = Oil.Parse("Crimson Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Tenacity", Effect = @"5% increased maximum Life
Transfiguration of Body" },
           new Passive{ A = Oil.Parse("Silver Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Silver Oil"), Name = "Sovereignty", Effect = @"6% reduced Mana Reserved
10% increased effect of Non-Curse Auras from your Skills" },
           new Passive{ A = Oil.Parse("Opalescent Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Tribal Fury", Effect = @"12% increased Melee Damage
Strike Skills target 1 additional nearby Enemy" },
           new Passive{ A = Oil.Parse("Black Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Whispers of Doom", Effect = @"You can apply an additional Curse" },
           new Passive{ A = Oil.Parse("Silver Oil"), B = Oil.Parse("Silver Oil"), C = Oil.Parse("Golden Oil"), Name = "Spiritual Aid", Effect = @"Increases and Reductions to Minion Damage also affect you
30% increased Minion Accuracy Rating
30% increased Global Accuracy Rating
Minions deal 15% increased Damage" },
           new Passive{ A = Oil.Parse("Opalescent Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Charisma", Effect = @"8% reduced Mana Reserved
6% increased effect of Non-Curse Auras from your Skills" },
           new Passive{ A = Oil.Parse("Silver Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Constitution", Effect = @"14% increased maximum Life
+20 to maximum Life" },
           new Passive{ A = Oil.Parse("Golden Oil"), B = Oil.Parse("Golden Oil"), C = Oil.Parse("Golden Oil"), Name = "Soul of Steel", Effect = @"30% increased Armour
5% additional Physical Damage Reduction
+1% to all maximum Elemental Resistances
+150 to Armour" },
        };


    }
}
