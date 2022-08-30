# Imports
import math
import random
import tkinter.messagebox
import tkinter.simpledialog
from tkinter import *

# Variables

# Character Class
class character:
    def __init__(self,name,moves):
        self.name = name # character's name
        self.moves = moves # character's moves, an array in an array (2d array)

# Format: Name, Moves (Blitz, Defensive Special, Offensive Special, Air Special (if applicable), Star Special (always))
sor1axel = character("Axel-SOR1",[["Summon Police","Pipe Rage"]])
sor2axel = character("Axel-SOR2",[["Grand Upper","Tiger Knee"],["Dragon Wing","Tornado Kick"],["Dragon Smash","Dragon Dash Blow"],["Grand Dragon Wing","Spinning Dragon Upper"]])
sor3axel = character("Axel-SOR3",[["Grand Upper","Scissors Kick"],["Dragon Wing","Spinning Body Blow"],["Dragon Smash","Dragon Punch"],["Spinning Body Smash","Spirit Blade"]])
sor4axel = character("Axel",[["Grand Upper","Dragon Roll"],["Dragon Wing","Dragon Upper"],["Dragon Smash","Dragon Bite"],["Dragon Dive","Dragon Crush"],["Dragon Burst","Ultimate Dragon Wing"]])
sor1blaze = character("Blaze-SOR1",[["Police Call","Drill Kick"]])
sor2blaze = character("Blaze-SOR2",[["Hishousouzan","Elbow Strike"],["Embukyako","Spinning Dive"],["Kikou Shou","Aerial Grab"],["Tumbling","Ring of Fire"]])
sor3blaze = character("Blaze-SOR3",[["Hishousouzan","Chou Reppa Dan"],["Embukyako","Energy Burst"],["Kikou Shou","Spirit Knife"],["Razor Sliding Tackle","Slice and Dice"]])
sor4blaze = character("Blaze",[["Hishousouzan","Rekkaken"],["Embukyako","Uraken Uchi"],["Kikou Shou","Hien Zan"],["Tobi Kyaku","Shin Hishousouzan"],["Tamashi Age","Shin Kikou Shou"]])
sor1adam = character("Adam-SOR1",[["Summon Police","Slash Kick"]])
sor4adam = character("Adam",[["Uzi Punch","Sword Upper"],["Chopper","Split Fangs"],["Howl Fang","Sword Smash"],["Air Chopper","Slash Kick"],["Sword Strike","Lift Off"]])
sor2max = character("Max-SOR2",[["Sliding Tackle","Power Chop"],["Spinning Knuckle Bomb","Hammer Slam"],["Thunder Tackle","Rolling Grab"],["Giant Swing","Cyclone Knuckle Bomb"]])
sor4max = character("Max",[["Power Slide","Clothes Lining"],["Spinning Knuckle Bomb","Spinning Knuckle Vortex"],["Thunder Tackle","Rolling Grab"],["Body Slam","Thunder Strike"],["Thunder Strikes","Iron Will"]])
sor2skate = character("Skate-SOR2",[["Flying Headbutt","Inline Rush"],["Spinning Attack","Cannonball"],["Corkscrew Kick","Somersault Kick"],["Breakdance","Drilling Strike"]])
sor3skate = character("Skate-SOR3",[["Flying Headbutt","Ground Roll"],["Spinning Attack","Get Off Me"],["Skating Fist Fury","Flash Kick"],["Ground Roll Smash","Human Cannonball"]])
sor3shiva = character("Shiva-SOR3",[["Dashing Moon Kick","Dark Dash"],["Moon Kick","Ki Strike"],["Final Crash","Diving Moon Kick"],["Ultimate Final Crash","Asura Ranbu"]])
sor4shiva = character("Shiva",[["Final Crash","Flying Kick"],["Flaming Circular Kick","Hashinshou"],["Senretsu Ken","Spirit Palm"],["Air Senretsu Ken","Spirit Kick"],["Shin Hashinshou","Spirit Dance"]])
zan = character("Dr.Zan-SOR3",[["Elbow Slam Shield","The Claw"],["Shock Treatment","Energy Ball"],["Electric Grab","Guillotine"],["Super Shield Charge","Big Energy Ball"]])
roo = character("Roo-SOR3",[["Handbrake","Gatling Kick"],["Somersault Tail Whip","Spinning Kick"],["Hurricane Kick","Rolling Attack"],["Air Tail Whip","Air Rolling Attack"],["Here Comes Bruce","Earthquake"]])
floyd = character("Floyd",[["Thunder Twins","Gatling Punches"],["Thunder Sphere","Thunder Trap"],["Magnetic Grab","Rakushin Cannon"],["Thunder Pounce","Power Slide"],["Rakushin Beam","Thunder Dome"]])
estel = character("Estel",[["Boot Mark","Flying Scythe"],["Flashbang","Grenade"],["Police Tackle","Sucker Punch"],["Air Grenade","Air Flashbang"],["Tactical Support","Surgical Strike"]])
cherry = character("Cherry",[["Flying Knee","Sliding Knee"],["Sound Check","Somersault Kick"],["Townshend Smash","Neck Break"],["Air Townshend Smash","Special Stage Effects"],["Stage Entrance","Triple Townshend"]])

chars = [
sor4axel,
sor1axel, 
sor2axel,
sor3axel,
sor4blaze,
sor1blaze,
sor2blaze,
sor3blaze,
cherry,
floyd,
sor4adam,
sor1adam,
sor4shiva,
sor3shiva,
estel,
sor2skate,
sor3skate,
sor4max,
sor2max,
zan,
roo
]

showmoves = 2 # 0 No / 1 Yes / 2 Both

# Functions

