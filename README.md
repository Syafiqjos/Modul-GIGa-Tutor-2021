# Maydua2
Concept context smh

benakno konsep game apa dan gimana,
benakno timeline / rundown modul,
benakno level design,
benakno asset sprite yang dipake,
benakno kode script,
bikin game,
coba build.

ide : cuphead / unlucid
assets : harambert/unlucid_git
berjalan pake keyboard wasd, nembak pake arrow up down left right

- Overview
- Pengenalan Unity Engine
- Pengenalan inspector, project asset, hierarchy, gameobject
- Bikin sprite slice
- Bikin player
- Bikin player moveable / playable
- Bikin level desain contoh
- Bikin level gerak
- Pengenalan debug log untuk score
- Bikin coin
- Bikin pickupable coin
- Bikin UI coin
- Scene management
- Bikin main menu sederhana
- Benerin scene
- Build
- Selesai

## Step :
- Import assets
- Setting up assets
- Split sprite jika ada multiple untuk tileset
- Asset sprite Normalin jadi pixels per unit 32
- Bikin prefabs
- Bikin Code Program
- Play Test : jalan jalan

- Bikin animations (jalan, lompat) (optional nembak)
- Code Animasi
- Play Test : test animasi

- Bikin desain level simple
- Code finish, kalo ngelewati ini menang
- Play Test : finish game

- Code camera follow player
- Play Test : Camera bisa follow player

- Code Enemy tambahi enemy
- Code player bisa nembak enemy
- Jadikan prefab sama taruh di scene enemy - nya
- Play Test : Jalan kill enemy sampe finish

- Code Score Manager
- Code UI untuk healthbar
- Code UI score progress kill musuh
- Play Test : check UI dan score

- Code Scene Management
- Bikin Game Over
- Bikin Level Complete
- Play Test : Kalo kalah restart, kalo menang lanjut level selanjutnya (untuk sementara gaperlu ada main menu)

- Duplicate level 1 atau bikin level 2 baru
- Bikin Scene Tamat
- Play Test : next next gameplay

- Build Game

- Finish

## Core yang di pelajari
- Unity
- Inspector
- Scene View
- Game View
- Project Asset
- Component
- Hierarchy
- Physics2D (sebagai physics bawaan Unity)
- Rigidbody2D (velocity, AddForce)
- Collider2D
- Prefab
- Tag (Player, Enemy, Bullet)
- Sprite LayerOrder (Untuk Environment)
- Layer (hanya untuk check enemy player dan obstacle saat layer mask)
- Raycast dan RaycastHit (hanya untuk check ground)
- Animator (Player dan Mushroom Enemy)
- Animation (Parameter, transition) (Untuk Player ada Idle, Jump, Run Shoot. Untuk Mushroom hanya Idle)
- Camera
- Camera Follow (script)
- Scripts dengan C#
- Awake
- Start
- Update
- Destroy
- Input, Input Axis (horizontal dan vertical), Input Key
- OnTriggerEnter2D
- OnCollisionEnter2D
- Singleton (GameManager, ScoreManager)
- Instantiate
- Transform, GameObject, Vector3, Vector2, Quaternion.identity, FindObjectsOfType (menghitung jumlah enemy)
- UI, Canvas, CanvasScaler, RectTransform, Image, Text
- SceneManagement (LoadScene dan buildIndex dan Add Current di build)
- Build Game (biar bisa tau gamenya siap diexport buat dimainkan)

## Core yang masih diabaikan, alasan waktu terbatas dan sebagainya
- Audio / Sound
- UI Input, (Scene Main Menu)
- Physics Material
- Material / Shader (gatau butuh nggak, since game 2D)
- Sprite slicing (since dari sumber, sprite udah terlanjur dipotong)
- Order Group (karena akan agak membengungkan, jadi pake default dulu aja)
- Bikin variasi enemy lain (frog, bakal lama karena untuk bikin enemy mushroom udah habis banyak)
- Untuk Enemy yang attackTarget di manual dulu, karena kalau pake FindObjectWithTag nanti lebih ke hafalan dari pada ke pemahaman
- Explorasi PlayerSettings ketika Build Game

## Ide saat Eksekusi
- Ada Ice Breaking tiap sesi nya (misal pas bikin player bisa loncat, kita main - main dengan parameter sehingga loncat nya ketinggian)
- Ada Alokasi waktu untuk kesalahan teknis untuk cadangan waktu kalo ada hal tidak diinginkan terjadi

## Proses bikin modul xixixi