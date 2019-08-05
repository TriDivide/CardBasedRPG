using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : DropZone {

    private void Start() {
        this.cardTypeAccepted = Draggable.CardType.Ability;
    }
}
