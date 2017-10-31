using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class of Characters and Mobs
public class Biology
{
	// health point
	public float maxHp;
	public float hp;

	// magic point
	public float maxMp;
	public float mp;

	// tiredness point
	public float tp;

	// constructors
	public Biology ()
	{
		hp = 100.0f;
		mp = 100.0f;
		tp = 0.0f;
	}

	public Biology (float initHp, float initMp, float initTp)
	{
		hp = initHp;
		mp = initMp;
		tp = initTp;
	}

	// common methods
	public bool IsAlive ()
	{
		return (hp > 0);
	}

	public bool TakeDamage (float damage)
	{
		if (hp <= 0) 
		{
			return false;
		}
		hp -= damage;
		return true;
	}

	public bool ConsumeMp (float consumingMp)
	{
		if (mp <= 0 || mp < consumingMp) 
		{
			return false;
		}
		mp -= consumingMp;
		return true;
	}

	public bool IncreaseTp (float increasingTp)
	{
		// TODO: need maximum limit of tp?
		tp += increasingTp;
		return true;
	}
}
