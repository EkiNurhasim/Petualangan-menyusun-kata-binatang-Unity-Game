using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayer : MonoBehaviour
{
    public GameObject[] dialogCanvasOrAlert;

    private void Update()
    {

        
        if (dialogCanvasOrAlert[0].activeInHierarchy == true ||
            dialogCanvasOrAlert[1].activeInHierarchy == true ||
            dialogCanvasOrAlert[2].activeInHierarchy == true ||
            dialogCanvasOrAlert[3].activeInHierarchy == true ||
            dialogCanvasOrAlert[4].activeInHierarchy == true ||
            dialogCanvasOrAlert[5].activeInHierarchy == true ||
            dialogCanvasOrAlert[6].activeInHierarchy == true ||
            dialogCanvasOrAlert[7].activeInHierarchy == true ||
            dialogCanvasOrAlert[8].activeInHierarchy == true ||
            dialogCanvasOrAlert[9].activeInHierarchy == true ||
            dialogCanvasOrAlert[10].activeInHierarchy == true ||
            dialogCanvasOrAlert[11].activeInHierarchy == true ||
            dialogCanvasOrAlert[12].activeInHierarchy == true ||
            dialogCanvasOrAlert[13].activeInHierarchy == true ||
            dialogCanvasOrAlert[14].activeInHierarchy == true ||
            dialogCanvasOrAlert[15].activeInHierarchy == true ||
            dialogCanvasOrAlert[16].activeInHierarchy == true ||
            dialogCanvasOrAlert[17].activeInHierarchy == true ||
            dialogCanvasOrAlert[18].activeInHierarchy == true ||
            dialogCanvasOrAlert[19].activeInHierarchy == true ||
            dialogCanvasOrAlert[20].activeInHierarchy == true ||
            dialogCanvasOrAlert[21].activeInHierarchy == true ||
            dialogCanvasOrAlert[22].activeInHierarchy == true ||
            dialogCanvasOrAlert[23].activeInHierarchy == true ||
            dialogCanvasOrAlert[24].activeInHierarchy == true ||
            dialogCanvasOrAlert[25].activeInHierarchy == true ||
            dialogCanvasOrAlert[26].activeInHierarchy == true ||
            dialogCanvasOrAlert[27].activeInHierarchy == true ||
            dialogCanvasOrAlert[28].activeInHierarchy == true ||
            dialogCanvasOrAlert[29].activeInHierarchy == true ||
            dialogCanvasOrAlert[30].activeInHierarchy == true ||
            dialogCanvasOrAlert[31].activeInHierarchy == true ||
            dialogCanvasOrAlert[32].activeInHierarchy == true ||
            dialogCanvasOrAlert[33].activeInHierarchy == true ||
            dialogCanvasOrAlert[34].activeInHierarchy == true ||
            dialogCanvasOrAlert[35].activeInHierarchy == true ||
            dialogCanvasOrAlert[36].activeInHierarchy == true ||
            dialogCanvasOrAlert[37].activeInHierarchy == true ||
            dialogCanvasOrAlert[38].activeInHierarchy == true ||
            dialogCanvasOrAlert[39].activeInHierarchy == true ||
            dialogCanvasOrAlert[40].activeInHierarchy == true ||
            dialogCanvasOrAlert[41].activeInHierarchy == true ||
            dialogCanvasOrAlert[42].activeInHierarchy == true ||
            dialogCanvasOrAlert[43].activeInHierarchy == true ||
            dialogCanvasOrAlert[44].activeInHierarchy == true ||
            dialogCanvasOrAlert[45].activeInHierarchy == true ||
            dialogCanvasOrAlert[46].activeInHierarchy == true ||
            dialogCanvasOrAlert[47].activeInHierarchy == true ||
            dialogCanvasOrAlert[48].activeInHierarchy == true ||
            dialogCanvasOrAlert[49].activeInHierarchy == true ||
            dialogCanvasOrAlert[50].activeInHierarchy == true ||
            dialogCanvasOrAlert[51].activeInHierarchy == true ||
            dialogCanvasOrAlert[52].activeInHierarchy == true ||
            dialogCanvasOrAlert[53].activeInHierarchy == true ||
            dialogCanvasOrAlert[54].activeInHierarchy == true ||
            dialogCanvasOrAlert[55].activeInHierarchy == true ||
            dialogCanvasOrAlert[56].activeInHierarchy == true ||
            dialogCanvasOrAlert[57].activeInHierarchy == true ||
            dialogCanvasOrAlert[58].activeInHierarchy == true ||
            dialogCanvasOrAlert[59].activeInHierarchy == true ||
            dialogCanvasOrAlert[60].activeInHierarchy == true ||
            dialogCanvasOrAlert[61].activeInHierarchy == true ||
            dialogCanvasOrAlert[62].activeInHierarchy == true ||
            dialogCanvasOrAlert[63].activeInHierarchy == true ||
            dialogCanvasOrAlert[64].activeInHierarchy == true ||
            dialogCanvasOrAlert[65].activeInHierarchy == true ||
            dialogCanvasOrAlert[66].activeInHierarchy == true ||
            dialogCanvasOrAlert[67].activeInHierarchy == true ||
            dialogCanvasOrAlert[68].activeInHierarchy == true ||
            dialogCanvasOrAlert[69].activeInHierarchy == true ||
            dialogCanvasOrAlert[70].activeInHierarchy == true ||
            dialogCanvasOrAlert[71].activeInHierarchy == true ||
            dialogCanvasOrAlert[72].activeInHierarchy == true ||
            dialogCanvasOrAlert[73].activeInHierarchy == true ||
            dialogCanvasOrAlert[74].activeInHierarchy == true ||
            dialogCanvasOrAlert[75].activeInHierarchy == true ||
            dialogCanvasOrAlert[76].activeInHierarchy == true ||
            dialogCanvasOrAlert[77].activeInHierarchy == true
            )
        {
            PlayerMovement.speed = 0;
            PlayerMovement.jumpForce = 0;
            PlayerMovement.up = false;
            
        }
        else
        {
            PlayerMovement.speed = 300;
            PlayerMovement.jumpForce = 15;
            PlayerMovement.up = true;
        }
    }
}
