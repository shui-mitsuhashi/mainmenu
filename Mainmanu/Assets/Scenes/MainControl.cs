using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
	public GameObject MainMenu;
	public GameObject Option;
	public GameObject Asobikata;
	// ���{�^���������ꂽ���ɌĂ΂��
	public void OnPushButtonMain()
	{
		MainMenu.SetActive(true);
		Option.SetActive(false);
		Asobikata.SetActive(false);
	}
	// �Ԃ��{�^���������ꂽ���ɌĂ΂��
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
	// �X�^�[�g�֐�
	private void Start()
	{
		OnPushButtonMain();
	}
	void Update()
	{

	}
}
