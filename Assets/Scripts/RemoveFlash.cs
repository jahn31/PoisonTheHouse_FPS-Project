﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFlash : MonoBehaviour
{
    public bool turnoff = false;

    void Update()
    {
            StartCoroutine(TurnOff());
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(0.2f);
        this.gameObject.SetActive(false);
    }


}
