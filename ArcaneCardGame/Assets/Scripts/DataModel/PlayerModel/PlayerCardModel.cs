using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CardModel {

    private static readonly CardModel instance = new CardModel();


    static CardModel() {

    }

    private CardModel() {

    }

    public static CardModel Instance {
        get { return instance; }
    }
}
