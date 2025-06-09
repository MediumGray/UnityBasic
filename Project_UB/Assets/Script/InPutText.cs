using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

 

public class InPutText : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;
    [SerializeField] TMP_InputField input_Text;

    public void OnClickInputText()
    {
        Txt_Text.text = input_Text.text;
    }

}
