using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject leftHeart;
    [SerializeField] private GameObject middleHeart;
    [SerializeField] private GameObject rightHeart;

    public bool DeductHealth()
    {
        if (rightHeart.activeInHierarchy)
        {
            rightHeart.SetActive(false);
            return false;
        }
        else if (middleHeart.activeInHierarchy)
        {
            middleHeart.SetActive(false);
            return false;
        }

        leftHeart.SetActive(false);
        return true;

    }

}
