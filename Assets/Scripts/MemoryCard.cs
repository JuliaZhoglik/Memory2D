using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private SceneController controller;
    [SerializeField] private GameObject cardBack;

    public int _id;

    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal) // объект активен, виден
        {
            cardBack.SetActive(false); // делаем объект не активным, невидимым
            controller.CardRevealed(this);
        }
    }
    
    public int id {
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

}
