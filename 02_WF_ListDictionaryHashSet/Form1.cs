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
            // Diziler : Tip ve Eleman De�eri
            //string[] sehirler = new string[] { "�stanbul", "Ankara", "�zmir" };

            //// Listeler : Tip
            //List<string> sehirlerList = new List<string>() { "�stanbul", "Ankara", "�zmir" };

            //sehirlerList.Add("Bursa");
            //sehirlerList.Add("Samsun");
            //sehirlerList.Insert(3, "Kocaeli");

            //sehirlerList.ForEach(x => MessageBox.Show(x)); // Lambda Expression

            // ArrayList 
            /* �u zamana kadar g�rd���m�z ilkel dizilerin en b�y�k iki �zelli�i VER� T�P� ve ELEMAN SAYISI zorunlulu�u idi. Ancak arraylist ile bu zorunluluklar ortadan kalkm��t�r. */

            /* Dezavantaj�
             * ArrayList i�erisindeki elemanlar� otomatik olarak object veri tipine d�nd�rme �zelli�ine sahiptir. Dolas�yla bu verileri geri almak istemizde "cast" veya "convert
               i�lemine gerek duymaktay�z.             
             */

            // Bu da ektra iki kat i� demektir. (Boxing, Unboxing)
            // Boxing: Bilinen T�pten => Object
            // Unboxing: object => Boxing

            //ArrayList yeniDizi = new ArrayList() { sehirlerList, sehirler, 'F', 34 };
            //yeniDizi.Add("Kars");
            //yeniDizi.Add(35);
            //yeniDizi.Add(true);

            //yeniDizi.Insert(3, "YZL 5101");

            //// Di�er Array S�n�flar�
            //yeniDizi.Sort();
            //yeniDizi.Remove("Kars");

            //yeniDizi.Clear();

            /*
             Collection (Koleksiyon), programlamada veri gruplar�n� depolamak ve y�netmek i�in kullan�lan bir terimdir. Verileri bir d�zen i�erisinde saklar. Veriler �zerinde gruplama, i�leme ve y�netme mekanizmalar� kazand�r�r.

            ->IEnumrable: Collection tiplerinin en tepsinde bulunur, t�m collection alt yap� sa�lar. Foreach i�in temel altyap�u� sa�lar. (Iterasyon)
                -> ICollection: Eleman ekleme, silme i�lemlerini
                    -IList : S�ralama i�lemlerini
                    -IDictionary: Key-Value (Anahtar-De�er) �iftlerini depolayan bir koleksiyon.

             */

            #endregion

            #region Queue
            // Queue<T> s�n�f�, ilk giren ilk ��kar (FIFO) d�zelmi� bir nesneler koleksiyonudur. ��eleri belirli bir s�rayla i�lemek istedi�inizde kullan��l�d�r.
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Coffee"); // s�ran�n sonuna bir ��e ekler.
            //queue.Enqueue("Tea");
            //queue.Enqueue("Ice Tea");

            //MessageBox.Show(queue.Dequeue()); // S�ran�n ba��ndaki ��eyi kald�r�r ve d�nd�r�r.
            //MessageBox.Show(queue.Peek()); // S�ran�n ba��ndaki eleman� ��karmadan d�nd�r�r.


            #endregion

            #region Stack
            // stack, son giren ilk ��kar (LIFO) d�zeninde d�zenlenmi� bir nesneler koleksiyondur.

            //Stack<string> stack = new Stack<string>();
            //stack.Push("Home"); // Y���n�n en �st�ne ekler
            //stack.Push("Contact");
            //stack.Push("About");

            //stack.Pop(); // Y���n en �st�ndeki ��eyi kald�r�r ve d�nd�r�r.
            //stack.Peek(); // Y���n�n en �st�ndeki ��eyi ��karmadan d�nd�r�r.

            #endregion

            #region HashSet
            // HashSet, belirli bir s�ras� olmayan benzersiz bir koleksiyondur. ��elerin benzersiz oldu�undan emin olmak istedi�imiz durumda kullan��l�d�r.

            HashSet<string> hashSet = new HashSet<string>();

            hashSet.Add("Zafer"); // Halihaz�rda yoksa HAshSet'e bir ��e ekler.
            hashSet.Add("Zehra");
            hashSet.Add("Deniz");
            hashSet.Add("Zehra");  // Zehra koleksiyonda bulundu�u i�in eklenmedi.

            #endregion

            #region Dictionary
            // Key-Value (Anahtar-De�er) �iftleri ile ili�kilendirilmi� bir koleksiyon t�r�d�r.
            //Anahtara dayal� oalrak de�erin h�zl� aranmas�n� sa��ayan bir key-ValueTask koleksiyonudur.

            Dictionary<string, int> personAges = new Dictionary<string, int>();

            personAges.Add("Zafer", 34);
            personAges.Add("Zehra", 22);
            personAges.Add("G�liz", 10);
            personAges.Add("Deniz", 7);

            //MessageBox.Show(personAges["G�liz"].ToString());

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

// Login i�lemi yap�lacak. Admin ve �ifre alacak. "Admin" ve "123" ise Personel giri� sayfas�na y�nlenecek.
// Personel Bilgileri: Ad�, Soyad�, TC KNO, Email, Telefon, Departman� (5-10), Cinsiyeti, Hobileri birden fazla se�ebilir (5 tane).
// Ekleme yaparken alanlar�n bo� ge�ilmemesine dikkat edin! Uyar� ver.
// Kaydedildi�inde Listbox verileri yaz.
// Kaydedilince t�m alanlar� default de�erlerine getir.

