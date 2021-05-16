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
- Menjelaskan Sprite Slicing
- Menjelaskan Sprite Tiling pada Sprite Renderer
- jadikan gambar ke 32 pixel, slice level, pilih tile nomer (?) lupa heheh

### Membuat Level
- bikin empty level desain sederhana, bikin graphic, jadikan gambar ke 32 pixel
- Menjelaskan tentang sprite order

### Menambahkan Physics
- Menjelaskan physics2D
- Pada player menambahkan RigidBody2D
- Pada player menambahkan Capsule Collider2D
- Pada environment menambahkan Box Collider2D pada tanah

### Membuat Prefab untuk Player
- Menjelaskan prefabs

## G. Membuat Entitas pada Game
### Membuat Code Player
- Menjelaskan bahasa C#
- Menjelaskan Awake, Start, Update, Input
- Menjelaskan Vector3 dan Vector2
- Menjelaskan private / public
- Menjelaskan attribute [Serilizeable]
- Menjelaskan GetComponent
- Bisa Jalan dulu
- List code ada disini nanti

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
