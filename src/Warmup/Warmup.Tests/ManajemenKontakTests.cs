namespace Warmup.Tests;

using Warmup.ManajemenKontak;

[TestClass]
public class ManajemenKontakTests
{

    [TestMethod]
    public void Kontak_PropertiKontak_SelesaiDenganBenar()
    {
        Kontak kontak = new Kontak("Test Name", "012-345-6789");

        Assert.AreEqual("Test Name", kontak.Nama, "Nama kontak tidak sesuai.");
        Assert.AreEqual("012-345-6789", kontak.NomorTelepon, "Nomor telepon kontak tidak sesuai.");
    }

    [TestMethod]
    public void TambahKontak_TambahSatuKontak_KontakBerhasilDitambahkan()
    {
        BukuKontak bukuKontak = new BukuKontak(5);
        Kontak kontak = new Kontak("Alice", "123-456-7890");

        bool result = bukuKontak.TambahKontak(kontak);

        Assert.IsTrue(result, "Kontak harus berhasil ditambahkan.");
    }

    [TestMethod]
    public void TambahKontak_TambahLebihDariKapasitas_KontakGagalDitambahkan()
    {
        BukuKontak bukuKontak = new BukuKontak(1);
        bukuKontak.TambahKontak(new Kontak("Alice", "123-456-7890"));

        bool result = bukuKontak.TambahKontak(new Kontak("Bob", "098-765-4321"));

        Assert.IsFalse(result, "Kontak kedua tidak seharusnya berhasil ditambahkan karena melebihi kapasitas.");
    }

    [TestMethod]
    public void HapusKontak_HapusKontakYangAda_KontakBerhasilDihapus()
    {
        BukuKontak bukuKontak = new BukuKontak(5);
        bukuKontak.TambahKontak(new Kontak("Alice", "123-456-7890"));

        bool result = bukuKontak.HapusKontak("Alice");

        Assert.IsTrue(result, "Kontak harus berhasil dihapus.");
    }

    [TestMethod]
    public void HapusKontak_HapusKontakYangTidakAda_KontakGagalDihapus()
    {
        BukuKontak bukuKontak = new BukuKontak(5);
        bukuKontak.TambahKontak(new Kontak("Alice", "123-456-7890"));

        bool result = bukuKontak.HapusKontak("Bob");

        Assert.IsFalse(result, "Kontak yang tidak ada tidak seharusnya berhasil dihapus.");
    }

    [TestMethod]
    public void CariKontak_CariKontakYangAda_KontakDitemukan()
    {
        BukuKontak bukuKontak = new BukuKontak(5);
        bukuKontak.TambahKontak(new Kontak("Alice", "123-456-7890"));

        Kontak? kontak = bukuKontak.CariKontak("Alice");

        Assert.IsNotNull(kontak, "Kontak harus ditemukan.");
        Assert.AreEqual("Alice", kontak?.Nama, "Nama kontak harus 'Alice'.");
    }

    [TestMethod]
    public void CariKontak_CariKontakYangTidakAda_KontakTidakDitemukan()
    {
        BukuKontak bukuKontak = new BukuKontak(5);
        bukuKontak.TambahKontak(new Kontak("Alice", "123-456-7890"));

        Kontak? kontak = bukuKontak.CariKontak("Bob");

        Assert.IsNull(kontak, "Kontak yang tidak ada tidak seharusnya ditemukan.");
    }
}