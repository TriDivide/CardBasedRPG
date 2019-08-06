using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public Transform parentToReturn = null;
    public enum CardType {
        Ability = 0,
        Augment = 1,
        Equipment = 2,
        Adventurer = 3
    };

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
