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
        //�{�^�����I�����ꂽ��ԂɂȂ�
        button.Select();
    }
}

