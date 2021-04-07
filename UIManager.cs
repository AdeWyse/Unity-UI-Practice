using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject option;
    public GameObject lights;
    public GameObject dark;
    public GameObject startpanel;
    public GameObject toggle;
    private int fontSize=24;
    private int fontSizeBig = 45;
    private Color fontColor;
    public GameObject[] textsS;
    public GameObject[] textsB;
    public GameObject[] drops;
    int i = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        option.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        




    }

    public void StarButton()
    {
        startpanel.SetActive(true);
    }
    //turns on the black image and changes the font colors
    public void DarkMode(bool isOn)
    {
        isOn = toggle.GetComponent<Toggle>().isOn;

        if (isOn==true)
        {
           
            lights.SetActive(true);
            dark.SetActive(true);
            for (i = 0; i <= 12; i++)
            {
                
                textsS[i].gameObject.GetComponent<TMP_Text>().color = new Color(62, 0, 89, 255);
            }
            for (i = 0; i <= 2; i++)
            {
                textsB[i].gameObject.GetComponent<TMP_Text>().color = new Color(62, 0, 89, 255);
            }
        }
        if (isOn == false)
        {
            
            lights.SetActive(false);
            dark.SetActive(false);
            for (i = 0; i <= 11; i++)
            {
                textsS[i].gameObject.GetComponent<TMP_Text>().color = new Color(0, 0, 0, 1);
            }
            for (i = 0; i <= 1; i++)
            {
                textsB[i].gameObject.GetComponent<TMP_Text>().color = new Color(0, 0, 0, 1);
            }
        }
    }
   

    // QuitButton calls confirmation Panel, ConfirmationYes exits aplication, ConfirmationNo sets confirmation Panel inactive

    public void QuitButton(GameObject confirmation)
    {
        confirmation.gameObject.SetActive(true);
        
    }
    public void ConfirmationYES()
    {
        Application.Quit();
    }

    public void ConfirmationNo(GameObject confirmationPanel)
    {
        confirmationPanel.SetActive(false);
    }

    public void OptionButton(GameObject button)
    {
        button.gameObject.GetComponent<TMP_Text>().alignment = TextAlignmentOptions.Left;
        mainMenu.gameObject.SetActive(false);
        option.gameObject.SetActive(true);
    }
    public void BackButton(GameObject button)
    {
        button.gameObject.GetComponent<TMP_Text>().alignment = TextAlignmentOptions.Left;
        option.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }

    //Font Control

    public void Fontsize(GameObject dropDown)
        
    {
        int value = dropDown.GetComponent<TMP_Dropdown>().value;
        switch (value)
        {
            case 0:
                fontSize = 12;
                fontSizeBig = 35;
                break;
            case 1:
                fontSize = 24;
                fontSizeBig = 45;
                break;
            case 2:
                fontSize = 30;
                fontSizeBig = 50;
                break;
            default:
                break;
        }
        for(i=0; i<=12; i++ )
        {
            textsS[i].gameObject.GetComponent<TMP_Text>().fontSize = fontSize;
        }
        for(i=0; i<=2; i++)
        {
            textsB[i].gameObject.GetComponent<TMP_Text>().fontSize = fontSizeBig;
        }

    }

    public void FontColor(GameObject dropDown)

    {
        int value = dropDown.GetComponent<TMP_Dropdown>().value;
        switch (value)
        {
            case 0:
                fontColor = new Color (0, 0, 0, 1);
                break;
            case 1:
                fontColor = new Color(1, 1, 1, 1);
                break;
            case 2:
                fontColor = new Color(62, 0, 89, 255);
                break;
            default:
                break;
        }
        for (i = 0; i <= 12; i++)
        {
            textsS[i].gameObject.GetComponent<TMP_Text>().color = fontColor;
        }
        for (i = 0; i <= 2; i++)
        {
            textsB[i].gameObject.GetComponent<TMP_Text>().color = fontColor;
        }

    }

    // Language Control

    public void LanguageControl(GameObject dropDown)
    {
        int value = dropDown.GetComponent<TMP_Dropdown>().value;
        switch (value)
        {
            case 0:
                English();
                drops[1].SetActive(false);
                drops[3].SetActive(false);
                drops[0].SetActive(true);
                drops[2].SetActive(true);
                break;
            case 1:
                Portugues();
                drops[1].SetActive(true);
                drops[3].SetActive(true);
                drops[0].SetActive(false);
                drops[2].SetActive(false);
                break;
            default:
                break;
        }
    }
    

    //  buttons "animation"
    public void OnHoverEnter(GameObject button)
    {
        
        button.gameObject.GetComponent<TMP_Text>().alignment = TextAlignmentOptions.Center;
       
    }
    public void OnHoverExit(GameObject button)
    {
        
        button.gameObject.GetComponent<TMP_Text>().alignment = TextAlignmentOptions.Left;
    }


    /* I know another specialized script for language control is better in the context of a whole game, but as this is suposed to be a quick project
     * I don't realy want to create a whole new system just for this.*/
    public void English()
    {
        textsS[0].gameObject.GetComponent<TMP_Text>().text = "Start";
        textsS[1].gameObject.GetComponent<TMP_Text>().text = "Options";
        textsS[2].gameObject.GetComponent<TMP_Text>().text = "Quit";
        textsS[3].gameObject.GetComponent<TMP_Text>().text = "Yes";
        textsS[4].gameObject.GetComponent<TMP_Text>().text = "No";
        textsS[5].gameObject.GetComponent<TMP_Text>().text = "Are you sure?";
        textsS[6].gameObject.GetComponent<TMP_Text>().text = "Volume";
        textsS[7].gameObject.GetComponent<TMP_Text>().text = "Font Size";
        textsS[8].gameObject.GetComponent<TMP_Text>().text = "back";
        textsS[9].gameObject.GetComponent<TMP_Text>().text = "Font Color";
        textsS[10].gameObject.GetComponent<TMP_Text>().text = "Language";
        textsS[11].gameObject.GetComponent<TMP_Text>().text = "Dark Mode";

        textsB[0].gameObject.GetComponent<TMP_Text>().text = "Options";
        textsB[1].gameObject.GetComponent<TMP_Text>().text = "A game";
        textsB[2].gameObject.GetComponent<TMP_Text>().text = "SORRY  THIS ISN'T A REAL GAME";



    }

    public void Portugues()
    {
        textsS[0].gameObject.GetComponent<TMP_Text>().text = "Iniciar";
        textsS[1].gameObject.GetComponent<TMP_Text>().text = "Opções";
        textsS[2].gameObject.GetComponent<TMP_Text>().text = "Sair";
        textsS[3].gameObject.GetComponent<TMP_Text>().text = "Sim";
        textsS[4].gameObject.GetComponent<TMP_Text>().text = "Não";
        textsS[5].gameObject.GetComponent<TMP_Text>().text = "Tem certeza?";
        textsS[6].gameObject.GetComponent<TMP_Text>().text = "Volume";
        textsS[7].gameObject.GetComponent<TMP_Text>().text = "Tamanho";
        textsS[8].gameObject.GetComponent<TMP_Text>().text = "voltar";
        textsS[9].gameObject.GetComponent<TMP_Text>().text = "Cor";
        textsS[10].gameObject.GetComponent<TMP_Text>().text = "Língua";
        textsS[11].gameObject.GetComponent<TMP_Text>().text = "Modo Escuro";

        textsB[0].gameObject.GetComponent<TMP_Text>().text = "Opções";
        textsB[1].gameObject.GetComponent<TMP_Text>().text = "Um jogo";
        textsB[2].gameObject.GetComponent<TMP_Text>().text = "FOI MAL  ISSO NÃO É UM JOGO DE VERDADE";
    }

}