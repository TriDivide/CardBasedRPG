using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct CardData {

    public enum CardType {
        Ability = 0,
        Augment = 1,
        Equipment = 2,
        Adventurer = 3
    };

    public enum CardClass {
        Fighter = 0,
        Hunter = 1,
        Mage = 2
    }


    public string cardName { get; private set; }            // The name of the card
    public string cardDescription { get; private set; }     // The flavour text on the card

    public string cardImage { get; private set; }           // The card art used to show the card, would likely be downloaded from firebase

    public CardType type { get; private set; }              // What type of card is this? and Ability, Equipment, augemnt or adventurer.
    public CardClass cardClass { get; private set; }        // What class can play this card?

    public int cost { get; private set; }                   // What is the cost of this card?


    public int? turnsToResolve;                             // How long does this card last on the field for, be it damage over time or power build up?
    public int? damageDealt;                                // How much damage, if any, can this card do?
    public int? stamina;                                    // How much damage, if any, can this card withstand?


}
