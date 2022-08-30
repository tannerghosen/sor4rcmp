using System;

namespace sor4
{
	public class character 
	{
		public string name;
		public string[,] moves;

        public character(string cname, string[,] cmoves)
		{
			name = cname; // character's name
			moves = cmoves; // character's moves, an array in an array (3d array)
		}
       /* public static implicit operator character(string v)
        {
            throw new NotImplementedException();
        }*/

        // Format: Name, Moves (Blitz, Defensive Special, Offensive Special, Air Special (if applicable), Star Special (always))
        public static character sor1axel = new character("Axel-SOR1", new string[,] { { "Summon Police", "Pipe Rage" } });
        public static character sor2axel = new character("Axel-SOR2", new string[,] { { "Grand Upper", "Tiger Knee" }, { "Dragon Wing", "Tornado Kick" }, { "Dragon Smash", "Dragon Dash Blow" }, { "Grand Dragon Wing", "Spinning Dragon Upper" } });
        public static character sor3axel = new character("Axel-SOR3", new string[,] { { "Grand Upper", "Scissors Kick" }, { "Dragon Wing", "Spinning Body Blow" }, { "Dragon Smash", "Dragon Punch" }, { "Spinning Body Smash", "Spirit Blade" } });
        public static character sor4axel = new character("Axel", new string[,] { { "Grand Upper", "Dragon Roll" }, { "Dragon Wing", "Dragon Upper" }, { "Dragon Smash", "Dragon Bite" }, { "Dragon Dive", "Dragon Crush" }, { "Dragon Burst", "Ultimate Dragon Wing" } });
        public static character sor1blaze = new character("Blaze-SOR1", new string[,] { { "Police Call", "Drill Kick" } });
        public static character sor2blaze = new character("Blaze-SOR2", new string[,] { { "Hishousouzan", "Elbow Strike" }, { "Embukyako", "Spinning Dive" }, { "Kikou Shou", "Aerial Grab" }, { "Tumbling", "Ring of Fire" } });
        public static character sor3blaze = new character("Blaze-SOR3", new string[,] { { "Hishousouzan", "Chou Reppa Dan" }, { "Embukyako", "Energy Burst" }, { "Kikou Shou", "Spirit Knife" }, { "Razor Sliding Tackle", "Slice and Dice" } });
        public static character sor4blaze = new character("Blaze", new string[,] { { "Hishousouzan", "Rekkaken" }, { "Embukyako", "Uraken Uchi" }, { "Kikou Shou", "Hien Zan" }, { "Tobi Kyaku", "Shin Hishousouzan" }, { "Tamashi Age", "Shin Kikou Shou" } });
        public static character sor1adam = new character("Adam-SOR1", new string[,] { { "Summon Police", "Slash Kick" } });
        public static character sor4adam = new character("Adam", new string[,] { { "Uzi Punch", "Sword Upper" }, { "Chopper", "Split Fangs" }, { "Howl Fang", "Sword Smash" }, { "Air Chopper", "Slash Kick" }, { "Sword Strike", "Lift Off" } });
        public static character sor2max = new character("Max-SOR2", new string[,] { { "Sliding Tackle", "Power Chop" }, { "Spinning Knuckle Bomb", "Hammer Slam" }, { "Thunder Tackle", "Rolling Grab" }, { "Giant Swing", "Cyclone Knuckle Bomb" } });
        public static character sor4max = new character("Max", new string[,] { { "Power Slide", "Clothes Lining" }, { "Spinning Knuckle Bomb", "Spinning Knuckle Vortex" }, { "Thunder Tackle", "Rolling Grab" }, { "Body Slam", "Thunder Strike" }, { "Thunder Strikes", "Iron Will" } });
        public static character sor2skate = new character("Skate-SOR2", new string[,] { { "Flying Headbutt", "Inline Rush" }, { "Spinning Attack", "Cannonball" }, { "Corkscrew Kick", "Somersault Kick" }, { "Breakdance", "Drilling Strike" } });
        public static character sor3skate = new character("Skate-SOR3", new string[,] { { "Flying Headbutt", "Ground Roll" }, { "Spinning Attack", "Get Off Me" }, { "Skating Fist Fury", "Flash Kick" }, { "Ground Roll Smash", "Human Cannonball" } });
        public static character sor3shiva = new character("Shiva-SOR3", new string[,] { { "Dashing Moon Kick", "Dark Dash" }, { "Moon Kick", "Ki Strike" }, { "Final Crash", "Diving Moon Kick" }, { "Ultimate Final Crash", "Asura Ranbu" } });
        public static character sor4shiva = new character("Shiva", new string[,] { { "Final Crash", "Flying Kick" }, { "Flaming Circular Kick", "Hashinshou" }, { "Senretsu Ken", "Spirit Palm" }, { "Air Senretsu Ken", "Spirit Kick" }, { "Shin Hashinshou", "Spirit Dance" } });
        public static character zan = new character("Dr.Zan-SOR3", new string[,] { { "Elbow Slam Shield", "The Claw" }, { "Shock Treatment", "Energy Ball" }, { "Electric Grab", "Guillotine" }, { "Super Shield Charge", "Big Energy Ball" } });
        public static character roo = new character("Roo-SOR3", new string[,] { { "Handbrake", "Gatling Kick" }, { "Somersault Tail Whip", "Spinning Kick" }, { "Hurricane Kick", "Rolling Attack" }, { "Air Tail Whip", "Air Rolling Attack" }, { "Here Comes Bruce", "Earthquake" } });
        public static character floyd = new character("Floyd", new string[,] { { "Thunder Twins", "Gatling Punches" }, { "Thunder Sphere", "Thunder Trap" }, { "Magnetic Grab", "Rakushin Cannon" }, { "Thunder Pounce", "Power Slide" }, { "Rakushin Beam", "Thunder Dome" } });
        public static character estel = new character("Estel", new string[,] { { "Boot Mark", "Flying Scythe" }, { "Flashbang", "Grenade" }, { "Police Tackle", "Sucker Punch" }, { "Air Grenade", "Air Flashbang" }, { "Tactical Support", "Surgical Strike" } });
        public static character cherry = new character("Cherry", new string[,] { { "Flying Knee", "Sliding Knee" }, { "Sound Check", "Somersault Kick" }, { "Townshend Smash", "Neck Break" }, { "Air Townshend Smash", "Special Stage Effects" }, { "Stage Entrance", "Triple Townshend" } });

        public static character[] chars = {
            sor1axel,
            sor2axel,
            sor3axel,
            sor4axel,
            sor1blaze,
            sor2blaze,
            sor3blaze,
            sor4blaze,
            sor1adam,
            sor4adam,
            sor2max,
            sor4max,
            sor2skate,
            sor3skate,
            sor3shiva,
            sor4shiva,
            zan,
            roo,
            floyd,
            estel,
            cherry
            };
    }
}