using UnityEngine;
using System.Collections;

public class baseWeapon : baseItems {
	public enum WeaponTypes{
		ShortSword,
		LongSword,
		Polearm,
		Pickaxe,
		Poleaxe,
		Spear,
		Axe,
		Longbow,
		Shortbow,
		Compositebow,
		Crossbows,
		Sling,
		Staff,
		Club,
		Mace,
		Maul,
		Dagger,
		Knife,
		Shield,
		Sickle,
		Scythe,
		Javelin,
		Fan,
		Hand,//Katar,knuckles
		Throwingblades,
		Throwingaxes,
		Blowgun,
		Chain,
		Sectional,//nunchaku yms.
		Whip
	}
	public WeaponTypes weaponType { get; set; }
	public int spellEffectID { get; set; }

}
