using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
  [SerializeField] private GameObject cardback;
  [SerializeField] private SceneController controller;
  private int _id;
  public int id
  { 
    get { return _id; }
  }
  public void SetCard(int id, Sprite image)
  {                                  //SetCard() takes the sprite image as a parameter and can be called on by other scripts
    _id=id;             //the get function runs when you try to access the sprite _id, so it gets the sprite and stores the _id
    GetComponent<SpriteRenderer>().sprite=image;
  }
  public void OnMouseDown()
  { 
    if (cardback.activeSelf && controller.canReveal)    //check to see if cardback is active and if so, deactivate when clicked
    {                                                   //only two cards are revealed at a time
      cardback.SetActive(false);
      controller.CardRevealed(this);      //notify controller when card is revealed
    }
  }
  public void Unreveal()
  {
    cardback.SetActive(true);
  }
}
