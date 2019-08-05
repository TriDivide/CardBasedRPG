using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public Transform parentToReturn = null;
    public enum CardType {  Ability, Augment, Equipment };

    public void OnBeginDrag(PointerEventData eventData) {
       // Debug.Log("BeginDrag");

        this.parentToReturn = this.transform.parent;
        
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
      //  Debug.Log("Dragging");
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) {

        this.transform.SetParent(parentToReturn);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
     //   Debug.Log("DragEnd");
    }

}
