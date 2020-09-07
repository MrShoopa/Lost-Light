using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private static float sideviewDefaultZAxis = -4.5f;

	private static float currentZAxis = 0f;

	public Camera mainCamera;

	public GameObject thePlayer, theLight, LightCanvas, masterUi;
	private GameObject winUI;
	public Perspective curPerspective;
	public Perspective ObjPerspective;
	public Animator lightAnim;
	public List<GameObject> CheckpointTexts;
	public IEnumerator updateCheckpoint(int checkpointNum)
	{
		if (checkpointNum - 1 != -1)
		{
			CheckpointTexts[checkpointNum - 1].GetComponent<Animator>().Play("FadeOutText");
			yield return new WaitForSeconds(1f);
			CheckpointTexts[checkpointNum - 1].SetActive(false);
		}
		CheckpointTexts[checkpointNum].SetActive(true);
		CheckpointTexts[checkpointNum].GetComponent<Animator>().Play("FadeInText");
	}
	public IEnumerator updatePerspective()
	{
		LightCanvas.SetActive(true);
		lightAnim.Play("FadeIn");
		yield return new WaitForSeconds(1f);
		if (curPerspective == Perspective.twoD)
			curPerspective = Perspective.threeD;
		else
			curPerspective = Perspective.twoD;

		updateEnvironment(curPerspective);
		lightAnim.Play("FadeOut");
		yield return new WaitForSeconds(1f);
		LightCanvas.SetActive(false);
	}
	public IEnumerator dead()
	{
		LightCanvas.SetActive(true);
		lightAnim.Play("FadeIn");
		yield return new WaitForSeconds(1f);
		lightAnim.Play("FadeOut");
		yield return new WaitForSeconds(1f);
		LightCanvas.SetActive(false);
	}
	public void updateEnvironment(Perspective perspective)
	{
		if (curPerspective == Perspective.twoD)
		{
			currentZAxis = thePlayer.transform.position.z;
			thePlayer.transform.position = GameManager.get2DPosition(thePlayer.transform.position);
			theLight.transform.position = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y, thePlayer.transform.position.z - 0.1f);

			mainCamera.orthographic = true;
			mainCamera.fieldOfView = 60;
		}
		else
		{
			thePlayer.transform.position = GameManager.get3DPosition(thePlayer.transform.position);
			theLight.transform.position = new Vector3(thePlayer.transform.position.x - .1f, thePlayer.transform.position.y, thePlayer.transform.position.z);

			mainCamera.orthographic = false;
			mainCamera.fieldOfView = 60;
		}
		SwitchObstaclePerspectives();
	}


	public Perspective getPerspective()
	{
		return curPerspective;
	}

	public enum Perspective
	{
		twoD,
		threeD
	}

	public static Vector3 get2DPosition(Vector3 playerPostion)
	{
		return new Vector3(playerPostion.x, playerPostion.y, sideviewDefaultZAxis);
	}
	public static Vector3 get3DPosition(Vector3 playerPostion)
	{
		return new Vector3(playerPostion.x, playerPostion.y, currentZAxis);
	}

	public void SwitchObstaclePerspectives()
	{
		foreach (ObstacleSwitch plat in GameObject.FindObjectsOfType<ObstacleSwitch>())
		{
			plat.SwitchPerspective();
		}
	}

	public void BeginLevel()
	{
		winUI = masterUi.GetComponentInChildren<UILevelComplete>().gameObject;
		winUI.SetActive(false);
	}

	public void CompleteLevel()
	{
		Debug.Log("Reached end of level!");
		CheckpointTexts[CheckpointTexts.Count-1].SetActive(false);
		winUI.SetActive(true);
	}

	private void Start()
	{
		BeginLevel();
	}
}
