using System;
using System.Collections.Generic;
using UnityEngine;

public class DestinationConroller : MonoBehaviour
{
	[SerializeField] int m_population;
	List<DateTime> m_DateTimes;
	List<int> m_Intervals;

	void Awake ()
	{
		m_population = 0;
		m_DateTimes = new List<DateTime> ();
		m_Intervals = new List<int> ();
	}

	void OnTriggerEnter (Collider other)
	{
		var now = DateTime.Now;
		m_DateTimes.Add (now);

		var size = m_DateTimes.Count;
		if (size > 0)
		{
			var ts = now - m_DateTimes [size - 1];
			m_Intervals.Add (ts.Seconds);
		}

		--m_population;
		Destroy (other.gameObject);
	}

	public void AddPopulation ()
	{
		++m_population;
	}
}
