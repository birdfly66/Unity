using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainText : MonoBehaviour
{
    private void Start()
    {
        UIManager.Instance.showPanel<BeginPanel>();
    }
}
