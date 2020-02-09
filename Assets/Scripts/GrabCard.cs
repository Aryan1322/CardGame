using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GrabCard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public bool hover;
    public bool drag,placed;
    public CardDisplay cardDisplay;



    public void Update()
    {
        if(drag)
        this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        // hold the left click
        //throw new System.NotImplementedException();
        
        drag = true; 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        hover = true;
        
        cardDisplay.background.color = new Color(0.5882353f, 0.5882353f, 0.7f);
        this.transform.localScale = new Vector3(1.1f, 1.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        //throw new System.NotImplementedException();
        hover = false;
        cardDisplay.background.color = new Color(0.5882353f, 0.5882353f, 0.5882353f);

        this.transform.localScale = new Vector3(1f, 1f);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //not holding left click for draging 
        //throw new System.NotImplementedException();
        drag = false;
        placed = true;
        //place card

    }
    
}
