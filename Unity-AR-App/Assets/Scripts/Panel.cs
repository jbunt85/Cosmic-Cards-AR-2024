using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    public GameObject panel2;
    public void openShow()
        {
            if(panel2 != null)
            {
                    bool IsActive=panel2.activeSelf;
                    panel2.SetActive(!IsActive);
            }
        }
}
