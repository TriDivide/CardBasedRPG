using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public Draggable.CardType? cardTypeAccepted = null;


    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop to " + gameObject.name);
        Card d = eventData.pointerDrag.GetComponent<Card>();

        bool snap = false;
        if (d != null) {
            if (cardTypeAccepted == null) {
                snap = true;
            }
            else {
                snap = (cardTypeAccepted == d.cardType);
            }
        }

        if (snap) {
            d.parentToReturn = this.transform;
        }
    }

    public void OnPointerEnter(PointerEventData eventData) {
      //  Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData) {
      //  Debug.Log("OnPointerExit");

        

    }
}
