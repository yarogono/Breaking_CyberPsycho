using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Popup : UI_Base
{
    public override void Init()
    {

    }

    public virtual void ClosePopupUI()
    {
        GameManager.UI.ClosePopupUI();
    }
}
