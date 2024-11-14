namespace _06_WF_StudentProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
/*

1- Kullanýcý Giriþi Ekraný yapacaksýnýz.
    Kullanýcý adý ve þifre.
    giriþ yap butonun basýnca, Form Load olurken belirlediðiniz dectionary tipindeki key, value kullanýcý adý, þifre bilgilerini kontrol edecek.
    alanlar boþ mu kontrol edecek. Alanlar boþ geçilemeyecek.
   LoginOlduMu() kullanýcý adý ve þifre dictionary içinde var mý yok mu kontrol etsin.
  kullanýcý yoksa lblBilgi içinde mesaj versin.
  Kullanýcý varsa StudentAddForm açýlsýn. ve StudentAddForm constructor'a kullanýcý adý bilgisi gönderilsin.
Login formu gizlensin.


2- Öðrenci Bilgileri ve Resim yükle grupbox'larý olsun.
Öðrenci Bilgileri içine adý, soyadý, cinsiyeti, Bölümü (CB) bilgilerini alacak.
Yukardaki bilgilerin doðruluðunu onaylýyorum mesajý onaylanýrsa Öðrenci Kaydet butonuna basabilecek.

Resim yükle alanýnda bir Picturebox, bir tane textbox ve 1 tane de buton olacak.
Seçilen resim yolu adresi textboxta görünsün. picture box'a da resim gelsin.

 yukarýda bir lable içinde login sayfasýndan gönderilen kullanýcý bilgisi hoþ geldin ile yazsýn.

 
Bilgileri de bir dizide tutunuz. Ayrýca bu bilgileri txt uzantýlý dosyaya da yazýnýz.


3- Öðrenci Kaydet butonunun yanýna Öðrenci Listesi butonu gelsin. Bu butona basýnca yeni bir form açýlsýn.

StudentListForm içinde listbox'ta txt den veriler çekilerek ekrana yazýlsýn.

 */