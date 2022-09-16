import character.java;

public class sor4
{
	// Variables

	// Character Class
	// See: characters.java

	int showmoves = 2; //0 No / 1 Yes / 2 Both

	// Functions
	public static void pick(character character) // Randomly picks moveset, takes character as specified input
	{
		if(character == "random")
		{
			String chara = chars[Math.floor((Math.random() * chars.length) + 0)];
		}
		else
		{
			String chara = character;
		}
		int[] movesa;
		for(int i = 0; i < 5; i++)
		{
			int form = Math.floor(Math.random() * 2);
			if(form == 0)
			{
				movesa[i] = 0; // Normal
			}
			if(form == 1)
			{
				movesa[i] = 1; // Alt
			}
		}
		if(showmoves == 0 || showmoves == 2)
		{
			String[] movesb;
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
		String moveso;
		switch(showmoves)
		{
			case 0:
				if(chara.moves.length == 1)
				{
					moveso = "Character: "+chara.name+"\nStar Move: "+movesb[0];
				}
				else if(chara.moves.length == 4)
				{
					moveseo = "Character: "+chara.name+"\nBlitz: "+movesb[0]+"\nDefensive Special: "+movesb[1]+"\nOffensive Special: "+movesb[2]+"\nStar Move: "+movesb[3]);
				}
				else if(chara.moves.length == 5)
				{
					moveso = "Character: "+chara.name+"\nBlitz: "+movesb[0]+"\nDefensive Special: "+movesb[1]+"\nOffensive Special: "+movesb[2]+"\nAir Special: "+movesb[3]+"\nStar Move: "+movesb[4]);
				}
				break;
			case 1:
				if(chara.moves.length == 1)
				{
					moveso = "Character: "+chara.name+"\nStar Move: "+chara.moves[0][movesa[0]]);
				}
				else if(chara.moves.length == 4)
				{
					moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0][movesa[0]]+"\nDefensive Special: "+chara.moves[1][movesa[1]]+"\nOffensive Special: "+chara.moves[2][movesa[2]]+"\nStar Move: "+chara.moves[3][movesa[3]]);
				}
				else if(chara.moves.length == 5)
				{
					moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0][movesa[0]]+"\nDefensive Special: "+chara.moves[1][movesa[1]]+"\nOffensive Special: "+chara.moves[2][movesa[2]]+"\nAir Special: "+chara.moves[3][movesa[3]]+"\nStar Move: "+chara.moves[4][movesa[4]]);
				}
				break;
			case 2:
				if(chara.moves.length == 1)
				{
					moveso = "Character: "+chara.name+"\nStar Move: "+chara.moves[0][movesa[0]]+" ("+movesb[0]+")");
				}
				else if(chara.moves.length == 4)
				{
					moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0][movesa[0]] +" ("+movesb[0]+")\nDefensive Special: "+chara.moves[1][movesa[1]]+"("+movesb[1]+")\nOffensive Special: "+chara.moves[2][movesa[2]]+" ("+movesb[2]+")\nStar Move: "+chara.moves[3][movesa[3]]+" ("+movesb[3]+")");
				}
				else if(chara.moves.length == 5)
				{
					moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0][movesa[0]] +" ("+movesb[0]+")\nDefensive Special: "+chara.moves[1][movesa[1]]+"("+movesb[1]+")\nOffensive Special: "+chara.moves[2][movesa[2]]+" ("+movesb[2]+")\nAir Special: "+chara.moves[3][movesa[3]]+" ("+movesb[3]+")\nStar Move: "+chara.moves[4][movesa[4]]+" ("+movesb[4]+")");
				}
				break;
		}
	}
	public static void pick()
	{
		pick("random");
	}
	
	public static void changemoves(int value)
	{
		switch(value)
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
	
	public static void main(String[] args)
	{
	   
	}
}