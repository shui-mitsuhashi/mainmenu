using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
	public GameObject MainMenu;
	public GameObject Option;
	public GameObject Asobikata;
	// 青いボタンが押された時に呼ばれる
	public void OnPushButtonMain()
	{
		MainMenu.SetActive(true);
		Option.SetActive(false);
		Asobikata.SetActive(false);
	}
	// 赤いボタンが押された時に呼ばれる
	public void OnPushButtonOption()
	{
		MainMenu.SetActive(false);
		Option.SetActive(true);
		Asobikata.SetActive(false);
	}
	public void OnPushButtonAsobikata()
	{
		MainMenu.SetActive(false);
		Option.SetActive(false);
		Asobikata.SetActive(true);
	}
	// スタート関数
	private void Start()
	{
		OnPushButtonMain();
	}
	void Update()
	{

	}
}
