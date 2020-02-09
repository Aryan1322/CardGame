using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardPlaceOnWorld : MonoBehaviour
{
    public Card card;
    public bool cardPlaced;
    public GameObject cardObject;


    [Header("Text Element")]
    public Text nameText;
    public Text discriptionText, costText, attackText, healthText;
    [Header("Image Element")]
    public Image icon;
    public Image background;

    // Start is called before the first frame update
    private void Update()
    {
        nameText.text = card.name;
        discriptionText.text = card.discription;
        costText.text = card.cost.ToString();
        attackText.text = card.damage.ToString();
        healthText.text = card.health.ToString();
        icon.sprite = card.icon;
        background.sprite = card.background;
        if(cardPlaced)
        {
            cardObject.SetActive(true);
            //card bacame that card



        }

    }
    
    

}
