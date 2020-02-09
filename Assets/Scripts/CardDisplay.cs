using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardDisplay : MonoBehaviour
{
    public Card card;
    

    [Header("Text Element")]
    public Text nameText;
    public Text discriptionText, costText, attackText, healthText;
    [Header("Image Element")]
    public Image icon;
    public Image background;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;
        discriptionText.text = card.discription;
        costText.text = card.cost.ToString();
        attackText.text = card.damage.ToString();
        healthText.text = card.health.ToString();
        icon.sprite = card.icon;
        background.sprite = card.background;
    }

    
}
