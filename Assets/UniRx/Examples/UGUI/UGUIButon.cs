using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class UGUIButon : MonoBehaviour,IPointerClickHandler,IPointerEnterHandler,IPointerExitHandler {

	public string sceneName;
	public GameObject myGameObject; 
	public string gameObjectName;
	public string LoadLevelOrLoadAddtive;

	public delegate void delegateOnClicked();
	public delegateOnClicked OnClicked;

	public delegate void delegateOnEntered();
	public delegateOnEntered OnEntered;

	public delegate void delegateOnExited();
	public delegateOnExited OnExited;
	void myOnEntered(){

	}
	void myOnClicked(){

	}
	void myOnExited(){

	}
	void Start(){

		OnClicked+=myOnClicked;
		OnEntered+=myOnEntered;
		OnExited+=myOnExited;


		gameObjectName=gameObject.name;

		/////////////////////////////////////////////////////////////////////////////
		//string modelDirStr = AssetDatabase.GetAssetPath (modelAsset);
		Debug.Log ("gameObjectName=" + gameObjectName);

		string[] modelDirArr;
		modelDirArr=gameObjectName.Split("/"[0]);
		string buildDir = modelDirArr[0];
		//for(int i = 1; i < modelDirArr.Length-1; i++){
		//	buildDir = buildDir +"/"+ modelDirArr [i];
		//}
		//CharaDir = buildDir;
		//Debug.Log ("CharaDir="+CharaDir);
		//CharaName = modelDirArr [modelDirArr.Length-1];
		//Debug.Log ("CharaName="+CharaName);

		////////////////////////////////////////////////////////////////////////////////
	}

	public void OnPointerClick (PointerEventData eventData){

		GameObject gameobject=eventData.selectedObject.gameObject;
		Debug.Log(gameobject.name);


		if(OnClicked != null)
		{
			OnClicked();
		}
	}

	public void OnPointerExit (PointerEventData eventData){
		if(OnExited != null)
		{
			OnExited();
		}
	}
	public void OnPointerEnter (PointerEventData eventData){
		if(OnEntered != null)
		{
			OnEntered();
		}
	}
}
