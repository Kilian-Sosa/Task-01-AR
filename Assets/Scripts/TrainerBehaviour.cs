using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrainerBehaviour : MonoBehaviour {

    public void ActivateObj() {
        gameObject.SetActive(true);
    }

    public void DeactivateObj() {
        gameObject.SetActive(false);
    }
}
