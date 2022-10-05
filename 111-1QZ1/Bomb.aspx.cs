using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ1
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // char2D array 10*10
            char[,] ia_Map = new char[10, 10];

            // int array 10
            int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44,
                                        62, 74, 75, 87, 90 };

            // set bomb
            for (int i = 0;  i < ia_MIndex.Length; i++)
            {
                int x = ia_MIndex[i] / 10;
                int y = ia_MIndex[i] % 10;
                ia_Map[x, y] = '*'; 
            }


            // Reseponse
            for (int i_x = 0; i_x < ia_Map.GetLength(0); i_x++)
            {
                for (int i_y = 0; i_y < ia_Map.GetLength(1); i_y++)
                {
                    if (ia_Map[i_x, i_y] == '\0')
                    {
                        ia_Map[i_x, i_y] = 'x';
                    }
                    Response.Write(ia_Map[i_x, i_y] + " ");
                }
                Response.Write("<br>");
            }
        }
    }
}