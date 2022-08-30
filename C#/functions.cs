using System;
using static System.Windows.Forms.DataFormats;
using System.Xml.Linq;
using System.Reflection;
using System.Drawing;

namespace sor4
{
    public class functions
	{
        public static int showmoves = 2; //0 No / 1 Yes / 2 Both
        public static string pick(string charact) // Randomly picks moveset, takes character as specified input
		{
			Random rnd = new Random();

			character chara = character.sor4axel;
			string characte = "";
			for (int i = 0; i < character.chars.Length; i++)
			{
				if (charact == character.chars[i].name)
				{
					chara = character.chars[i];
					characte = "";
					break;
				}
				else if(charact != character.chars[i].name)
				{
					characte = "random";
				}
			}
            if (characte == "random" || charact == "random") 
            {
                Decimal d = rnd.Next(0, character.chars.Length);
                int i = (int)d;
                chara = character.chars[i];
            }
            int[] movesa = new int[5];
			for(int i = 0; i < 5; i++)
			{
                double d = rnd.NextDouble() * 2;
                int form = (int)Math.Floor(d);
                if (form == 0)
				{
					movesa[i] = 0; // Normal
				}
				if(form == 1)
				{
					movesa[i] = 1; // Alt
				}
			}
            string[] movesb = new string[5];
            if (showmoves == 0 || showmoves == 2)
			{
				for(int i = 0; i < 5; i++)
				{
					if(movesa[i] == 0)
					{
						movesb[i] = "Normal";
					}
					else if(movesa[i] == 1)
					{
						movesb[i] = "Alt";
					}
				}
			}
			string moveso = "";
			switch(showmoves)
			{
				case 0:
					if(chara.moves.GetLength(0) == 1)
					{
						moveso = "Character: "+chara.name+"\nStar Move: "+movesb[0];
					}
					else if(chara.moves.GetLength(0) == 4)
					{
						moveso = "Character: "+chara.name+"\nBlitz: "+movesb[0]+"\nDefensive Special: "+movesb[1]+"\nOffensive Special: "+movesb[2]+"\nStar Move: "+movesb[3];
					}
					else if(chara.moves.GetLength(0) == 5)
					{
						moveso = "Character: "+chara.name+"\nBlitz: "+movesb[0]+"\nDefensive Special: "+movesb[1]+"\nOffensive Special: "+movesb[2]+"\nAir Special: "+movesb[3]+"\nStar Move: "+movesb[4]; 
					}
					break;
				case 1:
					if(chara.moves.GetLength(0) == 1)
					{
						moveso = "Character: "+chara.name+"\nStar Move: "+chara.moves[0,movesa[0]];
					}
					else if(chara.moves.GetLength(0) == 4)
					{
						moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0,movesa[0]]+"\nDefensive Special: "+chara.moves[1,movesa[1]]+"\nOffensive Special: "+chara.moves[2,movesa[2]]+"\nStar Move: "+chara.moves[3,movesa[3]];
					}
					else if(chara.moves.GetLength(0) == 5)
					{
						moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0,movesa[0]]+"\nDefensive Special: "+chara.moves[1,movesa[1]]+"\nOffensive Special: "+chara.moves[2,movesa[2]]+"\nAir Special: "+chara.moves[3,movesa[3]]+"\nStar Move: "+chara.moves[4,movesa[4]];
					}
					break;
				case 2:
					if(chara.moves.GetLength(0) == 1)
					{
						moveso = "Character: "+chara.name+"\nStar Move: "+chara.moves[0,movesa[0]]+" ("+movesb[0]+")";
					}
					else if(chara.moves.GetLength(0) == 4)
					{
						moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0,movesa[0]]+" ("+movesb[0]+")"+"\nDefensive Special: "+chara.moves[1,movesa[1]]+" ("+movesb[1]+")"+"\nOffensive Special: "+chara.moves[2,movesa[2]]+" ("+movesb[2]+")"+"\nStar Move: "+chara.moves[3,movesa[3]]+" ("+movesb[3]+")";
					}
					else if(chara.moves.GetLength(0) == 5)
					{
						moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0,movesa[0]]+" ("+movesb[0]+")"+"\nDefensive Special: "+chara.moves[1,movesa[1]]+" ("+movesb[1]+")"+"\nOffensive Special: "+chara.moves[2,movesa[2]]+" ("+movesb[2]+")"+"\nAir Special: "+chara.moves[3,movesa[3]]+" ("+movesb[3]+")"+"\nStar Move: "+chara.moves[4,movesa[4]]+" ("+movesb[4]+")";
					}
					break;
			}
			return moveso;
        }

		public static string characterlist()
		{
			string clist = "";
			for(int i = 0; i < character.chars.Length; i++)
			{
				clist = clist + character.chars[i].name + ", ";
			}
			clist = clist.Remove(clist.Length - 2);

            return clist;
		}
		public static void changemoves(int val)
		{
			switch(val)
			{
				case 0:
					showmoves = 0;
					break;
				case 1:
					showmoves = 1;
					break;
				case 2:
					showmoves = 2;
					break;
			}
		}

		public static string randomstage()
		{
			Random rnd = new Random();
			int stage = rnd.Next(1, 12);
			string[] stages = { "The Streets", "Police Precinct", "Cargo Ship", "Old Pier", "Underground", "Chinatown", "Skytrain", "Art Gallery", "Y Tower", "To The Concert", "Airplane", "Y Island" };
			return "Stage " + stage + " - " + stages[stage - 1];
        }
	}
}