using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card",menuName ="Card/1")]
public class Card : ScriptableObject
{
    public new string name;
    public string discription;
    public int cost, damage, health;
    public Sprite icon, background;
}
