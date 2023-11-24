using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Function : MonoBehaviour {
    public string text = "Bienvenido a FitBuddy, una aplicación dedicada a impulsar tu rutina de ejercicio! Descubre rutinas personalizadas, retos emocionantes y consejos de salud que te guiarán hacia una vida más activa. ¡Prepárate para transformar tu bienestar, un paso a la vez! #ActívateConNosotros";
    //public TextMeshPro textBox; //Falla
    public TMP_Text textBox;
    public void ActivateText() {
        StartCoroutine(ShowText());
        textBox.GetComponent<AudioSource>().enabled = true;
    }

    public void DesactivateText() {
        StopCoroutine("ShowText");
        textBox.text = ""; //limpiar 
        textBox.GetComponent<AudioSource>().enabled = false;
    }
    IEnumerator ShowText() {
        for (int i = 0; i < text.Length; i++) {
            textBox.text += text[i];
            yield return new
           WaitForSeconds(0.02f);
        }
    }
}
