using UnityEngine;
using System.Collections;

public class baseItems{
	public string ItemName { get; set; }
	public string ItemDescription { get; set; }
	public int ItemID { get; set; }
	public enum ItemTypes{
		EQUIPMENT,
		WEAPON,
		SCROLL,
		POTION,
		CHEST
	}

}
