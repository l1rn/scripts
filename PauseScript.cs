using UnityEngine;

public class PauseScript : MonoBehaviour

{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private NPCInteraction npcInteraction;
    [SerializeField] private GameObject inventoryPanel; 


    public InputManager inputManager;
    public PlayerManager playerManager;
    public CameraManager cameraManager;

    public bool isPauseMenuVisible = false;
    private void Awake()
    {
        npcInteraction = FindAnyObjectByType<NPCInteraction>();
        inputManager = FindAnyObjectByType<InputManager>();
        playerManager = FindAnyObjectByType<PlayerManager>();
        cameraManager = FindAnyObjectByType<CameraManager>();
    }

    void Start()
    {
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!npcInteraction.isDialogueActive)
        {
            if (Input.GetKeyUp(KeyCode.Escape) && isPauseMenuVisible == false)
            {
                inventoryPanel.SetActive(false);
                cameraManager.ReturnZeroCamera();
                playerManager.BlockMovement(true);
                inputManager.IsInputIdle();
                PauseMenu.SetActive(true);
                isPauseMenuVisible = true;

            }
            else if (Input.GetKeyUp(KeyCode.Escape) && isPauseMenuVisible == true)
            {
                inventoryPanel.SetActive(true);
                cameraManager.BackCamera();
                playerManager.BlockMovement(false);
                PauseMenu.SetActive(false);
                isPauseMenuVisible = false;
            }
        }
        else
        {

        }
        {
            return;
        }
        
        
    }

    public void ShowPause()
    {
        
    }
}
