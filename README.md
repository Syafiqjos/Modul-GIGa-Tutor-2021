# GiGa Tutor 2021

## A. Pendahuluan
Unity adalah gem enjin.

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
- Menjelaskan Scene View
- Menjelaskan Project
- Menjelaskan Scene
### Game View
- Menjelaskan Game View
### Project Window
- Menjelaskan Project Window
### Hierarchy
- Menjelaskan Hierarchy
### Inspector
- Menjelaskan Inspector
- Menjelaskan GameObject
- Menjelaskan Transform

## E. Import Assets
- extract zip terus taruh di project folder assets,
- check assets yang telah diimport

## F. Pengenalan GameObject pada Unity
### Membuat Player
- Menjelaskan Sprite Renderer
- bikin empty player, bikin graphic, jadikan gambar ke 32 pixel

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