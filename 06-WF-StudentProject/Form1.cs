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

1- Kullan�c� Giri�i Ekran� yapacaks�n�z.
    Kullan�c� ad� ve �ifre.
    giri� yap butonun bas�nca, Form Load olurken belirledi�iniz dectionary tipindeki key, value kullan�c� ad�, �ifre bilgilerini kontrol edecek.
    alanlar bo� mu kontrol edecek. Alanlar bo� ge�ilemeyecek.
   LoginOlduMu() kullan�c� ad� ve �ifre dictionary i�inde var m� yok mu kontrol etsin.
  kullan�c� yoksa lblBilgi i�inde mesaj versin.
  Kullan�c� varsa StudentAddForm a��ls�n. ve StudentAddForm constructor'a kullan�c� ad� bilgisi g�nderilsin.
Login formu gizlensin.


2- ��renci Bilgileri ve Resim y�kle grupbox'lar� olsun.
��renci Bilgileri i�ine ad�, soyad�, cinsiyeti, B�l�m� (CB) bilgilerini alacak.
Yukardaki bilgilerin do�rulu�unu onayl�yorum mesaj� onaylan�rsa ��renci Kaydet butonuna basabilecek.

Resim y�kle alan�nda bir Picturebox, bir tane textbox ve 1 tane de buton olacak.
Se�ilen resim yolu adresi textboxta g�r�ns�n. picture box'a da resim gelsin.

 yukar�da bir lable i�inde login sayfas�ndan g�nderilen kullan�c� bilgisi ho� geldin ile yazs�n.

 
Bilgileri de bir dizide tutunuz. Ayr�ca bu bilgileri txt uzant�l� dosyaya da yaz�n�z.


3- ��renci Kaydet butonunun yan�na ��renci Listesi butonu gelsin. Bu butona bas�nca yeni bir form a��ls�n.

StudentListForm i�inde listbox'ta txt den veriler �ekilerek ekrana yaz�ls�n.

 */