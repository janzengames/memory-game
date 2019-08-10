using Systems.Collections;
using Systems.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
  [SerializeField] private GameObject targetObject;   //targetobject gets informed about clicks
  [SerializeField] private string targetMessage;
  public Color highlightColor = Color.cyan;
  
  public void OnMouseEnter()        //tints the button when hovered over 
  {
    SpriteRenderer sprite = GetComponent<SpriteRenderer>();
    if (sprite!=null)
    {
      sprite.color=highlightColor;
    }
  }
  public void OnMouseExit()
  {
    SpriteRenderer sprite = GetComponent<SpriteRenderer>();
    if(sprite!=null)
    {
      sprite.color=Color.white;
    }
  }
  public void OnMouseDown()       //button pops when clicked 
  {
    transform.localScale = new Vector3(1.1f,1.1f,1.1f);
  }
  public void OnMouseUp()       //after button is clicked it sends a message 
  {
    transform.localScale=Vector3.one;
    if (targetObject !=null)
    {
      targetObject.SendMessage(targetMessage)
    }
}   
