using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeverageFactory : MonoBehaviour
{
    public void PrepareTea()
    {
        Tea tea = new Tea("Lemon Tea");
        tea.Prepare();
    }

    public void PreparePourOver()
    {
        PourOver pourOver = new PourOver("Double Double");
        pourOver.Prepare();
    }

    public void PrepareEspresso()
    {
        Espresso espresso = new Espresso("Espresso");
        espresso.Prepare();
    }
}
