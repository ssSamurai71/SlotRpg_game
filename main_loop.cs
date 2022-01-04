using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_loop: MonoBehaviour
{
    Slots slot_machine = new Slots();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                
    }

    public void Spin_reel()
    {
        slot_machine.Spin_slot();
    }

    public void Show_reel()
    {
        slot_machine.Display_reel();
    }
}
