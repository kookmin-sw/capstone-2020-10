﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldItems : MonoBehaviour
{
   public Item item;
   public SpriteRenderer image;

   public void SetItem(Item _item) {
      if (_item != null) {
         item = _item;
         image.sprite = item.itemImage;
      }
   }

	public Item GetItem() {
		return item;
   }
   public void DestroyItem() {
   	Destroy(gameObject);
   }
}
