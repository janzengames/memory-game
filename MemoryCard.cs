using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
  [SerializeField] private GameObject cardback;
  [SerializeField private SceneController controller;
  private int _id;
  public int id
  { 
    get { return _id; }
  }
  public void SetCard(int id, Sprite image)
  { 
    _id=id;
    GetComponent<SpriteRenderer>().sprite=image;
  }
  public void OnMouseDown()
  { 
    if (cardback.activeSelf)
    {
      card.SetActive(false);
    }
  }
  public void Unreveal()
  {
    card.SetActive(true);
  }
}
