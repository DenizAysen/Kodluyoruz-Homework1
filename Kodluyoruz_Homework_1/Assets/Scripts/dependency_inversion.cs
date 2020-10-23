using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dependency_inversion : MonoBehaviour
{

   

    public void Yazdir()
    {
        TurkishAthlete turkish = new TurkishAthlete();
        turkish.Jump(10);
        turkish.Run(20);

        NigerianAthlete nigerian = new NigerianAthlete();

        nigerian.Jump(25);
        nigerian.Run(30);
    }

}




public class TurkishAthlete : Athlete
{
    public void Run(int speed)
    {
        Debug.Log("He is running with " + speed + "m/s");
    }

    public void Jump(int meters)
    {
        Debug.Log("He jumped" + meters + " meters");
    }
}

public class NigerianAthlete : Athlete
{
    public void Run(int speed)
    {
        Debug.Log("He is running with " + speed + "m/s");
    }
    public void Jump(int meters)
    {
        Debug.Log("He jumped" + meters + " meters");
    }
}




public interface Athlete
{
    void Run(int speed);
    void Jump(int meters);
}

