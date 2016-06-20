using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class DestinationConroller : MonoBehaviour
{
	[SerializeField] int m_population;
	List<DateTime> m_DateTimes;
	List<double> m_Intervals;

	void Awake ()
	{
		m_population = 0;
		m_DateTimes = new List<DateTime> ();
		m_Intervals = new List<double> ();
	}

	void OnTriggerEnter (Collider other)
	{
		var now = DateTime.Now;
		m_DateTimes.Add (now);

		var size = m_DateTimes.Count;
		if (size > 1)
		{
			var ts = now - m_DateTimes [size - 2];
			m_Intervals.Add (ts.TotalSeconds);
		}

		--m_population;
		Destroy (other.gameObject);

		if (m_population <= 0)
		{
			WriteDateTimes ();
			WriteIntervals ();
			Destroy (gameObject);
		}
	}

	public void AddPopulation ()
	{
		++m_population;
	}

	void WriteDateTimes ()
	{
		var sw = new StreamWriter ("Assets/txt/result.txt", false);

		foreach (var dt in m_DateTimes)
		{
			sw.WriteLine (dt.ToString("HH:mm:ss"));
		}

		sw.Flush ();
		sw.Close ();
	}

	void WriteIntervals ()
	{
		var sw = new StreamWriter ("Assets/txt/intervals.txt", false);

		foreach (var interval in m_Intervals) {
			sw.WriteLine (interval);
		}

		sw.Flush ();
		sw.Close ();
	}
}
