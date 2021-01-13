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
        //NOTE IMPORTANT METHODS: SetActive(false) and activeInHierarchy()
        //First check if right heart is active, if it is then remove it


        //Second, check if the middle heart is active, if it is then remove it


        //Third, check if the left heart is active, if it is then remove it


        //Do not edit below this line
        return true;
    }

}
