# Data Structure - Warm Up

## Capaian Pembelajaran

1. Mahasiswa mampu menggunakan git untuk mengerjakan soal-soal yang diberikan.
2. Mahasiswa mampu mengeksekusi unit test untuk memvalidasi solusi.

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `ds-warmup` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

### Soal: Manajemen Kontak dengan Array di C#

Buat solusi dari soal ini di project `Warmup` folder `ManajemenKontak` dengan namespace `Warmup.ManajemenKontak`.

Anda diminta untuk membuat aplikasi sederhana untuk manajemen kontak menggunakan array di C#. Aplikasi ini harus memungkinkan pengguna untuk menambahkan, menghapus, dan mencari kontak berdasarkan nama. Setiap kontak akan memiliki nama dan nomor telepon sebagai informasi yang disimpan.

Langkah-langkah:

1. **Kelas Kontak**: Buat kelas publik `Kontak` yang memiliki dua properti publik: `Nama` (string) dan `NomorTelepon` (string). Kelas ini akan merepresentasikan setiap kontak dalam daftar kontak. Sediakan konstruktor yang menginisialisasi kedua properti tersebut.

2. **Manajemen Kontak**: Buat kelas publik `BukuKontak` yang menggunakan array untuk menyimpan objek `Kontak`. Buat metode konstruktor yang menerima input parameter `kapasitas` (int). Parameter kapasitas ini akan menentukan jumlah kontak yang bisa disimpan.

3. **Tambah Kontak**: Buat fungsi `TambahKontak` yang menerima parameter `kontak` (objek `Kontak`) dan menambahkannya ke dalam array. Jika berhasil menambahkan kontak, kembalikan nilai true. Jika array sudah penuh, kembalikan nilai false. 

4. **Hapus Kontak**: Buat fungsi `HapusKontak` yang menerima parameter `nama` (string) dan menghapus kontak dengan nama tersebut dari array. Jika kontak dengan nama tersebut tidak ditemukan, kembalikan nilai false. Jika berhasil dihapus kembalikan nilai true.

5. **Cari Kontak**: Buat fungsi `CariKontak` yang menerima parameter `nama` (string) dan mengembalikan objek bertipe `Kontak?` dan mencari kontak dengan nama tersebut dalam array. Jika ditemukan, kembalikan objek bertipe `Kontak`. Jika tidak ditemukan kembalikan nilai `null`.

6. **Tampilkan Semua Kontak**: Buat fungsi `TampilkanSemuaKontak` yang menampilkan daftar semua kontak dalam array dengan format sebagai berikut:

```
Alisa, 081233445566
Boby, 0812324252
```

7. Buat kelas `Program` yang berisi `Main` method. Di dalam `Main` method buat objek dari `BukuKontak` dan demonstrasikan setiap fungsi yang telah Anda implementasikan.

#### Contoh Output:

```
Menambahkan kontak baru: Alice, 123-456-7890
Menambahkan kontak baru: Bob, 098-765-4321
Menampilkan semua kontak:
1. Alice, 123-456-7890
2. Bob, 098-765-4321
Mencari kontak 'Alice'...
Kontak ditemukan: Alice, 123-456-7890
Menghapus kontak 'Alice'...
Menampilkan semua kontak:
1. Bob, 098-765-4321
```