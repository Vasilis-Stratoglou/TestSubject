using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour {

    public InputField nameField;
    public GameObject popup;
    public Text Toast;

    // Use this for initialization
    void Start() {
        hidePopupPanel();
    }

    // Update is called once per frame
    void Update() {

    }

    public void showPopupPanel() {
        popup.SetActive(true);
    }

    public void hidePopupPanel()
    {
        popup.SetActive(false);
    }

    public void say() {
        Toast.text = "Hello " + nameField.text;
        showPopupPanel();
    }
}
