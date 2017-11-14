using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell
{
	bool Damage (Biology target, float hp) 
	{
		return target.TakeDamage(hp);
	}

	bool Heal (Biology target, float healPoint)
	{
		return target.TakeHeal(healPoint);
	}
}
