
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace UniRx.ObjectTest
{
    public class LoadLevelTest : MonoBehaviour
    {
        void Start()
        {

			var Canvas=GameObject.Find("Canvas").gameObject;
			DontDestroyOnLoad(Canvas);

			var EventSystem=GameObject.Find("EventSystem").gameObject;
			DontDestroyOnLoad(EventSystem);

			menuMakerUI("LoadLevel_LoadLevelTestNew","LoadLevelTestNew","LoadLevel");
			menuMakerUI("LoadLevel_LoadLevelAdditive","LoadLevelTestAdditive","LoadLevelAdditive");


			menuMakerUI("LoadLevel_MultipleDispatchersTest","MultipleDispatchersTest","LoadLevel");
			menuMakerUI("LoadLevel_NextSandBox","NextSandbox","LoadLevel");
			menuMakerUI("LoadLevel_TestSandbox","TestSandbox","LoadLevel");
			menuMakerUI("LoadLevel_WorkerThreadTest","WorkerThreadTest","LoadLevel");
			//menuMaker("LoadLevel_MultipleDispatchersTest","MultipleDispatchersTest");


        }
		//using UnityEngine.UI;
		//using UnityEngine.EventSystems;
		void menuMakerUI(string GameObjName,string SceneName,string LoadLevelOrLoadAddtive){

			GameObject ll = GameObject.Find(GameObjName);
			//Color llcolor = ll.transform.GetComponent<UnityEngine.UI.Text>().color;
			UGUIButon cll = ll.AddComponent<UGUIButon>();
			//UnityEngine.UI.Text clltext=cll.transform.GetComponent<UnityEngine.UI.Text>();
			if(LoadLevelOrLoadAddtive=="LoadLevel"){
				cll.OnClicked += () => Application.LoadLevel(SceneName);
			}
			if(LoadLevelOrLoadAddtive=="LoadLevelAdditive"){
				cll.OnClicked += () => Application.LoadLevelAdditive(SceneName);
			}

			//cll.OnEntered += () => clltext.color = Color.blue;
			//cll.OnExited += () => clltext.color = llcolor;
		}
    }

}




/*
using System;
using System.Collections;
using UnityEngine;

namespace UniRx.ObjectTest
{
	public class LoadLevelTest : MonoBehaviour
	{
		void Start()
		{


            var ll = GameObject.Find("LoadLevel");
            var llcolor = ll.GetComponent<GUIText>().color;
            var cll = ll.AddComponent<Clicker>();
			var clltext=cll.GetComponent<GUIText>();
            cll.OnClicked += () => Application.LoadLevel("LoadLevelTestNew");
			cll.OnEntered += () => clltext.color = Color.blue;
			cll.OnExited += () => clltext.color = llcolor;

            var lla = GameObject.Find("LoadLevelAdditive");
            var llacolor = lla.GetComponent<GUIText>().color;
            var clla = lla.AddComponent<Clicker>();
			var cllatext=clla.GetComponent<GUIText>();
            clla.OnClicked += () => Application.LoadLevelAdditive("LoadLevelTestAdditive");
			clla.OnEntered += () => cllatext.color = Color.blue;
			clla.OnExited += () => cllatext.color = llacolor;





//------------------------------------------------
			GameObject loadLevelGameobj = GameObject.Find("LoadLevel");
			GUIText loadLevelGameobjText=loadLevelGameobj.GetComponent<GUIText>();
			Color loadLevelGameobjTextColor = loadLevelGameobjText.color;
			Clicker loadLevelGameobjClicker = loadLevelGameobj.AddComponent<Clicker>();
			GUIText loadLevelGameobjClickerText=loadLevelGameobjClicker.GetComponent<GUIText>();
			loadLevelGameobjClicker.OnClicked += () => Application.LoadLevel("LoadLevelTestNew");
			loadLevelGameobjClicker.OnEntered += () => loadLevelGameobjClickerText.color = Color.blue;
			loadLevelGameobjClicker.OnExited += () => loadLevelGameobjClickerText.color = loadLevelGameobjTextColor;

			GameObject loadLevelAdditive = GameObject.Find("LoadLevelAdditive");
			GUIText loadLevelAdditiveText=loadLevelAdditive.GetComponent<GUIText>();
			Color loadLevelAdditiveColor = loadLevelAdditiveText.color;
			Clicker loadLevelAdditiveClicker = loadLevelAdditive.AddComponent<Clicker>();
			GUIText loadLevelAdditiveClickerText=loadLevelAdditiveClicker.GetComponent<GUIText>();
			loadLevelAdditiveClicker.OnClicked += () => Application.LoadLevelAdditive("LoadLevelTestAdditive");
			loadLevelAdditiveClicker.OnEntered += () => loadLevelAdditiveClickerText.color = Color.blue;
			loadLevelAdditiveClicker.OnExited += () => loadLevelAdditiveClickerText.color = loadLevelAdditiveColor;
		}
		void menuMaker(string GameObjName,string SceneName){

			var ll = GameObject.Find(GameObjName);
			var llcolor = ll.GetComponent<GUIText>().color;
			var cll = ll.AddComponent<Clicker>();
			var clltext=cll.GetComponent<GUIText>();
			cll.OnClicked += () => Application.LoadLevel(SceneName);
			cll.OnEntered += () => clltext.color = Color.blue;
			cll.OnExited += () => clltext.color = llcolor;
		}
	}
}

*/