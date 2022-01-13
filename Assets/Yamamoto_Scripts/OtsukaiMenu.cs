using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ItemStatus
{
    public Sprite productImage;
    public float price;
    public Sprite customerImage;
}

public class OtsukaiMenu : MonoBehaviour
{
    public List<ItemStatus> item;
}