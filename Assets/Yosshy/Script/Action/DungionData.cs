using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungionData
{
    public bool GameState{ get { return InGame; } }
    bool InGame = false;

    public void Begin()
    {
        InGame = true;
    }

    public void Finish()
    {
        InGame = false;
    }
}