def pick(character):
    chara = None
    if character == None:
        chara = random.choice(chars)
    else:
        i = 0
        while i < len(chars):
            if chars[i].name == character:
                chara = chars[i];
            i += 1
    movesa = []
    i = 0
    while i < 5:
        form = random.randint(0,1)
        if form == 0:
            movesa.append(0)
        elif form == 1:
            movesa.append(1)
        i += 1
    if showmoves == 0 or showmoves == 2:
        movesb = []
        i = 0
        while i < 5:
            if movesa[i] == 0:
                movesb.append("Normal")
            elif movesa[i] == 1:
                movesb.append("Alt")
            i += 1
    moveso = ""
    if showmoves == 0:
        if(len(chara.moves) == 1):
            moveso = "Character: "+chara.name+"\nStar Move: "+movesb[0]
        elif(len(chara.moves) == 4):
            moveso = "Character: "+chara.name+"\nBlitz: "+movesb[0]+"\nDefensive Special: "+movesb[1]+"\nOffensive Special: "+movesb[2]+"\nStar Move: "+movesb[3]
        elif(len(chara.moves) == 5):
            moveso = "Character: "+chara.name+"\nBlitz: "+movesb[0]+"\nDefensive Special: "+movesb[1]+"\nOffensive Special: "+movesb[2]+"\nAir Special: "+movesb[3]+"\nStar Move: "+movesb[4]
        return moveso
    elif showmoves == 1: 
        if(len(chara.moves) == 1):
            moveso = "Character: "+chara.name+"\nStar Move: "+chara.moves[0][0]
        elif(len(chara.moves) == 4):
            moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0][movesa[0]]+"\nDefensive Special: "+chara.moves[1][movesa[1]]+"\nOffensive Special: "+chara.moves[2][movesa[2]]+"\nStar Move: "+chara.moves[3][movesa[3]]
        elif(len(chara.moves) == 5):
            moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0][movesa[0]]+"\nDefensive Special: "+chara.moves[1][movesa[1]]+"\nOffensive Special: "+chara.moves[2][movesa[2]]+"\nAir Special: "+chara.moves[3][movesa[3]]+"\nStar Move: "+chara.moves[4][movesa[4]]
        return moveso
    elif showmoves == 2:
        if(len(chara.moves) == 1):
            moveso = "Character: "+chara.name+"\nStar Move: "+chara.moves[0][movesa[0]]+" ("+movesb[0]+")"
        elif(len(chara.moves) == 4):
            moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0][movesa[0]]+" ("+movesb[0]+")"+"\nDefensive Special: "+chara.moves[1][movesa[1]]+" ("+movesb[1]+")"+"\nOffensive Special: "+chara.moves[2][movesa[2]]+" ("+movesb[2]+")"+"\nStar Move: "+chara.moves[3][movesa[3]]+" ("+movesb[3]+")"
        elif(len(chara.moves) == 5):
            moveso = "Character: "+chara.name+"\nBlitz: "+chara.moves[0][movesa[0]]+" ("+movesb[0]+")"+"\nDefensive Special: "+chara.moves[1][movesa[1]]+" ("+movesb[1]+")"+"\nOffensive Special: "+chara.moves[2][movesa[2]]+" ("+movesb[2]+")"+"\nAir Special: "+chara.moves[3][movesa[3]]+" ("+movesb[3]+")"+"\nStar Move: "+chara.moves[4][movesa[4]]+" ("+movesb[4]+")"
        return moveso
        
def changemoves(value):
    global showmoves
    if value == 0:
        showmoves = 0
    elif value == 1:
        showmoves = 1
    elif value == 2:
        showmoves = 2

# Window
window = Tk()
window.geometry('550x300')
window.title("Street of Rage 4 Random Character & Moveset Picker")

# Window Functions
def randomcharacter(): 
    tkinter.messagebox.showinfo("Randomly Pick a Character",pick(None))
    
def choosecharacter():
    listofchars = "List of characters:\n"
    i = 0
    while i < len(chars):
        listofchars = listofchars + chars[i].name + ",\n"
        i += 1
    listofchars = listofchars[:len(listofchars) - 2]
    character = simpledialog.askstring("Choose a Character",listofchars+"\nEnter the character you want below:",parent = window)
    if character == "" or str(character) in listofchars == False:
        tkinter.messagebox.showinfo("Randomly Pick a Character",pick(None))
    else:
        tkinter.messagebox.showinfo("Choose a Character",pick(character))
            
def randomstage():
    stage = random.randrange(1,12)
    stages = ["The Streets","Police Precinct","Cargo Ship","Old Pier","Underground","Chinatown","Skytrain","Art Gallery","Y Tower","To The Concert","Airplane","Y Island"]
    tkinter.messagebox.showinfo("Randomly Pick a Stage","Stage "+str(stage)+"\n"+stages[stage-1])

#def leave():
#    window.destroy()
    
# Window Buttons
rcb=Button(window,text="Randomly Pick a Character", width=20,height=5,command=randomcharacter)
rcb.place(x=0,y=50)
ccb=Button(window,text="Choose a Character", width=15,height=5,command=choosecharacter)
ccb.place(x=200,y=50)
rsb=Button(window,text="Randomly Pick a Stage", width=20,height=5,command=randomstage)
rsb.place(x=350,y=50)
nomb=Button(window,text="Normal/Alt", width=10,height=5,command=lambda: changemoves(0))
nomb.place(x=50,y=150)
smb=Button(window,text="Move Names", width=10,height=5,command=lambda: changemoves(1))
smb.place(x=150,y=150)
sbb=Button(window,text="Show Both", width=10,height=5,command=lambda: changemoves(2))
sbb.place(x=250,y=150)
#exi=Button(window,text="Exit",width=5,height=5,command=leave())
#exi.place(x=200,y=175)

window.mainloop()