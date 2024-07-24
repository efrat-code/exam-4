using static XmlTest.Servise.TestService;
using static XmlTest.Model.DateModel;
using XmlTest.Model;
using System.Windows.Forms;
namespace XmlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXmlIfNotExists();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        

        public void OnResultClicked(object sender, EventArgs e)
        {
            if (comboBoxDay.Text == null || comboBoxDayInMonth.Text == null
                || comboBoxMonth.Text == null || comboBoxYear.Text == null)
            {
                MessageBox.Show("full all dates");
            }
            string? day = comboBoxDay.Text;
            string? dayinmonth = comboBoxDayInMonth.Text;
            string? month = comboBoxMonth.Text;
            string? year = comboBoxYear.Text;

            string reday = null;
            string redayinmonth = null;
            string remonth = null;
            string reyear = null;

            switch (day)
            { case "ראשון":
                    reday = "באחד בשבת";break;
                case "שני":
                    reday = "בשני בשבת"; break;
                case "שלישי":
                    reday = "בשלישי בשבת"; break;
                case "רביעי":
                    reday = "ברביעי בשבת"; break;
                case "חמישי":
                    reday = "בחמישי בשבת"; break;
                case "שישי":
                    reday = "בשישי בשבת"; break;
                case "שבת":
                    reday = "בשבת"; break;
             
            }

            switch (dayinmonth)
            {
                case "1":
                    redayinmonth = "יום אחד לירח"; break;
                case "2":
                    redayinmonth = "שני ימים לירח"; break;
                case "3":
                    redayinmonth = "שלושה ימים לירח"; break;
                case "4":
                    redayinmonth = "ארבעה ימים לירח"; break;
                case "5":
                    redayinmonth = "חמישה ימים לירח"; break;
                case "6":
                    redayinmonth = "שישה ימים לירח"; break;
                case "7":
                    redayinmonth = "שבעה ימים לירח"; break;
                case "8":
                    redayinmonth = "שמונה ימים לירח"; break;
                case "9":
                    redayinmonth = "תשעה ימים לירח"; break;
                case "10":
                    redayinmonth = "עשרה ימים לירח"; break;
                case "11":
                    redayinmonth = "אחד עשר ימים לירח"; break;
                case "12":
                    redayinmonth = "שנים עשר ימים לירח"; break;
                case "13":
                    redayinmonth = "שלושה עשר ימים לירח"; break;
                case "14":
                    redayinmonth = "ארבעה עשר ימים לירח"; break;
                case "15":
                    redayinmonth = "חמישה עשר ימים לירח"; break;
                case "16":
                    redayinmonth = "שישה עשר ימים לירח"; break;
                case "17":
                    redayinmonth = "שבעה עשר ימים לירח"; break;
                case "18":
                    redayinmonth = "שמנה עשר ימים לירח"; break;
                case "19":
                    redayinmonth = "תשעה עשר ימים לירח"; break;
                case "20":
                    redayinmonth = " עשרים ימים לירח"; break;
                case "21":
                    redayinmonth = " עשרים ואחת ימים לירח"; break;
                case "22":
                    redayinmonth = " עשרים ושניים ימים לירח"; break;
                case "23":
                    redayinmonth = " עשרים ושלשה ימים לירח"; break;
                case "24":
                    redayinmonth = " עשרים וארבעה ימים לירח"; break;
                case "25":
                    redayinmonth = " עשרים וחמשה ימים לירח"; break;
                case "26":
                    redayinmonth = " עשרים וששה ימים לירח"; break;
                case "27":
                    redayinmonth = " עשרים ושבעה ימים לירח"; break;
                case "28":
                    redayinmonth = " עשרים ושמנה ימים לירח"; break;
                case "29":
                    redayinmonth = " עשרים ותשעה ימים לירח"; break;
                case "30":
                    redayinmonth = " שלושים ימים לירח"; break;

                default:
                    redayinmonth = "בבניה";break;

            }

            switch (month)
            {
                case "תשרי":
                    remonth = "תשרי"; break;
                case "חשוון":
                    remonth = "חשוון"; break;
                case "כסליו":
                    remonth = "כסליו"; break;
                case "טבת":
                    remonth = "טבת"; break;
                case "שבט":
                    remonth = "שבט"; break;
                case "אדר":
                    remonth = "אדר"; break;
                case "ניסן":
                    remonth = "ניסן"; break;
                case "אייר":
                    remonth = "אייר"; break;
                case "סיון":
                    remonth = "סיון"; break;
                case "תמוז":
                    remonth = "תשרי"; break;
                case "אב":
                    remonth = "אב"; break;
                case "אלול":
                    remonth = "אלול"; break;
            }

            switch (year)
            {
                case @"תשע""ט":
                    reyear = @"תשע""ט"; break;
                case @"תש""פ":
                    reyear = @"תש""פ"; break;
                case @"תשפ""א":
                    reyear = @"תשפ""א"; break;
                case @"תשפ""ב":
                    reyear = @"תשפ""ב"; break;
                case @"תשפ""ג":
                    reyear = @"תשפ""ג"; break;
                case @"תשפ""ד":
                    reyear = @"תשפ""ד"; break;
                case @"תשפ""ה":
                    reyear = @"תשפ""ה"; break;

                default:
                    reyear = "בבניה ";break;
                
            }

            string result = $"{reday} ב{redayinmonth} {remonth} לשנת {reyear} ";
            if (dayinmonth == "30")
            {
                switch (month)
                {
                case "תשרי":
                    remonth = "חשוון"; break;
                case "חשוון":
                    remonth = "כסליו"; break;
                case "כסליו":
                    remonth = "טבת"; break;
                case "טבת":
                    remonth = "שבט"; break;
                case "שבט":
                    remonth = "אדר"; break;
                case "אדר":
                    remonth = "ניסן"; break;
                case "ניסן":
                    remonth = "אייר"; break;
                case "אייר":
                    remonth = "סיון"; break;
                case "סיון":
                    remonth = "תמוז"; break;
                case "תמוז":
                    remonth = "אב"; break;
                case "אב":
                    remonth = "אלול"; break;
                case "אלול":
                    remonth = "תשרי"; break;
                };
                result = $"{reday} ב{redayinmonth} {month} שהוא ראש חודש {remonth} לשנת {reyear} ";
            }

            DateModel? dateModel = new(day , dayinmonth, month, year ,result);

            AddDate(dateModel);
            textBoxResult.Text = result;    
        }

        public void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
           
    }
}
