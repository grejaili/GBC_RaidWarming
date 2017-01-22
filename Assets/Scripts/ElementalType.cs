using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalType : MonoBehaviour {

	public enum Element
	{
		Fire,
		Earth,
		Air,
		Water
	}

	private Element m_type;
	public Element type
	{
		get { return m_type; }
		set { m_type = value; }
	}

	//public static Element GetCounterElement(Element e)
	//{
	//	switch (e)
	//	{
	//		case Element.Fire:
	//			return Element.Water;

	//		case Element.Earth:
	//			return Element.Air;

	//		case Element.Air:
	//			return Element.Fire;

	//		case Element.Water:
	//			return Element.Earth;

	//	}
	//	return Element.Air;
	//}
}
