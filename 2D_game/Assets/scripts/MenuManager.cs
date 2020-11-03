
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager: MonoBehaviour
{
    //註解：說明
    //按鈕如何和程式溝通
    //需要方法（函式、功能）-一堆有功能的程式、演算法
    //語法：
    //修飾詞 類型 方法名稱 () {}
    //私人 private（預設）- 不可被按鈕器呼叫
    //公開 public - 可被按鈕器呼叫
    //void 無類型
    void StarGame()
    {
        print("開始遊戲");          //輸出（訊息）- 文字要加雙引號，儀表板 Console
        ScalableBufferManager.LoadScene("關卡1")      //場景管理.載入場景("名稱")
        //ScalableBufferManager.LoadScene(1)        //場景管理.載入場景(編號) 
    }
    void QuitGame()
    {
        print("結束遊戲");
        Application.Quit();
    }
}
