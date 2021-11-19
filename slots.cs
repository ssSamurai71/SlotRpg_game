using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slots : MonoBehaviour
{
    private string[,,,,] slot = new array[5,5,5,5,5];
    private string[] slot_options = new array[] {'PAtk', 'PDef', 'EAtk', 'HEAL', 'COIN', 'NONE'};
    public Random rand = new Random();

    public void create_slot()
    {
        for (int row = 0; row < slot.length; row++)
        {
            for (int column = 0; i < slot[row].length; i++)
            {
                slot[row,column] = slot_options[5];
            }
        }
    }

    public void spin_slot()
    {
        for (int row = 0; row < slot.length; row++)
        {
            for (int column = 0; i < slot[row].length; i++)
            {
                int random_num = rand.Next(0,5);
                slot[row,column] = slot_options[5];
            }
        }
    }

    public void display_reel()
    {
        for (int row = 0; row < slot.length; row++)
        {
            public string display_line = "";
            for (int column = 0; i < slot[row].length; i++)
            {
                string.Concat(display_line,slot[row,column];)
                
            }
        }
    }
}
