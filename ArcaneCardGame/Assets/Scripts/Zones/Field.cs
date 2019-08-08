using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : DropZone {

    [SerializeField]
    private CardData.CardType acceptedCard = CardData.CardType.Ability;

    private void Start() {
        this.cardTypeAccepted = acceptedCard;
    }
}
