using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverCarro : MonoBehaviour, IPointerExitHandler {
    public bool pulsado;

    public void OnPointerExit(PointerEventData eventData)
    {
        pulsado = true;
    }
}
