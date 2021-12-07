using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTest : MonoBehaviour
{
    // Start is called before the first frame update
	public Camera main;
	public int time;
	public int dayNightPeriod;
	private float dayNightState;
	void Start()
    {
        RenderSettings.ambientLight = Color.white;
		main.backgroundColor = new Color(49f/256f, 77f/256f, 121f/256f);
    }

    // Update is called once per frame
    void Update()
    {
		time++;
		if(time%dayNightPeriod < dayNightPeriod/4) 
		{
			dayNightState = 1;
		}
		else if(time%dayNightPeriod < dayNightPeriod/2) 
		{	
			dayNightState = 1 - ((float) (time%dayNightPeriod) - dayNightPeriod/4)/(dayNightPeriod/4);
		}
		else if(time%dayNightPeriod < 3 * dayNightPeriod/4) 
		{	
			dayNightState = 0;
		}
		else
		{	
			dayNightState = ((float) (time%dayNightPeriod) - 3 * dayNightPeriod/4)/(dayNightPeriod/4);
		}
	
		RenderSettings.ambientLight = new Color(dayNightState, dayNightState, dayNightState);
		main.backgroundColor = new Color(49f/256f * dayNightState, 77f/256f * dayNightState, 121f/256f * dayNightState);
    }
}
