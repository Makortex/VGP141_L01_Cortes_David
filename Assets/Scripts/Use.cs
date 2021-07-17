using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Use : MonoBehaviour
{
    Player player;

    private void Start()
    {
    }

    public void Faster()
    {
        gameObject.GetComponent<Player>().Fast();
    }
    public void Jumper()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        gameObject.GetComponent<Player>().Jump();
    }
}
