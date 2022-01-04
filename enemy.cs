using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character_stats
{
    private double base_exp;

    public double BASE_EXP
    {
        get
        {
            return base_exp;
        }
        set
        {
            base_exp = value;
        }
    }

    public double DROP_EXP
    {
        get
        {
            return base_exp * System.Math.Exp(LVL);
        }
    }
}
