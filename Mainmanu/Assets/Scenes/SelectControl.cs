using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectControl : MonoBehaviour
// Start is called before the first frame update
{
    Button button;

    void Start()
    {
        button = GameObject.Find("Canvas/MainMenu/StageSelect/ButtonSummary/Button 1(Legacy)").GetComponent<Button>();
        //ƒ{ƒ^ƒ“‚ª‘I‘ğ‚³‚ê‚½ó‘Ô‚É‚È‚é
        button.Select();
    }
}

