using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiscardZone : DropZone {


    private void Start() {
        this.cardTypeAccepted = null;
    }

    public new void OnDrop(PointerEventData eventData) {
        Card d = eventData.pointerDrag.GetComponent<Card>();

        bool snap = false;
        if (d != null) {
            if (cardTypeAccepted == null) {
                snap = true;
            } else {
                snap = (cardTypeAccepted == d.cardType);
            }
        }

        if (snap) {
            d.parentToReturn = this.transform;
        }

        d.transform.position = this.transform.position;
        Quaternion rotation = d.transform.rotation;
        d.transform.Rotate(rotation.x, rotation.y, U.RandomNumber(-20, 20));
    }
}