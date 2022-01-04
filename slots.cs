using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    
    public const int slot_length = 4;
    private int[,] slot = new int [slot_length,slot_length];
    private string[] slot_options = new string[] {"PAtk", "PDef", "EAtk", "HEAL", "COIN", "NONE"};
   
    public Slots()
    {
        Create_slot();
    }

    public void Create_slot()
    {
        for (int row = 0; row < slot_length; row++)
        {
            for (int column = 0; column < slot_length; column++)
            {
                slot[row,column] = 5;
            }
        }
    }

    public void Spin_slot()
    {
        
        for (int row = 0; row < slot_length; row++)
        {
            for (int column = 0; column < slot_length; column++)
            {
                int random_num = Random.Range(0,6);
                slot[row,column] = random_num;
            }
        }
    }

    public void Display_reel()
    {
        string slot_option;
        Debug.Log("**********");
        for (int row = 0; row < slot_length; row++)
        {
            string display_line = "";
             
            for (int column = 0; column < slot_length; column++)
            {   
                slot_option = slot_options[slot[row, column]];
                display_line += slot_option + " ";   
                //string.Concat(display_line,slot_option + " ");
            }
            //string.Concat(display_line,"\n");
            Debug.Log(display_line + "\n");
        }
        Check_lines();
        Debug.Log("**********");
    }

    public void Check_lines()
    {
        int slot_position_0;
        bool same_symbol = true; 
        string debugging_string="";
        int slot_row = 0;
        /*
        for each row in the slot, get the first position in each row.
        for each column in each row, check if each position matches the first position
        */
        for(int row = 0; row < slot_length; row++)
        {
            slot_position_0 = slot[row,0];

            int matches = 0;
            debugging_string += "Checking row " + row + "\n";
            for(int column = 1; same_symbol = true && column < slot_length ; column++)
            {
                
                if(slot_position_0 != slot[row, column])
                {
                    same_symbol = false;
                    debugging_string += "position 0 doesn't match postion in row/column " + row + "/" + column + ". Moving to next line.\n";
                }
                else
                {
                    matches++;
                }
                slot_column++;
            }
            same_symbol =true; 
            debugging_string += "Row " + row + " has " + matches + " matches.";
            Debug.Log(debugging_string);
        }

    }

    public void Player_Skill_1()
    {

    }
}
