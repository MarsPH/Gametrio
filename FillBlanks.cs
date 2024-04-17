using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Son_of_Duo
{
    public partial class FillBlanks : Form
    {
        private int currentQuestionIndex = 0;
        private List<int> selectedIndexes = new List<int>();
        private const int totalQuestionsToAsk = 10;
        private ProgressBar progressBar;

        private string[] allQuestions = new string[]
        {
             "Je ________ (être) heureux.",
            "Nous ________ (avoir) deux chiens.",
    "Elle ________ (faire) ses devoirs.",
    "Ils ________ (aller) à l'école.",
    "Vous ________ (savoir) la réponse.",
    "Elle ________ (vouloir) partir.",
    "Nous ________ (pouvoir) gagner.",
    "Tu ________ (prendre) un café.",
    "Je ________ (venir) demain.",
    "Ils ________ (voir) le film.",
    "Tu ________ (lire) le journal.",
    "Nous ________ (écrire) une lettre.",
    "Elles ________ (choisir) un livre.",
    "Vous ________ (comprendre) la leçon?",
    "Il ________ (courir) chaque matin.",
    "Je ________ (devoir) parler.",
    "Elle ________ (dire) la vérité.",
    "Nous ________ (espérer) mieux.",
    "Vous ________ (étudier) le français.",
    "Ils ________ (fermer) la porte.",
    "Je ________ (jouer) au tennis.",
    "Elle ________ (montrer) le chemin.",
    "Nous ________ (obtenir) les résultats.",
    "Vous ________ (offrir) un cadeau.",
    "Ils ________ (oublier) l'anniversaire.",
    "Je ________ (partir) maintenant.",
    "Tu ________ (penser) à moi?",
    "Elle ________ (perdre) son sac.",
    "Nous ________ (permettre) l'accès.",
    "Vous ________ (placer) les chaises.",
    "Ils ________ (plaire) à leurs amis.",
    "Je ________ (porter) un manteau.",
    "Tu ________ (posséder) une voiture?",
    "Il ________ (pousser) la porte.",
    "Nous ________ (prendre) le déjeuner.",
    "Vous ________ (préparer) le dîner?",
    "Elles ________ (recevoir) les invités.",
    "Je ________ (rêver) souvent.",
    "Tu ________ (rire) de mes blagues?",
    "Elle ________ (savoir) nager.",
    "Nous ________ (sentir) la rose.",
    "Vous ________ (sortir) ce soir?",
    "Ils ________ (souffrir) beaucoup.",
    "Je ________ (suivre) le cours.",
    "Tu ________ (tenir) le livre.",
    "Il ________ (toucher) le sol.",
    "Nous ________ (trouver) la clé.",
    "Vous ________ (utiliser) l'ordinateur.",
    "Elles ________ (vendre) la maison.",
    "Je ________ (vivre) bien."
        };
        private string[] allAnswers = new string[] {
     "suis", "avons", "fait", "vont", "savez", "veut",
    "pouvons", "prends", "viens", "voient",
    "lis", "écrivons", "choisissent", "comprenez", "court",
    "dois", "dit", "espérons", "étudiez", "ferment",
    "joue", "montre", "obtenons", "offrez", "oublient",
    "pars", "penses", "perd", "permettons", "placez",
    "plaisent", "porte", "possèdes", "pousse", "prenons",
    "préparez", "reçoivent", "rêve", "ris", "sait",
    "sentons", "sortez", "souffrent", "suis", "tiens",
    "touche", "trouvons", "utilisez", "vendent", "vis"
        };

        private string[] explanations = new string[] {
        "être conjugates to 'suis' in the first person singular.",
    "avoir conjugates to 'avons' in the first person plural.",
    "faire conjugates to 'fait' in the third person singular.",
    "aller conjugates to 'vont' in the third person plural.",
    "savoir conjugates to 'savez' in the second person plural.",
    "vouloir conjugates to 'veut' in the third person singular.",
    "pouvoir conjugates to 'pouvons' in the first person plural.",
    "prendre conjugates to 'prends' in the first person singular.",
    "venir conjugates to 'viens' in the first person singular.",
    "voir conjugates to 'voient' in the third person plural.",
    "lire conjugates to 'lis' in the first person singular.",
    "écrire conjugates to 'écrivons' in the first person plural.",
    "choisir conjugates to 'choisissent' in the third person plural.",
    "comprendre conjugates to 'comprenez' in the second person plural.",
    "courir conjugates to 'court' in the third person singular.",
    "devoir conjugates to 'dois' in the first person singular.",
    "dire conjugates to 'dit' in the third person singular.",
    "espérer conjugates to 'espérons' in the first person plural.",
    "étudier conjugates to 'étudiez' in the second person plural.",
    "fermer conjugates to 'ferment' in the third person plural.",
    "jouer conjugates to 'joue' in the first person singular.",
    "montrer conjugates to 'montre' in the third person singular.",
    "obtenir conjugates to 'obtenons' in the first person plural.",
    "offrir conjugates to 'offrez' in the second person plural.",
    "oublier conjugates to 'oublient' in the third person plural.",
    "partir conjugates to 'pars' in the first person singular.",
    "penser conjugates to 'penses' in the second person singular.",
    "perdre conjugates to 'perd' in the third person singular.",
    "permettre conjugates to 'permettons' in the first person plural.",
    "placer conjugates to 'placez' in the second person plural.",
    "plaire conjugates to 'plaisent' in the third person plural.",
    "porter conjugates to 'porte' in the first person singular.",
    "posséder conjugates to 'possèdes' in the second person singular.",
    "pousser conjugates to 'pousse' in the third person singular.",
    "prendre conjugates to 'prenons' in the first person plural.",
    "préparer conjugates to 'préparez' in the second person plural.",
    "recevoir conjugates to 'reçoivent' in the third person plural.",
    "rêver conjugates to 'rêve' in the first person singular.",
    "rire conjugates to 'ris' in the first person singular.",
    "savoir conjugates to 'sait' in the third person singular.",
    "sentir conjugates to 'sentons' in the first person plural.",
    "sortir conjugates to 'sortez' in the second person plural.",
    "souffrir conjugates to 'souffrent' in the third person plural.",
    "suivre conjugates to 'suis' in the first person singular.",
    "tenir conjugates to 'tiens' in the first person singular.",
    "toucher conjugates to 'touche' in the third person singular.",
    "trouver conjugates to 'trouvons' in the first person plural.",
    "utiliser conjugates to 'utilisez' in the second person plural.",
    "vendre conjugates to 'vendent' in the third person plural.",
    "vivre conjugates to 'vis' in the first person singular."
        };

        public FillBlanks()
        {
            InitializeComponent();
            InitializeProgressBar();
            SelectRandomQuestions();
            NextQuestion();
          
        }

        private void InitializeProgressBar()
        {
            progressBar = new ProgressBar();
            progressBar.Location = new Point(207, 380);  
            progressBar.Size = new Size(530, 60);      
            progressBar.Maximum = totalQuestionsToAsk;
            this.Controls.Add(progressBar);
        }

        private void SelectRandomQuestions()
        {
            Random rnd = new Random();
            while (selectedIndexes.Count < totalQuestionsToAsk)
            {
                int index = rnd.Next(allQuestions.Length);
                if (!selectedIndexes.Contains(index))
                    selectedIndexes.Add(index);
            }
        }

        private void NextQuestion()
        {
            if (currentQuestionIndex < totalQuestionsToAsk)
            {
                int questionIndex = selectedIndexes[currentQuestionIndex];
                lblQuestion.Text = allQuestions[questionIndex];
                txtAnswer.Clear();
                lblMessage.Text = "";
                this.BackColor = SystemColors.Control;
                btnSubmit.BackColor = SystemColors.Control;
                progressBar.Value = currentQuestionIndex + 1;
            }
            else
            {
                lblQuestion.Text = "Game Over!";
                
                btnSubmit.Enabled = false;
                this.BackColor = SystemColors.Control;
                btnSubmit.BackColor = SystemColors.Control;
            }
        }

        private async void CheckAnswerAsync(string userAnswer)
        {
            int questionIndex = selectedIndexes[currentQuestionIndex];
            if (userAnswer.Equals(allAnswers[questionIndex], StringComparison.OrdinalIgnoreCase))
            {
                lblMessage.Text = "Correct!";
                this.BackColor = Color.LightGreen;
                btnSubmit.BackColor = Color.Green;

                await Task.Delay(1000); 

                currentQuestionIndex++;
                NextQuestion();
            }
            else
            {
                lblMessage.Text = $"Incorrect! The correct answer is '{allAnswers[questionIndex]}'. {explanations[questionIndex]}";
                this.BackColor = Color.MistyRose;
                btnSubmit.BackColor = Color.Red;
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            CheckAnswerAsync(txtAnswer.Text.Trim());
            txtAnswer.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }
    }
}
