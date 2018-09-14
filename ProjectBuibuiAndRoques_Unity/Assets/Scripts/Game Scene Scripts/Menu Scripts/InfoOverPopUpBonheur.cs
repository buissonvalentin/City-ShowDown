﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ProjectRoquesAndBuiBui;

public class InfoOverPopUpBonheur : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Transform popUp;

    Ville ville;
    // Use this for initialization
    void Start()
    {
        ville = FindObjectOfType<GameManager>().ville;
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        popUp.gameObject.SetActive(true);
        (popUp.transform as RectTransform).position  = new Vector2((popUp.transform as RectTransform).position.x, (transform as RectTransform).position.y);
        popUp.Find("Text").GetComponent<Text>().text = "Bonheur Aisee : " + ville.BonheurAisee;
        popUp.Find("Text1").GetComponent<Text>().text = "Bonheur Moyenne : " + ville.BonheurMoyenne;
        popUp.Find("Text2").GetComponent<Text>().text = "Bonheur Ouvriere : " + ville.BonheurOuvriere;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        popUp.gameObject.SetActive(false);
    }
}