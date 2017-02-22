using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Nicholas Mercadante
 * Team 12 ("The B(ee) Team")
 * attributes and functions for a "piece" of the map
 */
namespace HomeSweetHellMapEditorLibrary
{
    class MapPiece
    {
        //attributes for map piece
        public Texture texture;
        public int sourceX;
        public int sourceY;
        public int posX;
        public int posY;
        public bool isVisible;
        public bool isPath;
        public bool isStart;
        public bool isEnd;

    }
}
