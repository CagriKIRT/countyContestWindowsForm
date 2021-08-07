using countyContest.Win.DataModel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace countyContest.Win
{
    public partial class QuestionForm : DevExpress.XtraEditors.XtraForm
    {
        private List<Country> listOfCountry = new List<Country>() {
        new Country("AMERICA","WASHINTON D.C.","+1","DOLLAR"),
        new Country("GERMANY","BERLIN","+49","EURO"),
        new Country("JAPAN","TOKYO","+81","YEN"),
        new Country("CHINA","BEIJING","+86","RENMINBI"),
        new Country("RUSSIA","MOSCOW","+7","RUBLE"),
        new Country("COLOMBIA","BOGOTA","+57","PESO"),
        new Country("SOUTH KOREA","SEOUL","+82","WON"),
        new Country("NORWAY","OSLO","+47","KRONE"),
        new Country("INDIA","NEW DELHI","+91","RUPEE"),
        new Country("ENGLAND","LONDON","+44","POUND"),
        new Country("TÜRKİYE","ANKARA","+90","LİRA")
        };

        public int numberOfQuestion = 5;
        public int correctAnswer = 0;

        private HashSet<Question> listOfQuestion = new HashSet<Question>();
        private int questionIndex = 0;

        private void getQuestion()
        {
            Random rnd = new Random();

            int randomIndex1 = rnd.Next(0, listOfCountry.Count);
            int randomIndex2 = rnd.Next(0, 3);

            string[] names = Enum.GetNames(typeof(AnswerType));

            Country country = listOfCountry[randomIndex1];
            string qname = names[randomIndex2].ToString();

            Console.WriteLine(qname);
            if (qname == "Currency")
            {
                listOfQuestion.Add(new Question(String.Format("{0} of {1}", qname.ToString(), country.name.ToString()), country.currency.ToString(), AnswerType.Currency));
            }
            else if (qname == "Capital")
            {
                listOfQuestion.Add(new Question(String.Format("{0} of {1}", qname.ToString(), country.name.ToString()), country.capital.ToString(), AnswerType.Capital));
            }
            else
            {
                listOfQuestion.Add(new Question(String.Format("{0} of {1}", qname.ToString(), country.name.ToString()), country.dialogCode.ToString(), AnswerType.DialogCode));
            }
        }

        private HashSet<String> getOptions(string answer, AnswerType answerType)
        {
            HashSet<String> optionSet = new HashSet<String>() { answer };

            while (optionSet.Count < 4)
            {
                int randomIndex = new Random().Next(0, listOfCountry.Count);

                if (AnswerType.Currency == answerType)
                    optionSet.Add(listOfCountry[randomIndex].currency);
                else if (AnswerType.Capital == answerType)
                    optionSet.Add(listOfCountry[randomIndex].capital);
                else
                    optionSet.Add(listOfCountry[randomIndex].dialogCode);
            }

            HashSet<String> shuffledOptions = Shuffle(optionSet.ToArray()).ToHashSet();

            return shuffledOptions;
        }

        private string[] Shuffle(string[] wordArray)
        {
            Random random = new Random();
            for (int i = wordArray.Length - 1; i > 0; i--)
            {
                int swapIndex = random.Next(i + 1);
                string temp = wordArray[i];
                wordArray[i] = wordArray[swapIndex];
                wordArray[swapIndex] = temp;
            }
            return wordArray;
        }

        private void setOptionsToRadioButtons()
        {
            HashSet<String> options = getOptions(listOfQuestion.ElementAt(questionIndex).answer, listOfQuestion.ElementAt(questionIndex).answerType);

            //radioButton1.Text = options.ElementAt(0);

            string[] opt = options.OrderBy(m => new Random().Next()).ToArray();

            for (int i = 0; i < opt.Length; i++)
            {
                Controls.Find("radioButton" + (i + 1), true).FirstOrDefault().Text = opt[i];
            }
        }

        public QuestionForm()
        {
            InitializeComponent();
        }

        //This method is not valid for single responsibilty.
        //We should look for diffrent approach in the future.

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            var checkedRadioButton = this.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);

            if (checkedRadioButton.Text == listOfQuestion.ElementAt(questionIndex).answer)
                correctAnswer++;

            questionIndex++;
            if (questionIndex >= numberOfQuestion)
            {
                DialogResult soru = new DialogResult();
                soru = MessageBox.Show("Skorunuzu kaydetmek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    frmSaveScore frm = new frmSaveScore(correctAnswer, numberOfQuestion);
                    frm.ShowDialog();
                    this.Close();
                    return;
                }
                else
                {
                    this.Close();
                    return;
                }
            }

            textBox1.Text = listOfQuestion.ElementAt(questionIndex).question.ToString();
            playTurkiyemSongIfQuestionIsTurkey();

            setOptionsToRadioButtons();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            while (listOfQuestion.Count < 5)
            {
                getQuestion();
                //If I dont use thread getQuestion gets same questions.
                //I couldn't find the solution, this is a temporary solution.
                Thread.Sleep(20);
            }

            textBox1.Text = listOfQuestion.ElementAt(questionIndex).question.ToString();
            setOptionsToRadioButtons();
            playTurkiyemSongIfQuestionIsTurkey();
        }

        private void playTurkiyemSongIfQuestionIsTurkey()
        {
            string currentDirectory = Directory.GetCurrentDirectory(); //Full Path
            string dosya_yolu = currentDirectory + "\\olurum_türkiyem.wav";//.wa
            SoundPlayer simpleSound = new SoundPlayer(dosya_yolu);
            if (listOfQuestion.ElementAt(questionIndex).question.Contains("TÜRKİYE"))
            {
                simpleSound.Play();
            }
            else
            {
                simpleSound.Stop();
            }
        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            frmScoreboard frm = new frmScoreboard();
            frm.ShowDialog();
        }
    }
}