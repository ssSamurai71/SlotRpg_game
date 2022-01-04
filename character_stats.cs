using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_stats : MonoBehaviour
{
    private double hp;
    private double current_hp;
    private double def;
    private double atk;
    private double level;

    public double HP
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }

    public double CURRENT_HP
    {
        get
        {
            return current_hp;
        }
        set
        {
            current_hp = value;
        }
    }

    public double DEF
    {
        get
        {
            return def;
        }
        set
        {
            def = value;
        }
    }

    public double ATK
    {
        get
        {
            return atk;
        }
        set
        {
            atk = value;
        }
    }

    public double LVL
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
        }
    }
}
