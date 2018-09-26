using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTSGame
{
    public partial class Form1 : Form
    {
       public abstract class Unit: Button
       {
            //Private fields
            private int xPos = 0;
            private int yPos = 0;
            private int health;
            private int speed;
            private int attack;
            private int attackRange;
            private string team;
            protected string name;
            private char symbol;
            protected int distance;

            //Get and Sets all private fields to make them public.
            public int XPos
            {
                get { return xPos; }
                set { xPos = value; }
            }

            public int YPos
            {
                get { return yPos; }
                set { yPos = value; }
            }

            public int Health
            {
                get { return health; }
                set { health = value; }
            }

            public int Attack
            {
                get { return attack; }
                set { attack = value; }
            }

            public int AttackRange
            {
                get { return attackRange; }
                set { attackRange = value; }
            }

            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }

            public string Team
            {
                get { return team; }
                set { team = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public char Symbol
            {
                get { return symbol; }
                set { symbol = value; }
            }

            //Class contructor
            public Unit()
            {
                
            }

            //Methods for movements
            public virtual void movePos()
            {

            }

            public virtual void combatUnit()
            {

            }

            public virtual bool inRange()
            {
                return false;
            }

            public virtual void closestUnit()
            {

            }

            public virtual void death()
            {

            }

            public virtual void unitInfo()
            {

            }

            public virtual string ToString()
            {
                return null;
            }

            //Saving all information as an object to later be read.
            public abstract void Save(string FileName, Unit NewUnits);
       }

        public abstract class Building : Button
        {
            //protected fields for buildings 
            protected int buildXPos;
            protected int buildYPos;
            protected int buildHealth = 500;
            protected string buildFaction;
            protected char buildSymbol;

            //Get and Set protected values
            public int BuildXPos
            {
                get { return buildXPos; }
                set { buildXPos = value; }
            }

            public int BuildYPos
            {
                get { return buildYPos; }
                set { buildYPos = value; }
            }

            public int BuildHealth
            {
                get { return buildHealth; }
                set { buildHealth = value; }
            }

            public string BuildFaction
            {
                get { return buildFaction; }
                set { buildFaction = value; }
            }

            public char BuildSymbol
            {
                get { return buildSymbol; }
                set { buildSymbol = value; }
            }

            //class contructor
            public Building()
            {

            }

            //All methods for hanldling buildings
            public virtual void buildDestruction()
            {

            }

            public virtual void ToString()
            {

            }

            //Saving all information and storing it as an object to be stored and read later.
            public abstract void Save(string FileName, Building NewBuildings);
        }

        public class EmptyTile : Button
        {
            //This class is to create an empty tile on the game's map.

            //Get and Sets for empty tiles.
            int xPos, yPos;
            public int XPos
            {
                get { return xPos; }
                set { xPos = value; }
            }

            public int YPos
            {
                get { return yPos; }
                set { yPos = value; }
            }

            public EmptyTile()
            {

            }

            public string ToString()
            {
                string emptyString = "Empty Spot" + Environment.NewLine + "(" + xPos + "," + yPos + ")";
                return emptyString;
            }
        }

        [Serializable]
        public class FactoryBuilding : Building
        {
            //Buildings that produce units
            //Private fields
            private int unitsToProduce = 1;
            private int gametickProducion;
            private int spawnPoint;

            Form1 form1;
            ResourceBuilding resources;

            //Class contructor
            public FactoryBuilding(Form1 form1)
            {
                this.form1 = form1;
                this.resources = new ResourceBuilding(form1);
            }

            //Get and Sets for private fields
            public int UnitsToProduce
            {
                get { return unitsToProduce; }
                set { unitsToProduce = value; }
            }

            public int GameTickProducion
            {
                get { return gametickProducion; }
                set { gametickProducion = value; }
            }

            public int SpawnPoint
            {
                get { return spawnPoint; }
                set { spawnPoint = value; }
            }

            public override void ToString()
            {
                base.ToString();
            }

            public override void buildDestruction()
            {
                if (BuildHealth == 0)
                {
                    // Remove object from array. Redraw map.
                }
            }

            //Spawns new units when coin requirement is met. Also deducts from total.
            public void spawnNewUnits()
            {

            }

            public string FileName = @"F:\Saves\RTSfactory.ser";
            public override void Save(string FileName, Building NewBuildings)
            {
                FStream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                Bformatter = new BinaryFormatter();
                Bformatter.Serialize(FStream, NewBuildings);
                FStream.Close();
            }
        }

        [Serializable]
        public class ResourceBuilding : Building
        {
            //Buildings that generate resources
            //Private fields for Resource Building
            private int warResources;
            private int resourcesGainedTeam1 = 0;
            private int resourcesGainedTeam2 = 0;
            private int coalTeam1 = 0;
            private int coalTeam2 = 0;
            private int ironTeam1 = 0;
            private int ironTeam2 = 0;
            private int steelTeam1 = 0;
            private int steelTeam2 = 0;
            private int depositX, depositY;
            private string team;
            private int resourcesRemaining = 0;


            //Constructor for Resource Building
            public ResourceBuilding(Form1 form1)
            {
                this.form1 = form1;
            }
            
            //Get and Sets for resource buildings

            public int WarResources
            {
                get { return warResources; }
                set { warResources = value; }
            }

            public int ResourcesGainedTeam1
            {
                get { return resourcesGainedTeam1; }
                set { resourcesGainedTeam1 = value; }
            }

            public int ResourcesGainedTeam2
            {
                get { return resourcesGainedTeam2; }
                set { resourcesGainedTeam2 = value; }
            }

            public int CoalTeam1
            {
                get { return coalTeam1; }
                set { coalTeam1 = value; }
            }

            public int CoalTeam2
            {
                get { return coalTeam2; }
                set { coalTeam2 = value; }
            }

            public int IronTeam1
            {
                get { return ironTeam1; }
                set { ironTeam1 = value; }
            }

            public int IronTeam2
            {
                get { return ironTeam2; }
                set { ironTeam2 = value; }
            }

            public int SteelTeam1
            {
                get { return steelTeam1; }
                set { steelTeam1 = value; }
            }

            public int SteelTeam2
            {
                get { return steelTeam2; }
                set { steelTeam2 = value; }
            }

            public int DepositX
            {
                get { return depositX; }
                set { depositX = value; }
            }

            public int DepositY
            {
                get { return depositY; }
                set { depositY = value; }
            }

            public string Team
            {
                get { return team; }
                set { team = value; }
            }

            public override void buildDestruction()
            {
                if (BuildHealth == 0)
                {
                    //Set the position in the array holding the buildings to contain nothing.
                }
            }

            public override void ToString()
            {
                base.ToString();
            }

            Form1 form1;
            FactoryBuilding spawnUnits;
            private int i = 1;
            public int I
            {
                get { return i; }
                set { i = value; }
            }

            private int j = 1;
            public int J
            {
                get { return j; }
                set { j = value; }
            }

            private int coal = 1;
            public int Coal
            {
                get { return coal; }
                set { coal = value; }
            }

            private int iron = 1;
            public int Iron
            {
                get { return iron; }
                set { iron = value; }
            }

            private int steel = 1;
            public int Steel
            {
                get { return steel; }
                set { steel = value; }
            }

            int x, y;

            //Methods not in base class
            public void GenerateResources()
            {
                //Generate and removes resources from each team. Every Second adds 10 coins
                ResourcesGainedTeam1 = (i++ * 10);
                ResourcesGainedTeam2 = (j++ * 10);
                form1.resLabel.Text = String.Format("{0:00}", ResourcesGainedTeam1);
                form1.resLabel2.Text = String.Format("{0:00}", ResourcesGainedTeam2);
            }

            public void GenerateCoal()
            {
                Random randGather = new Random(Guid.NewGuid().GetHashCode());
                x = randGather.Next(3, 5);
                y = randGather.Next(3, 5);

                CoalTeam1 = Coal++ * x;
                CoalTeam2 = Coal++ * y;
                form1.coalLabel.Text = String.Format("{0:00}", CoalTeam1);
                form1.coalLabel2.Text = String.Format("{0:00}", CoalTeam2);
            }

            public void GenerateIron()
            {
                Random randGather = new Random(Guid.NewGuid().GetHashCode());
                x = randGather.Next(3, 5);
                y = randGather.Next(3, 5);

                ironTeam1 = Iron++ * x;
                ironTeam2 = Iron++ * y;
                form1.ironLabel.Text = String.Format("{0:00}", ironTeam1);
                form1.ironLabel2.Text = String.Format("{0:00}", ironTeam2);
            }

            public void GenerateSteel()
            {
                if (coalTeam1 == 60 && ironTeam1 == 30 || CoalTeam2 == 60 && ironTeam2 == 30)
                {
                    MessageBox.Show("Hello");
                }
            }

            public string FileName = @"F:\Saves\RTSresource.ser";
            public override void Save(string FileName, Building NewBuildings)
            {
                FStream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                Bformatter = new BinaryFormatter();
                Bformatter.Serialize(FStream, NewBuildings);
                FStream.Close();
            }
        }

        [Serializable]
        public class MeleeUnit : Unit
        {
            int closeX, closeY;
            Map map;
            Form1 form1;

            // Constructor for the class
            public MeleeUnit(Map map, Form1 form1)
            {
                this.form1 = form1;
                this.map = map;
            }

            //Methods to handle movements of Ranged Units
            public override void movePos()
            {
                
            }

            public override void combatUnit()
            {
                
            }

            public override bool inRange()
            {
                if (distance <= AttackRange)
                {
                    return true;
                }
                else return false;
            }

            public override void closestUnit()
            {
                //if (map.myMap[XPos, YPos].Name == "♥" && map.myMap[XPos, YPos].Name == "♦")
                //{
                //    for (int x = 0; x < 20; x++)
                //    {
                //        for (int y = 0; y < 20; y++)
                //        {
                //            if (map.myMap[x, y].Name == "♥" || map.myMap[x, y].Name == "♦" && map.myMap[x, y].Name == map.myMap[XPos, YPos].Name)
                //            {
                //                double r = Math.Sqrt((x * XPos) + (y * YPos));
                //                if (r < distance)
                //                {
                //                    closeX = x;
                //                    closeY = y;
                //                    distance = Convert.ToInt32(r);
                //                }
                //            }
                //        }
                //    }
                //}
            }

            public override void death()
            {

            }

            public override string ToString()
            {
                string info;
                info = "Team: Humans " + Environment.NewLine + "Symbol: ♥" + Environment.NewLine + "Health: 100" + Environment.NewLine + "Attack: 20" + Environment.NewLine + "Speed: 1" + Environment.NewLine + "Range: 1";
                return info;
            }


            //Save method to save objects to later be read into the game
            public string FileName = @"F:\Saves\RTSMelee.ser";
            public override void Save(string FileName, Unit NewUnits)
            {
                FStream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                Bformatter = new BinaryFormatter();
                Bformatter.Serialize(FStream, NewUnits);
                FStream.Close();
            }
        }

        [Serializable]
        public class RangedUnit : Unit
        {

            //Constructor for ranged unit
            public RangedUnit()
            {

            }

            //Methods to handle movements of Ranged Units
            public override void movePos()
            {
                
            }

            public override void combatUnit()
            {

            }

            public override bool inRange()
            {
                if (distance <= AttackRange)
                {
                    return true;
                }
                else return false;
            }

            public override void closestUnit()
            {

            }

            public override void death()
            {

            }

            public override string ToString()
            {
                string info;
                info = "Team: Undead " + Environment.NewLine + "Symbol: ♦" + Environment.NewLine + "Health: 50" + Environment.NewLine + "Attack: 10" + Environment.NewLine + "Speed: 1" + Environment.NewLine + "Range: 1";
                return info;
            }

            public string FileName = @"F:\Saves\RTSRange.ser";
            public override void Save(string FileName, Unit NewUnits)
            {
                FStream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                Bformatter = new BinaryFormatter();
                Bformatter.Serialize(FStream, NewUnits);
                FStream.Close();
            }
        }

        [Serializable]
        public class Map
        {
            ResourceBuilding build1R;
            ResourceBuilding build2R;
           
            FactoryBuilding build1F;
            FactoryBuilding build2F;
            FactoryBuilding workshopHumans1;
            FactoryBuilding workshopHumans2;
            FactoryBuilding workshopUndead1;
            FactoryBuilding workshopUndead2;

            int x, y;
            TableLayoutPanel gridMap;
            Form1 form1;
            
            public Button[,] myMap = new Button[20, 20];       

            public Map(TableLayoutPanel gridMap, Form1 form1)
            {
                this.gridMap = gridMap;
                this.form1 = form1;
                this.build1R = new ResourceBuilding(form1);
                this.build2R = new ResourceBuilding(form1);
                this.build1F = new FactoryBuilding(form1);
                this.build2F = new FactoryBuilding(form1);
                this.workshopHumans1 = new FactoryBuilding(form1);
                this.workshopHumans2 = new FactoryBuilding(form1);
                this.workshopUndead1 = new FactoryBuilding(form1);
                this.workshopUndead2 = new FactoryBuilding(form1);
            }

            //Run through the array and randomly generate a unit.
            public void drawUnit()
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        //Creates an empty spot on map before anything else is initialized.
                        EmptyTile emptyT = new EmptyTile();
                        emptyT.Name = "Empty";
                        emptyT.XPos = i;
                        emptyT.YPos = k;
                        emptyT.Text = "○";
                        myMap[i, k] = emptyT;
                    }
                }

                //Putting buildings into permanent spots in the array.

                build2R.BuildXPos = 0;
                build2R.BuildYPos = 0;
                build2R.BuildFaction = "Human's Resource Building";
                build2R.Text = "✠";
                build2R.Name = "XRbuild";
                build2R.BackColor = Color.Orange;
                myMap[build2R.BuildXPos, build2R.BuildYPos] = build2R;

                build1F.BuildXPos = 19;
                build1F.BuildYPos = 0;
                build1F.BuildFaction = "Human's Factory Building";
                build1F.Text = "♓︎";
                build1F.BackColor = Color.Orange;
                build1F.Name = "XFbuild";
                myMap[build1F.BuildXPos, build1F.BuildYPos] = build1F;

                build2R.BuildXPos = 19;
                build2R.BuildYPos = 19;
                build1R.BuildFaction = "Undead's Resource Building";
                build1R.Text = "✠";
                build1R.BackColor = Color.MediumAquamarine;
                build1R.Name = "YRbuild";
                myMap[build2R.BuildXPos, build2R.BuildYPos] = build1R;

                build2F.BuildXPos = 0;
                build2F.BuildYPos = 19;
                build2F.BuildFaction = "Undead's Factory Building";
                build2F.Text = "♓︎";
                build2F.BackColor = Color.MediumAquamarine;
                build2F.Name = "YFbuild";
                myMap[build2F.BuildXPos, build2F.BuildYPos] = build2F;

                workshopHumans1.BuildXPos = 10;
                workshopHumans1.BuildYPos = 0;
                workshopHumans1.BuildFaction = "Human's Workshop";
                workshopHumans1.Text = "HW";
                workshopHumans1.BackColor = Color.Blue;
                myMap[workshopHumans1.BuildXPos, workshopHumans1.BuildYPos] = workshopHumans1;

                workshopUndead1.BuildXPos = 10;
                workshopUndead1.BuildYPos = 19;
                workshopUndead1.BuildFaction = "Undead's Workshop";
                workshopUndead1.Text = "UW";
                workshopUndead1.BackColor = Color.Blue;
                myMap[workshopUndead1.BuildXPos, workshopUndead1.BuildYPos] = workshopUndead1;

                workshopHumans2.BuildXPos = 9;
                workshopHumans2.BuildYPos = 0;
                workshopHumans2.BuildFaction = "Human's Workshop";
                workshopHumans2.Text = "HW";
                workshopHumans2.BackColor = Color.Blue;
                myMap[workshopHumans2.BuildXPos, workshopHumans2.BuildYPos] = workshopHumans2;

                workshopUndead2.BuildXPos = 9;
                workshopUndead2.BuildYPos = 19;
                workshopUndead2.BuildFaction = "Undead's Workshop";
                workshopUndead2.Text = "UW";
                workshopUndead2.BackColor = Color.Blue;
                myMap[workshopUndead2.BuildXPos, workshopUndead2.BuildYPos] = workshopUndead2;

                //First Team Melee Units
                for (int i = 0; i < 6; i++)
                {
                    MeleeUnit mu = new MeleeUnit(this,form1);
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);
                    
                    if (myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild" && myMap[x, y].Name != "UW" && myMap[x, y].Name != "HW")
                    {
                        mu.XPos = x;
                        mu.YPos = y;
                        mu.Team = "Humans";
                        mu.Name = "♥";
                        mu.Text = "♥";
                        mu.BackColor = Color.Orange;
                        myMap[x, y] = mu;
                    }
                }

                //First Team Ranged Unit
                for (int i = 0; i < 4; i++)
                {
                    RangedUnit rU = new RangedUnit();
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);

                    if(myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild" && myMap[x, y].Name != "UW" && myMap[x, y].Name != "HW")
                    {
                        rU.XPos = x;
                        rU.YPos = y;
                        rU.Team = "Humans";
                        rU.Name = "♥";
                        rU.Text = "♥";
                        rU.BackColor = Color.Orange;
                        myMap[x, y] = rU;
                    }
                }

                //Second Team Melee Unit
                for (int i = 0; i < 6; i++)
                {
                    MeleeUnit mu = new MeleeUnit(this, form1);
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);

                    if (myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild" && myMap[x, y].Name != "UW" && myMap[x, y].Name != "HW")
                    {                        
                        mu.XPos = x;
                        mu.YPos = y;
                        mu.Team = "Undead";
                        mu.Name = "♦";
                        mu.Text = "♦";
                        mu.BackColor = Color.MediumAquamarine;
                        myMap[x, y] = mu;
                    }
                }

                //Second Team Ranged Unit
                for (int i = 0; i < 4; i++)
                {
                    RangedUnit rU = new RangedUnit();
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);

                    if (myMap[x, y].Name != "♥" && myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild" && myMap[x, y].Name != "UW" && myMap[x, y].Name != "HW")
                    {  
                        rU.XPos = x;
                        rU.YPos = y;
                        rU.Team = "Undead";
                        rU.Name = "♦";
                        rU.Text = "♦";
                        rU.BackColor = Color.MediumAquamarine;
                        myMap[x, y] = rU; 
                    }
                }

                //Coal deposits. Neutrally faction
                for (int i = 0; i < 6; i++)
                {
                    ResourceBuilding coalDeposit = new ResourceBuilding(form1);
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);

                    if (myMap[x, y].Name != "♦" && myMap[x, y].Name != "♥" && myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild")
                    {
                        coalDeposit.DepositX = x;
                        coalDeposit.DepositY = y;
                        coalDeposit.Team = "Environment";
                        coalDeposit.Name = "|";
                        coalDeposit.Text = "|";
                        coalDeposit.BackColor = Color.Black;
                        myMap[x, y] = coalDeposit;
                    }
                }
            }

            public void newMap()
            {
                //Method to redraw, clear a new map. Adds units that are randomized

                gridMap.Controls.Clear();
                drawUnit();

                for (int i = 0; i < 20; i++)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        myMap[i, k].Height = 45;
                        myMap[i, k].Width = 45;
                        gridMap.Controls.Add(myMap[i, k]);
                        if (myMap[i, k].Name == "Empty")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnEmpty);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Name == "XRbuild")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnBuildingR);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Name == "XFbuild")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnBuildingF);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Name == "YRbuild")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnBuildingR);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Name == "YFbuild")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnBuildingF);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Text == "♥")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnMelee);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Text == "♦")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnRange);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Text == "|")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnDeposit);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                    }
                }
            }

            public void moveUnit()
            {

            }

            public void updatePos()
            {

            }

            public static Form1[] AllObjects(string FileName)
            {
                FStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                Bformatter = new BinaryFormatter();

                Form1[] ObjectArr = new Form1[0];
                int i = 0;

                while (FStream.Position < FStream.Length)
                {
                    Array.Resize(ref ObjectArr, ObjectArr.Length + 1);
                    ObjectArr[i] = (Form1)Bformatter.Deserialize(FStream);

                    i++;
                }

                FStream.Close();
                return ObjectArr;
            }
        }

        [Serializable]
        public class GameEngine
        {
            MeleeUnit swordsman;
            RangedUnit archer;
            ResourceBuilding resources;
            FactoryBuilding spawnUnits;
            Form1 form1;
            Map map;

            public ResourceBuilding Resources
            {
                get{ return resources; }

                set{ resources = value; }
            }

            public FactoryBuilding SpawnUnits
            {
                get { return spawnUnits; }

                set { spawnUnits = value; }
            }

            public MeleeUnit Swordsman
            {
                get { return swordsman; }

                set { swordsman = value; }
            }

            public RangedUnit Archer
            {
                get { return archer; }

                set { archer = value; }
            }

            public GameEngine(Form1 form1,Map map)
            {
                this.map = map;
                this.form1 = form1;
                swordsman = new MeleeUnit(map, form1);
                archer = new RangedUnit();
                resources = new ResourceBuilding(form1);
                spawnUnits = new FactoryBuilding(form1);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        int timeMs, timeSec, timeMin;
        bool isActive;
        public Form1[] AllObjects = new Form1[0];
        GameEngine MainEngine;
        Map map;
        public static BinaryFormatter Bformatter { get; set; }
        public static FileStream FStream { get; set; }

        //Function to draw new time on labels
        //https://www.youtube.com/watch?v=lp9cJJUDUsk&t=1s
        public void DrawTime()
        {
            lblMill.Text = String.Format("{0:00}", timeMs);
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMin.Text = String.Format("{0:00}", timeMin);           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainEngine = new GameEngine(this, map);
            //Setting default times
            timeMs = 0;
            timeSec = 0;
            timeMin = 0;

            //Instances of the classes
            Unit meleeSoldier = new MeleeUnit(map, this);
            meleeSoldier.XPos = 0;
            meleeSoldier.YPos = 0;
            meleeSoldier.Health = 100;
            meleeSoldier.Speed = 1;
            meleeSoldier.Attack = 20;
            meleeSoldier.AttackRange = 1;

            Unit rangeSoldier = new RangedUnit();
            rangeSoldier.XPos = 0;
            rangeSoldier.YPos = 0;
            rangeSoldier.Health = 60;
            rangeSoldier.Speed = 1;
            rangeSoldier.Attack = 15;
            rangeSoldier.AttackRange = 4;

            //Draws a clean map
            Map gameMap = new Map(gridMap, this);
            gameMap.newMap();
        }

        private void btnBuildingR(object sender, EventArgs e)
        {
            unitLbl.Text = "This building accumulates War Resources!";
        }

        private void btnBuildingF(object sender, EventArgs e)
        {
            unitLbl.Text = "This building produces units!";
        }

        private void btnEmpty(object sender, EventArgs e)
        {
            unitLbl.Text = "Empty space!";
        }

        private void btnMelee(object sender, EventArgs e)
        {
            MeleeUnit mu= new MeleeUnit(map,this);
            unitLbl.Text = mu.ToString();
        }

        private void btnRange(object sender, EventArgs e)
        {
            RangedUnit ru = new RangedUnit();
            unitLbl.Text = ru.ToString();
        }

        private void btnDeposit(object sender, EventArgs e)
        {
            unitLbl.Text = "This is a mining hotspot. It can produce iron and coal!";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        //Button asks user to reset, then produces a new game with a fresh timer or the same timer.
        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to restart?", "Reset The Game", MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.OK)
            {
                DialogResult result2 = MessageBox.Show("Do you want to reset the timer and the coins?", "Reset the timer", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    isActive = false;
                    timeMs = 0;
                    timeSec = 0;
                    timeMin = 0;
                    unitLbl.Text = "";
                    MainEngine.Resources.I = 1;
                    MainEngine.Resources.J = 1;
                    MainEngine.Resources.Coal = 0;
                    MainEngine.Resources.Steel = 0;
                    MainEngine.Resources.Iron = 0;
                    resLabel.Text = "00";
                    resLabel2.Text = "00";
                    coalLabel.Text = "00";
                    coalLabel2.Text = "00";
                    ironLabel.Text = "00";
                    ironLabel2.Text = "00";
                    steelLabel.Text = "00";
                    steelLabel2.Text = "00";

                    //Draws a new map when reset
                    Map gameMap = new Map(gridMap, this);
                    gameMap.newMap();
                }
                else
                {
                    unitLbl.Text = "";
                    //Draws a new map when reset
                    Map gameMap = new Map(gridMap, this);
                    gameMap.newMap();
                }
            }
        }

        private void teamMeleeBtn_Click(object sender, EventArgs e)
        {
            MeleeUnit mu = new MeleeUnit(map, this);
            unitLbl.Text = mu.ToString();
        }

        private void teamRangeBtn_Click(object sender, EventArgs e)
        {
            RangedUnit ru = new RangedUnit();
            unitLbl.Text = ru.ToString();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("You are about to load your previous save!", "Load Game", MessageBoxButtons.OKCancel);
            //if (result1 == DialogResult.OK)
            //{
            //    Map readSave = new Map(gridMap, this);
            //    readSave.Read();
            //}
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to save your game?", "Save Game", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                //Form1[] AllObjects = MeleeUnit.Save(MainEngine.Swordsman.FileName);
                //Form1[] AllObjects = RangedUnit.Save(MainEngine.Archer.FileName);
                //Form1[] AllObjects = ResourceBuilding.Save(MainEngine.Resources.FileName);
                //Form1[] AllObjects = FactoryBuilding.Save(MainEngine.SpawnUnits.FileName);

                //MainEngine.Swordsman.Save(FileName, );
                //MainEngine.Archer.Save();
                //MainEngine.Resources.Save();
                //MainEngine.SpawnUnits.Save();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Making a correct timer.
            if (isActive)
            {
                timeMs++;

                if (timeMs >= 100)
                {
                    timeSec++;
                    timeMs = 0;
                    MainEngine.Resources.GenerateResources();
                    MainEngine.Resources.GenerateCoal();
                    MainEngine.Resources.GenerateIron();
                    MainEngine.Resources.GenerateSteel();
                    MainEngine.Swordsman.closestUnit();
                    //MainEngine.SpawnUnits.spawnNewUnits();

                    if (timeSec >=60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
                
            }
            DrawTime();
        }

        private void lblMill_Click(object sender, EventArgs e)
        {

        }

    }
}