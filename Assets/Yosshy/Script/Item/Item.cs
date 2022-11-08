using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] ItemNameEnum ItemName;
    public enum ItemNameEnum
    {
        Tree,
        Stone
    }


}

