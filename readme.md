# Street of Rage 4 Random Character & Moveset Picker

# Summary:
## What is this program?
This program was made for me and my friend for the game Streets of Rage 4.
It could give us a random character and a random moveset for when we played the game.
It also could give you a random moveset for a specified character.
The output can display the name of the moves, or have it be "normal" or "alt", or include both of these, depending on the settings. 
I added a random stage picker as an added bonus.
This program originally was a HTML webpage with JavaScript and had a very basic graphical design, it was then ported to Java, 
then it was ported to Python with a basic GUI and a few new touches, then it was finally ported to C#. with a GUI with the features of
the Python version. 
This project helped me re-learn and improve on my OOP, Java and Python skills while helping me learn C#.

## How does it accomplish this? (Code Explanation)
The characters are stored in a class object called fittingly "characters", which takes their name as a string and their movesets
as a 2D String Array (as there is a normal and alternative move). There is a function that will randomly pick a character out of a list containing these characters. 
The movesets themselves are picked at random from the list they're in. If it is 0, it's the normal move, 
if it is 1, it's the alternative move. If the program is set to display normal/alt only, it will only display that where if it's not,
be it to display both normal/alt or just the names, it will set the names to a variable by accessing the 2D array of the character
and accessing the appropriate index (so if it was normal, it'd be the first move, 0, or if it was alt, it'd be the 2nd move, 1).
The function also has a parameter for specified characters, so I could use a GUI with an input to allow the user to have a specified
character's random moveset.
The random stage picker is a simple random function that picks a number from 1 to 12. The stage names (in later versions of the program)
are provided in a list which the function will get by indexing the list minus 1 position away.