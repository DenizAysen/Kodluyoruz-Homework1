using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class liskov_substitution : MonoBehaviour
{

    public Button button;

    private void Start()
    {
        button.onClick.AddListener(Yazdir);
    }

    private void Yazdir()
    {
        
        GameDeveloper gameDeveloper = new GameDeveloper();
        gameDeveloper.Getsalary();
        GameManager gameManager = new GameManager();
        gameManager.Getsalary();
    }

}


public abstract class Employee
{

    public abstract void Getsalary();
}


public class GameManager : Employee
{
    public override void Getsalary()
    {
        Debug.Log("5500TL");
    }
}

public class GameDeveloper : Employee
{
    public override void Getsalary()
    {
        Debug.Log("2324TL");
    }
}


