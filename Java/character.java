public class character 
{
	String name;
	String moves[][];
	public character(String cname, String[][] cmoves)
	{
		name = cname; // character's name
		moves = cmoves; // character's moves, an array in an array (3d array)
	}

	public static void main(String[] args)
	{
		// Format: Name, Moves (Blitz, Defensive Special, Offensive Special, Air Special (if applicable), Star Special (always))
		character sor1axel = new character("Axel-SOR1", new String[][] {{"Summon Police","Pipe Rage"}});
		character sor2axel = new character("Axel-SOR2", new String[][] {{"Grand Upper","Tiger Knee"},{"Dragon Wing","Tornado Kick"},{"Dragon Smash","Dragon Dash Blow"},{"Grand Dragon Wing","Spinning Dragon Upper"}});
		character sor3axel = new character("Axel-SOR3", new String[][] {{"Grand Upper","Scissors Kick"},{"Dragon Wing","Spinning Body Blow"},{"Dragon Smash","Dragon Punch"},{"Spinning Body Smash","Spirit Blade"}});
		character sor4axel = new character("Axel", new String[][] {{"Grand Upper","Dragon Roll"},{"Dragon Wing","Dragon Upper"},{"Dragon Smash","Dragon Bite"},{"Dragon Dive","Dragon Crush"},{"Dragon Burst","Ultimate Dragon Wing"}});
		character sor1blaze = new character("Blaze-SOR1", new String[][] {{"Police Call","Drill Kick"}});
		character sor2blaze = new character("Blaze-SOR2", new String[][] {{"Hishousouzan","Elbow Strike"},{"Embukyako","Spinning Dive"},{"Kikou Shou","Aerial Grab"},{"Tumbling","Ring of Fire"}});
		character sor3blaze = new character("Blaze-SOR3", new String[][] {{"Hishousouzan","Chou Reppa Dan"},{"Embukyako","Energy Burst"},{"Kikou Shou","Spirit Knife"},{"Razor Sliding Tackle","Slice and Dice"}});
		character sor4blaze = new character("Blaze", new String[][] {{"Hishousouzan","Rekkaken"},{"Embukyako","Uraken Uchi"},{"Kikou Shou","Hien Zan"},{"Tobi Kyaku","Shin Hishousouzan"},{"Tamashi Age","Shin Kikou Shou"}});
		character sor1adam = new character("Adam-SOR1", new String[][] {{"Summon Police","Slash Kick"}});
		character sor4adam = new character("Adam", new String[][] {{"Uzi Punch","Sword Upper"},{"Chopper","Split Fangs"},{"Howl Fang","Sword Smash"},{"Air Chopper","Slash Kick"},{"Sword Strike","Lift Off"}});
		character sor2max = new character("Max-SOR2", new String[][] {{"Sliding Tackle","Power Chop"},{"Spinning Knuckle Bomb","Hammer Slam"},{"Thunder Tackle","Rolling Grab"},{"Giant Swing","Cyclone Knuckle Bomb"}});
		character sor4max = new character("Max",new String[][] {{"Power Slide","Clothes Lining"},{"Spinning Knuckle Bomb","Spinning Knuckle Vortex"},{"Thunder Tackle","Rolling Grab"},{"Body Slam","Thunder Strike"},{"Thunder Strikes","Iron Will"}});
		character sor2skate = new character("Skate-SOR2", new String[][] {{"Flying Headbutt","Inline Rush"},{"Spinning Attack","Cannonball"},{"Corkscrew Kick","Somersault Kick"},{"Breakdance","Drilling Strike"}});
		character sor3skate = new character("Skate-SOR3", new String[][] {{"Flying Headbutt","Ground Roll"},{"Spinning Attack","Get Off Me"},{"Skating Fist Fury","Flash Kick"},{"Ground Roll Smash","Human Cannonball"}});
		character sor3shiva = new character("Shiva-SOR3", new String[][] {{"Dashing Moon Kick","Dark Dash"},{"Moon Kick","Ki Strike"},{"Final Crash","Diving Moon Kick"},{"Ultimate Final Crash","Asura Ranbu"}});
		character sor4shiva = new character("Shiva", new String[][] {{"Final Crash","Flying Kick"},{"Flaming Circular Kick","Hashinshou"},{"Senretsu Ken","Spirit Palm"},{"Air Senretsu Ken","Spirit Kick"},{"Shin Hashinshou","Spirit Dance"}});
		character zan = new character("Dr.Zan-SOR3", new String[][] {{"Elbow Slam Shield","The Claw"},{"Shock Treatment","Energy Ball"},{"Electric Grab","Guillotine"},{"Super Shield Charge","Big Energy Ball"}});
		character roo = new character("Roo-SOR3", new String[][] {{"Handbrake","Gatling Kick"},{"Somersault Tail Whip","Spinning Kick"},{"Hurricane Kick","Rolling Attack"},{"Air Tail Whip","Air Rolling Attack"},{"Here Comes Bruce","Earthquake"}});
		character floyd = new character("Floyd", new String[][] {{"Thunder Twins","Gatling Punches"},{"Thunder Sphere","Thunder Trap"},{"Magnetic Grab","Rakushin Cannon"},{"Thunder Pounce","Power Slide"},{"Rakushin Beam","Thunder Dome"}});
		character estel = new character("Estel", new String[][] {{"Boot Mark","Flying Scythe"},{"Flashbang","Grenade"},{"Police Tackle","Sucker Punch"},{"Air Grenade","Air Flashbang"},{"Tactical Support","Surgical Strike"}});
		character cherry = new character("Cherry", new String[][] {{"Flying Knee","Sliding Knee"},{"Sound Check","Somersault Kick"},{"Townshend Smash","Neck Break"},{"Air Townshend Smash","Special Stage Effects"},{"Stage Entrance","Triple Townshend"}});

		character[] chars = {
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