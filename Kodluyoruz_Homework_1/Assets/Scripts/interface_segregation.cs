using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interface_segregation : MonoBehaviour
{
   

    public void Write()
    {

        Player1 player1 = new Player1();
        player1.Block("Ekpe Udoh");

        Player2 player2 = new Player2();
        player2.Block("Lebron James");
        player2.Shoot("Lebron James");

    }
}







public interface IShootable
{
   
    void Shoot(string player);

}

public interface IBlockable
{
    void Block(string player);

}

public class Player1 : IBlockable
{
    public void Block(string player)
    {
        Debug.Log("What a block by " + player + "!!!");
    }
}

public class Player2 : IBlockable, IShootable
{
    public void Block(string player)
    {
        Debug.Log("What a block by " + player + "!!!");
    }

    public void Shoot(string player)
    {
        Debug.Log("3 points by "+player);
    }
}
    







