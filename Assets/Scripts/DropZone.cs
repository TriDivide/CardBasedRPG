using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {


    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop to " + gameObject.name);
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();

        if (d != null) {
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
