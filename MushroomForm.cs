using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MushroomForm : Form
    {
        // One box of the question tree: either a question or a mushroom name
        private class Node
        {
            public string Text;
            public Node Yes;     // next box if the answer is Yes
            public Node No;      // next box if the answer is No
            public bool IsAnswer
            {
                get { return Yes == null && No == null; }
            }
        }

        public LoginForm loginForm;
        public ChooseForm chooseForm;

        private Node root;
        private Node current;
        private int questionNumber;

        public MushroomForm()
        {
            InitializeComponent();
            BuildTree();
            StartOver();
        }

        private static Node Ask(string question, Node yes, Node no)
        {
            Node n = new Node();
            n.Text = question;
            n.Yes = yes;
            n.No = no;
            return n;
        }

        private static Node Answer(string mushroomName)
        {
            Node n = new Node();
            n.Text = mushroomName;
            return n;
        }

        private void BuildTree()
        {
            Node agaric = Answer("Agaric Jaunissant");
            Node amanite = Answer("Amanite tue-mouches");
            Node cepe = Answer("Cepe de bordeaux");
            Node coprin = Answer("Coprin chevelu");
            Node girolle = Answer("Girolle");
            Node pied = Answer("Pied bleu");

            string cupQuestion = "Does your mushroom have a convex cup?";

            Node cupIfMeadow = Ask(cupQuestion, agaric, coprin);
            Node forestQ = Ask("Does your mushroom grow in a forest?", amanite, cupIfMeadow);

            Node cupIfGills = Ask(cupQuestion, pied, girolle);
            Node gillsQ = Ask("Does your mushroom have gills?", cupIfGills, cepe);

            root = Ask("Does your mushroom have a ring?", forestQ, gillsQ);
        }

        private void StartOver()
        {
            current = root;
            questionNumber = 1;
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            lblCount.Text = "Question " + questionNumber + " of at most 3";
            lblQuestion.Text = current.Text;
        }

        private void Answered(bool yes)
        {
            if (yes) current = current.Yes;
            else current = current.No;

            if (current.IsAnswer)
            {
                MessageBox.Show("Your mushroom is: " + current.Text, "Result",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartOver();
            }
            else
            {
                questionNumber = questionNumber + 1;
                ShowQuestion();
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answered(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Answered(false);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            chooseForm.Close();
            this.Close();
        }

        private void MushroomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginForm.Visible) Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            chooseForm.Show();
            this.Hide();
        }
    }
}