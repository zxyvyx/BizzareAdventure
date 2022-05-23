using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject Origin_DamagedCreep => Resources.Load<GameObject>("Prefabs/Enemies/DamagedCreep");
    public GameObject Origin_NativeCreep => Resources.Load<GameObject>("Prefabs/Enemies/NativeCreep");
    public GameObject Origin_WarriorCreep => Resources.Load<GameObject>("Prefabs/Enemies/WarriorCreep");
    public GameObject Origin_WitchCreep => Resources.Load<GameObject>("Prefabs/Enemies/WitchCreep");
    public GameObject Origin_SkeltCreep => Resources.Load<GameObject>("Prefabs/Enemies/SkeltCreep");
    public GameObject Origin_CastLight => Resources.Load<GameObject>("Prefabs/Stuffs/CastLight");
    public GameObject Origin_Fire1 => Resources.Load<GameObject>("Prefabs/Stuffs/Fire_Style1");
    public GameObject Origin_Fire2 => Resources.Load<GameObject>("Prefabs/Stuffs/Fire_Style2");
    public GameObject Origin_Shell => Resources.Load<GameObject>("Prefabs/Stuffs/ShellEffect");
    public GameObject Origin_Damage => Resources.Load<GameObject>("Prefabs/Stuffs/DamagePop");
    public GameObject Origin_Elixir => Resources.Load<GameObject>("Prefabs/PowerUps/Item_Elixir");
    public GameObject Origin_Scroll => Resources.Load<GameObject>("Prefabs/PowerUps/Item_Scroll");
    public GameObject Origin_Green => Resources.Load<GameObject>("Prefabs/PowerUps/Power_Green");
    public GameObject Origin_Red => Resources.Load<GameObject>("Prefabs/PowerUps/Power_Red");
    public GameObject Origin_Blue => Resources.Load<GameObject>("Prefabs/PowerUps/Power_Blue");

    public LevelSet LevelPoint;
    public int GamePoint;
    public int KillPoint;

    public int Item_Elixir { 
        get {
            return itemElixir;
        }
        set {
            itemElixir = value;
            if (itemElixir > 99) {
                itemElixir = 99;
            }
        }
    }

    public int Item_Scroll {
        get {
            return itemScroll;
        }
        set {
            itemScroll = value;
            if (itemScroll > 99) {
                itemScroll = 99;
            }
        }
    }

    public static GameManager Instance { get; private set; }
    
    [SerializeField] private int itemElixir;
    [SerializeField] private int itemScroll;

    private void Start() {
        Instance = this;
    }
}

public enum UnitState {
    Idle, Move, Attack, Cast, Dead,
}

public enum DamageState {
    Default, 
    PlayerPhs, PlayerMag, 
    EnemyPhs, AllyHeal,
}

public enum EnemySet {
    Default, Damaged, Native, Warrior, Witch, Skeleton,
}

public enum SkillSet {
    Default, SplashSwing, DemonShell,
}

public enum ItemSet {
    Default, 
    Power_Green, Power_Red, Power_Blue,
    Item_Elixir, Item_Scroll,
}

public enum LevelSet {
    Default, Easy, Normal, Hard,
}
