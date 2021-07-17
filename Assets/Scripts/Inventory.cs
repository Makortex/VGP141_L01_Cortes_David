using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;


public class Inventory : MonoBehaviour
{
    Player player;
    Pickup pickup;

    public bool[] isFull;
    public GameObject[] slots;
    public LinkedList<GameObject> items = new LinkedList<GameObject>();

    void Update()
    {
        //items.AddLast(slots[0]);
        //items.AddLast(slots[1]);
    }
}