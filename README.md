# GiGa Tutor 2021
## Shooting-Platformer 2D Unity Tutorial

[Gameplay-Overview](/Images/Gameplay-Overview.gif)

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
- Membuat prefab bullet
- Menjelaskan Intantiate
- Menjelaskan Quaternion
- Memodifikasi code Player

### Membuat Enemy
- Membuat Code Enemy
- Menjelaskan OnTriggerEnter
- Menjelaskan OnCollisionEnter

### Membuat Enemy Mushroom
- Membuat Code Enemy Mushroom yang nge inherit Enemy
- Membuat Prefab untuk Enemy Mushroom

### Membuat Fitur Player Loncat
- Menjelaskan Raycast
- Menjelaskan Raycast Hit
- Menjelaskan Layer
- Menjelaskan Layer Mask
- Menambah layer pada Bullet, Player dan Enemy
- Membuat Code Player Loncat

### Membuat Camera Follow
- Menjelaskan Camera
- Menjelaskan Background Camera
- Mengubah warna Background Camera
- Membuat code camera follow
- Menjelaskan Lerp

## H. Membuat GameMaster yang mengontrol sebagian besar Game
### Membuat GameManager
- Menjelaskan Singleton
- Membuat Code GameManager

### Membuat ScoreManager
- Menjelaskan Singleton
- Membuat Code ScoreManager

## I. Membuat UI untuk memperindah Game
### Membuat UI
- Menjelaskan UI
- Menjelaskan Canvas
- Menjelaskan CanvasScaler
- Mengubah CanvasScaler
- Menjelaskan Image UI
- Menjelaskan Text UI

### Membuat Healthbar Player
- Mengatur sprite dan UI
- Membuat UI

### Membuat Score UI
- Mengatur sprite dan UI
- Membuat UI

### Membuat UIManager
- Membuat Code
- Menggabungkan dengan GameManager dan ScoreManager
- Menjelaskan mengganti text dari code

## J. Membuat Scene Baru Agar Game Lebih Menyenangkan
### Pengenalan pada Build Settings
- Menjelaskan SceneManagement
- Menjelaskan ActiveScene
- Menjelaskan LoadScene
- Menjelaskan buildIndex

### Membuat Scene Baru
- Melakukan Duplicate Scene
- Memodifikasi Scene
- Menambah scene pada build

## K. Build Game agar game dapat Dimainkan!
### Pengenalan Platform
- Menjelaskan platform apa aja yang bisa digunakan
### Pengenalan Player Settings
- Menjelaskan Cara export
- Melakukan Build

## L. Selesai !!
### Game dapat dimainkan

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
