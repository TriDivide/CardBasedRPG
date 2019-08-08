using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U {

    public static int RandomNumber(int min, int max) {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }
}
