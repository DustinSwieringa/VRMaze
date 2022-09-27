using UnityEngine;

public class MazeOptions : MonoBehaviour
{
    public Material SkyboxMaterial;
    public float JumpSpeed;
    public float Gravity;
    public int JumpCount;

    [SerializeField]
    private JumpMoveProvider _jumpMoveProvider;

    public void ApplySettings()
    {
        RenderSettings.skybox = SkyboxMaterial;
        _jumpMoveProvider.JumpCount = JumpCount;
        _jumpMoveProvider.JumpSpeed = JumpSpeed;
        _jumpMoveProvider.GravityMultiplier = Gravity;
    }
}
