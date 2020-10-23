using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_closed : MonoBehaviour
{
    // Start is called before the first frame update

   

    private void Update()
    {
        
        var card = new Card();

        card.UseCard();
    }
    
    public void Tikla()
    {
        Debug.Log("f'ye basınız.");
        
    }
}



public class Card
{
    Visa visa = new Visa();
    MasterCard masterCard = new MasterCard();
    Ziraat ziraat = new Ziraat();
   public void UseCard()
    {

        if (Input.GetKey(KeyCode.F))
        {
            visa.DrawMoney(5.0f);
            masterCard.DrawMoney(10f);
            ziraat.DrawMoney(9f);
        }
            
        
    }
}


public class Visa : IPay
{
    public void DrawMoney(float dolar)
    {
        Debug.Log("Drawing " + dolar + "TL from your Visa account");
       
    }

    public void Pay()
    {
        Debug.Log("Paying your debt with your visa card");
    }
}


public class MasterCard : IPay
{
    public void DrawMoney(float dolar)
    {
        Debug.Log("Drawing " + dolar + "TL from your Mastercard account");
    }

    public void Pay()
    {
        Debug.Log("Paying your debt with your Mastercard card");
    }
}


public class Ziraat : IPay
{
    public void DrawMoney(float dolar)
    {
        Debug.Log("Drawing " + dolar + "TL from your Ziraat account");
    }

    public void Pay()
    {
        Debug.Log("Paying your debt with your Ziraat card");
    }
}

public interface IPay
{
    void Pay();
    void DrawMoney(float dolar);
}
