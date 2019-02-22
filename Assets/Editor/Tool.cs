using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Tool : EditorWindow
{

    int target = 0;
    int inventoryTypeIndex = 0;
    string[] inventoryTypes = { "Hack'n'Slash", "Classic RPG", "Bag system" };
    string test = "Howdy";
    Texture2D firstTexture;
    Texture2D secondTexture;
    Texture2D previewTexture;
    GameObject testingObject;

    [MenuItem("Window/SilviuTool")]
    public static void ShowWindow()
    {
        GetWindow<Tool>("Heyoooo");
    }

    private void OnGUI()
    {
        target=GUILayout.Toolbar(target, new string[] { "Inventory", "Items", "Stats" });

        switch (target)
        {
            case 0:

                Inventory();
                if (GUILayout.Button("Say my name", GUILayout.Width(100), GUILayout.Height(25)))
                { EditPrefab(); }
                break;
            case 1:
                GUILayout.Label("Plm", EditorStyles.boldLabel);
                
                break;
            case 2:
                GUILayout.Label("Plt", EditorStyles.boldLabel);
                testingObject = (GameObject)EditorGUILayout.ObjectField("Object here:", testingObject, typeof(GameObject), false, GUILayout.Height(15));
                previewTexture = AssetPreview.GetAssetPreview(testingObject);
                if(previewTexture!=null)
                EditorGUI.DrawPreviewTexture(new Rect(20, 75, 200, 200), previewTexture);
                
                break;
        }
    }
    void Inventory()
    {
        GUILayout.Label("This is a label.", EditorStyles.boldLabel);
        inventoryTypeIndex = EditorGUILayout.Popup( "Inventory type:", inventoryTypeIndex, inventoryTypes);
        test = EditorGUILayout.TextField("Name", test);
        firstTexture = (Texture2D)EditorGUILayout.ObjectField("Texture here:", firstTexture, typeof(Texture2D), false, GUILayout.Height(15));
        secondTexture = (Texture2D)EditorGUILayout.ObjectField("Texture here:", secondTexture, typeof(Texture2D), false, GUILayout.Height(15));
        if (GUILayout.Button("Press Me", GUILayout.Width(100), GUILayout.Height(25)))
        { Debug.Log("Button pressed"); }
    }

    void EditPrefab()
    {
        GameObject prefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Slot.prefab",typeof(GameObject));
        string name=prefab.GetComponent<Image>().sprite.name;
        Debug.Log(name);
    }

}
