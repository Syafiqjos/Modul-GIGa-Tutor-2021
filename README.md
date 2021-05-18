# GiGa Tutor 2021
## Shooting-Platformer 2D Unity Tutorial

![Gameplay-Overview](/Images/Gameplay-Overview.gif)

## A. Pendahuluan
Unity adalah gem enjin.

Project adalah project seperti itu.
Scene adalah scene yang seperti ini.

## B. Download Assets
Assets Sprite untuk modul ini dapat di download di [Unlucid Adopted Assets](https://drive.google.com/file/d/1NOk7RWAwUmZ9mNOkndJDw4jE9vUCM96I/view?usp=drivesdk)

## C. Setting Up Project
1. Buka Unity Hub yang telah di download.

![SettingUp-UnityHub](/Images/SettingUp-UnityHub.png)

2. Pilih New pada pojok kanan atas untuk membuat Project baru.

3. Pilih Template 2D untuk membuat game 2D dan isi **Project Name** untuk Nama Project Game yang ingin dibuat dan **Location** untuk lokasi project yang akan ditempatkan.

![SettingUp-UnityHubNewProject](/Images/SettingUp-UnityHubNewProject.png)

4. Tekan **Create** dan menunggu loading dari Unity untuk membuat Project Game 2D baru.

![SettingUp-UnityInterface](/Images/SettingUp-UnityInterface.png)

## D. Pengenalan Layout Unity
### Scene View

![LayoutUnity-SceneView](/Images/LayoutUnity-SceneView.png)

- Menjelaskan Scene View
- Menjelaskan Project
- Menjelaskan Scene
### Game View

![LayoutUnity-GameView](/Images/LayoutUnity-GameView.png)

- Menjelaskan Game View
### Project Window

![LayoutUnity-ProjectWindow](/Images/LayoutUnity-ProjectWindow.png)

- Menjelaskan Project Window
### Hierarchy

![LayoutUnity-Hierarchy](/Images/LayoutUnity-Hierarchy.png)

- Menjelaskan Hierarchy
### Inspector

![LayoutUnity-Inspector](/Images/LayoutUnity-Inspector.png)

- Menjelaskan Inspector
- Menjelaskan GameObject
- Menjelaskan Component
- Menjelaskan bahwa Transform termasuk Component

## E. Import Assets

### Extract file Assets yang telah didownload sebelumnya pada lokasi Project yang barusan dibuat.

![ImportAssets-Extract](/Images/ImportAssets-Extract.png)

### Sehingga struktur project yang baru kurang lebih seperti berikut ini.

![ImportAssets-Structure](/Images/ImportAssets-Structure.png)

## F. Pengenalan GameObject pada Unity
### Membuat Player
- Menjelaskan GameObject (lagi).
- Buat GameObject kosong (Empty) dengan cara GameObject > Create Empty.

![IntroductionGameObject-PlayerEmpty](/Images/IntroductionGameObject-PlayerEmpty.png)

- Ganti nama GameObject ini menjadi Player.

![IntroductionGameObject-PlayerRename](/Images/IntroductionGameObject-PlayerRename.png)

- Pada Hierarchy, klik kanan pada Player dan pilih Create Empty dan ubah namanya menjadi Graphic.

![IntroductionGameObject-PlayerCreateChild](/Images/IntroductionGameObject-PlayerCreateChild.png)

- Pada child Player Graphic ini, tambahkan component Sprite Renderer.

![IntroductionGameObject-PlayerAddSpriteRenderer](/Images/IntroductionGameObject-PlayerAddSpriteRenderer.png)

- Menjelaskan Sprite Renderer.

- Navigasi pada `Assets/Sprites/Player` dan pilih salah satu Sprite, dalam modul ini kami menggunakan `player_idle_0.png` sebagai contoh.

![IntroductionGameObject-PlayerSpriteAssets](/Images/IntroductionGameObject-PlayerSpriteAssets.png)

- Klik pada sprite tersebut lalu pada Inspector ubah Pixels Per Unit menjadi 32 lalu Apply.

![IntroductionGameObject-PlayerSpritePixels32](/Images/IntroductionGameObject-PlayerSpritePixels32.png)

- Drag Sprite tersebut menuju field Sprite pada component SpriteRenderer yang ada pada GameObject Graphic.

![IntroductionGameObject-PlayerSpriteAssign](/Images/IntroductionGameObject-PlayerSpriteAssign.png)

- Jika berhasil, kita dapat melihat Player pada Scene View. Pilih Player lalu coba pindahkan posisinya dengan menggunakan axis transform.

![IntroductionGameObject-PlayerPreview](/Images/IntroductionGameObject-PlayerPreview.png)

- Menjelaskan Transform (lagi).

### Mencoba Sprite Slicing untuk Forest Tile

- Pada Project Assets pilih Sprite forest_tile.png.

![IntroductionGameObject-ForestTileAssets](/Images/IntroductionGameObject-ForestTileAssets.png)

- Pada Inspector ubah Sprite Mode menjadi **Multiple**, Pixels Per Unit menjadi **32**, Mesh Type menjadi **Full Rect**  lalu **Apply**.

![IntroductionGameObject-ForestTileInspector](/Images/IntroductionGameObject-ForestTileInspector.png)

- Pada Inspector lagi, klik button **Sprite Editor**

![IntroductionGameObject-ForestTileInspectorSpriteEditor](/Images/IntroductionGameObject-ForestTileInspectorSpriteEditor.png)

- Kemudian pada Sprite Editor pilih Slice lalu pilih **Grid by Cell Size** dan ganti Pixel Size menjadi 16x16. Kemudian klik Apply.

![IntroductionGameObject-ForestTileSpriteEditor](/Images/IntroductionGameObject-ForestTileSpriteEditor.png)

- Menjelaskan Sprite Slicing

- Hasil slicing sprite dapat dilihat pada Project Window, maka setiap potongan kotak dapat digunakan secara terpisah.

![IntroductionGameObject-ForestTileSliceResult](/Images/IntroductionGameObject-ForestTileSliceResult.png)

- Buat Game Object Empty dan ganti namanya menjadi Environment. Game Object ini untuk menampung lingkungan / pijakan / dekorasi pada level nanti

![IntroductionGameObject-ForestTileEnvironment](/Images/IntroductionGameObject-ForestTileEnvironment.png)

- Coba cari kotak dengan nama forest_tile_57 dan drag and drop ke Game Object Environment pada Hierarchy dan ubah namanya menjadi nama lain agar mudah dikenali.

![IntroductionGameObject-ForestTileEnvironmentHierarchy](/Images/IntroductionGameObject-ForestTileEnvironmentHierarchy.png)

- Pada SpriteRenderer ubah Draw Mode menjadi **Tiled**.

![IntroductionGameObject-ForestTileEnvironmentSpriteRenderer](/Images/IntroductionGameObject-ForestTileEnvironmentSpriteRenderer.png)

- Menjelaskan Sprite Tiling pada Sprite Renderer

- Modifikasi ukuran dan posisi Sprite dengan bantuan tools transform yang ada.

![IntroductionGameObject-ForestTileEnvironmentTilingResult](/Images/IntroductionGameObject-ForestTileEnvironmentTilingResult.png)

- Dengan cara yang sama coba cari forest_tile_44 dan coba hias level sedemikian rupa agar indah dan cantik.

![IntroductionGameObject-ForestTileEnvironmentResult](/Images/IntroductionGameObject-ForestTileEnvironmentResult.png)

### Membuat Level

- Pada seluruh sprite pada Project Window, ubah **Pixels Per Unit** nya menjadi 32. Bisa dengan cara select menggunakan shift click pada sprite yang diinginkan.

![IntroductionGameObject-CreateLevel32](/Images/IntroductionGameObject-CreateLevel32.png)

 - Pada inspector ubah **Pixels Per Unit** nya menjadi 32, lalu Apply. Lakukan pada semua sprite yang ada (Bullet, Environment, Mushroom, Player dan UI).

![IntroductionGameObject-CreateLevel32Apply](/Images/IntroductionGameObject-CreateLevel32Apply.png)

- Dengan cara drag and drop dari Project Window ke Graphic dan jadikan sprite tersebut sebagai child dari Environment, hias Level mu sesuai keinginan!

![IntroductionGameObject-CreateLevel32Result](/Images/IntroductionGameObject-CreateLevel32Result.png)

- Terkadang urutan tampilan sprite tidak benar, bisa diatur pada **Order in Layer** pada setiap Sprite Renderer.

![IntroductionGameObject-CreateLevel32LayerOrder](/Images/IntroductionGameObject-CreateLevel32LayerOrder.png)

- Menjelaskan tentang sprite order

### Menambahkan Physics

- Menjelaskan physics2D

- Pada player menambahkan Rigidbody2D

![image](https://user-images.githubusercontent.com/16128257/118537852-a7d9eb80-b777-11eb-9510-868082a8b1bc.png)

- Centang Freeze Rotation Z pada constraint Rigidbody2D

![image](https://user-images.githubusercontent.com/16128257/118537260-f1760680-b776-11eb-8cfa-24e1ea66a9b8.png)

- Tambahkan component Capsule Collider2D pada Player

![image](https://user-images.githubusercontent.com/16128257/118537348-0ce11180-b777-11eb-9dfb-4644d46e5fd5.png)

- Menjelaskan Capsule Collider2D

- Ubah ukuran Collider sesuai dengan sprite Player

![image](https://user-images.githubusercontent.com/16128257/118537486-339f4800-b777-11eb-8e64-166c1b6bc0ff.png)

- Pada Environment tambahkan Box Collider2D pada tanah yang dapat dipijak Player dan sesuaikan ukuran collidernya

![image](https://user-images.githubusercontent.com/16128257/118537926-bd4f1580-b777-11eb-8eed-7cb18829670d.png)

![image](https://user-images.githubusercontent.com/16128257/118537687-77924d00-b777-11eb-920d-634632d7b66c.png)

### Membuat Prefab untuk Player
- Menjelaskan prefabs

- Pada Project Window, click kanan lalu Create > Folder untuk membuat folder baru pada Assets lalu beri nama Prefabs.

![image](https://user-images.githubusercontent.com/16128257/118538961-0b184d80-b779-11eb-999c-f0c888967a09.png)

- Buka Folder Prefabs tersebut, lalu pada Hierachy pilih Player dan drag pad Project Assets untuk membuat prefab Player.

![image](https://user-images.githubusercontent.com/16128257/118539104-3864fb80-b779-11eb-84e1-f483d15ca4c9.png)

### Test Play pada Game
- Menjelaskan Edit Mode pada Unity Editor

- Menjelaskan Game Mode pada Unity Editor

- Lakukan test Play dengan menekan tombol Play

![image](https://user-images.githubusercontent.com/16128257/118539260-6b0ef400-b779-11eb-828b-32632590c616.png)

- Tampilan Game Mode, Player akan jatuh karena pengaruh Rigidbody2D

![image](https://user-images.githubusercontent.com/16128257/118539766-0607ce00-b77a-11eb-8a7a-5c36a9626d32.png)

## G. Membuat Entitas pada Game
### Membuat Code Player
- Buat Folder baru dengan nama Scripts dan buat Script baru dengan Create > C# Script dan beri nama PlayerController

![image](https://user-images.githubusercontent.com/16128257/118540915-4b78cb00-b77b-11eb-9bb3-04562c6e57c4.png)

- Drag Script PlayerController dan drag pada gameobject Player pada Hierarchy. Atau bisa juga dengan klik Player dulu, lalu drag script PlayerController ke Inspector.

![image](https://user-images.githubusercontent.com/16128257/118541126-8ed33980-b77b-11eb-8af8-92a90a4f1aea.png)

- Menjelaskan bahwa Unity menggunakan bahasa C#

- Klik dua kali script PlayerController dan masukkan Code Player berikut untuk Code Input dan Jalan

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [Header("Properties")]
    [SerializeField] private SpriteRenderer graphic;

    [Header("Status")]
    public float health = 100;
    public float attack = 5;

    public bool canBeMoved = true;

    public float healthMax { private set; get; }

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;

    private Rigidbody2D rb2;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();        

        healthMax = health;
    }

    void Update()
    {
        if (canBeMoved)
        {
            MovementController();
        }
    }

    void MovementController()
    {
        float x = Input.GetAxisRaw("Horizontal");

        Vector2 direction = rb2.velocity;
        direction.x = x * moveSpeed;

        rb2.velocity = direction;

        //sprite dibalik ketika arahnya ke kiri
        if (direction.x < 0)
        {
            graphic.flipX = true;
        } else if (direction.x > 0)
        {
            graphic.flipX = false;
        }
    }
}
```

- Menjelaskan Awake, Start, Update, Input
- Menjelaskan Vector3 dan Vector2
- Menjelaskan private / public
- Menjelaskan attribute [Serilizeable]
- Menjelaskan GetComponent

- Assign Child Player (Graphic) pada Field Graphic Player Controller.

![image](https://user-images.githubusercontent.com/16128257/118540567-e624da00-b77a-11eb-855b-3fc8573ce65d.png)

- Coba Play dan test jalan dengan menggunakan Arrow Key kiri dan kanan. Gimana, Keren kan !?

![image](https://user-images.githubusercontent.com/16128257/118541420-d8238900-b77b-11eb-987b-57cb55448a0e.png)

### Membuat Fitur Player Menembak
- Buat GameObject baru dan beri nama Bullet lalu tambahkan child empty beri nama Graphic

![image](https://user-images.githubusercontent.com/16128257/118564897-665b3780-b79b-11eb-9220-497fe0abef23.png)

- Pada assets cari sprite Bullet dan ubah Pixel Per Unit menjadi 32 lalu Apply.

![image](https://user-images.githubusercontent.com/16128257/118565045-b1754a80-b79b-11eb-9508-d9ed14a4ccb1.png)

- Pada Graphic tambahkan component Sprite Renderer dan pada field sprite pilih sprite Bullet dan ubah scale transform menjadi `(0.4, 0.4, 0.4)`

![image](https://user-images.githubusercontent.com/16128257/118565813-0c5b7180-b79d-11eb-9d85-0a2363efb722.png)

- Pada GameObject Bullet tambahkan Rigidbody2D dan Circle Collider2D. Pada Rigidbody2D ubah Body Type menjadi Kinematik dan centang contraint Freeze Rotation Z. Pada Circle Collider2D sesuaikan ukuran dan letak circle collider dengan sprite bullet dan centang Is Trigger.

![image](https://user-images.githubusercontent.com/16128257/118566428-0a45e280-b79e-11eb-9c21-1e2a3fa78bf6.png)

- Menjelaskan Is Trigger.

- Buat Script untuk bullet dengan nama Bullet dan simpan pada folder Scripts. Lalu tambahkan component script Bullet ini pada GameObject Bullet.

![image](https://user-images.githubusercontent.com/16128257/118565486-732c5b00-b79c-11eb-8389-dd05616f359c.png)

- Membuat prefab GameObject Bullet dan simpan prefab Bullet pada folder Prefabs. Setelah itu hapus GameObject Bullet dari Hierarchy.

![image](https://user-images.githubusercontent.com/16128257/118565466-6871c600-b79c-11eb-8d89-fc198fc17437.png)

- Berikut adalah script untuk Bullet

```cs
using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private float damage = 2;
    [SerializeField] private float dieTime = 5;

    public string targetTag = "Enemy";

    private Vector2 direction;

    private Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2.velocity = direction.normalized * speed;

        dieTime -= Time.deltaTime;

        if (dieTime < 0)
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector2 direction, string targetTag, float speed, float damage)
    {
        this.direction = direction;
        this.speed = speed;
        this.damage = damage;
        this.targetTag = targetTag;
    }

    public float GetDamage()
    {
        return damage;
    }
}
```

- Menjelaskan kode bullet

- Pada Script PlayerController modifikasi agar player dapat melakukan shooting bullet

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [Header("Properties")]
    [SerializeField] private SpriteRenderer graphic;

    [Header("Status")]
    public float health = 100;
    public float attack = 5;

    public bool canBeMoved = true;

    public float healthMax { private set; get; }

    private bool isShooting = true;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;
    [SerializeField] private float shootingTimeMax = 1.0f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10;

    [SerializeField] private Vector2 gunOffset;

    private float shootingTime = 0;

    private Rigidbody2D rb2;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();

        shootingTime = shootingTimeMax;
        healthMax = health;
    }

    void Update()
    {
        if (canBeMoved)
        {
            MovementController();
            ShootController();
        }
    }

    void MovementController()
    {
        float x = Input.GetAxisRaw("Horizontal");

        Vector2 direction = rb2.velocity;
        direction.x = x * moveSpeed;

        rb2.velocity = direction;

        //sprite dibalik ketika arahnya ke kiri
        if (direction.x < 0)
        {
            graphic.flipX = true;
        } else if (direction.x > 0)
        {
            graphic.flipX = false;
        }
    }

    void ShootController()
    {
        isShooting = Input.GetKey(KeyCode.Z);

        if (isShooting)
        {
            shootingTime -= Time.deltaTime;
        } else
        {
            shootingTime = shootingTimeMax;
        }

        if (isShooting && shootingTime < 0)
        {
            shootingTime = shootingTimeMax;
            Shoot();
        }
    }

    void Shoot()
    {
        int direction = (graphic.flipX == false ? 1 : -1);

        Vector2 gunPos = new Vector2(gunOffset.x * direction + transform.position.x, gunOffset.y + transform.position.y);

        GameObject bulletObj = Instantiate(bulletPrefab, gunPos, Quaternion.identity);
        Bullet bullet = bulletObj.GetComponent<Bullet>();

        if (bullet)
        {
            bullet.Launch(new Vector2(direction, 0),"Enemy", bulletSpeed, attack);
        }
    }
}
```

- Assign prefab Bullet pada component PlayerController.

![image](https://user-images.githubusercontent.com/16128257/118565577-a2db6300-b79c-11eb-9028-bfb92b4120b2.png)

- Menjelaskan Intantiate.
 
- Menjelaskan Quaternion.

- Coba Test Play dan Tahan Z untuk melakukan shooting.

### Membuat Enemy
- Buat GameObject baru dan beri nama Mushroom lalu tambahkan child empty beri nama Graphic

![image](https://user-images.githubusercontent.com/16128257/118566847-d9b27880-b79e-11eb-9625-326371a21be5.png)

- Pada assets cari masuk ke Assets/Sprites/Mushroom dan ubah semua Pixel Per Unit dari sprites tersebut menjadi 32 lalu Apply.

![image](https://user-images.githubusercontent.com/16128257/118566920-06ff2680-b79f-11eb-898f-143142196221.png)

![image](https://user-images.githubusercontent.com/16128257/118566936-13837f00-b79f-11eb-887d-146dac706f0f.png)

- Pada Graphic tambahkan component Sprite Renderer dan pada field sprite pilih sprite mushroom_0 sebagai contoh.

![image](https://user-images.githubusercontent.com/16128257/118566974-27c77c00-b79f-11eb-928c-998447aebe53.png)

- Pada GameObject Mushroom tambahkan Rigidbody2D dan Box Collider2D. Pada Rigidbody2D centang contraint Freeze Rotation Z. Pada Box Collider2D sesuaikan ukuran dan letak box collider dengan sprite mushroom.

![image](https://user-images.githubusercontent.com/16128257/118567090-5e9d9200-b79f-11eb-8195-d6f7c05d63b9.png)

- Sebelum membuat code untuk Enemy. Buat tag untuk Player, Bullet dan Enemy dengan cara Klik Untagged lalu Add Tag.

![image](https://user-images.githubusercontent.com/16128257/118566744-a839ad00-b79e-11eb-90a4-f9bf6bf51d8a.png)

![image](https://user-images.githubusercontent.com/16128257/118566793-c0113100-b79e-11eb-86d0-5ef18ee05219.png)

- Jangan lupa untuk mengganti tag Mushroom ke tag Enemy

![image](https://user-images.githubusercontent.com/16128257/118567155-7b39ca00-b79f-11eb-9da8-998d8124418d.png)

- Tambahkan juga tag Bullet pada Bullet dan tag Player pada Player

![image](https://user-images.githubusercontent.com/16128257/118567225-99072f00-b79f-11eb-94df-6b08803e75ff.png)

![image](https://user-images.githubusercontent.com/16128257/118567281-b50ad080-b79f-11eb-9fd2-c43d36888035.png)

- Menjelaskan Tag

- Jelasin bahwa tag player udah default

- Buat Script baru dan beri nama EnemyController.

![image](https://user-images.githubusercontent.com/16128257/118567438-fef3b680-b79f-11eb-8424-6c8f8808ce24.png)

- Berikut adalah code untuk EnemyController.

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Status")]
    public float health = 20;
    public float attack = 5;

    public Transform attackTarget;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;

    void Update()
    {
        Movement();

        FallDie();
    }

    protected virtual void Movement()
    {

    }

    public void DamagedBy(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    void FallDie()
    {
        if (transform.position.y < -20)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public float GetAttackDamage()
    {
        return attack;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Bullet bullet = collision.GetComponent<Bullet>();
            if (bullet.targetTag == "Enemy")
            {
                float damage = bullet.GetDamage();
                DamagedBy(damage);
                Destroy(collision.gameObject);
            }
        }
    }
}
```

- Menjelaskan OnTriggerEnter
- Menjelaskan OnCollisionEnter

- Code EnemyController akan digunakan sebagai parent class dari enemy yang akan kita buat. Jadi untuk menambah enemy baru kita dapat melakukan inherit pada Class EnemyController ini.

### Membuat Enemy Mushroom
- Buat Script baru dan beri nama EnemyMushroom

![image](https://user-images.githubusercontent.com/16128257/118567680-6e69a600-b7a0-11eb-9187-4f17703a88a2.png)

- Berikut adalah code script EnemyMushroom yang merupakan child class dari EnemyController.

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMushroom : EnemyController
{
    [Header("Mushroom")]
    [SerializeField] SpriteRenderer graphic;

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;

    [SerializeField] private float attackMinDistance;
    [SerializeField] private float attackTimeMax;

    [SerializeField] private Vector3 shootOffset;
    private float attackTime = 0;

    protected override void Movement()
    {
        if (attackTarget)
        {
            float distance = Vector2.Distance(transform.position, attackTarget.position);
            if (distance < attackMinDistance)
            {
                if (attackTarget.position.x < transform.position.x)
                {
                    graphic.flipX = true;
                } else
                {
                    graphic.flipX = false;
                }

                if (attackTime < 0)
                {
                    Shoot();
                    attackTime = attackTimeMax;
                }

                attackTime -= Time.deltaTime;
            }
        }
    }

    void Shoot()
    {
        int direction = (graphic.flipX == false ? 1 : -1);

        Vector3 shootOffsetDirection = shootOffset;

        if (direction < 0)
        {
            shootOffsetDirection.x *= -1;
        }

        Vector3 shootPos = transform.position + shootOffsetDirection;

        GameObject bulletObj = Instantiate(bulletPrefab, shootPos, Quaternion.identity);
        Bullet bullet = bulletObj.GetComponent<Bullet>();
        bullet.Launch(new Vector2(direction, 0), "Player", bulletSpeed, attack);
    }
}
```

- Tambahkan Component EnemyMushroom pada GameObject Mushroom. Isi field graphic dengan child Graphic pada Mushroom dan Attack Target isi dengan Game Object Player.

![image](https://user-images.githubusercontent.com/16128257/118568030-21d29a80-b7a1-11eb-90ab-40ce8766bf6c.png)

- Karena mushroom menyerang dengan cara shooting bullet juga maka kita lakukan duplicate pada prefab Bullet dan ganti namanya menjadi EnemyBullet lalu ubah warnanya menjadi merah.

![image](https://user-images.githubusercontent.com/16128257/118567908-dcae6880-b7a0-11eb-8f5b-ebd429990cc7.png)

![image](https://user-images.githubusercontent.com/16128257/118567930-eb951b00-b7a0-11eb-92c1-5f2a1c9f72d7.png)

- Assign bullet pada component EnemyMushroom sebelumnya dengan EnemyBullet.

![image](https://user-images.githubusercontent.com/16128257/118568030-21d29a80-b7a1-11eb-90ab-40ce8766bf6c.png)

- Membuat Prefab untuk Enemy Mushroom

![image](https://user-images.githubusercontent.com/16128257/118568139-63634580-b7a1-11eb-9708-84debc997102.png)

### Membuat Fitur Player Loncat

- Sebelum membuat fitur loncat, pada setiap GameObject tanah yang memiliki collider pada Environment, ubah layer nya menjadi Obstacle. Jika belum ada tambahkan dengan Add Layer.

![image](https://user-images.githubusercontent.com/16128257/118568698-93f7af00-b7a2-11eb-9dbb-92675215f3d4.png)

![image](https://user-images.githubusercontent.com/16128257/118568719-9eb24400-b7a2-11eb-94c9-6cba9dee9812.png)

- Setelah itu modifikasi Script PlayerController sebagai berikut.

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [Header("Properties")]
    [SerializeField] private SpriteRenderer graphic;

    [Header("Status")]
    public float health = 100;
    public float attack = 5;

    public bool canBeMoved = true;

    public float healthMax { private set; get; }

    private bool isGrounded = true;
    private bool isShooting = true;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float shootingTimeMax = 1.0f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10;

    [SerializeField] private Vector2 gunOffset;

    private float shootingTime = 0;

    [SerializeField] private float minGroundDistance = 1.5f;

    private Rigidbody2D rb2;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();

        shootingTime = shootingTimeMax;
        healthMax = health;
    }

    void Update()
    {
        if (canBeMoved)
        {
            MovementController();
            JumpController();
            ShootController();
        }

        FallDie();
    }

    void MovementController()
    {
        float x = Input.GetAxisRaw("Horizontal");

        Vector2 direction = rb2.velocity;
        direction.x = x * moveSpeed;

        rb2.velocity = direction;

        //sprite dibalik ketika arahnya ke kiri
        if (direction.x < 0)
        {
            graphic.flipX = true;
        } else if (direction.x > 0)
        {
            graphic.flipX = false;
        }
    }

    void JumpController()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.down, 10, (1 << 3));
        
        if (ray && ray.distance < minGroundDistance)
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (isGrounded)
        {
            rb2.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void ShootController()
    {
        isShooting = Input.GetKey(KeyCode.Z);

        if (isShooting)
        {
            shootingTime -= Time.deltaTime;
        } else
        {
            shootingTime = shootingTimeMax;
        }

        if (isShooting && shootingTime < 0)
        {
            shootingTime = shootingTimeMax;
            Shoot();
        }
    }

    void Shoot()
    {
        int direction = (graphic.flipX == false ? 1 : -1);

        Vector2 gunPos = new Vector2(gunOffset.x * direction + transform.position.x, gunOffset.y + transform.position.y);

        GameObject bulletObj = Instantiate(bulletPrefab, gunPos, Quaternion.identity);
        Bullet bullet = bulletObj.GetComponent<Bullet>();

        if (bullet)
        {
            bullet.Launch(new Vector2(direction, 0),"Enemy", bulletSpeed, attack);
        }
    }
}
```

- Menjelaskan Raycast
- Menjelaskan Raycast Hit
- Menjelaskan Layer
- Menjelaskan Layer Mask

- Coba Play Test lalu tekan Up Arrow untuk loncat dengan Player.

### Membuat Fitur Player mati
- Setiap kali player terkena bullet dari Enemy atau player menyentuh Enemy atau ketika player jatuh, kita dapat menambahkan fitur agar Player bisa mati sehingga level akan di restart. Untuk itu modifikasi PlayerController sebagai berikut.

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [Header("Properties")]
    [SerializeField] private SpriteRenderer graphic;

    [Header("Status")]
    public float health = 100;
    public float attack = 5;

    public bool canBeMoved = true;

    public float healthMax { private set; get; }

    private bool isGrounded = true;
    private bool isShooting = true;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float shootingTimeMax = 1.0f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10;

    [SerializeField] private Vector2 gunOffset;

    private float shootingTime = 0;

    [SerializeField] private float minGroundDistance = 1.5f;

    private Rigidbody2D rb2;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();

        shootingTime = shootingTimeMax;
        healthMax = health;
    }

    void Update()
    {
        if (canBeMoved)
        {
            MovementController();
            JumpController();
            ShootController();            
        }

        FallDie();
    }

    void MovementController()
    {
        float x = Input.GetAxisRaw("Horizontal");

        Vector2 direction = rb2.velocity;
        direction.x = x * moveSpeed;

        rb2.velocity = direction;

        //sprite dibalik ketika arahnya ke kiri
        if (direction.x < 0)
        {
            graphic.flipX = true;
        } else if (direction.x > 0)
        {
            graphic.flipX = false;
        }
    }

    void JumpController()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.down, 10, (1 << 3));
        
        if (ray && ray.distance < minGroundDistance)
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (isGrounded)
        {
            rb2.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void ShootController()
    {
        isShooting = Input.GetKey(KeyCode.Z);

        if (isShooting)
        {
            shootingTime -= Time.deltaTime;
        } else
        {
            shootingTime = shootingTimeMax;
        }

        if (isShooting && shootingTime < 0)
        {
            shootingTime = shootingTimeMax;
            Shoot();
        }
    }

    void Shoot()
    {
        int direction = (graphic.flipX == false ? 1 : -1);

        Vector2 gunPos = new Vector2(gunOffset.x * direction + transform.position.x, gunOffset.y + transform.position.y);

        GameObject bulletObj = Instantiate(bulletPrefab, gunPos, Quaternion.identity);
        Bullet bullet = bulletObj.GetComponent<Bullet>();

        if (bullet)
        {
            bullet.Launch(new Vector2(direction, 0),"Enemy", bulletSpeed, attack);
        }
    }

    public void DamagedBy(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    void FallDie()
    {
        if (transform.position.y < -20)
        {
            Die();
        }
    }

    void Die()
    {
        graphic.enabled = false;
        canBeMoved = false;
        GameManager.GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            float damage = collision.collider.GetComponent<EnemyController>().GetAttackDamage();
            DamagedBy(damage);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Bullet bullet = collision.GetComponent<Bullet>();
            if (bullet.targetTag == "Player")
            {
                float damage = bullet.GetDamage();
                DamagedBy(damage);
                Destroy(collision.gameObject);
            }
        }
    }
}
```

### Membuat Camera Follow
- Menjelaskan Camera

![image](https://user-images.githubusercontent.com/16128257/118585720-aa623280-b7c3-11eb-915c-a89b8b20af56.png)

- Menjelaskan Background Camera / Clear Flags, ganti menjadi Solid Color

![image](https://user-images.githubusercontent.com/16128257/118585791-cd8ce200-b7c3-11eb-9e28-eb11bd8ebd88.png)

- Mengubah warna Background Camera, coba ubah warna background camera menjadi #03071C

![image](https://user-images.githubusercontent.com/16128257/118585875-f0b79180-b7c3-11eb-8389-1b705ff5af3b.png)

- Membuat code camera follow

- Buat Script baru di folder Scripts dengan nama CameraFollow

![image](https://user-images.githubusercontent.com/16128257/118585939-0dec6000-b7c4-11eb-94c3-cc605504a908.png)

- Berikut adalah kode script untuk CameraFollow

```cs
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public bool isFollowing = true;
    public Transform target;

    private Vector3 targetPos;
    public Vector3 targetOffset;

    [Range(0, 1.0f)] public float followRatio = 1.0f;

    void Update()
    {
        if (target)
        {
            if (isFollowing)
            {
                targetPos = target.position + targetOffset;
            }

            Vector3 newPos = Vector3.Lerp(transform.position, targetPos, followRatio);
            newPos.z = transform.position.z;

            transform.position = newPos;
        }
    }
}
```

- Menjelaskan Attribute Range
- Menjelaskan Lerp

- Tambahkan component script CameraFollow pada Game Object Main Camera

![image](https://user-images.githubusercontent.com/16128257/118586123-5f94ea80-b7c4-11eb-9f95-8b38579ca3fd.png)

- Assign Player pada field Target dan isi field yang lain sesuai kebutuhan

![image](https://user-images.githubusercontent.com/16128257/118586192-7c312280-b7c4-11eb-9940-6ce22bd77f53.png)

## H. Membuat GameMaster yang mengontrol sebagian besar Game
### Membuat GameManager
- Menjelaskan SceneManagement
- Menjelaskan ActiveScene
- Menjelaskan LoadScene
- Menjelaskan buildIndex
- Menjelaskan Singleton
- Membuat Code GameManager

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver { get; private set; }
    public static bool isLevelComplete { get; private set; }

    private void Awake()
    {
        isGameOver = false;
        isLevelComplete = false;
    }

    private void Update()
    {
        if (isLevelComplete)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextLevel();
            }
        }
        else if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RetryGame();
            }
        }
    }

    public static void GameOver()
    {
        isGameOver = true;
    }

    public static void CompleteLevel()
    {
        isLevelComplete = true;
    }

    public static void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
```

### Membuat ScoreManager
- Menjelaskan Singleton
- Membuat Code ScoreManager

```cs
using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public static int currentEnemyProgress { get; private set; }
    public static int targetEnemyProgress { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        EnemyController[] enemyControllers = FindObjectsOfType<EnemyController>();

        targetEnemyProgress = enemyControllers.Length;
        currentEnemyProgress = 0;
    }

    public static void DefeatEnemy()
    {
        currentEnemyProgress += 1;

        if (currentEnemyProgress >= targetEnemyProgress)
        {
            GameManager.CompleteLevel();
        }
    }
}
```

### Membuat Game Master

- Buat GameObject Empty baru, lalu tambahkan component GameManager dan ScoreManager

![image](https://user-images.githubusercontent.com/16128257/118587202-645a9e00-b7c6-11eb-978f-8b2327245104.png)

## I. Membuat UI untuk memperindah Game
### Membuat UI
- Menjelaskan UI

- Buat GameObject Canvas untuk UI

![image](https://user-images.githubusercontent.com/16128257/118587422-c74c3500-b7c6-11eb-8cd7-2cb815949a67.png)

- Menjelaskan Canvas

- Select GameObject Canvas dan ubah konfigurasi component Canvas dan Canvas Scaler sebagai berikut.

![image](https://user-images.githubusercontent.com/16128257/118587458-d6cb7e00-b7c6-11eb-954b-4c5f7868ed3c.png)

- Menjelaskan CanvasScaler

- Menjelaskan Image UI

- Menjelaskan Text UI

### Membuat Healthbar Player
- Pada Project Assets masuk ke folder UI, ubah semua Pixels Per Unit sprite menjadi 32.

![image](https://user-images.githubusercontent.com/16128257/118587662-345fca80-b7c7-11eb-9881-502faaaadb98.png)

![image](https://user-images.githubusercontent.com/16128257/118587689-3de93280-b7c7-11eb-8aca-fab5acc3f9f3.png)

- Pada Hierarchy, klik kanan pada Canvas lalu Create Empty. Beri nama child tersebut menjadi Healthbar

![image](https://user-images.githubusercontent.com/16128257/118587827-6ffa9480-b7c7-11eb-8bac-4d4093dd9c23.png)

- Klik kanan lagi pada Healthbar, lalu pilih UI > Image. Lakukan sebanyak 3 kali karena masing - masing untuk Healthbar Bg, Healthbar Border, Healthbar sebelumnya.

![image](https://user-images.githubusercontent.com/16128257/118587940-aafcc800-b7c7-11eb-928e-edfc282ad4aa.png)

- Menjelaskan Sorting order pada canvas

- Untuk masing - masing Image UI tersebut, assign sprite yang sesuai. Sesuaikan konfigurasinya seperti berikut agar healthbar terlihat rapi dan bagus.

![image](https://user-images.githubusercontent.com/16128257/118588013-c962c380-b7c7-11eb-9659-dfa2a577d00f.png)

![image](https://user-images.githubusercontent.com/16128257/118588028-d1226800-b7c7-11eb-86f5-3baf84ec275c.png)

![image](https://user-images.githubusercontent.com/16128257/118588042-db446680-b7c7-11eb-99b6-23cb93050f01.png)

- Berikut adalah hasil sementara dari Healthbar UI.

![image](https://user-images.githubusercontent.com/16128257/118588274-3f672a80-b7c8-11eb-9a3a-50e21805cb84.png)

### Membuat Score UI

- Pada Hierarchy, klik kanan pada Canvas lalu Create Empty. Beri nama child tersebut menjadi EnemyProgress

![image](https://user-images.githubusercontent.com/16128257/118588595-e350d600-b7c8-11eb-85ce-ad59fc3de043.png)

- Klik kanan lagi pada EnemyProgress, lalu pilih UI > Text. Beri nama Text tersebut menjadi ProgressText. UI Text ini untuk melakukan track pada score Player.

![image](https://user-images.githubusercontent.com/16128257/118588836-670ac280-b7c9-11eb-9709-368533e751b3.png)

- Menjelaskan UI Text

- Pada Component Text, ubah Text menjadi "4 of 10" sebagai contoh. Lalu ubah juga Font Size, Horizontal Overflow dan Vertical Overflow nya.

![image](https://user-images.githubusercontent.com/16128257/118588874-7853cf00-b7c9-11eb-8b2f-6e2f566d136a.png)

- Klik kanan lagi pada EnemyProgress, lalu pilih UI > Image. Beri nama Image tersebut menjadi ProgressCover. Image UI ini digunakan untuk hiasan score saja.

![image](https://user-images.githubusercontent.com/16128257/118589021-bd780100-b7c9-11eb-9e44-a0637ba18838.png)

- Berikut adalah tampilan sementara dari GameObject EnemyProgress.

![image](https://user-images.githubusercontent.com/16128257/118589057-d1236780-b7c9-11eb-977f-b7d56382b3f0.png)

### Membuat Tampilan Game Over
- Pada Canvas, buat UI > Image dan beri nama GameOver untuk membuat vignette. Ubah warnanya menjadi hitam dan alpha yang tipis.

![image](https://user-images.githubusercontent.com/16128257/118590230-3710ee80-b7cc-11eb-99bd-4b188e781172.png)

- Lalu pada GameObject GameOver tambahkan child text untuk tulisan "Game Over" dan "Press Space to Retry Level".

![image](https://user-images.githubusercontent.com/16128257/118590398-91aa4a80-b7cc-11eb-9c2a-36caf48c7acd.png)

![image](https://user-images.githubusercontent.com/16128257/118590360-7d664d80-b7cc-11eb-8144-154212ee7279.png)

![image](https://user-images.githubusercontent.com/16128257/118590308-6162ac00-b7cc-11eb-82d4-2d1ed309499a.png)

- Berikut adalah tampilan sementara dari GameOver.

![image](https://user-images.githubusercontent.com/16128257/118590462-af77af80-b7cc-11eb-9131-16159458006b.png)

- Lalu Disable GameOver, karena kita ingin GameOver ditampilkan saat Game Over saja.

![image](https://user-images.githubusercontent.com/16128257/118590501-c3bbac80-b7cc-11eb-974f-170edd65c44b.png)

### Membuat Tampilan Level Complete

- Duplicate UI GameOver dan ganti namanya menjadi LevelComplete

![image](https://user-images.githubusercontent.com/16128257/118590606-eea60080-b7cc-11eb-96be-d063c184e58c.png)

- Edit tulisan seperti yang diinginkan sehingga tampilan LevelComplete adalah sebagai berikut.

![image](https://user-images.githubusercontent.com/16128257/118590650-08474800-b7cd-11eb-9585-8d872eb86a0c.png)

- Disable juga LevelComplete, karena kita ingin LevelComplete ditampilkan saat Level berhasil dimenangkan saja.

![image](https://user-images.githubusercontent.com/16128257/118590697-2614ad00-b7cd-11eb-9bae-6208c3a3bf5a.png)

### Membuat UIManager

- Agar UI dapat berubah seiring dengan Game dimainkan maka perlu sebuah script untuk mengatur UI tersebut.

- Buat script baru pada folder Scripts dan beri nama menjadi UIManager.

![image](https://user-images.githubusercontent.com/16128257/118589305-5018a000-b7ca-11eb-815e-d5f11365f5a2.png)

- Berikut adalah code untuk UIManager

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text enemyProgressText;
    public Image playerHealthBar;
    public float playerHealthBarFullX = 78;

    public GameObject gameOverUI;
    public GameObject levelCompleteUI;

    public PlayerController player;

    void Update()
    {
        if (enemyProgressText)
        {
            enemyProgressText.text = ScoreManager.currentEnemyProgress + " of " + ScoreManager.targetEnemyProgress;
        }

        if (playerHealthBar)
        {
            Vector2 size = playerHealthBar.rectTransform.sizeDelta;
            size.x = player.health / player.healthMax * playerHealthBarFullX;

            playerHealthBar.rectTransform.sizeDelta = size;
        }

        if (levelCompleteUI && GameManager.isLevelComplete)
        {
            levelCompleteUI.SetActive(GameManager.isLevelComplete);
        } else if (gameOverUI && GameManager.isGameOver)
        {
            gameOverUI.SetActive(GameManager.isGameOver);
        }
    }
}
```

- Menjelaskan mengganti text dari code

- Menggabungkan dengan GameManager dan ScoreManager

- Kemudian tambahkan component UIManager pada GameObject GameMaster. Isi konfigurasi UI seperti berikut ini.

![image](https://user-images.githubusercontent.com/16128257/118589417-8bb36a00-b7ca-11eb-8cf0-71fff3bfb3d6.png)

## J. Membuat Scene Baru Agar Game Lebih Menyenangkan
### Pengenalan pada Build Settings
- Menjelaskan SceneManagement
- Menjelaskan Build Settings
- Pilih File > Build Settings pada Menu Bar untuk membuka Build Settings

![image](https://user-images.githubusercontent.com/16128257/118634741-157c2b00-b7fd-11eb-95df-ad6256d0faef.png)

![image](https://user-images.githubusercontent.com/16128257/118634822-29279180-b7fd-11eb-956d-53645b1d6d4f.png)

- Saat ini hanya ada 1 scene, jika belum ada maka tambahkan dengan menekan tombol **Add Open Scenes**

![image](https://user-images.githubusercontent.com/16128257/118634977-4e1c0480-b7fd-11eb-8d39-d0d8fcfc6d94.png)

- Menjelaskan buildIndex

### Membuat Scene Baru
- Pada Project Window folder Scenes rename Scene sekarang menjadi "Level 1"

![image](https://user-images.githubusercontent.com/16128257/118637291-d26f8700-b7ff-11eb-8722-73fcb6b8631b.png)

- Kemudian, lelakukan Duplicate Scene dari Scene Level 1 dengan Ctrl + D lalu ubah namanya menjadi Level 2. Hal ini dapat diulangi untuk membuat level - level selanjutnya.

![image](https://user-images.githubusercontent.com/16128257/118637392-f03cec00-b7ff-11eb-99f3-81148e71ccec.png)

- Buka Scene Level 2 dan memodifikasi Scene tersebut. Sebagai contoh tambahkan enemy yang lebih banyak dari Level 1.

![image](https://user-images.githubusercontent.com/16128257/118639161-cc7aa580-b801-11eb-8a09-a4b79fa6f2f9.png)

- Menambah scene pada build

![image](https://user-images.githubusercontent.com/16128257/118639234-def4df00-b801-11eb-9628-773adfd1e9fa.png)

- Buat Scene Baru lagi dan coba buat tampilan seperti berikut. Beri nama scene tersebut End atau EndLevel.

![image](https://user-images.githubusercontent.com/16128257/118639479-27ac9800-b802-11eb-9633-aaa798c6c295.png)

- Kemudian tambahkan scene ini pada build

![image](https://user-images.githubusercontent.com/16128257/118639575-43b03980-b802-11eb-8b69-3fb2b5d4aa98.png)

- Coba Play Game dari scene Level 1 dan mainkan game mu.

## K. Build Game agar game dapat Dimainkan!
### Pengenalan Platform
- Menjelaskan platform apa aja yang bisa digunakan

![image](https://user-images.githubusercontent.com/16128257/118639663-56c30980-b802-11eb-8816-db716b1c59f5.png)

### Pengenalan Player Settings
- Menjelaskan Cara export

- Melakukan Build untuk Windows. Klik **Build** bukan yang **Build and Run**

![image](https://user-images.githubusercontent.com/16128257/118639840-883bd500-b802-11eb-812b-36fb288ce982.png)

- Pilih lokasi build, disarankan folder kosong.

![image](https://user-images.githubusercontent.com/16128257/118640386-1adc7400-b803-11eb-9943-a9f60bef1143.png)

- Tunggu hingga proses build selesai. Lalu coba Play Executable.

![image](https://user-images.githubusercontent.com/16128257/118640185-e1a40400-b802-11eb-800b-4611c7dc1f1b.png)

## L. Selesai !!
### Game dapat dimainkan

![Gameplay-Overview](/Images/Gameplay-Overview.gif)

## M. Extra!! Menambahkan Animasi
### Pengenalan Animasi
- Menjelaskan Animator
- Menjelaskan Animation
- Menjelaskan Transition
- Menjelaskan Loop
- Menjelaskan Parameter
- Melakukan code pada Player dan Enemy karena memiliki Animasi
- Mencoba test
- Selesai

## N. Penutup
Terima Kasih telah ditutup.

## O. Terima Kasih
sip
