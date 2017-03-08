using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeSweetHellMapEditor
{
    public partial class Form1 : Form
    {
        //attributes for form-specific functions
        private int tileType;
        private int[,] tiles;
        private PictureBox[,] mapGrid;
        private Image backgroundPic;
        private Image towerPlacablePic;
        private Image enemyPathPic;
        //for file reading/writing
        private StreamWriter saveMap;
        private StreamReader loadMap;
        private Random rng = new Random();
        private string pathName;


        public Form1()
        {
            InitializeComponent();
            backgroundPic = null;
            towerPlacablePic = null;
            enemyPathPic = null;
            tileType = 0;
            tiles = new int[10, 15];
        }

        //getters and setters for attributes that need them
        public Image BackgroundPic
        {
            get { return backgroundPic; }
            set
            {
                backgroundPic = value;
            }
        }
        public Image TowerPlacablePic
        {
            get { return towerPlacablePic; }
            set
            {
                towerPlacablePic = value;
            }
        }
        public Image EnemyPathPic
        {
            get { return enemyPathPic; }
            set
            {
                enemyPathPic = value;
            }
        }
        public PictureBox[,] MapGrid
        {
            get { return mapGrid; }
            set
            {
                mapGrid = value;
            }
        }
        public int TileType
        {
            get { return tileType; }
            set
            {
                tileType = value;
            }
        }
        public int[,] Tiles
        {
            get { return tiles; }
            set
            {
                tiles = value;
            }
        }
        //IGNORE
        private void submitButton_Click(object sender, EventArgs e)
        {

        }
        //IGNORE
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //IGNORE
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        //browse files for a picture to set
        private void pictureSelectionButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog pictureSelectionDialogue = new OpenFileDialog();
            DialogResult result = pictureSelectionDialogue.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //picFile = pictureSelectionDialogue.OpenFile.ToString();
            }
        }

        private void tileTypeSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void generateMapButton_Click(object sender, EventArgs e)
        {
            
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            mapButton.Visible = false;
            mapGrid = new PictureBox[10, 15];
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 15; column++)
                {
                    mapGrid[row, column] = new PictureBox();
                    mapGrid[row, column].Location = new Point(column * 50 + 12, row * 50 + 12);
                    mapGrid[row, column].Width = 50;
                    mapGrid[row, column].Height = 50;
                    mapGrid[row, column].Visible = true;
                    mapGrid[row, column].BorderStyle = BorderStyle.FixedSingle;
                    mapGrid[row, column].BringToFront();
                    mapGrid[row, column].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
                    this.Controls.Add(mapGrid[row, column]);
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox tile = (PictureBox)sender;
            int tileRow = (tile.Location.Y - 12) / 50;
            int tileColumn = (tile.Location.X - 12) / 50;
            //Console.WriteLine(tile.Location.X);
            //Console.WriteLine(tile.Location.Y);
            if(tileTypeSelectionBox.SelectedItem == null)
            {

            }
            else
            {
                switch (tileTypeSelectionBox.SelectedItem.ToString())
                {
                    case "Background":
                        tileType = 0;
                        break;
                    case "Tower Placable":
                        tileType = 1;
                        break;
                    case "Enemy Path Start":
                        tileType = 2;
                        break;
                    case "Enemy Path Step 1":
                        tileType = 3;
                        break;
                    case "Enemy Path Step 2":
                        tileType = 4;
                        break;
                    case "Enemy Path Step 3":
                        tileType = 5;
                        break;
                    case "Enemy Path End":
                        tileType = 6;
                        break;
                    default:
                        tileType = 0;
                        break;
                }
                tiles[tileRow, tileColumn] = tileType;
                switch (tileType)
                {
                    case 0:
                        mapGrid[tileRow, tileColumn].BackColor = Color.Gray;
                        break;
                    case 1:
                        mapGrid[tileRow, tileColumn].BackColor = Color.DarkRed;
                        break;
                    case 2:
                        mapGrid[tileRow, tileColumn].BackColor = Color.Tan;
                        break;
                    case 3:
                        mapGrid[tileRow, tileColumn].BackColor = Color.Tan;
                        break;
                    case 4:
                        mapGrid[tileRow, tileColumn].BackColor = Color.Tan;
                        break;
                    case 5:
                        mapGrid[tileRow, tileColumn].BackColor = Color.Tan;
                        break;
                    case 6:
                        mapGrid[tileRow, tileColumn].BackColor = Color.Tan;
                        break;
                    default:
                        break;
                }
            }
        }
        //save the array of tiles
        private void saveButton_Click(object sender, EventArgs e)
        {
            //pathName = Directory.GetCurrentDirectory();
            if(fileNameTextBox != null)
            {
                saveMap = new StreamWriter(fileNameTextBox.Text + ".txt");
            }
            else
            {
                saveMap = new StreamWriter(rng.Next() + ".txt");
            }
            for(int row = 0; row < tiles.GetLength(0); row++)
            {
                for(int column = 0; column < tiles.GetLength(1); column++)
                {
                    saveMap.Write(tiles[row, column] + " ");
                }
                saveMap.WriteLine("\n");
            }
            saveMap.Close();
        }
        //load an array of tiles
        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog mapFileSelection = new OpenFileDialog();
            DialogResult result = mapFileSelection.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string mapFile = mapFileSelection.FileName;
                loadMap = new StreamReader(mapFile);
                string line;
                int tileRow = 0;
                int tileColumn = 0;
                while((line = loadMap.ReadLine()) != null)
                {
                    string[] rowTiles = line.Split(' ');
                    foreach(string tile in rowTiles)
                    {
                        int test = 0;
                        int.TryParse(tile, out test);
                        tiles[tileRow, tileColumn] = test;
                        tileColumn++;
                    }
                    tileRow++;
                }
                mapButton.Visible = false;
                mapGrid = new PictureBox[10, 15];
                for (int row = 0; row < 10; row++)
                {
                    for (int column = 0; column < 15; column++)
                    {
                        mapGrid[row, column] = new PictureBox();
                        mapGrid[row, column].Location = new Point(column * 50 + 12, row * 50 + 12);
                        mapGrid[row, column].Width = 50;
                        mapGrid[row, column].Height = 50;
                        mapGrid[row, column].Visible = true;
                        mapGrid[row, column].BorderStyle = BorderStyle.FixedSingle;
                        mapGrid[row, column].BringToFront();
                        mapGrid[row, column].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
                        this.Controls.Add(mapGrid[row, column]);
                        switch (tiles[row, column])
                        {
                            case 0:
                                mapGrid[row, column].BackColor = Color.Gray;
                                break;
                            case 1:
                                mapGrid[row, column].BackColor = Color.DarkRed;
                                break;
                            case 2:
                                mapGrid[row, column].BackColor = Color.Tan;
                                break;
                            case 3:
                                mapGrid[row, column].BackColor = Color.Tan;
                                break;
                            case 4:
                                mapGrid[row, column].BackColor = Color.Tan;
                                break;
                            case 5:
                                mapGrid[row, column].BackColor = Color.Tan;
                                break;
                            case 6:
                                mapGrid[row, column].BackColor = Color.Tan;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
