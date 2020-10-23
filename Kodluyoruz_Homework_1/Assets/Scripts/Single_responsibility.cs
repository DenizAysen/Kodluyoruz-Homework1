using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Single_responsibility : MonoBehaviour
{
    
   

    public void Click()
    {
        Debug.Log("Parcalara ayriliyor!!!");

        Car car = new Car();
        car.Apply();
    }
    
}


public class Car
{
    MoveHandler _movehandler = new MoveHandler();

    Boost _boost = new Boost(5.0f);

    InputHandler _inputHandler = new InputHandler();

    bool stop = false;

    int count = 0;

    public void Apply()
    {
        while (!stop)
        {
            _movehandler.Move();
            _boost.AddBoost();
            _inputHandler.GetInput();
            count++;

            if(count == 2)
            {
                stop = true;
            }
        }
    }
}



public class MoveHandler
{
    public void Move()
    {
        Debug.Log("Moving");
    }
}


public class Boost
{
    float _hiz;

    public Boost(float hiz)
    {
        _hiz = hiz;
    }

    public void AddBoost()
    {
        Debug.Log("Going " + _hiz + "m/s faster");
    }
}


public class InputHandler
{

    public void GetInput()
    {
        Debug.Log("Getting input.");
    }

}
