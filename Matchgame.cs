using Son_of_Duo;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Son_of_Duo
{

    public partial class game1 : Form
    {


        private List<Button> buttons = new List<Button>();

        List<string> questions = new List<string>
        {
            "Bonjour", "Chat", "Chien", "Pomme", "Livre",
            "Rouge", "Vert", "Bleu", "Voiture", "Fenêtre",
            "Maison", "Ordinateur", "Téléphone", "Arbre", "Fleur",
            "Montagne", "Plage", "Lune", "Étoile", "Feu",
            "Eau", "Air", "Terre", "Ciel", "Soleil",
            "Nuage", "École", "Professeur", "Étudiant", "Calculatrice",
            "Crayon", "Papier", "Musique", "Cinéma", "Théâtre",
            "Restaurant", "Café", "Thé", "Jus", "Lait",
            "Fromage", "Viande", "Poulet", "Poisson", "Légume",
            "Carotte", "Pomme de terre", "Tomate", "Riz", "Pain",
            "Pâtes", "Gâteau", "Biscuit", "Chocolat", "Bonbon",
            "Épice", "Sel", "Poivre", "Sucre", "Huile",
            "Vinaigre", "Beurre", "Miel", "Yaourt", "Crème",
            "Oeuf", "Orange", "Banane", "Citron", "Raisin",
            "Fraise", "Cerise", "Pastèque", "Ananas", "Pêche",
            "Poire", "Abricot", "Framboise", "Mûre", "Myrtille",
            "Kiwi", "Mangue", "Grenade", "Fig", "Dattes",
            "Coing", "Noix", "Amande", "Noisette", "Pistache",
            "Châtaigne", "Cacahuète", "Graines", "Fèves", "Pois chiches",
            "Lentilles", "Tofu", "Champignon", "Brocoli", "Chou-fleur",
            "Épinards", "Laitue", "Concombre", "Poivron", "Courgette",
            "Aubergine", "Maïs", "Artichaut", "Navet", "Radis",
            "Betterave", "Oignon", "Ail", "Échalote", "Chou",
            "Asperges", "Fenouil", "Rutabaga", "Patate douce",

        };
        public static int RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            return randomNumber;
        }

        List<string> answers = new List<string>
        {
            "Hello", "Cat", "Dog", "Apple", "Book",
            "Red", "Green", "Blue", "Car", "Window",
            "House", "Computer", "Phone", "Tree", "Flower",
            "Mountain", "Beach", "Moon", "Star", "Fire",
            "Water", "Air", "Earth", "Sky", "Sun",
            "Cloud", "School", "Teacher", "Student", "Calculator",
            "Pencil", "Paper", "Music", "Cinema", "Theater",
            "Restaurant", "Cafe", "Tea", "Juice", "Milk",
            "Cheese", "Meat", "Chicken", "Fish", "Vegetable",
            "Carrot", "Potato", "Tomato", "Rice", "Bread",
            "Pasta", "Cake", "Cookie", "Chocolate", "Candy",
            "Spice", "Salt", "Pepper", "Sugar", "Oil",
            "Vinegar", "Butter", "Honey", "Yogurt", "Cream",
            "Egg", "Orange", "Banana", "Lemon", "Grape",
            "Strawberry", "Cherry", "Watermelon", "Pineapple", "Peach",
            "Pear", "Apricot", "Raspberry", "Blackberry", "Blueberry",
            "Kiwi", "Mango", "Pomegranate", "Fig", "Dates",
            "Quince", "Walnut", "Almond", "Hazelnut", "Pistachio",
            "Chestnut", "Peanut", "Seeds", "Beans", "Chickpeas",
            "Lentils", "Tofu", "Mushroom", "Broccoli", "Cauliflower",
            "Spinach", "Lettuce", "Cucumber", "Bell Pepper",
            "Zucchini", "Eggplant", "Corn", "Artichoke", "Turnip",
            "Radish", "Beet", "Onion", "Garlic", "Shallot",
            "Cabbage", "Asparagus", "Fennel", "Rutabaga",
            "Sweet Potato", "Salsify", "Avocado", "Papaya",
            "Passion Fruit", "Lychee", "Starfruit", "Mangosteen",
            "Rambutan", "Longan", "Durian", "Tamarind",
            "Guava", "Persimmon", "Jackfruit", "Maracuya",

        };

        private Button firstClicked = null;
        private Button secondClicked = null;
        Quickgame quic = new Quickgame();
        public game1()
        {
            InitializeComponent();

            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);

            AssignIconsToSquares();

            button18.Visible = false;

        }
        int count = 0;

        //int rc = RandomNumber();
        // I changed the whole method, due to major logic problem.
        public void AssignIconsToSquares()
        {
            count++;
            Random random = new Random();
            int numPairs = buttons.Count / 2;

            HashSet<int> selectedIndices = new HashSet<int>();
            while (selectedIndices.Count < numPairs)
            {
                int newIndex = random.Next(questions.Count);
                selectedIndices.Add(newIndex);
            }

            List<string> selectedQuestions = new List<string>();
            List<string> selectedAnswers = new List<string>();

            foreach (int index in selectedIndices)
            {
                selectedQuestions.Add(questions[index]);
                selectedAnswers.Add(answers[index]);
            }

            List<int> buttonIndices = new List<int>();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttonIndices.Add(i);
            }

            for (int i = 0; i < buttonIndices.Count; i++)
            {
                int swapIndex = random.Next(i, buttonIndices.Count);
                int temp = buttonIndices[i];
                buttonIndices[i] = buttonIndices[swapIndex];
                buttonIndices[swapIndex] = temp;
            }

            for (int i = 0; i < numPairs; i++)
            {
                buttons[buttonIndices[i * 2]].Text = selectedQuestions[i];
                buttons[buttonIndices[i * 2]].Tag = selectedAnswers[i];
                buttons[buttonIndices[i * 2]].ForeColor = buttons[buttonIndices[i * 2]].BackColor;


                buttons[buttonIndices[i * 2 + 1]].Text = selectedAnswers[i];
                buttons[buttonIndices[i * 2 + 1]].Tag = selectedQuestions[i];
                buttons[buttonIndices[i * 2 + 1]].ForeColor = buttons[buttonIndices[i * 2 + 1]].BackColor;
            }
        }
        /*
        List<int> indices = new List<int>();
        for (int i = 0; i < questions.Count; i++)
        {
            indices.Add(i);
        }
        Random random = new Random();
        while (indices.Count > 0)
        {
            int index = random.Next(indices.Count);
            int questionIndex = indices[index];
            indices.RemoveAt(index);

            // To check the even number
            if (indices.Count == 0)
                break;
            index = random.Next(indices.Count);
            int answerIndex = indices[index];
            indices.RemoveAt(index);


            buttons[questionIndex].Text = questions[questionIndex];
            buttons[questionIndex].Tag = answers[questionIndex];  
            buttons[questionIndex].ForeColor = buttons[questionIndex].BackColor;

            buttons[answerIndex].Text = answers[answerIndex];
            buttons[answerIndex].ForeColor = buttons[answerIndex].BackColor;
        /*
        }
        /*
        for (int i = 0; i < buttons.Count; i = i + 2)
        {

            buttons[i].Text = questions[rc];

            buttons[i].ForeColor = buttons[i].BackColor;
            questions.RemoveAt(rc);

        }
        for (int i = 1; i < buttons.Count; i = i + 2)
        {
            buttons[i].Text = answers[rc];
            buttons[i].ForeColor = buttons[i].BackColor;
            answers.RemoveAt(rc);
        } */



        private void button_Click(object sender, EventArgs e)
        {
            Quickgame.SoundManager.PlayButtonPick1();
            if (firstClicked != null && secondClicked != null)
                return;

            Button clickedButton = sender as Button;

            if (clickedButton.ForeColor == Color.Black)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedButton;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedButton;
            secondClicked.ForeColor = Color.Black;

            string firstWord = firstClicked.Text;
            string secondWord = secondClicked.Text;

            // Possible fix of Match Logic 
            bool isMatch = (firstClicked.Tag.ToString() == secondClicked.Text || secondClicked.Tag.ToString() == firstClicked.Text);
            //bool isMatch = (firstWord == questions[rc] && secondWord == answers[rc]);


            if (isMatch)
            {
                firstClicked = null;
                secondClicked = null;
                CheckForWinner();
            }
            else
            {
                timer1.Start();
                Quickgame.SoundManager.PlayFalse();
            }
        }

        private void CheckForWinner()
        {
            foreach (Button button in buttons)
            {
                if (button.ForeColor == button.BackColor)
                {
                    Quickgame.SoundManager.PlayTrue();
                    return;
                }

            }

            MessageBox.Show("You matched all the icons!", "Congratulations");
            button18.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }


        private void button17_Click_1(object sender, EventArgs e)
        {
            Quickgame.SoundManager.PlayButtonSound();
            this.Hide();
            quic.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Quickgame.SoundManager.PlayButtonSound();
            AssignIconsToSquares();
            label2.Text = Convert.ToString(count);
            button18.Visible = false;
        }

    }
}

