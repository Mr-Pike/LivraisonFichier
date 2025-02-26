using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LivraisonFichier
{
    public partial class FormLivraison : Form
    {
        public FormLivraison()
        {
            InitializeComponent();
        }

        /// <summary>
        /// L'utilisateur clique sur le bouton pour ouvrir une fenêtre de choix de dossier de développement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDossierDev_Click(object sender, EventArgs e)
        {
            ChooseFolder(TextBoxDossierDev);
        }

        /// <summary>
        /// L'utilisateur clique sur le bouton pour ouvrir une fenêtre de choix de dossier de livraison.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDossierLiv_Click(object sender, EventArgs e)
        {
            ChooseFolder(TextBoxDossierLiv);
        }

        /// <summary>
        /// L'utilisateur clique sur le bouton livrer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLivrer_Click(object sender, EventArgs e)
        {
            // Vérifier si les dossiers ont bien été sélectionnés.
            if (TextBoxDossierDev.Text == string.Empty)
            {
                MessageBox.Show("Le dossier de développement n'a pas été sélectionné.", "Erreur sélection dossier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TextBoxDossierLiv.Text == string.Empty)
            {
                MessageBox.Show("Le dossier de livraison n'a pas été sélectionné", "Erreur sélection dossier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                // Récupérer les dossiers.
                DirectoryInfo DossierDev = new DirectoryInfo(TextBoxDossierDev.Text);
                DirectoryInfo DossierLiv = new DirectoryInfo(TextBoxDossierLiv.Text);

                // Parcourir l'ensemble des fichiers présents dans le dossier dont la date de création est supérieure ou égale à la date voulue.
                foreach (FileInfo fichier in DossierDev.EnumerateFiles("*", SearchOption.AllDirectories).Where(x => x.LastWriteTime >= DateTimePickerModif.Value))
                {
                    // Copier le fichier dans le dossier de développement.
                    string fichierLivraison = fichier.FullName.Replace(DossierDev.FullName, DossierLiv.FullName);
                    Directory.CreateDirectory(Path.GetDirectoryName(fichierLivraison));
                    fichier.CopyTo(fichierLivraison, true);
                }

                MessageBox.Show("Les fichiers ont été copiés avec succès.", "Fichiers copiés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excep)
            {
                MessageBox.Show("Une erreur s'est produite lors du parcours des dossiers :\n" + excep.Message, "Erreur parcours fichiers", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// L'utilisateur clique sur le bouton "Fermer".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Choisir un répertoire et récupérer le chemin dans le textbox.
        /// </summary>
        /// <param name="textBox">Nom du textbox</param>
        private void ChooseFolder(TextBox textBox)
        {
            using (FolderBrowserDialog dossier = new FolderBrowserDialog())
            {
                if (dossier.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = dossier.SelectedPath;
                }
            }
        }
    }
}
