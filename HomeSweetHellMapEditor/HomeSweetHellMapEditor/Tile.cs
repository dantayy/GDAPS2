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
/*
 * Nicholas Mercadante
 * Section 2(?)
 * Generic tile class
 */
namespace HomeSweetHellMapEditor
{
    class Tile
    {
        //attributes for tiles
        private int tileType;
        private int tileRow;
        private int tileColumn;
        private Image tilePic;

        //properties for attributes
        public int TileType
        {
            get { return tileType; }
            set
            {
                tileType = value;
            }
        }
        public int TileRow
        {
            get { return tileRow; }
            set
            {
                tileRow = value;
            }
        }
        public int TileColumn
        {
            get { return tileColumn; }
            set
            {
                tileColumn = value;
            }
        }
        public Image TilePic
        {
            get { return tilePic; }
            set
            {
                tilePic = value;
            }
        }

        //default constructor for a tile
        public Tile()
        {
            tileType = 0;
            tileRow = 0;
            tileColumn = 0;
            tilePic = null;
        }

        //parameterized constructor for a tile
        public Tile(int type, int posX, int posY, Image pic)
        {
            tileType = type;
            tileRow = posX;
            tileColumn = posY;
            tilePic = pic;
        }
    }
}
