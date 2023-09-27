using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabInputField : MonoBehaviour
{
    public InputField[] inputFields;           //Tab 키로 이동할 InputField 배열

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            InputField currentInputField = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<InputField>();

            if(currentInputField != null)
            {
                int currentIndex = System.Array.IndexOf(inputFields, currentInputField);
                int nextIndex = (currentIndex + 1) % inputFields.Length;

                inputFields[nextIndex].Select();
                inputFields[nextIndex].ActivateInputField();
            }
        }
    }
}
