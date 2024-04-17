using Son_of_Duo;
using System;
using System.Collections.Generic;
using System.Drawing;
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


        }
        int rc = RandomNumber();
        public void AssignIconsToSquares()
        {

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
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
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

            bool isMatch = (firstWord == questions[rc] && secondWord == answers[rc]);


            if (isMatch)
            {
                firstClicked = null;
                secondClicked = null;
                CheckForWinner();
            }
            else
            {
                timer1.Start();
            }
        }

        private void CheckForWinner()
        {
            foreach (Button button in buttons)
            {
                if (button.ForeColor == button.BackColor)
                    return;
            }

            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
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
            this.Hide();
            quic.Show();
        }
    }
}
