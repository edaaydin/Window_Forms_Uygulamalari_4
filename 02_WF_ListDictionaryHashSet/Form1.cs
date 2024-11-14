using System.Collections;

namespace _02_WF_ListDictionaryHashSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Collection
            // Diziler : Tip ve Eleman Deðeri
            //string[] sehirler = new string[] { "Ýstanbul", "Ankara", "Ýzmir" };

            //// Listeler : Tip
            //List<string> sehirlerList = new List<string>() { "Ýstanbul", "Ankara", "Ýzmir" };

            //sehirlerList.Add("Bursa");
            //sehirlerList.Add("Samsun");
            //sehirlerList.Insert(3, "Kocaeli");

            //sehirlerList.ForEach(x => MessageBox.Show(x)); // Lambda Expression

            // ArrayList 
            /* þu zamana kadar gördüðümüz ilkel dizilerin en büyük iki özelliði VERÝ TÝPÝ ve ELEMAN SAYISI zorunluluðu idi. Ancak arraylist ile bu zorunluluklar ortadan kalkmýþtýr. */

            /* Dezavantajý
             * ArrayList içerisindeki elemanlarý otomatik olarak object veri tipine döndürme özelliðine sahiptir. Dolasýyla bu verileri geri almak istemizde "cast" veya "convert
               iþlemine gerek duymaktayýz.             
             */

            // Bu da ektra iki kat iþ demektir. (Boxing, Unboxing)
            // Boxing: Bilinen TÝpten => Object
            // Unboxing: object => Boxing

            //ArrayList yeniDizi = new ArrayList() { sehirlerList, sehirler, 'F', 34 };
            //yeniDizi.Add("Kars");
            //yeniDizi.Add(35);
            //yeniDizi.Add(true);

            //yeniDizi.Insert(3, "YZL 5101");

            //// Diðer Array Sýnýflarý
            //yeniDizi.Sort();
            //yeniDizi.Remove("Kars");

            //yeniDizi.Clear();

            /*
             Collection (Koleksiyon), programlamada veri gruplarýný depolamak ve yönetmek için kullanýlan bir terimdir. Verileri bir düzen içerisinde saklar. Veriler üzerinde gruplama, iþleme ve yönetme mekanizmalarý kazandýrýr.

            ->IEnumrable: Collection tiplerinin en tepsinde bulunur, tüm collection alt yapý saðlar. Foreach için temel altyapýuý saðlar. (Iterasyon)
                -> ICollection: Eleman ekleme, silme iþlemlerini
                    -IList : Sýralama iþlemlerini
                    -IDictionary: Key-Value (Anahtar-Deðer) çiftlerini depolayan bir koleksiyon.

             */

            #endregion

            #region Queue
            // Queue<T> sýnýfý, ilk giren ilk çýkar (FIFO) düzelmiþ bir nesneler koleksiyonudur. Öðeleri belirli bir sýrayla iþlemek istediðinizde kullanýþlýdýr.
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Coffee"); // sýranýn sonuna bir öðe ekler.
            //queue.Enqueue("Tea");
            //queue.Enqueue("Ice Tea");

            //MessageBox.Show(queue.Dequeue()); // Sýranýn baþýndaki öðeyi kaldýrýr ve döndürür.
            //MessageBox.Show(queue.Peek()); // Sýranýn baþýndaki elemaný çýkarmadan döndürür.


            #endregion

            #region Stack
            // stack, son giren ilk çýkar (LIFO) düzeninde düzenlenmiþ bir nesneler koleksiyondur.

            //Stack<string> stack = new Stack<string>();
            //stack.Push("Home"); // Yýðýnýn en üstüne ekler
            //stack.Push("Contact");
            //stack.Push("About");

            //stack.Pop(); // Yýðýn en üstündeki öðeyi kaldýrýr ve döndürür.
            //stack.Peek(); // Yýðýnýn en üstündeki öðeyi çýkarmadan döndürür.

            #endregion

            #region HashSet
            // HashSet, belirli bir sýrasý olmayan benzersiz bir koleksiyondur. Öðelerin benzersiz olduðundan emin olmak istediðimiz durumda kullanýþlýdýr.

            HashSet<string> hashSet = new HashSet<string>();

            hashSet.Add("Zafer"); // Halihazýrda yoksa HAshSet'e bir öðe ekler.
            hashSet.Add("Zehra");
            hashSet.Add("Deniz");
            hashSet.Add("Zehra");  // Zehra koleksiyonda bulunduðu için eklenmedi.

            #endregion

            #region Dictionary
            // Key-Value (Anahtar-Deðer) çiftleri ile iliþkilendirilmiþ bir koleksiyon türüdür.
            //Anahtara dayalý oalrak deðerin hýzlý aranmasýný saðþayan bir key-ValueTask koleksiyonudur.

            Dictionary<string, int> personAges = new Dictionary<string, int>();

            personAges.Add("Zafer", 34);
            personAges.Add("Zehra", 22);
            personAges.Add("Güliz", 10);
            personAges.Add("Deniz", 7);

            //MessageBox.Show(personAges["Güliz"].ToString());

            foreach (KeyValuePair<string, int> item in personAges)
            {
                MessageBox.Show($"{item.Key} - {item.Value}");
            }

            foreach (var item in personAges.Keys)
            {
                MessageBox.Show($"{item} {personAges[item]}");
            }

            #endregion
        }
    }
}

// Login iþlemi yapýlacak. Admin ve þifre alacak. "Admin" ve "123" ise Personel giriþ sayfasýna yönlenecek.
// Personel Bilgileri: Adý, Soyadý, TC KNO, Email, Telefon, Departmaný (5-10), Cinsiyeti, Hobileri birden fazla seçebilir (5 tane).
// Ekleme yaparken alanlarýn boþ geçilmemesine dikkat edin! Uyarý ver.
// Kaydedildiðinde Listbox verileri yaz.
// Kaydedilince tüm alanlarý default deðerlerine getir.

