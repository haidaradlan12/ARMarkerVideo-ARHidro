using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuJudul, MenuGambar, MenuButton, MenuMateri, MenuInformasi, MenuPetunjuk;
    // Start is called before the first frame update
    void Start()
    {
        MenuJudul.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambar.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuJudul.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambar.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void MenuMateributton()
    {
        MenuJudul.DOAnchorPos(new Vector2(0, 2000), 1.0f);
        MenuGambar.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void MenuInformasibutton()
    {
        MenuJudul.DOAnchorPos(new Vector2(0, 2000), 1.0f);
        MenuGambar.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);

    }
    public void MenuPetunjukbutton()
    {
        MenuJudul.DOAnchorPos(new Vector2(0, 2000), 1.0f);
        MenuGambar.DOAnchorPos(new Vector2(0, -2000), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);

    }

}
